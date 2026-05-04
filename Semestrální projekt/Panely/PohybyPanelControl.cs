namespace Semestrální_projekt
{
    public partial class PohybyPanelControl : UserControl {
        private SkladConfig _config;
        public PohybyPanelControl(SkladConfig config) {
            _config = config;
            InitializeComponent();
        }
    }
}
