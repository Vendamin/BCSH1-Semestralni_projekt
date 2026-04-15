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

        private void InitializeComponent()
        {
            this.palety_center = new Panel();
            this.palety_top = new Panel();
            this.label10 = new Label();
            this.palety_bottom = new Panel();
            this.spacerTop = new Panel();
            this.spacerBottom = new Panel();
            this.palety_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // palety_center
            // 
            this.palety_center.BackColor = Color.FromArgb(40, 55, 74);
            this.palety_center.Dock = DockStyle.Fill;
            this.palety_center.Location = new Point(0, 65);
            this.palety_center.Name = "palety_center";
            this.palety_center.Size = new Size(601, 294);
            this.palety_center.TabIndex = 6;
            // 
            // palety_top
            // 
            this.palety_top.BackColor = Color.FromArgb(40, 55, 74);
            this.palety_top.Controls.Add(this.label10);
            this.palety_top.Dock = DockStyle.Top;
            this.palety_top.Location = new Point(0, 0);
            this.palety_top.Name = "palety_top";
            this.palety_top.Size = new Size(601, 50);
            this.palety_top.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Dock = DockStyle.Fill;
            this.label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            this.label10.ForeColor = Color.White;
            this.label10.Location = new Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new Size(601, 50);
            this.label10.TabIndex = 1;
            this.label10.Text = "Palety SMAZAT";
            this.label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // palety_bottom
            // 
            this.palety_bottom.BackColor = Color.FromArgb(40, 55, 74);
            this.palety_bottom.Dock = DockStyle.Bottom;
            this.palety_bottom.Location = new Point(0, 374);
            this.palety_bottom.Name = "palety_bottom";
            this.palety_bottom.Size = new Size(601, 100);
            this.palety_bottom.TabIndex = 2;
            // 
            // spacerTop
            // 
            this.spacerTop.Dock = DockStyle.Top;
            this.spacerTop.Location = new Point(0, 50);
            this.spacerTop.Name = "spacerTop";
            this.spacerTop.Size = new Size(601, 15);
            this.spacerTop.TabIndex = 7;
            // 
            // spacerBottom
            // 
            this.spacerBottom.Dock = DockStyle.Bottom;
            this.spacerBottom.Location = new Point(0, 359);
            this.spacerBottom.Name = "spacerBottom";
            this.spacerBottom.Size = new Size(601, 15);
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
            this.Size = new Size(601, 474);
            this.palety_top.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel palety_center;
        private Panel palety_top;
        private Label label10;
        private Panel palety_bottom;
        private Panel spacerTop;
        private Panel spacerBottom;
    }
}
