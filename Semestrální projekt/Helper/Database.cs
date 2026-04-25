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
                    stav TEXT NOT NULL
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

                INSERT OR IGNORE INTO nastaveni (klic, hodnota) VALUES ('maxPalet', '100');
            ";
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
