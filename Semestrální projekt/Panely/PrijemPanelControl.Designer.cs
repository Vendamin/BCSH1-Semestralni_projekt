namespace Semestrální_projekt
{
    partial class PrijemPanelControl
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
            this.prijem_center = new Panel();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.flowLayoutPanel1 = new Panel();
            this.label1 = new Label();
            this.label3 = new Label();
            this.idPaletyPrijemTextBox = new TextBox();
            this.label5 = new Label();
            this.comboBox1 = new ComboBox();
            this.button2 = new Button();
            this.flowLayoutPanel2 = new Panel();
            this.label2 = new Label();
            this.label4 = new Label();
            this.idPaletyExpediceTextBox = new TextBox();
            this.label6 = new Label();
            this.aktPoziceTextBox = new TextBox();
            this.label7 = new Label();
            this.obsahTextBox = new TextBox();
            this.checkBox1 = new CheckBox();
            this.button1 = new Button();
            this.prijem_bottom = new Panel();
            this.panel1 = new Panel();
            this.spacerBottom = new Panel();
            this.prijem_center.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.prijem_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // prijem_center
            // 
            this.prijem_center.BackColor = Color.FromArgb(40, 55, 74);
            this.prijem_center.Controls.Add(this.tableLayoutPanel1);
            this.prijem_center.Dock = DockStyle.Fill;
            this.prijem_center.Location = new Point(0, 0);
            this.prijem_center.Name = "prijem_center";
            this.prijem_center.Size = new Size(601, 384);
            this.prijem_center.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new Size(601, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.idPaletyPrijemTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = DockStyle.Fill;
            this.flowLayoutPanel1.Location = new Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Padding(10);
            this.flowLayoutPanel1.Size = new Size(294, 378);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new Size(274, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOVÝ PŘÍJEM PALETY";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 11F);
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID PALETY";
            // 
            // idPaletyPrijemTextBox
            // 
            this.idPaletyPrijemTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.idPaletyPrijemTextBox.Location = new Point(10, 75);
            this.idPaletyPrijemTextBox.Name = "idPaletyPrijemTextBox";
            this.idPaletyPrijemTextBox.Size = new Size(274, 23);
            this.idPaletyPrijemTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Segoe UI", 11F);
            this.label5.ForeColor = Color.White;
            this.label5.Location = new Point(10, 108);
            this.label5.Name = "label5";
            this.label5.Size = new Size(110, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "CÍLOVÁ POZICE";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(10, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(274, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.button2.BackColor = Color.FromArgb(46, 99, 142);
            this.button2.FlatAppearance.BorderColor = Color.FromArgb(46, 99, 142);
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Font = new Font("Segoe UI", 11F);
            this.button2.ForeColor = Color.White;
            this.button2.Location = new Point(10, 331);
            this.button2.Name = "button2";
            this.button2.Size = new Size(274, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "POTVRDIT PŘÍJEM";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.idPaletyExpediceTextBox);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.aktPoziceTextBox);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.obsahTextBox);
            this.flowLayoutPanel2.Controls.Add(this.checkBox1);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Dock = DockStyle.Fill;
            this.flowLayoutPanel2.Location = new Point(303, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new Padding(10);
            this.flowLayoutPanel2.Size = new Size(295, 378);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new Size(275, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "EXPEDICE PALETY";
            this.label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Segoe UI", 11F);
            this.label4.ForeColor = Color.White;
            this.label4.Location = new Point(10, 50);
            this.label4.Name = "label4";
            this.label4.Size = new Size(76, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID PALETY";
            // 
            // idPaletyExpediceTextBox
            // 
            this.idPaletyExpediceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.idPaletyExpediceTextBox.Location = new Point(10, 75);
            this.idPaletyExpediceTextBox.Name = "idPaletyExpediceTextBox";
            this.idPaletyExpediceTextBox.Size = new Size(275, 23);
            this.idPaletyExpediceTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Segoe UI", 11F);
            this.label6.ForeColor = Color.White;
            this.label6.Location = new Point(10, 108);
            this.label6.Name = "label6";
            this.label6.Size = new Size(139, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "SOUČASNÁ POZICE";
            // 
            // aktPoziceTextBox
            // 
            this.aktPoziceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.aktPoziceTextBox.Location = new Point(10, 133);
            this.aktPoziceTextBox.Name = "aktPoziceTextBox";
            this.aktPoziceTextBox.ReadOnly = true;
            this.aktPoziceTextBox.Size = new Size(275, 23);
            this.aktPoziceTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Segoe UI", 11F);
            this.label7.ForeColor = Color.White;
            this.label7.Location = new Point(10, 166);
            this.label7.Name = "label7";
            this.label7.Size = new Size(58, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "OBSAH";
            // 
            // obsahTextBox
            // 
            this.obsahTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.obsahTextBox.Location = new Point(10, 191);
            this.obsahTextBox.Name = "obsahTextBox";
            this.obsahTextBox.ReadOnly = true;
            this.obsahTextBox.Size = new Size(275, 23);
            this.obsahTextBox.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new Font("Segoe UI", 11F);
            this.checkBox1.ForeColor = Color.White;
            this.checkBox1.Location = new Point(10, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(167, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "POTVRZENÍ OBSAHU";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.button1.BackColor = Color.FromArgb(46, 99, 142);
            this.button1.FlatAppearance.BorderColor = Color.FromArgb(46, 99, 142);
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Segoe UI", 11F);
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(10, 331);
            this.button1.Name = "button1";
            this.button1.Size = new Size(275, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "POTVRDIT EXPEDICI";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // prijem_bottom
            // 
            this.prijem_bottom.BackColor = Color.FromArgb(40, 55, 74);
            this.prijem_bottom.Controls.Add(this.panel1);
            this.prijem_bottom.Dock = DockStyle.Bottom;
            this.prijem_bottom.Location = new Point(0, 399);
            this.prijem_bottom.Name = "prijem_bottom";
            this.prijem_bottom.Size = new Size(601, 75);
            this.prijem_bottom.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = Properties.Resources.box_single;
            this.panel1.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel1.Location = new Point(5, 5);
            this.panel1.Margin = new Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(65, 65);
            this.panel1.TabIndex = 9;
            // 
            // spacerBottom
            // 
            this.spacerBottom.Dock = DockStyle.Bottom;
            this.spacerBottom.Location = new Point(0, 384);
            this.spacerBottom.Name = "spacerBottom";
            this.spacerBottom.Size = new Size(601, 15);
            this.spacerBottom.TabIndex = 7;
            // 
            // PrijemPanelControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.prijem_center);
            this.Controls.Add(this.spacerBottom);
            this.Controls.Add(this.prijem_bottom);
            this.Name = "PrijemPanelControl";
            this.Size = new Size(601, 474);
            this.prijem_center.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.prijem_bottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel prijem_center;
        private Panel prijem_bottom;
        private Panel spacerBottom;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel flowLayoutPanel1;
        private Label label1;
        private Label label3;
        private TextBox idPaletyPrijemTextBox;
        private Label label5;
        private Panel flowLayoutPanel2;
        private Label label2;
        private Label label4;
        private TextBox idPaletyExpediceTextBox;
        private Label label6;
        private ComboBox comboBox1;
        private Button button2;
        private TextBox aktPoziceTextBox;
        private Label label7;
        private TextBox obsahTextBox;
        private CheckBox checkBox1;
        private Button button1;
    }
}
