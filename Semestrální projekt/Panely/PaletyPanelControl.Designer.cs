namespace Semestrální_projekt
{
    partial class PaletyPanelControl
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
            this.palety_center = new Panel();
            this.dataGridView1 = new DataGridView();
            this.id = new DataGridViewTextBoxColumn();
            this.obsah = new DataGridViewTextBoxColumn();
            this.pocetKusu = new DataGridViewTextBoxColumn();
            this.hmotnost = new DataGridViewTextBoxColumn();
            this.aktPozice = new DataGridViewTextBoxColumn();
            this.label1 = new Label();
            this.palety_top = new Panel();
            this.addNewButton = new Button();
            this.searchBox = new TextBox();
            this.palety_bottom = new Panel();
            this.pocetKusuLabel = new Label();
            this.hmotnostLabel = new Label();
            this.aktPoziceLabel = new Label();
            this.obsahLabel = new Label();
            this.idPaletyLabel = new Label();
            this.label7 = new Label();
            this.panel1 = new Panel();
            this.updateButton = new Button();
            this.deleteButton = new Button();
            this.historyButton = new Button();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.spacerTop = new Panel();
            this.spacerBottom = new Panel();
            this.palety_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            this.palety_top.SuspendLayout();
            this.palety_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // palety_center
            // 
            this.palety_center.BackColor = Color.FromArgb(40, 55, 74);
            this.palety_center.Controls.Add(this.dataGridView1);
            this.palety_center.Controls.Add(this.label1);
            this.palety_center.Dock = DockStyle.Fill;
            this.palety_center.Location = new Point(0, 65);
            this.palety_center.Name = "palety_center";
            this.palety_center.Size = new Size(718, 319);
            this.palety_center.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.id, this.obsah, this.pocetKusu, this.hmotnost, this.aktPozice });
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Location = new Point(0, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new Size(718, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += this.ShowPalet;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.FillWeight = 75F;
            this.id.HeaderText = "ID PALETY";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // obsah
            // 
            this.obsah.DataPropertyName = "Obsah";
            this.obsah.FillWeight = 110F;
            this.obsah.HeaderText = "OBSAH";
            this.obsah.Name = "obsah";
            this.obsah.ReadOnly = true;
            // 
            // pocetKusu
            // 
            this.pocetKusu.DataPropertyName = "PocetKusuString";
            this.pocetKusu.FillWeight = 85F;
            this.pocetKusu.HeaderText = "POČET KUSŮ";
            this.pocetKusu.Name = "pocetKusu";
            this.pocetKusu.ReadOnly = true;
            // 
            // hmotnost
            // 
            this.hmotnost.DataPropertyName = "HmotnostString";
            this.hmotnost.FillWeight = 85F;
            this.hmotnost.HeaderText = "HMOTNOST";
            this.hmotnost.Name = "hmotnost";
            this.hmotnost.ReadOnly = true;
            // 
            // aktPozice
            // 
            this.aktPozice.DataPropertyName = "AktPozice";
            this.aktPozice.FillWeight = 110F;
            this.aktPozice.HeaderText = "AKTUÁLNÍ POZICE";
            this.aktPozice.Name = "aktPozice";
            this.aktPozice.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Dock = DockStyle.Top;
            this.label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(718, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PŘEHLED PALET (ZBOŽÍ)";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // palety_top
            // 
            this.palety_top.BackColor = Color.FromArgb(40, 55, 74);
            this.palety_top.Controls.Add(this.addNewButton);
            this.palety_top.Controls.Add(this.searchBox);
            this.palety_top.Dock = DockStyle.Top;
            this.palety_top.Location = new Point(0, 0);
            this.palety_top.Name = "palety_top";
            this.palety_top.Size = new Size(718, 50);
            this.palety_top.TabIndex = 3;
            // 
            // addNewButton
            // 
            this.addNewButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.addNewButton.BackColor = Color.FromArgb(46, 99, 142);
            this.addNewButton.FlatAppearance.BorderColor = Color.FromArgb(46, 99, 142);
            this.addNewButton.FlatStyle = FlatStyle.Flat;
            this.addNewButton.Font = new Font("Segoe UI", 9F);
            this.addNewButton.ForeColor = Color.White;
            this.addNewButton.Location = new Point(613, 8);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new Size(98, 31);
            this.addNewButton.TabIndex = 1;
            this.addNewButton.Text = "NOVÁ PALETA";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += this.addNewButton_Click;
            // 
            // searchBox
            // 
            this.searchBox.Location = new Point(14, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Vyhledávač";
            this.searchBox.Size = new Size(147, 23);
            this.searchBox.TabIndex = 0;
            // 
            // palety_bottom
            // 
            this.palety_bottom.BackColor = Color.FromArgb(40, 55, 74);
            this.palety_bottom.Controls.Add(this.pocetKusuLabel);
            this.palety_bottom.Controls.Add(this.hmotnostLabel);
            this.palety_bottom.Controls.Add(this.aktPoziceLabel);
            this.palety_bottom.Controls.Add(this.obsahLabel);
            this.palety_bottom.Controls.Add(this.idPaletyLabel);
            this.palety_bottom.Controls.Add(this.label7);
            this.palety_bottom.Controls.Add(this.panel1);
            this.palety_bottom.Controls.Add(this.updateButton);
            this.palety_bottom.Controls.Add(this.deleteButton);
            this.palety_bottom.Controls.Add(this.historyButton);
            this.palety_bottom.Controls.Add(this.label6);
            this.palety_bottom.Controls.Add(this.label5);
            this.palety_bottom.Controls.Add(this.label3);
            this.palety_bottom.Controls.Add(this.label2);
            this.palety_bottom.Dock = DockStyle.Bottom;
            this.palety_bottom.Location = new Point(0, 399);
            this.palety_bottom.Name = "palety_bottom";
            this.palety_bottom.Size = new Size(718, 75);
            this.palety_bottom.TabIndex = 2;
            // 
            // pocetKusuLabel
            // 
            this.pocetKusuLabel.AutoSize = true;
            this.pocetKusuLabel.Font = new Font("Segoe UI", 11F);
            this.pocetKusuLabel.ForeColor = Color.White;
            this.pocetKusuLabel.Location = new Point(384, 31);
            this.pocetKusuLabel.Name = "pocetKusuLabel";
            this.pocetKusuLabel.Size = new Size(97, 20);
            this.pocetKusuLabel.TabIndex = 14;
            this.pocetKusuLabel.Text = "pocetKusuTxt";
            // 
            // hmotnostLabel
            // 
            this.hmotnostLabel.AutoSize = true;
            this.hmotnostLabel.Font = new Font("Segoe UI", 11F);
            this.hmotnostLabel.ForeColor = Color.White;
            this.hmotnostLabel.Location = new Point(384, 51);
            this.hmotnostLabel.Name = "hmotnostLabel";
            this.hmotnostLabel.Size = new Size(91, 20);
            this.hmotnostLabel.TabIndex = 13;
            this.hmotnostLabel.Text = "hmotnostTxt";
            // 
            // aktPoziceLabel
            // 
            this.aktPoziceLabel.AutoSize = true;
            this.aktPoziceLabel.Font = new Font("Segoe UI", 11F);
            this.aktPoziceLabel.ForeColor = Color.White;
            this.aktPoziceLabel.Location = new Point(173, 51);
            this.aktPoziceLabel.Name = "aktPoziceLabel";
            this.aktPoziceLabel.Size = new Size(90, 20);
            this.aktPoziceLabel.TabIndex = 12;
            this.aktPoziceLabel.Text = "aktPoziceTxt";
            // 
            // obsahLabel
            // 
            this.obsahLabel.AutoSize = true;
            this.obsahLabel.Font = new Font("Segoe UI", 11F);
            this.obsahLabel.ForeColor = Color.White;
            this.obsahLabel.Location = new Point(173, 31);
            this.obsahLabel.Name = "obsahLabel";
            this.obsahLabel.Size = new Size(68, 20);
            this.obsahLabel.TabIndex = 11;
            this.obsahLabel.Text = "obsahTxt";
            // 
            // idPaletyLabel
            // 
            this.idPaletyLabel.AutoSize = true;
            this.idPaletyLabel.Font = new Font("Segoe UI", 11F);
            this.idPaletyLabel.ForeColor = Color.White;
            this.idPaletyLabel.Location = new Point(204, 5);
            this.idPaletyLabel.Name = "idPaletyLabel";
            this.idPaletyLabel.Size = new Size(80, 20);
            this.idPaletyLabel.TabIndex = 10;
            this.idPaletyLabel.Text = "idPaletyTxt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Segoe UI", 11F);
            this.label7.ForeColor = Color.White;
            this.label7.Location = new Point(90, 4);
            this.label7.Name = "label7";
            this.label7.Size = new Size(108, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "DETAIL PALETY";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = Properties.Resources.box_white;
            this.panel1.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel1.Location = new Point(5, 5);
            this.panel1.Margin = new Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(65, 65);
            this.panel1.TabIndex = 8;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.updateButton.BackColor = Color.FromArgb(68, 77, 84);
            this.updateButton.FlatAppearance.BorderColor = Color.FromArgb(68, 77, 84);
            this.updateButton.FlatStyle = FlatStyle.Flat;
            this.updateButton.Font = new Font("Segoe UI", 9F);
            this.updateButton.ForeColor = Color.White;
            this.updateButton.Location = new Point(531, 43);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new Size(87, 27);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "UPRAVIT DETAIL";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.deleteButton.BackColor = Color.FromArgb(111, 67, 68);
            this.deleteButton.FlatAppearance.BorderColor = Color.FromArgb(111, 67, 68);
            this.deleteButton.FlatStyle = FlatStyle.Flat;
            this.deleteButton.Font = new Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = Color.White;
            this.deleteButton.Location = new Point(624, 43);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new Size(87, 27);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "ODSTRANIT";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += this.DeletePalet;
            // 
            // historyButton
            // 
            this.historyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.historyButton.BackColor = Color.FromArgb(46, 99, 142);
            this.historyButton.FlatAppearance.BorderColor = Color.FromArgb(46, 99, 142);
            this.historyButton.FlatStyle = FlatStyle.Flat;
            this.historyButton.Font = new Font("Segoe UI", 9F);
            this.historyButton.ForeColor = Color.White;
            this.historyButton.Location = new Point(587, 10);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new Size(124, 27);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "ZOBRAZIT HISTORII";
            this.historyButton.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Segoe UI", 11F);
            this.label6.ForeColor = Color.White;
            this.label6.Location = new Point(295, 51);
            this.label6.Name = "label6";
            this.label6.Size = new Size(78, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hmotnost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Segoe UI", 11F);
            this.label5.ForeColor = Color.White;
            this.label5.Location = new Point(295, 31);
            this.label5.Name = "label5";
            this.label5.Size = new Size(83, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Počet Kusů:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 11F);
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(90, 51);
            this.label3.Name = "label3";
            this.label3.Size = new Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Akt. pozice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 11F);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(90, 31);
            this.label2.Name = "label2";
            this.label2.Size = new Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Obsah:";
            // 
            // spacerTop
            // 
            this.spacerTop.Dock = DockStyle.Top;
            this.spacerTop.Location = new Point(0, 50);
            this.spacerTop.Name = "spacerTop";
            this.spacerTop.Size = new Size(718, 15);
            this.spacerTop.TabIndex = 7;
            // 
            // spacerBottom
            // 
            this.spacerBottom.Dock = DockStyle.Bottom;
            this.spacerBottom.Location = new Point(0, 384);
            this.spacerBottom.Name = "spacerBottom";
            this.spacerBottom.Size = new Size(718, 15);
            this.spacerBottom.TabIndex = 8;
            // 
            // PaletyPanelControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.palety_center);
            this.Controls.Add(this.spacerBottom);
            this.Controls.Add(this.palety_bottom);
            this.Controls.Add(this.spacerTop);
            this.Controls.Add(this.palety_top);
            this.Name = "PaletyPanelControl";
            this.Size = new Size(718, 474);
            this.palety_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            this.palety_top.ResumeLayout(false);
            this.palety_top.PerformLayout();
            this.palety_bottom.ResumeLayout(false);
            this.palety_bottom.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel palety_center;
        private Panel palety_top;
        private Label label10;
        private Panel palety_bottom;
        private Panel spacerTop;
        private Panel spacerBottom;
        private Label label1;
        private DataGridView dataGridView1;
        private Button updateButton;
        private TextBox searchBox;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Button deleteButton;
        private Button addNewButton;
        private Button historyButton;
        private Label label7;
        private Label pocetKusuLabel;
        private Label hmotnostLabel;
        private Label aktPoziceLabel;
        private Label obsahLabel;
        private Label idPaletyLabel;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn obsah;
        private DataGridViewTextBoxColumn pocetKusu;
        private DataGridViewTextBoxColumn hmotnost;
        private DataGridViewTextBoxColumn aktPozice;
    }
}
