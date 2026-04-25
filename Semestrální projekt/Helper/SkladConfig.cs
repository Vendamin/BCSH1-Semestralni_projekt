using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestrální_projekt;

public class SkladConfig {
    public string DatabasePath { get; set; }
    public bool SwitchPanelInteraction { get; set; }
    public Database DatabaseInstance { get; private set; } = null!;
    public string Theme { get; set; }

    public SkladConfig() {
        DatabasePath = Properties.Settings.Default.db_path ?? string.Empty;
        SwitchPanelInteraction = true;
        Theme = Properties.Settings.Default.theme ?? "dark";
    }

    public bool ValidateDatabasePath() {
        if (string.IsNullOrEmpty(DatabasePath)) {
            return false;
        }
        return true;
    }

    public bool ValidateDatabaseConnection() {
        if (!ValidateDatabasePath()) {
            return false;
        }
        try {
            using var connection = DatabaseInstance.GetConnection();
            connection.Open();
            return true;
        } catch (Exception ex) {
            System.Diagnostics.Debug.WriteLine($"Database connection validation failed: {ex.Message}");
            return false;
        }
    }

    public bool InitializeDatabase(bool first = false) {
        if (first) {
            // check if DatabasePath exists
            if (!File.Exists(DatabasePath)) {
                MessageBox.Show("Uložená cesta k souboru s databází nebyl nalezen.");
                System.Diagnostics.Debug.WriteLine("File not found!");
                Properties.Settings.Default.db_path = String.Empty;
                Properties.Settings.Default.Save();
                DatabasePath = String.Empty;
            }
        }

        if (DatabaseInstance != null) {
            System.Diagnostics.Debug.WriteLine("DatabaseInstance is already set.");
            return true;
        }
        if (!ValidateDatabasePath()) {
            System.Diagnostics.Debug.WriteLine("Invalid database path.");
            return false;
        }
        DatabaseInstance = new Database(DatabasePath);
        return true;
    }

    public void DestroyDatabase() {
        DatabaseInstance = null!;
    }
}
