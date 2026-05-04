namespace Semestrální_projekt
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip1 = new StatusStrip();
            this.toolStripStatusLabel1 = new ToolStripStatusLabel();
            this.stavDB = new ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new ToolStripStatusLabel();
            this.pohybText = new ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new ToolStripStatusLabel();
            this.pocetVolnychMistText = new ToolStripStatusLabel();
            this.menuStrip1 = new MenuStrip();
            this.souborToolStripMenuItem = new ToolStripMenuItem();
            this.exportovatDataToolStripMenuItem = new ToolStripMenuItem();
            this.importovatZCSVToolStripMenuItem = new ToolStripMenuItem();
            this.konecToolStripMenuItem = new ToolStripMenuItem();
            this.skladyToolStripMenuItem = new ToolStripMenuItem();
            this.definiceŘadARegálůToolStripMenuItem = new ToolStripMenuItem();
            this.kontrolovaZaplněnostiToolStripMenuItem = new ToolStripMenuItem();
            this.seznamPoškozenýchPozicToolStripMenuItem = new ToolStripMenuItem();
            this.operaceToolStripMenuItem = new ToolStripMenuItem();
            this.novýPříjemToolStripMenuItem = new ToolStripMenuItem();
            this.expediceToolStripMenuItem = new ToolStripMenuItem();
            this.historieToolStripMenuItem = new ToolStripMenuItem();
            this.knihaPohýbůToolStripMenuItem = new ToolStripMenuItem();
            this.archivExpedovanýchPaletToolStripMenuItem = new ToolStripMenuItem();
            this.statistikyToolStripMenuItem = new ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new ToolStripMenuItem();
            this.konfiguraceDatabázeToolStripMenuItem = new ToolStripMenuItem();
            this.nastavitCestuKDatabázyToolStripMenuItem = new ToolStripMenuItem();
            this.testPřipojeníToolStripMenuItem = new ToolStripMenuItem();
            this.vzhledToolStripMenuItem = new ToolStripMenuItem();
            this.tmavýToolStripMenuItem = new ToolStripMenuItem();
            this.světlýToolStripMenuItem = new ToolStripMenuItem();
            this.zálohováníToolStripMenuItem = new ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new ToolStripMenuItem();
            this.klávesovéZkratkyToolStripMenuItem = new ToolStripMenuItem();
            this.oSoftwareToolStripMenuItem = new ToolStripMenuItem();
            this.main_wrapper = new Panel();
            this.menu_left = new Panel();
            this.flow_button = new FlowLayoutPanel();
            this.button1 = new FlowLayoutPanel();
            this.panel1 = new Panel();
            this.button_text1 = new Label();
            this.button2 = new FlowLayoutPanel();
            this.panel2 = new Panel();
            this.button_text2 = new Label();
            this.button3 = new FlowLayoutPanel();
            this.panel3 = new Panel();
            this.button_text3 = new Label();
            this.button4 = new FlowLayoutPanel();
            this.panel4 = new Panel();
            this.button_text4 = new Label();
            this.button5 = new FlowLayoutPanel();
            this.panel5 = new Panel();
            this.button_text5 = new Label();
            this.under_button_holder = new Panel();
            this.openFileDialog1 = new OpenFileDialog();
            this.saveFileDialog1 = new SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menu_left.SuspendLayout();
            this.flow_button.SuspendLayout();
            this.button1.SuspendLayout();
            this.button2.SuspendLayout();
            this.button3.SuspendLayout();
            this.button4.SuspendLayout();
            this.button5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = Color.FromArgb(40, 55, 74);
            this.statusStrip1.GripMargin = new Padding(0);
            this.statusStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabel1, this.stavDB, this.toolStripStatusLabel2, this.pohybText, this.toolStripStatusLabel3, this.pocetVolnychMistText });
            this.statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(948, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new Size(53, 17);
            this.toolStripStatusLabel1.Text = "Stav DB: ";
            // 
            // stavDB
            // 
            this.stavDB.ForeColor = Color.White;
            this.stavDB.Name = "stavDB";
            this.stavDB.Size = new Size(43, 17);
            this.stavDB.Text = "stavDB";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new Size(101, 17);
            this.toolStripStatusLabel2.Text = "| Poslední pohyb: ";
            // 
            // pohybText
            // 
            this.pohybText.ForeColor = Color.White;
            this.pohybText.Name = "pohybText";
            this.pohybText.Size = new Size(62, 17);
            this.pohybText.Text = "pohybText";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new Size(87, 17);
            this.toolStripStatusLabel3.Text = "| Volných míst: ";
            // 
            // pocetVolnychMistText
            // 
            this.pocetVolnychMistText.ForeColor = Color.White;
            this.pocetVolnychMistText.Name = "pocetVolnychMistText";
            this.pocetVolnychMistText.Size = new Size(123, 17);
            this.pocetVolnychMistText.Text = "pocetVolnychMistText";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new Padding(0);
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.souborToolStripMenuItem, this.skladyToolStripMenuItem, this.operaceToolStripMenuItem, this.historieToolStripMenuItem, this.nastaveníToolStripMenuItem, this.nápovědaToolStripMenuItem });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new Padding(0);
            this.menuStrip1.Size = new Size(948, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.exportovatDataToolStripMenuItem, this.importovatZCSVToolStripMenuItem, this.konecToolStripMenuItem });
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new Size(57, 24);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // exportovatDataToolStripMenuItem
            // 
            this.exportovatDataToolStripMenuItem.Name = "exportovatDataToolStripMenuItem";
            this.exportovatDataToolStripMenuItem.Size = new Size(165, 22);
            this.exportovatDataToolStripMenuItem.Text = "Exportovat data";
            this.exportovatDataToolStripMenuItem.Click += this.exportovatDataToolStripMenuItem_Click;
            // 
            // importovatZCSVToolStripMenuItem
            // 
            this.importovatZCSVToolStripMenuItem.Name = "importovatZCSVToolStripMenuItem";
            this.importovatZCSVToolStripMenuItem.Size = new Size(165, 22);
            this.importovatZCSVToolStripMenuItem.Text = "Importovat z CSV";
            this.importovatZCSVToolStripMenuItem.Click += this.importovatZCSVToolStripMenuItem_Click;
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new Size(165, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += this.konecToolStripMenuItem_Click;
            // 
            // skladyToolStripMenuItem
            // 
            this.skladyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.definiceŘadARegálůToolStripMenuItem, this.kontrolovaZaplněnostiToolStripMenuItem, this.seznamPoškozenýchPozicToolStripMenuItem });
            this.skladyToolStripMenuItem.Name = "skladyToolStripMenuItem";
            this.skladyToolStripMenuItem.Size = new Size(53, 24);
            this.skladyToolStripMenuItem.Text = "Sklady";
            // 
            // definiceŘadARegálůToolStripMenuItem
            // 
            this.definiceŘadARegálůToolStripMenuItem.Name = "definiceŘadARegálůToolStripMenuItem";
            this.definiceŘadARegálůToolStripMenuItem.Size = new Size(218, 22);
            this.definiceŘadARegálůToolStripMenuItem.Text = "Definice řad a regálů";
            this.definiceŘadARegálůToolStripMenuItem.Click += this.definiceŘadARegálůToolStripMenuItem_Click;
            // 
            // kontrolovaZaplněnostiToolStripMenuItem
            // 
            this.kontrolovaZaplněnostiToolStripMenuItem.Name = "kontrolovaZaplněnostiToolStripMenuItem";
            this.kontrolovaZaplněnostiToolStripMenuItem.Size = new Size(218, 22);
            this.kontrolovaZaplněnostiToolStripMenuItem.Text = "Kontrolova zaplněnosti";
            // 
            // seznamPoškozenýchPozicToolStripMenuItem
            // 
            this.seznamPoškozenýchPozicToolStripMenuItem.Name = "seznamPoškozenýchPozicToolStripMenuItem";
            this.seznamPoškozenýchPozicToolStripMenuItem.Size = new Size(218, 22);
            this.seznamPoškozenýchPozicToolStripMenuItem.Text = "Seznam poškozených pozic";
            this.seznamPoškozenýchPozicToolStripMenuItem.Click += this.seznamPoškozenýchPozicToolStripMenuItem_Click;
            // 
            // operaceToolStripMenuItem
            // 
            this.operaceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.novýPříjemToolStripMenuItem, this.expediceToolStripMenuItem });
            this.operaceToolStripMenuItem.Name = "operaceToolStripMenuItem";
            this.operaceToolStripMenuItem.Size = new Size(63, 24);
            this.operaceToolStripMenuItem.Text = "Operace";
            // 
            // novýPříjemToolStripMenuItem
            // 
            this.novýPříjemToolStripMenuItem.Name = "novýPříjemToolStripMenuItem";
            this.novýPříjemToolStripMenuItem.Size = new Size(186, 22);
            this.novýPříjemToolStripMenuItem.Text = "Nový příjem (Ctrl+N)";
            this.novýPříjemToolStripMenuItem.Click += this.novýPříjemToolStripMenuItem_Click;
            // 
            // expediceToolStripMenuItem
            // 
            this.expediceToolStripMenuItem.Name = "expediceToolStripMenuItem";
            this.expediceToolStripMenuItem.Size = new Size(186, 22);
            this.expediceToolStripMenuItem.Text = "Expedice (Ctrl+E)";
            this.expediceToolStripMenuItem.Click += this.expediceToolStripMenuItem_Click;
            // 
            // historieToolStripMenuItem
            // 
            this.historieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.knihaPohýbůToolStripMenuItem, this.archivExpedovanýchPaletToolStripMenuItem, this.statistikyToolStripMenuItem });
            this.historieToolStripMenuItem.Name = "historieToolStripMenuItem";
            this.historieToolStripMenuItem.Size = new Size(60, 24);
            this.historieToolStripMenuItem.Text = "Historie";
            // 
            // knihaPohýbůToolStripMenuItem
            // 
            this.knihaPohýbůToolStripMenuItem.Name = "knihaPohýbůToolStripMenuItem";
            this.knihaPohýbůToolStripMenuItem.Size = new Size(217, 22);
            this.knihaPohýbůToolStripMenuItem.Text = "Kniha pohybů";
            this.knihaPohýbůToolStripMenuItem.Click += this.knihaPohýbůToolStripMenuItem_Click;
            // 
            // archivExpedovanýchPaletToolStripMenuItem
            // 
            this.archivExpedovanýchPaletToolStripMenuItem.Name = "archivExpedovanýchPaletToolStripMenuItem";
            this.archivExpedovanýchPaletToolStripMenuItem.Size = new Size(217, 22);
            this.archivExpedovanýchPaletToolStripMenuItem.Text = "Archiv expedovaných palet";
            // 
            // statistikyToolStripMenuItem
            // 
            this.statistikyToolStripMenuItem.Name = "statistikyToolStripMenuItem";
            this.statistikyToolStripMenuItem.Size = new Size(217, 22);
            this.statistikyToolStripMenuItem.Text = "Statistiky";
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.konfiguraceDatabázeToolStripMenuItem, this.vzhledToolStripMenuItem, this.zálohováníToolStripMenuItem });
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new Size(71, 24);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            // 
            // konfiguraceDatabázeToolStripMenuItem
            // 
            this.konfiguraceDatabázeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.nastavitCestuKDatabázyToolStripMenuItem, this.testPřipojeníToolStripMenuItem });
            this.konfiguraceDatabázeToolStripMenuItem.Name = "konfiguraceDatabázeToolStripMenuItem";
            this.konfiguraceDatabázeToolStripMenuItem.Size = new Size(188, 22);
            this.konfiguraceDatabázeToolStripMenuItem.Text = "Konfigurace databáze";
            // 
            // nastavitCestuKDatabázyToolStripMenuItem
            // 
            this.nastavitCestuKDatabázyToolStripMenuItem.Name = "nastavitCestuKDatabázyToolStripMenuItem";
            this.nastavitCestuKDatabázyToolStripMenuItem.Size = new Size(207, 22);
            this.nastavitCestuKDatabázyToolStripMenuItem.Text = "Nastavit cestu k databázy";
            this.nastavitCestuKDatabázyToolStripMenuItem.Click += this.nastavitCestuKDatabázyToolStripMenuItem_Click;
            // 
            // testPřipojeníToolStripMenuItem
            // 
            this.testPřipojeníToolStripMenuItem.Name = "testPřipojeníToolStripMenuItem";
            this.testPřipojeníToolStripMenuItem.Size = new Size(207, 22);
            this.testPřipojeníToolStripMenuItem.Text = "Test připojení";
            // 
            // vzhledToolStripMenuItem
            // 
            this.vzhledToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.tmavýToolStripMenuItem, this.světlýToolStripMenuItem });
            this.vzhledToolStripMenuItem.Name = "vzhledToolStripMenuItem";
            this.vzhledToolStripMenuItem.Size = new Size(188, 22);
            this.vzhledToolStripMenuItem.Text = "Vzhled";
            // 
            // tmavýToolStripMenuItem
            // 
            this.tmavýToolStripMenuItem.Checked = true;
            this.tmavýToolStripMenuItem.CheckState = CheckState.Checked;
            this.tmavýToolStripMenuItem.Name = "tmavýToolStripMenuItem";
            this.tmavýToolStripMenuItem.Size = new Size(108, 22);
            this.tmavýToolStripMenuItem.Text = "Tmavý";
            // 
            // světlýToolStripMenuItem
            // 
            this.světlýToolStripMenuItem.Name = "světlýToolStripMenuItem";
            this.světlýToolStripMenuItem.Size = new Size(108, 22);
            this.světlýToolStripMenuItem.Text = "Světlý";
            // 
            // zálohováníToolStripMenuItem
            // 
            this.zálohováníToolStripMenuItem.Name = "zálohováníToolStripMenuItem";
            this.zálohováníToolStripMenuItem.Size = new Size(188, 22);
            this.zálohováníToolStripMenuItem.Text = "Zálohování";
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.klávesovéZkratkyToolStripMenuItem, this.oSoftwareToolStripMenuItem });
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new Size(73, 24);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // klávesovéZkratkyToolStripMenuItem
            // 
            this.klávesovéZkratkyToolStripMenuItem.Name = "klávesovéZkratkyToolStripMenuItem";
            this.klávesovéZkratkyToolStripMenuItem.Size = new Size(166, 22);
            this.klávesovéZkratkyToolStripMenuItem.Text = "Klávesové zkratky";
            // 
            // oSoftwareToolStripMenuItem
            // 
            this.oSoftwareToolStripMenuItem.Name = "oSoftwareToolStripMenuItem";
            this.oSoftwareToolStripMenuItem.Size = new Size(166, 22);
            this.oSoftwareToolStripMenuItem.Text = "O aplikaci";
            this.oSoftwareToolStripMenuItem.Click += this.oSoftwareToolStripMenuItem_Click;
            // 
            // main_wrapper
            // 
            this.main_wrapper.BackColor = Color.Transparent;
            this.main_wrapper.Dock = DockStyle.Fill;
            this.main_wrapper.Location = new Point(230, 24);
            this.main_wrapper.Margin = new Padding(0);
            this.main_wrapper.Name = "main_wrapper";
            this.main_wrapper.Padding = new Padding(15);
            this.main_wrapper.Size = new Size(718, 503);
            this.main_wrapper.TabIndex = 3;
            // 
            // menu_left
            // 
            this.menu_left.BackColor = Color.FromArgb(40, 55, 74);
            this.menu_left.Controls.Add(this.flow_button);
            this.menu_left.Controls.Add(this.under_button_holder);
            this.menu_left.Dock = DockStyle.Left;
            this.menu_left.Location = new Point(0, 24);
            this.menu_left.Name = "menu_left";
            this.menu_left.Size = new Size(230, 503);
            this.menu_left.TabIndex = 2;
            // 
            // flow_button
            // 
            this.flow_button.Controls.Add(this.button1);
            this.flow_button.Controls.Add(this.button2);
            this.flow_button.Controls.Add(this.button3);
            this.flow_button.Controls.Add(this.button4);
            this.flow_button.Controls.Add(this.button5);
            this.flow_button.Dock = DockStyle.Fill;
            this.flow_button.FlowDirection = FlowDirection.TopDown;
            this.flow_button.Location = new Point(0, 0);
            this.flow_button.Name = "flow_button";
            this.flow_button.Padding = new Padding(10);
            this.flow_button.Size = new Size(230, 390);
            this.flow_button.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = Color.FromArgb(79, 92, 109);
            this.button1.Controls.Add(this.panel1);
            this.button1.Controls.Add(this.button_text1);
            this.button1.Cursor = Cursors.Hand;
            this.button1.FlowDirection = FlowDirection.TopDown;
            this.button1.Location = new Point(10, 10);
            this.button1.Margin = new Padding(0, 0, 0, 5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(210, 70);
            this.button1.TabIndex = 1;
            this.button1.TabStop = true;
            this.button1.Click += this.button1_Click;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = Properties.Resources.map_white;
            this.panel1.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel1.Location = new Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(207, 38);
            this.panel1.TabIndex = 1;
            this.panel1.Click += this.button1_Click;
            // 
            // button_text1
            // 
            this.button_text1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.button_text1.ForeColor = Color.White;
            this.button_text1.Location = new Point(3, 44);
            this.button_text1.Name = "button_text1";
            this.button_text1.Size = new Size(205, 25);
            this.button_text1.TabIndex = 0;
            this.button_text1.Text = "Dashboard";
            this.button_text1.TextAlign = ContentAlignment.MiddleCenter;
            this.button_text1.Click += this.button1_Click;
            // 
            // button2
            // 
            this.button2.BackColor = Color.FromArgb(79, 92, 109);
            this.button2.Controls.Add(this.panel2);
            this.button2.Controls.Add(this.button_text2);
            this.button2.Cursor = Cursors.Hand;
            this.button2.Location = new Point(10, 85);
            this.button2.Margin = new Padding(0, 0, 0, 5);
            this.button2.Name = "button2";
            this.button2.Size = new Size(210, 70);
            this.button2.TabIndex = 2;
            this.button2.TabStop = true;
            this.button2.Click += this.button2_Click;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = Properties.Resources.boxes_packing_white;
            this.panel2.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel2.Location = new Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(207, 38);
            this.panel2.TabIndex = 2;
            this.panel2.Click += this.button2_Click;
            // 
            // button_text2
            // 
            this.button_text2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.button_text2.ForeColor = Color.White;
            this.button_text2.Location = new Point(3, 44);
            this.button_text2.Name = "button_text2";
            this.button_text2.Size = new Size(205, 25);
            this.button_text2.TabIndex = 0;
            this.button_text2.Text = "Palety (Zboží)";
            this.button_text2.TextAlign = ContentAlignment.MiddleCenter;
            this.button_text2.Click += this.button2_Click;
            // 
            // button3
            // 
            this.button3.BackColor = Color.FromArgb(79, 92, 109);
            this.button3.Controls.Add(this.panel3);
            this.button3.Controls.Add(this.button_text3);
            this.button3.Cursor = Cursors.Hand;
            this.button3.Location = new Point(10, 160);
            this.button3.Margin = new Padding(0, 0, 0, 5);
            this.button3.Name = "button3";
            this.button3.Size = new Size(210, 70);
            this.button3.TabIndex = 3;
            this.button3.TabStop = true;
            this.button3.Click += this.button3_Click;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = Properties.Resources.arrow_up_from_bracket_white;
            this.panel3.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel3.Location = new Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(207, 38);
            this.panel3.TabIndex = 2;
            this.panel3.Click += this.button3_Click;
            // 
            // button_text3
            // 
            this.button_text3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button_text3.ForeColor = Color.White;
            this.button_text3.Location = new Point(3, 44);
            this.button_text3.Name = "button_text3";
            this.button_text3.Size = new Size(205, 25);
            this.button_text3.TabIndex = 0;
            this.button_text3.Text = "Příjem && Výdej";
            this.button_text3.TextAlign = ContentAlignment.MiddleCenter;
            this.button_text3.Click += this.button3_Click;
            // 
            // button4
            // 
            this.button4.BackColor = Color.FromArgb(79, 92, 109);
            this.button4.Controls.Add(this.panel4);
            this.button4.Controls.Add(this.button_text4);
            this.button4.Cursor = Cursors.Hand;
            this.button4.Location = new Point(10, 235);
            this.button4.Margin = new Padding(0, 0, 0, 5);
            this.button4.Name = "button4";
            this.button4.Size = new Size(210, 70);
            this.button4.TabIndex = 4;
            this.button4.TabStop = true;
            this.button4.Click += this.button4_Click;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = Properties.Resources.clock_rotate_left_white;
            this.panel4.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel4.Location = new Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(207, 38);
            this.panel4.TabIndex = 2;
            this.panel4.Click += this.button4_Click;
            // 
            // button_text4
            // 
            this.button_text4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.button_text4.ForeColor = Color.White;
            this.button_text4.Location = new Point(3, 44);
            this.button_text4.Name = "button_text4";
            this.button_text4.Size = new Size(205, 25);
            this.button_text4.TabIndex = 0;
            this.button_text4.Text = "Pohyby";
            this.button_text4.TextAlign = ContentAlignment.MiddleCenter;
            this.button_text4.Click += this.button4_Click;
            // 
            // button5
            // 
            this.button5.BackColor = Color.FromArgb(79, 92, 109);
            this.button5.Controls.Add(this.panel5);
            this.button5.Controls.Add(this.button_text5);
            this.button5.Cursor = Cursors.Hand;
            this.button5.Location = new Point(10, 310);
            this.button5.Margin = new Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new Size(210, 70);
            this.button5.TabIndex = 5;
            this.button5.TabStop = true;
            this.button5.Click += this.button5_Click;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = Properties.Resources.gears_white;
            this.panel5.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel5.Location = new Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new Size(207, 38);
            this.panel5.TabIndex = 2;
            this.panel5.Click += this.button5_Click;
            // 
            // button_text5
            // 
            this.button_text5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.button_text5.ForeColor = Color.White;
            this.button_text5.Location = new Point(3, 44);
            this.button_text5.Name = "button_text5";
            this.button_text5.Size = new Size(205, 25);
            this.button_text5.TabIndex = 0;
            this.button_text5.Text = "Nastavení";
            this.button_text5.TextAlign = ContentAlignment.MiddleCenter;
            this.button_text5.Click += this.button5_Click;
            // 
            // under_button_holder
            // 
            this.under_button_holder.BackgroundImage = Properties.Resources.shelf;
            this.under_button_holder.BackgroundImageLayout = ImageLayout.Zoom;
            this.under_button_holder.Dock = DockStyle.Bottom;
            this.under_button_holder.Location = new Point(0, 390);
            this.under_button_holder.Name = "under_button_holder";
            this.under_button_holder.Size = new Size(230, 113);
            this.under_button_holder.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "SQLite files (*.sqlite, *.sqlite3, *.db, *.db3, *.s3db, *.sl3)|*.sqlite;*.sqlite3;*.db;*.db3;*.s3db;*.sl3|All files (*.*)|*.*";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sqlite";
            this.saveFileDialog1.FileName = "sklad.sqlite";
            this.saveFileDialog1.Filter = "SQLite files (*.sqlite, *.sqlite3, *.db, *.db3, *.s3db, *.sl3)|*.sqlite;*.sqlite3;*.db;*.db3;*.s3db;*.sl3|All files (*.*)|*.*";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(23, 34, 52);
            this.ClientSize = new Size(948, 549);
            this.Controls.Add(this.main_wrapper);
            this.Controls.Add(this.menu_left);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new Size(964, 588);
            this.Name = "MainWindow";
            this.Text = "Skladový systém - BCSH1 Projekt | Václav Vellek";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menu_left.ResumeLayout(false);
            this.flow_button.ResumeLayout(false);
            this.button1.ResumeLayout(false);
            this.button2.ResumeLayout(false);
            this.button3.ResumeLayout(false);
            this.button4.ResumeLayout(false);
            this.button5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem souborToolStripMenuItem;
        private ToolStripMenuItem exportovatDataToolStripMenuItem;
        private ToolStripMenuItem importovatZCSVToolStripMenuItem;
        private ToolStripMenuItem konecToolStripMenuItem;
        private ToolStripMenuItem skladyToolStripMenuItem;
        private ToolStripMenuItem definiceŘadARegálůToolStripMenuItem;
        private ToolStripMenuItem kontrolovaZaplněnostiToolStripMenuItem;
        private ToolStripMenuItem seznamPoškozenýchPozicToolStripMenuItem;
        private ToolStripMenuItem operaceToolStripMenuItem;
        private ToolStripMenuItem novýPříjemToolStripMenuItem;
        private ToolStripMenuItem expediceToolStripMenuItem;
        private ToolStripMenuItem historieToolStripMenuItem;
        private ToolStripMenuItem knihaPohýbůToolStripMenuItem;
        private ToolStripMenuItem archivExpedovanýchPaletToolStripMenuItem;
        private ToolStripMenuItem statistikyToolStripMenuItem;
        private ToolStripMenuItem nastaveníToolStripMenuItem;
        private ToolStripMenuItem konfiguraceDatabázeToolStripMenuItem;
        private ToolStripMenuItem nastavitCestuKDatabázyToolStripMenuItem;
        private ToolStripMenuItem testPřipojeníToolStripMenuItem;
        private ToolStripMenuItem vzhledToolStripMenuItem;
        private ToolStripMenuItem tmavýToolStripMenuItem;
        private ToolStripMenuItem světlýToolStripMenuItem;
        private ToolStripMenuItem zálohováníToolStripMenuItem;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem klávesovéZkratkyToolStripMenuItem;
        private ToolStripMenuItem oSoftwareToolStripMenuItem;
        public ToolStripStatusLabel stavDB;
        public ToolStripStatusLabel pohybText;
        public ToolStripStatusLabel pocetVolnychMistText;
        private Panel main_wrapper;
        private Panel menu_left;
        private FlowLayoutPanel flow_button;
        private FlowLayoutPanel button1;
        private Label button_text1;
        private FlowLayoutPanel button2;
        private Label button_text2;
        private FlowLayoutPanel button3;
        private Label button_text3;
        private FlowLayoutPanel button4;
        private Label button_text4;
        private FlowLayoutPanel button5;
        private Label button_text5;
        private Panel under_button_holder;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}
