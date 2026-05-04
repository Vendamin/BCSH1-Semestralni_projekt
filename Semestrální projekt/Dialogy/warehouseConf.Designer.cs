namespace Semestrální_projekt;

partial class WarehouseConf {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.panel1 = new Panel();
        this.pocetPozic = new Label();
        this.saveButton = new Button();
        this.cancelButton = new Button();
        this.panel2 = new Panel();
        this.panel3 = new Panel();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.label1 = new Label();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.label3 = new Label();
        this.rady = new TextBox();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.label4 = new Label();
        this.pocetSloupcu = new NumericUpDown();
        this.label5 = new Label();
        this.pocetPater = new NumericUpDown();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.addNewButton = new Button();
        this.label2 = new Label();
        this.dataGridView1 = new DataGridView();
        this.id = new DataGridViewTextBoxColumn();
        this.rada = new DataGridViewTextBoxColumn();
        this.sloupec = new DataGridViewTextBoxColumn();
        this.patro = new DataGridViewTextBoxColumn();
        this.akce = new DataGridViewButtonColumn();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.pocetSloupcu).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.pocetPater).BeginInit();
        this.flowLayoutPanel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.panel1.BackColor = Color.FromArgb(40, 55, 74);
        this.panel1.Controls.Add(this.pocetPozic);
        this.panel1.Controls.Add(this.saveButton);
        this.panel1.Controls.Add(this.cancelButton);
        this.panel1.Location = new Point(15, 431);
        this.panel1.Margin = new Padding(0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(533, 75);
        this.panel1.TabIndex = 0;
        // 
        // pocetPozic
        // 
        this.pocetPozic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        this.pocetPozic.Font = new Font("Segoe UI", 13F);
        this.pocetPozic.ForeColor = Color.White;
        this.pocetPozic.Location = new Point(0, 12);
        this.pocetPozic.Name = "pocetPozic";
        this.pocetPozic.Size = new Size(371, 53);
        this.pocetPozic.TabIndex = 2;
        this.pocetPozic.Text = "pocetPozic";
        this.pocetPozic.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // saveButton
        // 
        this.saveButton.BackColor = Color.FromArgb(46, 99, 142);
        this.saveButton.FlatAppearance.BorderColor = Color.FromArgb(46, 99, 142);
        this.saveButton.FlatStyle = FlatStyle.Flat;
        this.saveButton.Font = new Font("Segoe UI", 11F);
        this.saveButton.ForeColor = Color.White;
        this.saveButton.Location = new Point(377, 32);
        this.saveButton.Name = "saveButton";
        this.saveButton.Size = new Size(65, 33);
        this.saveButton.TabIndex = 1;
        this.saveButton.Text = "Uložit";
        this.saveButton.UseVisualStyleBackColor = false;
        this.saveButton.Click += this.saveButton_Click;
        // 
        // cancelButton
        // 
        this.cancelButton.BackColor = Color.FromArgb(68, 77, 84);
        this.cancelButton.FlatAppearance.BorderColor = Color.FromArgb(68, 77, 84);
        this.cancelButton.FlatStyle = FlatStyle.Flat;
        this.cancelButton.Font = new Font("Segoe UI", 11F);
        this.cancelButton.ForeColor = Color.White;
        this.cancelButton.Location = new Point(455, 32);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(75, 33);
        this.cancelButton.TabIndex = 0;
        this.cancelButton.Text = "Zrušit";
        this.cancelButton.UseVisualStyleBackColor = false;
        this.cancelButton.Click += this.cancelButton_Click;
        // 
        // panel2
        // 
        this.panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.panel2.BackColor = Color.FromArgb(40, 55, 74);
        this.panel2.Controls.Add(this.panel3);
        this.panel2.Controls.Add(this.flowLayoutPanel1);
        this.panel2.Location = new Point(15, 15);
        this.panel2.Margin = new Padding(0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(533, 406);
        this.panel2.TabIndex = 1;
        // 
        // panel3
        // 
        this.panel3.BackgroundImage = Properties.Resources.gears_white;
        this.panel3.BackgroundImageLayout = ImageLayout.Zoom;
        this.panel3.Location = new Point(19, 19);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(76, 76);
        this.panel3.TabIndex = 1;
        // 
        // flowLayoutPanel1
        // 
        this.flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.flowLayoutPanel1.Controls.Add(this.label1);
        this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
        this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
        this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
        this.flowLayoutPanel1.Controls.Add(this.label2);
        this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
        this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel1.Location = new Point(114, 0);
        this.flowLayoutPanel1.Margin = new Padding(0);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Padding = new Padding(5, 5, 5, 0);
        this.flowLayoutPanel1.Size = new Size(419, 406);
        this.flowLayoutPanel1.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.label1.ForeColor = Color.White;
        this.label1.Location = new Point(5, 5);
        this.label1.Margin = new Padding(0, 0, 0, 5);
        this.label1.Name = "label1";
        this.label1.Size = new Size(241, 25);
        this.label1.TabIndex = 0;
        this.label1.Text = "Konfigurace Řad a Regálů";
        // 
        // flowLayoutPanel2
        // 
        this.flowLayoutPanel2.Controls.Add(this.label3);
        this.flowLayoutPanel2.Controls.Add(this.rady);
        this.flowLayoutPanel2.Location = new Point(5, 35);
        this.flowLayoutPanel2.Margin = new Padding(0, 0, 15, 5);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(413, 30);
        this.flowLayoutPanel2.TabIndex = 1;
        // 
        // label3
        // 
        this.label3.Font = new Font("Segoe UI", 11F);
        this.label3.ForeColor = Color.White;
        this.label3.Location = new Point(3, 0);
        this.label3.Name = "label3";
        this.label3.Size = new Size(220, 33);
        this.label3.TabIndex = 0;
        this.label3.Text = "Řada/Rozsah (např. A, B, C-F):";
        this.label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // rady
        // 
        this.rady.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        this.rady.Font = new Font("Segoe UI", 11F);
        this.rady.Location = new Point(229, 3);
        this.rady.Name = "rady";
        this.rady.Size = new Size(171, 27);
        this.rady.TabIndex = 1;
        // 
        // flowLayoutPanel3
        // 
        this.flowLayoutPanel3.Controls.Add(this.label4);
        this.flowLayoutPanel3.Controls.Add(this.pocetSloupcu);
        this.flowLayoutPanel3.Controls.Add(this.label5);
        this.flowLayoutPanel3.Controls.Add(this.pocetPater);
        this.flowLayoutPanel3.Location = new Point(5, 70);
        this.flowLayoutPanel3.Margin = new Padding(0, 0, 15, 5);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(413, 33);
        this.flowLayoutPanel3.TabIndex = 2;
        // 
        // label4
        // 
        this.label4.Font = new Font("Segoe UI", 11F);
        this.label4.ForeColor = Color.White;
        this.label4.Location = new Point(3, 0);
        this.label4.Name = "label4";
        this.label4.Size = new Size(141, 33);
        this.label4.TabIndex = 0;
        this.label4.Text = "Počet Sloupců:";
        this.label4.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pocetSloupcu
        // 
        this.pocetSloupcu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        this.pocetSloupcu.Font = new Font("Segoe UI", 11F);
        this.pocetSloupcu.Location = new Point(150, 3);
        this.pocetSloupcu.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        this.pocetSloupcu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.pocetSloupcu.Name = "pocetSloupcu";
        this.pocetSloupcu.Size = new Size(54, 27);
        this.pocetSloupcu.TabIndex = 1;
        this.pocetSloupcu.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label5
        // 
        this.label5.Font = new Font("Segoe UI", 11F);
        this.label5.ForeColor = Color.White;
        this.label5.Location = new Point(210, 0);
        this.label5.Margin = new Padding(3, 0, 35, 0);
        this.label5.Name = "label5";
        this.label5.Size = new Size(100, 33);
        this.label5.TabIndex = 2;
        this.label5.Text = "Počet Pater:";
        this.label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pocetPater
        // 
        this.pocetPater.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        this.pocetPater.Font = new Font("Segoe UI", 11F);
        this.pocetPater.Location = new Point(348, 3);
        this.pocetPater.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        this.pocetPater.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.pocetPater.Name = "pocetPater";
        this.pocetPater.Size = new Size(52, 27);
        this.pocetPater.TabIndex = 3;
        this.pocetPater.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // flowLayoutPanel4
        // 
        this.flowLayoutPanel4.Controls.Add(this.addNewButton);
        this.flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
        this.flowLayoutPanel4.Location = new Point(5, 108);
        this.flowLayoutPanel4.Margin = new Padding(0, 0, 0, 5);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(413, 33);
        this.flowLayoutPanel4.TabIndex = 6;
        // 
        // addNewButton
        // 
        this.addNewButton.BackColor = Color.FromArgb(46, 99, 142);
        this.addNewButton.BackgroundImageLayout = ImageLayout.None;
        this.addNewButton.FlatAppearance.BorderColor = Color.FromArgb(46, 99, 142);
        this.addNewButton.FlatStyle = FlatStyle.Flat;
        this.addNewButton.Font = new Font("Segoe UI", 9F);
        this.addNewButton.ForeColor = Color.White;
        this.addNewButton.Location = new Point(207, 0);
        this.addNewButton.Margin = new Padding(0, 0, 15, 0);
        this.addNewButton.Name = "addNewButton";
        this.addNewButton.Size = new Size(191, 33);
        this.addNewButton.TabIndex = 3;
        this.addNewButton.Text = "PŘIDAT NOVOU KONFIGURACI";
        this.addNewButton.UseVisualStyleBackColor = false;
        this.addNewButton.Click += this.addNewButton_Click;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new Font("Segoe UI", 11F);
        this.label2.ForeColor = Color.White;
        this.label2.Location = new Point(5, 146);
        this.label2.Margin = new Padding(0, 0, 0, 5);
        this.label2.Name = "label2";
        this.label2.Size = new Size(159, 20);
        this.label2.TabIndex = 4;
        this.label2.Text = "Definice Řad a Regálů:";
        // 
        // dataGridView1
        // 
        this.dataGridView1.AllowUserToAddRows = false;
        this.dataGridView1.AllowUserToResizeColumns = false;
        this.dataGridView1.AllowUserToResizeRows = false;
        this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.id, this.rada, this.sloupec, this.patro, this.akce });
        this.dataGridView1.Location = new Point(5, 171);
        this.dataGridView1.Margin = new Padding(0);
        this.dataGridView1.MultiSelect = false;
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.RowHeadersVisible = false;
        this.dataGridView1.RowTemplate.ReadOnly = true;
        this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView1.Size = new Size(398, 230);
        this.dataGridView1.TabIndex = 5;
        this.dataGridView1.CellContentClick += this.odebratZaznamButton_Click;
        this.dataGridView1.RowsRemoved += this.dataGridView1_UserDeletingRow;
        this.dataGridView1.UserDeletedRow += this.dataGridView1_UserDeletingRow;
        this.dataGridView1.UserDeletingRow += this.dataGridView1_UserDeletingRow;
        // 
        // id
        // 
        this.id.DataPropertyName = "Id";
        this.id.HeaderText = "id";
        this.id.Name = "id";
        this.id.ReadOnly = true;
        this.id.Visible = false;
        // 
        // rada
        // 
        this.rada.DataPropertyName = "Rada";
        this.rada.FillWeight = 50F;
        this.rada.HeaderText = "Řada";
        this.rada.Name = "rada";
        this.rada.ReadOnly = true;
        // 
        // sloupec
        // 
        this.sloupec.DataPropertyName = "PocetSloupcu";
        this.sloupec.FillWeight = 50F;
        this.sloupec.HeaderText = "Počet Sloupců";
        this.sloupec.Name = "sloupec";
        this.sloupec.ReadOnly = true;
        // 
        // patro
        // 
        this.patro.DataPropertyName = "PocetPater";
        this.patro.FillWeight = 50F;
        this.patro.HeaderText = "Počet Pater";
        this.patro.Name = "patro";
        this.patro.ReadOnly = true;
        // 
        // akce
        // 
        this.akce.FillWeight = 35F;
        this.akce.HeaderText = "Akce";
        this.akce.Name = "akce";
        this.akce.ReadOnly = true;
        this.akce.Text = "Smazat";
        this.akce.UseColumnTextForButtonValue = true;
        // 
        // warehouseConf
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(23, 34, 52);
        this.ClientSize = new Size(563, 521);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "warehouseConf";
        this.Padding = new Padding(15);
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Konfigurace Řad a Regálů";
        this.panel1.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel2.PerformLayout();
        this.flowLayoutPanel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.pocetSloupcu).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.pocetPater).EndInit();
        this.flowLayoutPanel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private FlowLayoutPanel flowLayoutPanel1;
    private Panel panel3;
    private Label label1;
    private FlowLayoutPanel flowLayoutPanel2;
    private FlowLayoutPanel flowLayoutPanel3;
    private Button saveButton;
    private Label label2;
    private DataGridView dataGridView1;
    private Label label3;
    private TextBox rady;
    private Label label4;
    private NumericUpDown pocetSloupcu;
    private Label label5;
    private NumericUpDown pocetPater;
    private FlowLayoutPanel flowLayoutPanel4;
    private Label pocetPozic;
    private Button addNewButton;
    private Button cancelButton;
    private DataGridViewTextBoxColumn id;
    private DataGridViewTextBoxColumn rada;
    private DataGridViewTextBoxColumn sloupec;
    private DataGridViewTextBoxColumn patro;
    private DataGridViewButtonColumn akce;
}