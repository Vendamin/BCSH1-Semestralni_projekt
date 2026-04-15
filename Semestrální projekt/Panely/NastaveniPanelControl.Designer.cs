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
            this.nastaveni_topleft = new Panel();
            this.panel1 = new Panel();
            this.button6 = new Button();
            this.label3 = new Label();
            this.nastaveniVytvoritBtn = new Button();
            this.cestaDb = new TextBox();
            this.nastaveniTestovatBtn = new Button();
            this.label2 = new Label();
            this.nastaveni_topright = new Panel();
            this.label4 = new Label();
            this.nastaveni_bottomleft = new Panel();
            this.panel2 = new Panel();
            this.label13 = new Label();
            this.volnaMista = new Label();
            this.vychoziJednotka = new ComboBox();
            this.numericUpDown1 = new NumericUpDown();
            this.label12 = new Label();
            this.label14 = new Label();
            this.label5 = new Label();
            this.nastaveni_bottomright = new Panel();
            this.label6 = new Label();
            this.nastaveni_top = new Panel();
            this.label1 = new Label();
            this.nastaveni_bottom = new Panel();
            this.button10 = new Button();
            this.button9 = new Button();
            this.nastaveni_center.SuspendLayout();
            this.nastaveni_topleft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.nastaveni_topright.SuspendLayout();
            this.nastaveni_bottomleft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
            this.nastaveni_bottomright.SuspendLayout();
            this.nastaveni_top.SuspendLayout();
            this.nastaveni_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // nastaveni_center
            // 
            this.nastaveni_center.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.nastaveni_center.BackColor = Color.Transparent;
            this.nastaveni_center.ColumnCount = 2;
            this.nastaveni_center.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8366F));
            this.nastaveni_center.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.1634F));
            this.nastaveni_center.Controls.Add(this.nastaveni_topleft, 0, 0);
            this.nastaveni_center.Controls.Add(this.nastaveni_topright, 1, 0);
            this.nastaveni_center.Controls.Add(this.nastaveni_bottomleft, 0, 1);
            this.nastaveni_center.Controls.Add(this.nastaveni_bottomright, 1, 1);
            this.nastaveni_center.Location = new Point(0, 65);
            this.nastaveni_center.Margin = new Padding(0);
            this.nastaveni_center.Name = "nastaveni_center";
            this.nastaveni_center.RowCount = 2;
            this.nastaveni_center.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.nastaveni_center.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.nastaveni_center.Size = new Size(601, 344);
            this.nastaveni_center.TabIndex = 6;
            // 
            // nastaveni_topleft
            // 
            this.nastaveni_topleft.BackColor = Color.FromArgb(40, 55, 74);
            this.nastaveni_topleft.Controls.Add(this.panel1);
            this.nastaveni_topleft.Controls.Add(this.label2);
            this.nastaveni_topleft.Dock = DockStyle.Fill;
            this.nastaveni_topleft.Location = new Point(0, 0);
            this.nastaveni_topleft.Margin = new Padding(0, 0, 7, 7);
            this.nastaveni_topleft.Name = "nastaveni_topleft";
            this.nastaveni_topleft.Size = new Size(292, 165);
            this.nastaveni_topleft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nastaveniVytvoritBtn);
            this.panel1.Controls.Add(this.cestaDb);
            this.panel1.Controls.Add(this.nastaveniTestovatBtn);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(292, 143);
            this.panel1.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Anchor = AnchorStyles.None;
            this.button6.BackColor = Color.FromArgb(68, 77, 84);
            this.button6.FlatAppearance.BorderColor = Color.FromArgb(79, 92, 109);
            this.button6.FlatStyle = FlatStyle.Flat;
            this.button6.Font = new Font("Wingdings", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            this.button6.ForeColor = Color.White;
            this.button6.Location = new Point(254, 53);
            this.button6.Name = "button6";
            this.button6.Size = new Size(23, 23);
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
            this.label3.Location = new Point(25, 28);
            this.label3.Name = "label3";
            this.label3.Size = new Size(183, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cesta k souboru databáze:";
            // 
            // nastaveniVytvoritBtn
            // 
            this.nastaveniVytvoritBtn.Anchor = AnchorStyles.None;
            this.nastaveniVytvoritBtn.BackColor = Color.FromArgb(68, 77, 84);
            this.nastaveniVytvoritBtn.FlatAppearance.BorderColor = Color.FromArgb(79, 92, 109);
            this.nastaveniVytvoritBtn.FlatStyle = FlatStyle.Flat;
            this.nastaveniVytvoritBtn.Font = new Font("Segoe UI", 11.25F);
            this.nastaveniVytvoritBtn.ForeColor = Color.White;
            this.nastaveniVytvoritBtn.Location = new Point(157, 82);
            this.nastaveniVytvoritBtn.Name = "nastaveniVytvoritBtn";
            this.nastaveniVytvoritBtn.Size = new Size(120, 27);
            this.nastaveniVytvoritBtn.TabIndex = 5;
            this.nastaveniVytvoritBtn.Text = "Vytvořit zálohu";
            this.nastaveniVytvoritBtn.UseVisualStyleBackColor = false;
            // 
            // cestaDb
            // 
            this.cestaDb.Anchor = AnchorStyles.None;
            this.cestaDb.BackColor = Color.FromArgb(79, 92, 109);
            this.cestaDb.BorderStyle = BorderStyle.FixedSingle;
            this.cestaDb.ForeColor = Color.White;
            this.cestaDb.Location = new Point(25, 53);
            this.cestaDb.Name = "cestaDb";
            this.cestaDb.ReadOnly = true;
            this.cestaDb.Size = new Size(223, 23);
            this.cestaDb.TabIndex = 2;
            // 
            // nastaveniTestovatBtn
            // 
            this.nastaveniTestovatBtn.Anchor = AnchorStyles.None;
            this.nastaveniTestovatBtn.BackColor = Color.FromArgb(68, 77, 84);
            this.nastaveniTestovatBtn.FlatAppearance.BorderColor = Color.FromArgb(79, 92, 109);
            this.nastaveniTestovatBtn.FlatStyle = FlatStyle.Flat;
            this.nastaveniTestovatBtn.Font = new Font("Segoe UI", 11.25F);
            this.nastaveniTestovatBtn.ForeColor = Color.White;
            this.nastaveniTestovatBtn.Location = new Point(25, 82);
            this.nastaveniTestovatBtn.Name = "nastaveniTestovatBtn";
            this.nastaveniTestovatBtn.Size = new Size(120, 27);
            this.nastaveniTestovatBtn.TabIndex = 4;
            this.nastaveniTestovatBtn.Text = "Testovat připojení";
            this.nastaveniTestovatBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Dock = DockStyle.Top;
            this.label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(292, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Databáze";
            this.label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nastaveni_topright
            // 
            this.nastaveni_topright.BackColor = Color.FromArgb(40, 55, 74);
            this.nastaveni_topright.Controls.Add(this.label4);
            this.nastaveni_topright.Dock = DockStyle.Fill;
            this.nastaveni_topright.Location = new Point(307, 0);
            this.nastaveni_topright.Margin = new Padding(8, 0, 0, 7);
            this.nastaveni_topright.Name = "nastaveni_topright";
            this.nastaveni_topright.Size = new Size(294, 165);
            this.nastaveni_topright.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = DockStyle.Top;
            this.label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.label4.ForeColor = Color.White;
            this.label4.Location = new Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(294, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Uživatelské rozhraní";
            this.label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nastaveni_bottomleft
            // 
            this.nastaveni_bottomleft.BackColor = Color.FromArgb(40, 55, 74);
            this.nastaveni_bottomleft.Controls.Add(this.panel2);
            this.nastaveni_bottomleft.Controls.Add(this.label5);
            this.nastaveni_bottomleft.Dock = DockStyle.Fill;
            this.nastaveni_bottomleft.Location = new Point(0, 180);
            this.nastaveni_bottomleft.Margin = new Padding(0, 8, 7, 0);
            this.nastaveni_bottomleft.Name = "nastaveni_bottomleft";
            this.nastaveni_bottomleft.Size = new Size(292, 164);
            this.nastaveni_bottomleft.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.volnaMista);
            this.panel2.Controls.Add(this.vychoziJednotka);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Padding(0, 25, 0, 25);
            this.panel2.Size = new Size(292, 142);
            this.panel2.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.Anchor = AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new Font("Segoe UI", 11.25F);
            this.label13.ForeColor = Color.White;
            this.label13.Location = new Point(3, 84);
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
            this.volnaMista.Location = new Point(177, 55);
            this.volnaMista.Name = "volnaMista";
            this.volnaMista.Size = new Size(81, 20);
            this.volnaMista.TabIndex = 6;
            this.volnaMista.Text = "volnaMista";
            // 
            // vychoziJednotka
            // 
            this.vychoziJednotka.Anchor = AnchorStyles.None;
            this.vychoziJednotka.BackColor = Color.FromArgb(68, 77, 84);
            this.vychoziJednotka.FlatStyle = FlatStyle.Flat;
            this.vychoziJednotka.FormattingEnabled = true;
            this.vychoziJednotka.Location = new Point(177, 81);
            this.vychoziJednotka.Name = "vychoziJednotka";
            this.vychoziJednotka.Size = new Size(112, 23);
            this.vychoziJednotka.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = AnchorStyles.None;
            this.numericUpDown1.Location = new Point(178, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(111, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Anchor = AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Segoe UI", 11.25F);
            this.label12.ForeColor = Color.White;
            this.label12.Location = new Point(3, 55);
            this.label12.Name = "label12";
            this.label12.Size = new Size(89, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Volná místa:";
            // 
            // label14
            // 
            this.label14.Anchor = AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            this.label14.ForeColor = Color.White;
            this.label14.Location = new Point(3, 27);
            this.label14.Name = "label14";
            this.label14.Size = new Size(161, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Maximální počet palet:";
            // 
            // label5
            // 
            this.label5.Dock = DockStyle.Top;
            this.label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.label5.ForeColor = Color.White;
            this.label5.Location = new Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(292, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Správa skladu";
            this.label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nastaveni_bottomright
            // 
            this.nastaveni_bottomright.BackColor = Color.FromArgb(40, 55, 74);
            this.nastaveni_bottomright.Controls.Add(this.label6);
            this.nastaveni_bottomright.Dock = DockStyle.Fill;
            this.nastaveni_bottomright.Location = new Point(307, 180);
            this.nastaveni_bottomright.Margin = new Padding(8, 8, 0, 0);
            this.nastaveni_bottomright.Name = "nastaveni_bottomright";
            this.nastaveni_bottomright.Size = new Size(294, 164);
            this.nastaveni_bottomright.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Dock = DockStyle.Top;
            this.label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.label6.ForeColor = Color.White;
            this.label6.Location = new Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(294, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Správa uživatelů";
            this.label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nastaveni_top
            // 
            this.nastaveni_top.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.nastaveni_top.BackColor = Color.FromArgb(40, 55, 74);
            this.nastaveni_top.Controls.Add(this.label1);
            this.nastaveni_top.Location = new Point(0, 0);
            this.nastaveni_top.Margin = new Padding(0);
            this.nastaveni_top.Name = "nastaveni_top";
            this.nastaveni_top.Size = new Size(601, 50);
            this.nastaveni_top.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = DockStyle.Fill;
            this.label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(601, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "NASTAVENÍ";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nastaveni_bottom
            // 
            this.nastaveni_bottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.nastaveni_bottom.BackColor = Color.FromArgb(40, 55, 74);
            this.nastaveni_bottom.Controls.Add(this.button10);
            this.nastaveni_bottom.Controls.Add(this.button9);
            this.nastaveni_bottom.Location = new Point(0, 424);
            this.nastaveni_bottom.Margin = new Padding(0);
            this.nastaveni_bottom.Name = "nastaveni_bottom";
            this.nastaveni_bottom.Size = new Size(601, 50);
            this.nastaveni_bottom.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button10.BackColor = Color.FromArgb(68, 77, 84);
            this.button10.FlatAppearance.BorderColor = Color.FromArgb(79, 92, 109);
            this.button10.FlatStyle = FlatStyle.Flat;
            this.button10.Font = new Font("Segoe UI", 11.25F);
            this.button10.ForeColor = Color.White;
            this.button10.Location = new Point(379, 16);
            this.button10.Name = "button10";
            this.button10.Size = new Size(98, 28);
            this.button10.TabIndex = 1;
            this.button10.Text = "Uložit změny";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button9.BackColor = Color.FromArgb(68, 77, 84);
            this.button9.FlatAppearance.BorderColor = Color.FromArgb(79, 92, 109);
            this.button9.FlatStyle = FlatStyle.Flat;
            this.button9.Font = new Font("Segoe UI", 11.25F);
            this.button9.ForeColor = Color.White;
            this.button9.Location = new Point(492, 16);
            this.button9.Name = "button9";
            this.button9.Size = new Size(104, 28);
            this.button9.TabIndex = 0;
            this.button9.Text = "Zrušit změny";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // NastaveniPanelControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.nastaveni_center);
            this.Controls.Add(this.nastaveni_top);
            this.Controls.Add(this.nastaveni_bottom);
            this.Name = "NastaveniPanelControl";
            this.Size = new Size(601, 474);
            this.nastaveni_center.ResumeLayout(false);
            this.nastaveni_topleft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nastaveni_topright.ResumeLayout(false);
            this.nastaveni_bottomleft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
            this.nastaveni_bottomright.ResumeLayout(false);
            this.nastaveni_top.ResumeLayout(false);
            this.nastaveni_bottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel nastaveni_center;
        private Panel nastaveni_topleft;
        private Panel panel1;
        private Button button6;
        private Label label3;
        private Button nastaveniVytvoritBtn;
        private TextBox cestaDb;
        private Button nastaveniTestovatBtn;
        private Label label2;
        private Panel nastaveni_topright;
        private Label label4;
        private Panel nastaveni_bottomleft;
        private Panel panel2;
        private Label label13;
        private Label volnaMista;
        private ComboBox vychoziJednotka;
        private NumericUpDown numericUpDown1;
        private Label label12;
        private Label label14;
        private Label label5;
        private Panel nastaveni_bottomright;
        private Label label6;
        private Panel nastaveni_top;
        private Label label1;
        private Panel nastaveni_bottom;
        private Button button10;
        private Button button9;
    }
}
