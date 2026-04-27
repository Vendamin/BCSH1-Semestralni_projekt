namespace Semestrální_projekt
{
    public partial class MainWindow : Form {
        private readonly Dictionary<string, UserControl> _panelControls = new();
        private SkladConfig _config;

        public MainWindow() {
            InitializeComponent();
            _config = new SkladConfig(menuStrip1, statusStrip1);

            InitializePanels();

            if (!_config.InitializeDatabase()) {
                switchPanel("nastaveni", true);
            }
            else {
                switchPanel("dashboard", true);
            }
        }

        private void InitializePanels() {
            var dashboardPanel = new DashboardPanelControl();
            var paletyPanel = new PaletyPanelControl();
            var prijemPanel = new PrijemPanelControl();
            var pohybyPanel = new PohybyPanelControl();
            var nastaveniPanel = new NastaveniPanelControl(_config);
            nastaveniPanel.SetOpenFileDialog(openFileDialog1);
            nastaveniPanel.SetSaveFileDialog(saveFileDialog1);

            _panelControls["dashboard"] = dashboardPanel;
            _panelControls["palety"] = paletyPanel;
            _panelControls["prijem"] = prijemPanel;
            _panelControls["pohyby"] = pohybyPanel;
            _panelControls["nastaveni"] = nastaveniPanel;

            foreach (var panel in _panelControls.Values) {
                panel.Dock = DockStyle.Fill;
            }
        }

        public void switchPanel(string button, bool force = false) {

            System.Diagnostics.Debug.WriteLine($"switchPanel was called with button: {button}, force: {force.ToString()}");

            if (!force && _config.SelectedPane == button) {
                return;
            }

            if (!force && !_config.SwitchPanelInteraction) {
                MessageBox.Show("Dodělejte co dělate aby jste mohli měnit panely.");
                System.Diagnostics.Debug.WriteLine("Panel switch interaction is currently disabled.");
                return;
            }

            if (!_config.ValidateDatabasePath()) {
                MessageBox.Show("Nastavte cestu k databázy");
                if (!force) {
                    return;
                }
            }

            System.Diagnostics.Debug.WriteLine($"{button} opened");

            button1.BackColor = Color.FromArgb(79, 92, 109);
            button2.BackColor = Color.FromArgb(79, 92, 109);
            button3.BackColor = Color.FromArgb(79, 92, 109);
            button4.BackColor = Color.FromArgb(79, 92, 109);
            button5.BackColor = Color.FromArgb(79, 92, 109);

            if (!_panelControls.TryGetValue(button, out var selectedPanel)) {
                return;
            }

            main_wrapper.SuspendLayout();
            main_wrapper.Controls.Clear();
            main_wrapper.Controls.Add(selectedPanel);
            main_wrapper.ResumeLayout();

            if (button == "dashboard") {
                button1.BackColor = Color.FromArgb(40, 118, 175);
            }
            else if (button == "palety") {
                button2.BackColor = Color.FromArgb(40, 118, 175);
            }
            else if (button == "prijem") {
                button3.BackColor = Color.FromArgb(40, 118, 175);
            }
            else if (button == "pohyby") {
                button4.BackColor = Color.FromArgb(40, 118, 175);
            }
            else if (button == "nastaveni") {
                button5.BackColor = Color.FromArgb(40, 118, 175);
            }

            _config.SelectedPane = button;
        }

        private void button1_Click(object sender, EventArgs e) {
            switchPanel("dashboard");
        }

        private void button2_Click(object sender, EventArgs e) {
            switchPanel("palety");
        }

        private void button3_Click(object sender, EventArgs e) {
            switchPanel("prijem");
        }

        private void button4_Click(object sender, EventArgs e) {
            switchPanel("pohyby");
        }

        private void button5_Click(object sender, EventArgs e) {
            switchPanel("nastaveni");
        }

        private void oSoftwareToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 aboutBox = new();
            aboutBox.ShowDialog();
        }

        private void nastavitCestuKDatabázyToolStripMenuItem_Click(object sender, EventArgs e) {
            switchPanel("nastaveni");
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void definiceŘadARegálůToolStripMenuItem_Click(object sender, EventArgs e) {
            warehouseConf wc = new(_config);
            wc.ShowDialog();
        }

        private void seznamPoškozenýchPozicToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void novýPříjemToolStripMenuItem_Click(object sender, EventArgs e) {
            switchPanel("prijem");
        }

        private void expediceToolStripMenuItem_Click(object sender, EventArgs e) {
            switchPanel("prijem");
        }

        private void knihaPohýbůToolStripMenuItem_Click(object sender, EventArgs e) {
            switchPanel("pohyby");
        }

        private void exportovatDataToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void importovatZCSVToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
