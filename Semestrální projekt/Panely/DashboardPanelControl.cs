namespace Semestrální_projekt
{
    public partial class DashboardPanelControl : UserControl {
        private SkladConfig _config;
        public DashboardPanelControl(SkladConfig config) {
            _config = config;
            InitializeComponent();
        }
    }
}
