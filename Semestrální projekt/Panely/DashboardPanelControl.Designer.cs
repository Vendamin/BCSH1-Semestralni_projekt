namespace Semestrální_projekt
{
    partial class DashboardPanelControl
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
            this.dashboard_bottom = new Panel();
            this.dashboard_top = new Panel();
            this.label7 = new Label();
            this.dashboard_center = new Panel();
            this.spacerTop = new Panel();
            this.spacerBottom = new Panel();
            this.dashboard_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboard_bottom
            // 
            this.dashboard_bottom.BackColor = Color.FromArgb(40, 55, 74);
            this.dashboard_bottom.Dock = DockStyle.Bottom;
            this.dashboard_bottom.Location = new Point(0, 374);
            this.dashboard_bottom.Name = "dashboard_bottom";
            this.dashboard_bottom.Size = new Size(601, 100);
            this.dashboard_bottom.TabIndex = 1;
            // 
            // dashboard_top
            // 
            this.dashboard_top.BackColor = Color.FromArgb(40, 55, 74);
            this.dashboard_top.Controls.Add(this.label7);
            this.dashboard_top.Dock = DockStyle.Top;
            this.dashboard_top.Location = new Point(0, 0);
            this.dashboard_top.Name = "dashboard_top";
            this.dashboard_top.Size = new Size(601, 50);
            this.dashboard_top.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = DockStyle.Fill;
            this.label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            this.label7.ForeColor = Color.White;
            this.label7.Location = new Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(601, 50);
            this.label7.TabIndex = 1;
            this.label7.Text = "DASHBOARD smazat";
            this.label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashboard_center
            // 
            this.dashboard_center.BackColor = Color.FromArgb(40, 55, 74);
            this.dashboard_center.Dock = DockStyle.Fill;
            this.dashboard_center.Location = new Point(0, 65);
            this.dashboard_center.Name = "dashboard_center";
            this.dashboard_center.Size = new Size(601, 294);
            this.dashboard_center.TabIndex = 2;
            // 
            // spacerTop
            // 
            this.spacerTop.Dock = DockStyle.Top;
            this.spacerTop.Location = new Point(0, 50);
            this.spacerTop.Name = "spacerTop";
            this.spacerTop.Size = new Size(601, 15);
            this.spacerTop.TabIndex = 3;
            // 
            // spacerBottom
            // 
            this.spacerBottom.Dock = DockStyle.Bottom;
            this.spacerBottom.Location = new Point(0, 359);
            this.spacerBottom.Name = "spacerBottom";
            this.spacerBottom.Size = new Size(601, 15);
            this.spacerBottom.TabIndex = 4;
            // 
            // DashboardPanelControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.dashboard_center);
            this.Controls.Add(this.spacerBottom);
            this.Controls.Add(this.dashboard_bottom);
            this.Controls.Add(this.spacerTop);
            this.Controls.Add(this.dashboard_top);
            this.Name = "DashboardPanelControl";
            this.Size = new Size(601, 474);
            this.dashboard_top.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel dashboard_bottom;
        private Panel dashboard_top;
        private Label label7;
        private Panel dashboard_center;
        private Panel spacerTop;
        private Panel spacerBottom;
    }
}
