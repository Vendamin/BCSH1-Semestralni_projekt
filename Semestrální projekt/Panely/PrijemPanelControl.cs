namespace Semestrální_projekt
{
    public partial class PrijemPanelControl : UserControl
    {
        private SkladConfig _config;
        public PrijemPanelControl(SkladConfig config)
        {
            _config = config;
            InitializeComponent();
        }
    }
}
