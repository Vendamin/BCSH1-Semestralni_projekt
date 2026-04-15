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

        private void InitializeComponent()
        {
            this.prijem_center = new Panel();
            this.prijem_top = new Panel();
            this.label8 = new Label();
            this.prijem_bottom = new Panel();
            this.spacerTop = new Panel();
            this.spacerBottom = new Panel();
            this.prijem_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // prijem_center
            // 
            this.prijem_center.BackColor = Color.FromArgb(40, 55, 74);
            this.prijem_center.Dock = DockStyle.Fill;
            this.prijem_center.Location = new Point(0, 65);
            this.prijem_center.Name = "prijem_center";
            this.prijem_center.Size = new Size(601, 294);
            this.prijem_center.TabIndex = 5;
            // 
            // prijem_top
            // 
            this.prijem_top.BackColor = Color.FromArgb(40, 55, 74);
            this.prijem_top.Controls.Add(this.label8);
            this.prijem_top.Dock = DockStyle.Top;
            this.prijem_top.Location = new Point(0, 0);
            this.prijem_top.Name = "prijem_top";
            this.prijem_top.Size = new Size(601, 50);
            this.prijem_top.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Dock = DockStyle.Fill;
            this.label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            this.label8.ForeColor = Color.White;
            this.label8.Location = new Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new Size(601, 50);
            this.label8.TabIndex = 1;
            this.label8.Text = "PRIJEM SMAZAT";
            this.label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prijem_bottom
            // 
            this.prijem_bottom.BackColor = Color.FromArgb(40, 55, 74);
            this.prijem_bottom.Dock = DockStyle.Bottom;
            this.prijem_bottom.Location = new Point(0, 374);
            this.prijem_bottom.Name = "prijem_bottom";
            this.prijem_bottom.Size = new Size(601, 100);
            this.prijem_bottom.TabIndex = 2;
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
            this.spacerBottom.Location = new Point(0, 359);
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
            this.Controls.Add(this.spacerTop);
            this.Controls.Add(this.prijem_top);
            this.Name = "PrijemPanelControl";
            this.Size = new Size(601, 474);
            this.prijem_top.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel prijem_center;
        private Panel prijem_top;
        private Label label8;
        private Panel prijem_bottom;
        private Panel spacerTop;
        private Panel spacerBottom;
    }
}
