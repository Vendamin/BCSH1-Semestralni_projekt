namespace Semestrální_projekt;

partial class AboutBox1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
        this.tableLayoutPanel = new TableLayoutPanel();
        this.logoPictureBox = new PictureBox();
        this.labelProductName = new Label();
        this.labelVersion = new Label();
        this.labelCopyright = new Label();
        this.labelCompanyName = new Label();
        this.textBoxDescription = new TextBox();
        this.okButton = new Button();
        this.tableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.logoPictureBox).BeginInit();
        this.SuspendLayout();
        // 
        // tableLayoutPanel
        // 
        this.tableLayoutPanel.ColumnCount = 2;
        this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
        this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
        this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
        this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
        this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
        this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
        this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
        this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
        this.tableLayoutPanel.Dock = DockStyle.Fill;
        this.tableLayoutPanel.Location = new Point(10, 10);
        this.tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
        this.tableLayoutPanel.Name = "tableLayoutPanel";
        this.tableLayoutPanel.RowCount = 6;
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        this.tableLayoutPanel.Size = new Size(487, 307);
        this.tableLayoutPanel.TabIndex = 0;
        // 
        // logoPictureBox
        // 
        this.logoPictureBox.Dock = DockStyle.Fill;
        this.logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
        this.logoPictureBox.Location = new Point(4, 3);
        this.logoPictureBox.Margin = new Padding(4, 3, 4, 3);
        this.logoPictureBox.Name = "logoPictureBox";
        this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
        this.logoPictureBox.Size = new Size(152, 301);
        this.logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        this.logoPictureBox.TabIndex = 12;
        this.logoPictureBox.TabStop = false;
        // 
        // labelProductName
        // 
        this.labelProductName.Dock = DockStyle.Fill;
        this.labelProductName.Location = new Point(167, 0);
        this.labelProductName.Margin = new Padding(7, 0, 4, 0);
        this.labelProductName.MaximumSize = new Size(0, 20);
        this.labelProductName.Name = "labelProductName";
        this.labelProductName.Size = new Size(316, 20);
        this.labelProductName.TabIndex = 19;
        this.labelProductName.Text = "Product Name";
        this.labelProductName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelVersion
        // 
        this.labelVersion.Dock = DockStyle.Fill;
        this.labelVersion.Location = new Point(167, 30);
        this.labelVersion.Margin = new Padding(7, 0, 4, 0);
        this.labelVersion.MaximumSize = new Size(0, 20);
        this.labelVersion.Name = "labelVersion";
        this.labelVersion.Size = new Size(316, 20);
        this.labelVersion.TabIndex = 0;
        this.labelVersion.Text = "Version";
        this.labelVersion.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelCopyright
        // 
        this.labelCopyright.Dock = DockStyle.Fill;
        this.labelCopyright.Location = new Point(167, 60);
        this.labelCopyright.Margin = new Padding(7, 0, 4, 0);
        this.labelCopyright.MaximumSize = new Size(0, 20);
        this.labelCopyright.Name = "labelCopyright";
        this.labelCopyright.Size = new Size(316, 20);
        this.labelCopyright.TabIndex = 21;
        this.labelCopyright.Text = "Copyright";
        this.labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // labelCompanyName
        // 
        this.labelCompanyName.Dock = DockStyle.Fill;
        this.labelCompanyName.Location = new Point(167, 90);
        this.labelCompanyName.Margin = new Padding(7, 0, 4, 0);
        this.labelCompanyName.MaximumSize = new Size(0, 20);
        this.labelCompanyName.Name = "labelCompanyName";
        this.labelCompanyName.Size = new Size(316, 20);
        this.labelCompanyName.TabIndex = 22;
        this.labelCompanyName.Text = "Company Name";
        this.labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // textBoxDescription
        // 
        this.textBoxDescription.Dock = DockStyle.Fill;
        this.textBoxDescription.Location = new Point(167, 123);
        this.textBoxDescription.Margin = new Padding(7, 3, 4, 3);
        this.textBoxDescription.Multiline = true;
        this.textBoxDescription.Name = "textBoxDescription";
        this.textBoxDescription.ReadOnly = true;
        this.textBoxDescription.ScrollBars = ScrollBars.Both;
        this.textBoxDescription.Size = new Size(316, 147);
        this.textBoxDescription.TabIndex = 23;
        this.textBoxDescription.TabStop = false;
        this.textBoxDescription.Text = "Description";
        // 
        // okButton
        // 
        this.okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        this.okButton.DialogResult = DialogResult.Cancel;
        this.okButton.Location = new Point(395, 277);
        this.okButton.Margin = new Padding(4, 3, 4, 3);
        this.okButton.Name = "okButton";
        this.okButton.Size = new Size(88, 27);
        this.okButton.TabIndex = 24;
        this.okButton.Text = "&OK";
        // 
        // AboutBox1
        // 
        this.AcceptButton = this.okButton;
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(507, 327);
        this.Controls.Add(this.tableLayoutPanel);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.Margin = new Padding(4, 3, 4, 3);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "AboutBox1";
        this.Padding = new Padding(10);
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "AboutBox1";
        this.tableLayoutPanel.ResumeLayout(false);
        this.tableLayoutPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.logoPictureBox).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.PictureBox logoPictureBox;
    private System.Windows.Forms.Label labelProductName;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.Label labelCompanyName;
    private System.Windows.Forms.TextBox textBoxDescription;
    private System.Windows.Forms.Button okButton;
}
