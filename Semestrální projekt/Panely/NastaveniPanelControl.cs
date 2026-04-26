namespace Semestrální_projekt
{
    public partial class NastaveniPanelControl : UserControl {
        private OpenFileDialog? openFileDialog;
        private SaveFileDialog? saveFileDialog;
        private SkladConfig _config;
        private bool firstLoad = false;

        public NastaveniPanelControl(SkladConfig config) {
            _config = config;
            InitializeComponent();

            load_settings();
            firstLoad = true;
        }

        private void load_settings() {
            System.Diagnostics.Debug.WriteLine("Load settings");
            if (!firstLoad) {
                _config.DestroyDatabase();
            }
            vychoziJednotka.Items.Clear();
            vychoziJednotka.Items.Add("kg");
            vychoziJednotka.Items.Add("g");
            vychoziJednotka.Items.Add("lb");

            motivCombo.Items.Clear();
            motivCombo.Items.Add("Tmavý");
            motivCombo.Items.Add("Světlý");

            jazykCombo.Items.Clear();
            jazykCombo.Items.Add("Čeština");
            jazykCombo.Items.Add("English");

            typDatabaze.SelectedItem = typDatabaze.Items[0];

            switch (Properties.Settings.Default.lang) {
                case "en":
                    jazykCombo.SelectedItem = "English";
                    break;
                case "cs":
                default:
                    jazykCombo.SelectedItem = "Čeština";
                    break;
            }

            motivCombo.SelectedItem = Properties.Settings.Default.theme == "dark" ? "Tmavý" : "Světlý";
            vychoziJednotka.SelectedItem = Properties.Settings.Default.def_metric;

            casZmeny.Text = Properties.Settings.Default.last_saved.ToString("g");

            _config.DatabasePath = Properties.Settings.Default.db_path;
            cestaDb.Text = _config.DatabasePath;

            _config.InitializeDatabase(!firstLoad);


            if (_config.ValidateDatabaseConnection()) {
                var conn = _config.DatabaseInstance.GetConnection();
                
                conn.Open();
                var cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT hodnota FROM nastaveni WHERE klic = 'maxPalet' LIMIT 1";

                var result = cmd.ExecuteScalar();

                volnaMista.Text = "0";
            } else {

                volnaMista.Text = "0";
            }
            checkDirty();
        }

        public void SetOpenFileDialog(OpenFileDialog dialog) {
            openFileDialog = dialog;
        }

        public void SetSaveFileDialog(SaveFileDialog dialog) {
            saveFileDialog = dialog;
        }

        private void button6_Click(object sender, EventArgs e) {
            if (openFileDialog?.ShowDialog() == DialogResult.OK) {
                cestaDb.Text = openFileDialog.FileName;
                System.Diagnostics.Debug.WriteLine(openFileDialog.FileName);
            }
        }

        private void nastaveniSaveButton_Click(object sender, EventArgs e) {
            Properties.Settings.Default.db_path = cestaDb.Text;
            Properties.Settings.Default.def_metric = vychoziJednotka.SelectedItem.ToString() ?? "kg";
            Properties.Settings.Default.theme = motivCombo.SelectedItem.ToString() == "Tmavý" ? "dark" : "light";
            switch (jazykCombo.SelectedItem.ToString()) {
                case "English":
                    Properties.Settings.Default.lang = "en";
                    break;
                case "Čeština":
                default:
                    Properties.Settings.Default.lang = "cs";
                    break;
            }

            Properties.Settings.Default.last_saved = DateTime.Now;
            Properties.Settings.Default.Save();
            load_settings();
        }

        private void checkDirtyEventHandler(object sender, EventArgs e) {
            if (firstLoad) {
                checkDirty();
            }
        }

        private void checkDirty() {
            System.Diagnostics.Debug.WriteLine("checkDirty was called");
            bool isDirty = cestaDb.Text != Properties.Settings.Default.db_path ||
                           (vychoziJednotka.SelectedItem?.ToString() ?? "kg") != Properties.Settings.Default.def_metric ||
                           (motivCombo.SelectedItem?.ToString() == "Tmavý" ? "dark" : "light") != Properties.Settings.Default.theme ||
                           (jazykCombo.SelectedItem?.ToString() == "English" ? "en" : "cs") != Properties.Settings.Default.lang;
            if (isDirty) {
                _config.SwitchPanelInteraction = false;
                nastaveniSaveButton.Enabled = true;
                nastaveniCancelButton.Enabled = true;
            }
            else {
                _config.SwitchPanelInteraction = true;
                nastaveniSaveButton.Enabled = false;
                nastaveniCancelButton.Enabled = false;
            }
            System.Diagnostics.Debug.WriteLine(_config.SwitchPanelInteraction);
        }

        private void nastaveniCancelButton_Click(object sender, EventArgs e) {
            load_settings();
        }

        private void nastaveniVytvoritBtn_Click(object sender, EventArgs e) {
            if (saveFileDialog?.ShowDialog() == DialogResult.OK) {
                cestaDb.Text = saveFileDialog.FileName;
            }
        }
    }
}
