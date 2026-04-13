namespace Semestrální_projekt
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            switchPanel("dashboard");
        }

        public void switchPanel(String button) {
            object[] panels = { panelDashboard, panelPalety, panelPohyby, panelPrijem, panelNastaveni };

            button1.BackColor = Color.FromArgb(79, 92, 109);
            button2.BackColor = Color.FromArgb(79, 92, 109);
            button3.BackColor = Color.FromArgb(79, 92, 109);
            button4.BackColor = Color.FromArgb(79, 92, 109);
            button5.BackColor = Color.FromArgb(79, 92, 109);

            foreach (object panel in panels) {
                if (button == "dashboard" && panel == panelDashboard) {
                    ((Panel)panel).Visible = true;
                    button1.BackColor = Color.FromArgb(40, 118, 175);
                } else if (button == "palety" && panel == panelPalety) {
                    ((Panel)panel).Visible = true;
                    button2.BackColor = Color.FromArgb(40, 118, 175);
                } else if (button == "prijem" && panel == panelPrijem) {
                    ((Panel)panel).Visible = true;
                    button3.BackColor = Color.FromArgb(40, 118, 175);
                } else if (button == "pohyby" && panel == panelPohyby) {
                    ((Panel)panel).Visible = true;
                    button4.BackColor = Color.FromArgb(40, 118, 175);
                } else if (button == "nastaveni" && panel == panelNastaveni) {
                    ((Panel)panel).Visible = true;
                    button5.BackColor = Color.FromArgb(40, 118, 175);
                } else {
                    ((Panel)panel).Visible = false;
                }
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

        private void button6_Click(object sender, EventArgs e) {

        }
    }
}
