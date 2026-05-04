namespace Semestrální_projekt
{
    partial class AddPalet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.button1 = new Button();
            this.button2 = new Button();
            this.Content = new TextBox();
            this.Count = new NumericUpDown();
            this.Weight = new NumericUpDown();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)this.Count).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.Weight).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button1.DialogResult = DialogResult.OK;
            this.button1.Location = new Point(271, 7);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.addButton_Click;
            // 
            // button2
            // 
            this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.button2.DialogResult = DialogResult.Cancel;
            this.button2.Location = new Point(190, 7);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Content
            // 
            this.Content.Dock = DockStyle.Fill;
            this.Content.Location = new Point(177, 3);
            this.Content.Name = "Content";
            this.Content.Size = new Size(169, 23);
            this.Content.TabIndex = 3;
            // 
            // Count
            // 
            this.Count.Dock = DockStyle.Fill;
            this.Count.Location = new Point(177, 40);
            this.Count.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.Count.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.Count.Name = "Count";
            this.Count.Size = new Size(169, 23);
            this.Count.TabIndex = 4;
            this.Count.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Weight
            // 
            this.Weight.DecimalPlaces = 2;
            this.Weight.Dock = DockStyle.Fill;
            this.Weight.Location = new Point(177, 77);
            this.Weight.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.Weight.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            this.Weight.Name = "Weight";
            this.Weight.Size = new Size(169, 23);
            this.Weight.TabIndex = 5;
            this.Weight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Content, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Count, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Weight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            this.tableLayoutPanel1.Size = new Size(349, 113);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = DockStyle.Fill;
            this.label1.Font = new Font("Segoe UI", 11F);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(168, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Obsah:";
            this.label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = DockStyle.Fill;
            this.label2.Font = new Font("Segoe UI", 11F);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new Size(168, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Počet (boxů):";
            this.label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = DockStyle.Fill;
            this.label3.Font = new Font("Segoe UI", 11F);
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new Size(168, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Celková hmotnost (kg):";
            this.label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(15, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(349, 36);
            this.panel1.TabIndex = 7;
            // 
            // AddPalet
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(23, 34, 52);
            this.CancelButton = this.button2;
            this.ClientSize = new Size(379, 179);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPalet";
            this.Padding = new Padding(15);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Přidání palet";
            ((System.ComponentModel.ISupportInitialize)this.Count).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.Weight).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox Content;
        private NumericUpDown Count;
        private NumericUpDown Weight;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}