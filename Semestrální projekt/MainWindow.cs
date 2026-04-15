namespace Semestrální_projekt
{
    public partial class MainWindow : Form {
        private readonly Dictionary<string, UserControl> _panelControls = new();
        private string _databasePath = string.Empty;

        public MainWindow() {
            InitializeComponent();
            InitializePanels();
            switchPanel("dashboard");
        }

        private void InitializePanels() {
            var dashboardPanel = new DashboardPanelControl();
            var paletyPanel = new PaletyPanelControl();
            var prijemPanel = new PrijemPanelControl();
            var pohybyPanel = new PohybyPanelControl();
            var nastaveniPanel = new NastaveniPanelControl();
            nastaveniPanel.SetOpenFileDialog(openFileDialog1);

            _panelControls["dashboard"] = dashboardPanel;
            _panelControls["palety"] = paletyPanel;
            _panelControls["prijem"] = prijemPanel;
            _panelControls["pohyby"] = pohybyPanel;
            _panelControls["nastaveni"] = nastaveniPanel;

            foreach (var panel in _panelControls.Values) {
                panel.Dock = DockStyle.Fill;
            }
        }

        public void switchPanel(String button) {
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
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Button 1 clicked");
            switchPanel("dashboard");
        }

        private void button2_Click(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Button 2 clicked");
            switchPanel("palety");
        }

        private void button3_Click(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Button 3 clicked");
            switchPanel("prijem");
        }

        private void button4_Click(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Button 4 clicked");
            switchPanel("pohyby");
        }

        private void button5_Click(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Button 5 clicked");
            switchPanel("nastaveni");
        }

        private void oSoftwareToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            System.Diagnostics.Debug.WriteLine(openFileDialog1.FileName);
            _databasePath = openFileDialog1.FileName;
        }
    }
}
