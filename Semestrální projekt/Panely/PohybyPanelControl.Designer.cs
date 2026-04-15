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

        private void InitializeComponent()
        {
            this.pohyby_center = new Panel();
            this.pohyby_top = new Panel();
            this.label9 = new Label();
            this.pohyby_bottom = new Panel();
            this.spacerTop = new Panel();
            this.spacerBottom = new Panel();
            this.pohyby_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pohyby_center
            // 
            this.pohyby_center.BackColor = Color.FromArgb(40, 55, 74);
            this.pohyby_center.Dock = DockStyle.Fill;
            this.pohyby_center.Location = new Point(0, 65);
            this.pohyby_center.Name = "pohyby_center";
            this.pohyby_center.Size = new Size(601, 294);
            this.pohyby_center.TabIndex = 5;
            // 
            // pohyby_top
            // 
            this.pohyby_top.BackColor = Color.FromArgb(40, 55, 74);
            this.pohyby_top.Controls.Add(this.label9);
            this.pohyby_top.Dock = DockStyle.Top;
            this.pohyby_top.Location = new Point(0, 0);
            this.pohyby_top.Name = "pohyby_top";
            this.pohyby_top.Size = new Size(601, 50);
            this.pohyby_top.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Dock = DockStyle.Fill;
            this.label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            this.label9.ForeColor = Color.White;
            this.label9.Location = new Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new Size(601, 50);
            this.label9.TabIndex = 1;
            this.label9.Text = "POHYBY SMAZAT";
            this.label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pohyby_bottom
            // 
            this.pohyby_bottom.BackColor = Color.FromArgb(40, 55, 74);
            this.pohyby_bottom.Dock = DockStyle.Bottom;
            this.pohyby_bottom.Location = new Point(0, 374);
            this.pohyby_bottom.Name = "pohyby_bottom";
            this.pohyby_bottom.Size = new Size(601, 100);
            this.pohyby_bottom.TabIndex = 2;
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
            this.pohyby_top.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pohyby_center;
        private Panel pohyby_top;
        private Label label9;
        private Panel pohyby_bottom;
        private Panel spacerTop;
        private Panel spacerBottom;
    }
}
