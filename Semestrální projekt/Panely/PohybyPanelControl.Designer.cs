namespace Semestrální_projekt
{
    partial class PohybyPanelControl
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
            this.pohyby_center = new Panel();
            this.label11 = new Label();
            this.dataGridView1 = new DataGridView();
            this.pohyby_top = new Panel();
            this.exportDataButton = new Button();
            this.dateTimePickerTo = new DateTimePicker();
            this.dateTimePickerFrom = new DateTimePicker();
            this.label2 = new Label();
            this.label1 = new Label();
            this.searchBox = new TextBox();
            this.pohyby_bottom = new Panel();
            this.showPaletButton = new Button();
            this.showInDashboard = new Button();
            this.label10 = new Label();
            this.label9 = new Label();
            this.label8 = new Label();
            this.label7 = new Label();
            this.idPohybu = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.panel1 = new Panel();
            this.spacerTop = new Panel();
            this.spacerBottom = new Panel();
            this.pohyby_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            this.pohyby_top.SuspendLayout();
            this.pohyby_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pohyby_center
            // 
            this.pohyby_center.BackColor = Color.FromArgb(40, 55, 74);
            this.pohyby_center.Controls.Add(this.label11);
            this.pohyby_center.Controls.Add(this.dataGridView1);
            this.pohyby_center.Dock = DockStyle.Fill;
            this.pohyby_center.Location = new Point(0, 65);
            this.pohyby_center.Name = "pohyby_center";
            this.pohyby_center.Size = new Size(601, 319);
            this.pohyby_center.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Dock = DockStyle.Top;
            this.label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.label11.ForeColor = Color.White;
            this.label11.Location = new Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new Size(601, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "HISTORIE SKLADOVÝCH POHYBŮ (LOG)";
            this.label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Location = new Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(601, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // pohyby_top
            // 
            this.pohyby_top.BackColor = Color.FromArgb(40, 55, 74);
            this.pohyby_top.Controls.Add(this.exportDataButton);
            this.pohyby_top.Controls.Add(this.dateTimePickerTo);
            this.pohyby_top.Controls.Add(this.dateTimePickerFrom);
            this.pohyby_top.Controls.Add(this.label2);
            this.pohyby_top.Controls.Add(this.label1);
            this.pohyby_top.Controls.Add(this.searchBox);
            this.pohyby_top.Dock = DockStyle.Top;
            this.pohyby_top.Location = new Point(0, 0);
            this.pohyby_top.Name = "pohyby_top";
            this.pohyby_top.Size = new Size(601, 50);
            this.pohyby_top.TabIndex = 3;
            // 
            // exportDataButton
            // 
            this.exportDataButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.exportDataButton.BackColor = Color.FromArgb(68, 77, 84);
            this.exportDataButton.FlatAppearance.BorderColor = Color.FromArgb(68, 77, 84);
            this.exportDataButton.FlatStyle = FlatStyle.Flat;
            this.exportDataButton.ForeColor = Color.White;
            this.exportDataButton.Location = new Point(473, 16);
            this.exportDataButton.Name = "exportDataButton";
            this.exportDataButton.Size = new Size(125, 23);
            this.exportDataButton.TabIndex = 11;
            this.exportDataButton.Text = "EXPORT DATA (CSV)";
            this.exportDataButton.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd. MM. - HH:mm";
            this.dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new Point(365, 14);
            this.dateTimePickerTo.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new Size(109, 23);
            this.dateTimePickerTo.TabIndex = 4;
            this.dateTimePickerTo.Value = new DateTime(2026, 1, 1, 13, 5, 0, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd. MM. - HH:mm";
            this.dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new Point(192, 14);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new Size(118, 23);
            this.dateTimePickerFrom.TabIndex = 3;
            this.dateTimePickerFrom.Value = new DateTime(2025, 1, 1, 6, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(321, 18);
            this.label2.Name = "label2";
            this.label2.Size = new Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(148, 18);
            this.label1.Name = "label1";
            this.label1.Size = new Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // searchBox
            // 
            this.searchBox.Location = new Point(14, 14);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new Size(128, 23);
            this.searchBox.TabIndex = 0;
            // 
            // pohyby_bottom
            // 
            this.pohyby_bottom.BackColor = Color.FromArgb(40, 55, 74);
            this.pohyby_bottom.Controls.Add(this.showPaletButton);
            this.pohyby_bottom.Controls.Add(this.showInDashboard);
            this.pohyby_bottom.Controls.Add(this.label10);
            this.pohyby_bottom.Controls.Add(this.label9);
            this.pohyby_bottom.Controls.Add(this.label8);
            this.pohyby_bottom.Controls.Add(this.label7);
            this.pohyby_bottom.Controls.Add(this.idPohybu);
            this.pohyby_bottom.Controls.Add(this.label5);
            this.pohyby_bottom.Controls.Add(this.label4);
            this.pohyby_bottom.Controls.Add(this.label3);
            this.pohyby_bottom.Controls.Add(this.panel1);
            this.pohyby_bottom.Dock = DockStyle.Bottom;
            this.pohyby_bottom.Location = new Point(0, 399);
            this.pohyby_bottom.Name = "pohyby_bottom";
            this.pohyby_bottom.Size = new Size(601, 75);
            this.pohyby_bottom.TabIndex = 2;
            // 
            // showPaletButton
            // 
            this.showPaletButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.showPaletButton.BackColor = Color.FromArgb(46, 99, 142);
            this.showPaletButton.FlatAppearance.BorderColor = Color.FromArgb(46, 99, 142);
            this.showPaletButton.FlatStyle = FlatStyle.Flat;
            this.showPaletButton.ForeColor = Color.White;
            this.showPaletButton.Location = new Point(426, 13);
            this.showPaletButton.Name = "showPaletButton";
            this.showPaletButton.Size = new Size(155, 23);
            this.showPaletButton.TabIndex = 10;
            this.showPaletButton.Text = "PŘEJÍT NA PALETU";
            this.showPaletButton.UseVisualStyleBackColor = false;
            // 
            // showInDashboard
            // 
            this.showInDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.showInDashboard.BackColor = Color.FromArgb(68, 77, 84);
            this.showInDashboard.FlatAppearance.BorderColor = Color.FromArgb(68, 77, 84);
            this.showInDashboard.FlatStyle = FlatStyle.Flat;
            this.showInDashboard.ForeColor = Color.White;
            this.showInDashboard.Location = new Point(426, 41);
            this.showInDashboard.Name = "showInDashboard";
            this.showInDashboard.Size = new Size(155, 23);
            this.showInDashboard.TabIndex = 9;
            this.showInDashboard.Text = "ZOBRAZIT V DASHBOARD";
            this.showInDashboard.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Segoe UI", 11F);
            this.label10.ForeColor = Color.White;
            this.label10.Location = new Point(226, 54);
            this.label10.Name = "label10";
            this.label10.Size = new Size(114, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "#xxxxxx (obsah)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new Font("Segoe UI", 11F);
            this.label9.ForeColor = Color.White;
            this.label9.Location = new Point(178, 54);
            this.label9.Name = "label9";
            this.label9.Size = new Size(52, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Paleta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Segoe UI", 11F);
            this.label8.ForeColor = Color.White;
            this.label8.Location = new Point(135, 53);
            this.label8.Name = "label8";
            this.label8.Size = new Size(32, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "das";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Segoe UI", 11F);
            this.label7.ForeColor = Color.White;
            this.label7.Location = new Point(114, 33);
            this.label7.Name = "label7";
            this.label7.Size = new Size(52, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Přesun";
            // 
            // idPohybu
            // 
            this.idPohybu.AutoSize = true;
            this.idPohybu.Font = new Font("Segoe UI", 11F);
            this.idPohybu.ForeColor = Color.White;
            this.idPohybu.Location = new Point(251, 3);
            this.idPohybu.Name = "idPohybu";
            this.idPohybu.Size = new Size(78, 20);
            this.idPohybu.TabIndex = 4;
            this.idPohybu.Text = "(#Pxxxxxx)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Segoe UI", 11F);
            this.label5.ForeColor = Color.White;
            this.label5.Location = new Point(80, 50);
            this.label5.Name = "label5";
            this.label5.Size = new Size(49, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "fsdfds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Segoe UI", 11F);
            this.label4.ForeColor = Color.White;
            this.label4.Location = new Point(80, 33);
            this.label4.Name = "label4";
            this.label4.Size = new Size(35, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Typ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 11F);
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(80, 3);
            this.label3.Name = "label3";
            this.label3.Size = new Size(207, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "DETAIL VYBRANÉHO POHYBU";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = Properties.Resources.box_single;
            this.panel1.BackgroundImageLayout = ImageLayout.Zoom;
            this.panel1.Location = new Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(65, 65);
            this.panel1.TabIndex = 0;
            // 
            // spacerTop
            // 
            this.spacerTop.Dock = DockStyle.Top;
            this.spacerTop.Location = new Point(0, 50);
            this.spacerTop.Name = "spacerTop";
            this.spacerTop.Size = new Size(601, 15);
            this.spacerTop.TabIndex = 6;
            // 
            // spacerBottom
            // 
            this.spacerBottom.Dock = DockStyle.Bottom;
            this.spacerBottom.Location = new Point(0, 384);
            this.spacerBottom.Name = "spacerBottom";
            this.spacerBottom.Size = new Size(601, 15);
            this.spacerBottom.TabIndex = 7;
            // 
            // PohybyPanelControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.pohyby_center);
            this.Controls.Add(this.spacerBottom);
            this.Controls.Add(this.pohyby_bottom);
            this.Controls.Add(this.spacerTop);
            this.Controls.Add(this.pohyby_top);
            this.Name = "PohybyPanelControl";
            this.Size = new Size(601, 474);
            this.pohyby_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            this.pohyby_top.ResumeLayout(false);
            this.pohyby_top.PerformLayout();
            this.pohyby_bottom.ResumeLayout(false);
            this.pohyby_bottom.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pohyby_center;
        private Panel pohyby_top;
        private Panel pohyby_bottom;
        private Panel spacerTop;
        private Panel spacerBottom;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private Label label2;
        private Label label1;
        private TextBox searchBox;
        private Label label11;
        private DataGridView dataGridView1;
        private Button exportDataButton;
        private Button showInDashboard;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label idPohybu;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Button showPaletButton;
    }
}
