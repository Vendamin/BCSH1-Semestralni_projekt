namespace Semestrální_projekt
{
    public partial class NastaveniPanelControl : UserControl
    {
        private OpenFileDialog? openFileDialog;

        public NastaveniPanelControl()
        {
            InitializeComponent();
        }

        public void SetOpenFileDialog(OpenFileDialog dialog) 
        {
            openFileDialog = dialog;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog?.ShowDialog() == DialogResult.OK)
            {
                cestaDb.Text = openFileDialog.FileName;
            }
        }
    }
}
