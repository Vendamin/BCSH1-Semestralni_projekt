namespace Semestrální_projekt
{
    partial class NastaveniPanelControl
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

        #region Component Designer generated code

        private void InitializeComponent() {
            this.nastaveni_center = new TableLayoutPanel();
            this.nastaveni_groups = new TableLayoutPanel();
            this.databazeGroupBox = new GroupBox();
            this.panel1 = new Panel();
            this.panel4 = new Panel();
            this.typDatabaze = new ComboBox();
            this.label6 = new Label();
            this.button6 = new Button();
            this.label3 = new Label();
            this.nastaveniVytvoritBtn = new Button();
            this.cestaDb = new TextBox();
            this.nastaveniTestovatBtn = new Button();
            this.uiGroupBox = new GroupBox();
            this.panel6 = new Panel();
            this.panel3 = new Panel();
            this.jazykCombo = new ComboBox();
            this.motivCombo = new ComboBox();
            this.label9 = new Label();
            this.label10 = new Label();
            this.spravaSkladuGroupBox = new GroupBox();
            this.panel2 = new Panel();
            this.panel5 = new Panel();
            this.label13 = new Label();
            this.volnaMista = new Label();
            this.vychoziJednotka = new ComboBox();
            this.label12 = new Label();
            this.nastaveni_top = new Panel();
            this.label1 = new Label();
            this.nastaveni_bottom = new Panel();
            this.label8 = new Label();
            this.casZmeny = new Label();
            this.nastaveniSaveButton = new Button();
            this.nastaveniCancelButton = new Button();
            this.nastaveni_center.SuspendLayout();
            this.nastaveni_groups.SuspendLayout();
            this.databazeGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uiGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.spravaSkladuGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.nastaveni_top.SuspendLayout();
            this.nastaveni_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // nastaveni_center
            // 
            this.nastaveni_center.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.nastaveni_center.BackColor = Color.FromArgb(40, 55, 74);
            this.nastaveni_center.ColumnCount = 1;
            this.nastaveni_center.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.nastaveni_center.Controls.Add(this.nastaveni_groups, 0, 0);
            this.nastaveni_center.Location = new Point(0, 65);
            this.nastaveni_center.Margin = new Padding(0);
            this.nastaveni_center.Name = "nastaveni_center";
            this.nastaveni_center.Padding = new Padding(10);
            this.nastaveni_center.RowCount = 1;
            this.nastaveni_center.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.nastaveni_center.Size = new Size(718, 344);
            this.nastaveni_center.TabIndex = 6;
            // 
            // nastaveni_groups
            // 
            this.nastaveni_groups.ColumnCount = 2;
            this.nastaveni_groups.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.nastaveni_groups.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.nastaveni_groups.Controls.Add(this.databazeGroupBox, 0, 0);
            this.nastaveni_groups.Controls.Add(this.uiGroupBox, 0, 1);
            this.nastaveni_groups.Controls.Add(this.spravaSkladuGroupBox, 1, 1);
            this.nastaveni_groups.Dock = DockStyle.Fill;
            this.nastaveni_groups.Location = new Point(13, 13);
            this.nastaveni_groups.Name = "nastaveni_groups";
            this.nastaveni_groups.RowCount = 2;
            this.nastaveni_groups.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            this.nastaveni_groups.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            this.nastaveni_groups.Size = new Size(692, 318);
            this.nastaveni_groups.TabIndex = 0;
            // 
            // databazeGroupBox
            // 
            this.nastaveni_groups.SetColumnSpan(this.databazeGroupBox, 2);
            this.databazeGroupBox.Controls.Add(this.panel1);
            this.databazeGroupBox.Dock = DockStyle.Fill;
            this.databazeGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.databazeGroupBox.ForeColor = Color.White;
            this.databazeGroupBox.Location = new Point(0, 0);
            this.databazeGroupBox.Margin = new Padding(0, 0, 0, 6);
            this.databazeGroupBox.Name = "databazeGroupBox";
            this.databazeGroupBox.Padding = new Padding(8, 6, 8, 8);
            this.databazeGroupBox.Size = new Size(692, 178);
            this.databazeGroupBox.TabIndex = 0;
            this.databazeGroupBox.TabStop = false;
            this.databazeGroupBox.Text = "Databáze";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.typDatabaze);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nastaveniVytvoritBtn);
            this.panel1.Controls.Add(this.cestaDb);
            this.panel1.Controls.Add(this.nastaveniTestovatBtn);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(8, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(676, 142);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = AnchorStyles.None;
            this.panel4.BackColor = Color.Transparent;
            this.panel4.BackgroundImage = Properties.Resources.database_white;
            this.panel4.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel4.Location = new Point(3, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(82, 72);
            this.panel4.TabIndex = 9;
            // 
            // typDatabaze
            // 
            this.typDatabaze.Anchor = AnchorStyles.None;
            this.typDatabaze.BackColor = SystemColors.Window;
            this.typDatabaze.Cursor = Cursors.Hand;
            this.typDatabaze.DropDownStyle = ComboBoxStyle.DropDownList;
            this.typDatabaze.Enabled = false;
            this.typDatabaze.FlatStyle = FlatStyle.Flat;
            this.typDatabaze.Font = new Font("Segoe UI", 11F);
            this.typDatabaze.ForeColor = SystemColors.WindowText;
            this.typDatabaze.FormattingEnabled = true;
            this.typDatabaze.Items.AddRange(new object[] { "SQLite" });
            this.typDatabaze.Location = new Point(220, 51);
            this.typDatabaze.Name = "typDatabaze";
            this.typDatabaze.Size = new Size(112, 28);
            this.typDatabaze.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Segoe UI", 11.25F);
            this.label6.ForeColor = Color.White;
            this.label6.Location = new Point(98, 55);
            this.label6.Name = "label6";
            this.label6.Size = new Size(101, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Typ databáze:";
            // 
            // button6
            // 
            this.button6.Anchor = AnchorStyles.None;
            this.button6.BackColor = Color.FromArgb(68, 77, 84);
            this.button6.Cursor = Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = Color.FromArgb(79, 92, 109);
            this.button6.FlatStyle = FlatStyle.Flat;
            this.button6.Font = new Font("Wingdings", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            this.button6.ForeColor = Color.White;
            this.button6.Location = new Point(621, 46);
            this.button6.Name = "button6";
            this.button6.Size = new Size(27, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += this.button6_Click;
            // 
            // label3
            // 
            this.label3.Anchor = AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 11.25F);
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(396, 23);
            this.label3.Name = "label3";
            this.label3.Size = new Size(183, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cesta k souboru databáze:";
            this.label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nastaveniVytvoritBtn
            // 
            this.nastaveniVytvoritBtn.Anchor = AnchorStyles.None;
            this.nastaveniVytvoritBtn.BackColor = Color.FromArgb(68, 77, 84);
            this.nastaveniVytvoritBtn.Cursor = Cursors.Hand;
            this.nastaveniVytvoritBtn.FlatAppearance.BorderColor = Color.FromArgb(79, 92, 109);
            this.nastaveniVytvoritBtn.FlatStyle = FlatStyle.Flat;
            this.nastaveniVytvoritBtn.Font = new Font("Segoe UI", 11F);
            this.nastaveniVytvoritBtn.ForeColor = Color.White;
            this.nastaveniVytvoritBtn.Location = new Point(528, 86);
            this.nastaveniVytvoritBtn.Name = "nastaveniVytvoritBtn";
            this.nastaveniVytvoritBtn.Size = new Size(120, 27);
            this.nastaveniVytvoritBtn.TabIndex = 5;
            this.nastaveniVytvoritBtn.Text = "Vytvořit novou";
            this.nastaveniVytvoritBtn.UseVisualStyleBackColor = false;
            this.nastaveniVytvoritBtn.Click += this.nastaveniVytvoritBtn_Click;
            // 
            // cestaDb
            // 
            this.cestaDb.Anchor = AnchorStyles.None;
            this.cestaDb.BackColor = Color.FromArgb(79, 92, 109);
            this.cestaDb.BorderStyle = BorderStyle.FixedSingle;
            this.cestaDb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.cestaDb.ForeColor = Color.White;
            this.cestaDb.Location = new Point(396, 46);
            this.cestaDb.Name = "cestaDb";
            this.cestaDb.ReadOnly = true;
            this.cestaDb.Size = new Size(219, 23);
            this.cestaDb.TabIndex = 2;
            this.cestaDb.TextChanged += this.checkDirtyEventHandler;
            // 
            // nastaveniTestovatBtn
            // 
            this.nastaveniTestovatBtn.Anchor = AnchorStyles.None;
            this.nastaveniTestovatBtn.BackColor = Color.FromArgb(68, 77, 84);
            this.nastaveniTestovatBtn.Cursor = Cursors.Hand;
            this.nastaveniTestovatBtn.FlatAppearance.BorderColor = Color.FromArgb(79, 92, 109);
            this.nastaveniTestovatBtn.FlatStyle = FlatStyle.Flat;
            this.nastaveniTestovatBtn.Font = new Font("Segoe UI", 11F);
            this.nastaveniTestovatBtn.ForeColor = Color.White;
            this.nastaveniTestovatBtn.Location = new Point(396, 86);
            this.nastaveniTestovatBtn.Name = "nastaveniTestovatBtn";
            this.nastaveniTestovatBtn.Size = new Size(120, 27);
            this.nastaveniTestovatBtn.TabIndex = 4;
            this.nastaveniTestovatBtn.Text = "Testovat připojení";
            this.nastaveniTestovatBtn.UseVisualStyleBackColor = false;
            // 
            // uiGroupBox
            // 
            this.uiGroupBox.Controls.Add(this.panel3);
            this.uiGroupBox.Dock = DockStyle.Fill;
            this.uiGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.uiGroupBox.ForeColor = Color.White;
            this.uiGroupBox.Location = new Point(0, 190);
            this.uiGroupBox.Margin = new Padding(0, 6, 6, 0);
            this.uiGroupBox.Name = "uiGroupBox";
            this.uiGroupBox.Padding = new Padding(8, 6, 8, 8);
            this.uiGroupBox.Size = new Size(340, 128);
            this.uiGroupBox.TabIndex = 1;
            this.uiGroupBox.TabStop = false;
            this.uiGroupBox.Text = "Uživatelské rozhraní";
            // 
            // panel6
            // 
            this.panel6.Anchor = AnchorStyles.None;
            this.panel6.BackColor = Color.Transparent;
            this.panel6.BackgroundImage = Properties.Resources.window_maximize_white;
            this.panel6.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel6.Location = new Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new Size(82, 72);
            this.panel6.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.jazykCombo);
            this.panel3.Controls.Add(this.motivCombo);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = DockStyle.Fill;
            this.panel3.Location = new Point(8, 28);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Padding(0, 25, 0, 25);
            this.panel3.Size = new Size(324, 92);
            this.panel3.TabIndex = 9;
            // 
            // jazykCombo
            // 
            this.jazykCombo.Anchor = AnchorStyles.None;
            this.jazykCombo.Cursor = Cursors.Hand;
            this.jazykCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.jazykCombo.FlatStyle = FlatStyle.Flat;
            this.jazykCombo.Font = new Font("Segoe UI", 11F);
            this.jazykCombo.FormattingEnabled = true;
            this.jazykCombo.Location = new Point(193, 39);
            this.jazykCombo.Name = "jazykCombo";
            this.jazykCombo.Size = new Size(121, 28);
            this.jazykCombo.TabIndex = 10;
            this.jazykCombo.SelectedValueChanged += this.checkDirtyEventHandler;
            // 
            // motivCombo
            // 
            this.motivCombo.Anchor = AnchorStyles.None;
            this.motivCombo.Cursor = Cursors.Hand;
            this.motivCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.motivCombo.FlatStyle = FlatStyle.Flat;
            this.motivCombo.Font = new Font("Segoe UI", 11F);
            this.motivCombo.FormattingEnabled = true;
            this.motivCombo.Location = new Point(193, 6);
            this.motivCombo.Name = "motivCombo";
            this.motivCombo.Size = new Size(121, 28);
            this.motivCombo.TabIndex = 9;
            this.motivCombo.SelectedValueChanged += this.checkDirtyEventHandler;
            // 
            // label9
            // 
            this.label9.Anchor = AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new Font("Segoe UI", 11.25F);
            this.label9.ForeColor = Color.White;
            this.label9.Location = new Point(91, 43);
            this.label9.Name = "label9";
            this.label9.Size = new Size(46, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Jazyk:";
            // 
            // label10
            // 
            this.label10.Anchor = AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            this.label10.ForeColor = Color.White;
            this.label10.Location = new Point(91, 10);
            this.label10.Name = "label10";
            this.label10.Size = new Size(50, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Motiv:";
            // 
            // spravaSkladuGroupBox
            // 
            this.spravaSkladuGroupBox.Controls.Add(this.panel2);
            this.spravaSkladuGroupBox.Dock = DockStyle.Fill;
            this.spravaSkladuGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.spravaSkladuGroupBox.ForeColor = Color.White;
            this.spravaSkladuGroupBox.Location = new Point(352, 190);
            this.spravaSkladuGroupBox.Margin = new Padding(6, 6, 0, 0);
            this.spravaSkladuGroupBox.Name = "spravaSkladuGroupBox";
            this.spravaSkladuGroupBox.Padding = new Padding(8, 6, 8, 8);
            this.spravaSkladuGroupBox.Size = new Size(340, 128);
            this.spravaSkladuGroupBox.TabIndex = 2;
            this.spravaSkladuGroupBox.TabStop = false;
            this.spravaSkladuGroupBox.Text = "Správa skladu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.volnaMista);
            this.panel2.Controls.Add(this.vychoziJednotka);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(8, 28);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Padding(0, 25, 0, 25);
            this.panel2.Size = new Size(324, 92);
            this.panel2.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Anchor = AnchorStyles.None;
            this.panel5.BackColor = Color.Transparent;
            this.panel5.BackgroundImage = Properties.Resources.warehouse_white;
            this.panel5.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel5.Location = new Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new Size(82, 72);
            this.panel5.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Anchor = AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new Font("Segoe UI", 11.25F);
            this.label13.ForeColor = Color.White;
            this.label13.Location = new Point(91, 43);
            this.label13.Name = "label13";
            this.label13.Size = new Size(125, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Výchozí jednotka:";
            // 
            // volnaMista
            // 
            this.volnaMista.Anchor = AnchorStyles.None;
            this.volnaMista.AutoSize = true;
            this.volnaMista.Font = new Font("Segoe UI", 11.25F);
            this.volnaMista.ForeColor = Color.White;
            this.volnaMista.Location = new Point(232, 10);
            this.volnaMista.Name = "volnaMista";
            this.volnaMista.Size = new Size(81, 20);
            this.volnaMista.TabIndex = 6;
            this.volnaMista.Text = "volnaMista";
            // 
            // vychoziJednotka
            // 
            this.vychoziJednotka.Anchor = AnchorStyles.None;
            this.vychoziJednotka.BackColor = SystemColors.Window;
            this.vychoziJednotka.Cursor = Cursors.Hand;
            this.vychoziJednotka.DropDownStyle = ComboBoxStyle.DropDownList;
            this.vychoziJednotka.FlatStyle = FlatStyle.Flat;
            this.vychoziJednotka.Font = new Font("Segoe UI", 11F);
            this.vychoziJednotka.ForeColor = SystemColors.WindowText;
            this.vychoziJednotka.FormattingEnabled = true;
            this.vychoziJednotka.Location = new Point(222, 39);
            this.vychoziJednotka.Name = "vychoziJednotka";
            this.vychoziJednotka.Size = new Size(91, 28);
            this.vychoziJednotka.TabIndex = 7;
            this.vychoziJednotka.SelectedValueChanged += this.checkDirtyEventHandler;
            // 
            // label12
            // 
            this.label12.Anchor = AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Segoe UI", 11.25F);
            this.label12.ForeColor = Color.White;
            this.label12.Location = new Point(91, 10);
            this.label12.Name = "label12";
            this.label12.Size = new Size(89, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Volná místa:";
            // 
            // nastaveni_top
            // 
            this.nastaveni_top.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.nastaveni_top.BackColor = Color.FromArgb(40, 55, 74);
            this.nastaveni_top.Controls.Add(this.label1);
            this.nastaveni_top.Location = new Point(0, 0);
            this.nastaveni_top.Margin = new Padding(0);
            this.nastaveni_top.Name = "nastaveni_top";
            this.nastaveni_top.Size = new Size(718, 50);
            this.nastaveni_top.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = DockStyle.Fill;
            this.label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(718, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "NASTAVENÍ";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nastaveni_bottom
            // 
            this.nastaveni_bottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.nastaveni_bottom.BackColor = Color.FromArgb(40, 55, 74);
            this.nastaveni_bottom.Controls.Add(this.label8);
            this.nastaveni_bottom.Controls.Add(this.casZmeny);
            this.nastaveni_bottom.Controls.Add(this.nastaveniSaveButton);
            this.nastaveni_bottom.Controls.Add(this.nastaveniCancelButton);
            this.nastaveni_bottom.Location = new Point(0, 424);
            this.nastaveni_bottom.Margin = new Padding(0);
            this.nastaveni_bottom.Name = "nastaveni_bottom";
            this.nastaveni_bottom.Size = new Size(718, 50);
            this.nastaveni_bottom.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = Color.White;
            this.label8.Location = new Point(13, 24);
            this.label8.Name = "label8";
            this.label8.Size = new Size(93, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Poslední změna:";
            // 
            // casZmeny
            // 
            this.casZmeny.AutoSize = true;
            this.casZmeny.ForeColor = Color.White;
            this.casZmeny.Location = new Point(112, 24);
            this.casZmeny.Name = "casZmeny";
            this.casZmeny.Size = new Size(61, 15);
            this.casZmeny.TabIndex = 2;
            this.casZmeny.Text = "casZmeny";
            // 
            // nastaveniSaveButton
            // 
            this.nastaveniSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.nastaveniSaveButton.BackColor = Color.FromArgb(46, 99, 142);
            this.nastaveniSaveButton.Cursor = Cursors.Hand;
            this.nastaveniSaveButton.FlatAppearance.BorderColor = Color.FromArgb(46, 99, 142);
            this.nastaveniSaveButton.FlatStyle = FlatStyle.Flat;
            this.nastaveniSaveButton.Font = new Font("Segoe UI", 11F);
            this.nastaveniSaveButton.ForeColor = Color.White;
            this.nastaveniSaveButton.Location = new Point(496, 16);
            this.nastaveniSaveButton.Name = "nastaveniSaveButton";
            this.nastaveniSaveButton.Size = new Size(98, 28);
            this.nastaveniSaveButton.TabIndex = 1;
            this.nastaveniSaveButton.Text = "Uložit změny";
            this.nastaveniSaveButton.UseVisualStyleBackColor = false;
            this.nastaveniSaveButton.Click += this.nastaveniSaveButton_Click;
            // 
            // nastaveniCancelButton
            // 
            this.nastaveniCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.nastaveniCancelButton.BackColor = Color.FromArgb(68, 77, 84);
            this.nastaveniCancelButton.Cursor = Cursors.Hand;
            this.nastaveniCancelButton.FlatAppearance.BorderColor = Color.FromArgb(79, 92, 109);
            this.nastaveniCancelButton.FlatStyle = FlatStyle.Flat;
            this.nastaveniCancelButton.Font = new Font("Segoe UI", 11F);
            this.nastaveniCancelButton.ForeColor = Color.White;
            this.nastaveniCancelButton.Location = new Point(609, 16);
            this.nastaveniCancelButton.Name = "nastaveniCancelButton";
            this.nastaveniCancelButton.Size = new Size(104, 28);
            this.nastaveniCancelButton.TabIndex = 0;
            this.nastaveniCancelButton.Text = "Zrušit změny";
            this.nastaveniCancelButton.UseVisualStyleBackColor = false;
            this.nastaveniCancelButton.Click += this.nastaveniCancelButton_Click;
            // 
            // NastaveniPanelControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.nastaveni_center);
            this.Controls.Add(this.nastaveni_top);
            this.Controls.Add(this.nastaveni_bottom);
            this.Name = "NastaveniPanelControl";
            this.Size = new Size(718, 474);
            this.nastaveni_center.ResumeLayout(false);
            this.nastaveni_groups.ResumeLayout(false);
            this.databazeGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.uiGroupBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.spravaSkladuGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.nastaveni_top.ResumeLayout(false);
            this.nastaveni_bottom.ResumeLayout(false);
            this.nastaveni_bottom.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel nastaveni_center;
        private TableLayoutPanel nastaveni_groups;
        private GroupBox databazeGroupBox;
        private GroupBox uiGroupBox;
        private GroupBox spravaSkladuGroupBox;
        private Panel panel1;
        private Button button6;
        private Label label3;
        private Button nastaveniVytvoritBtn;
        private TextBox cestaDb;
        private Button nastaveniTestovatBtn;
        private ComboBox typDatabaze;
        private Label label6;
        private Panel panel2;
        private Label label13;
        private Label volnaMista;
        private ComboBox vychoziJednotka;
        private Label label12;
        private Panel nastaveni_top;
        private Label label1;
        private Panel nastaveni_bottom;
        private Button nastaveniSaveButton;
        private Button nastaveniCancelButton;
        private Panel panel3;
        private ComboBox jazykCombo;
        private ComboBox motivCombo;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label casZmeny;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}
