using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace Semestrální_projekt
{
    public class Database
    {
        private string _databasePath;

        public Database(string databasePath)
        {
            this._databasePath = databasePath;
            InitializeDatabase();
        }

        public SQLiteConnection GetConnection()
        {
            var connectionString = new SQLiteConnectionStringBuilder
            {
                DataSource = _databasePath,
                Version = 3
            }.ToString();
            return new SQLiteConnection(connectionString);
        }

        private void InitializeDatabase()
        {
            using var connection = GetConnection();
            connection.Open();
            using (var pragmaCommand = connection.CreateCommand())
            {
                pragmaCommand.CommandText = "PRAGMA foreign_keys = ON;";
                pragmaCommand.ExecuteNonQuery();
            }
            var command = connection.CreateCommand();
            command.CommandText =
            @"
                CREATE TABLE IF NOT EXISTS skladove_pozice (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    rada TEXT NOT NULL,
                    regal INTEGER NOT NULL,
                    patro INTEGER NOT NULL,
                    stav TEXT NOT NULL DEFAULT 'empty',
                    UNIQUE(rada,regal,patro)
                );

                CREATE TABLE IF NOT EXISTS palety (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    obsah TEXT NOT NULL,
                    pocet_kusu INTEGER NOT NULL,
                    hmotnost REAL NOT NULL,
                    skladova_pozice_id INTEGER NOT NULL UNIQUE,
                    FOREIGN KEY (skladova_pozice_id) REFERENCES skladove_pozice(id)
                );

                CREATE TABLE IF NOT EXISTS skladove_pohyby (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    paleta_id INTEGER NOT NULL,
                    skladova_pozice_id INTEGER NOT NULL,
                    typ TEXT NOT NULL,
                    datum_cas TEXT NOT NULL,
                    poznamka TEXT,
                    FOREIGN KEY (paleta_id) REFERENCES palety(id),
                    FOREIGN KEY (skladova_pozice_id) REFERENCES skladove_pozice(id)
                );

                CREATE TABLE IF NOT EXISTS nastaveni (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    klic TEXT NOT NULL UNIQUE,
                    hodnota TEXT NOT NULL
                );
            ";
            command.ExecuteNonQuery();

            connection.Close();
        }

        public List<(string Rada, int Regal, int Patro)> GetAllWarehousePositions()
        {
            var positions = new List<(string Rada, int Regal, int Patro)>();
            using var connection = GetConnection();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT rada, regal, patro FROM skladove_pozice ORDER BY rada, regal, patro;";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                positions.Add((
                    reader.GetString(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2)
                ));
            }
            return positions;
        }

        public Dictionary<(string Rada, int Regal, int Patro), (int PaletaId, string Obsah)> GetPositionsWithProducts()
        {
            var result = new Dictionary<(string Rada, int Regal, int Patro), (int, string)>();
            using var connection = GetConnection();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                SELECT sp.rada, sp.regal, sp.patro, p.id, p.obsah
                FROM skladove_pozice sp
                LEFT JOIN palety p ON sp.id = p.skladova_pozice_id
                WHERE p.id IS NOT NULL
                ORDER BY sp.rada, sp.regal, sp.patro;";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var position = (reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2));
                var paletaId = reader.GetInt32(3);
                var obsah = reader.GetString(4);
                result[position] = (paletaId, obsah);
            }
            return result;
        }

        public void DeleteWarehousePositions(SQLiteTransaction transaction, List<(string Rada, int Regal, int Patro)> positions)
        {
            if (!positions.Any())
                return;

            var connection = transaction.Connection;
            using var command = connection.CreateCommand();
            command.CommandText = @"
                DELETE FROM skladove_pozice 
                WHERE rada = @rada AND regal = @regal AND patro = @patro;";
            command.Transaction = transaction;
            
            var radaParam = command.Parameters.Add("@rada", System.Data.DbType.String);
            var regalParam = command.Parameters.Add("@regal", System.Data.DbType.Int32);
            var patroParam = command.Parameters.Add("@patro", System.Data.DbType.Int32);

            foreach (var (rada, regal, patro) in positions)
            {
                radaParam.Value = rada;
                regalParam.Value = regal;
                patroParam.Value = patro;
                command.ExecuteNonQuery();
            }
        }

        public void CreateWarehousePositions(SQLiteTransaction transaction, List<(string Rada, int Regal, int Patro)> positions)
        {
            if (!positions.Any())
                return;

            var connection = transaction.Connection;
            using var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO skladove_pozice (rada, regal, patro, stav) 
                VALUES (@rada, @regal, @patro, 'empty');";
            command.Transaction = transaction;
            
            var radaParam = command.Parameters.Add("@rada", System.Data.DbType.String);
            var regalParam = command.Parameters.Add("@regal", System.Data.DbType.Int32);
            var patroParam = command.Parameters.Add("@patro", System.Data.DbType.Int32);

            foreach (var (rada, regal, patro) in positions)
            {
                radaParam.Value = rada;
                regalParam.Value = regal;
                patroParam.Value = patro;
                command.ExecuteNonQuery();
            }
        }
    }
}
