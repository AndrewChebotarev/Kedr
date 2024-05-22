namespace Kedr
{
    public partial class MenuForm : Form
    {
        MainPanelBehavior mainPanelBehavior = new();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void RocketButton_Click(object sender, EventArgs e)
        {
            RocketPanel rocketPanel = new();
        }
        private void ExitButton_Click(object sender, EventArgs e) 
        {
            ExitApplication exitApplication = new();
        }

        private void RocketPanel_MouseEnter(object sender, EventArgs e) => mainPanelBehavior.SetBlackPanelRocket(RocketPanel);
        private void RocketPanel_MouseLeave(object sender, EventArgs e) => mainPanelBehavior.SetDefaultPanelRocket(RocketPanel);
        private void SolarSystemPanel_MouseEnter(object sender, EventArgs e) => mainPanelBehavior.SetBlackPanelSolarSystem(SolarSystemPanel);
        private void SolarSystemPanel_MouseLeave(object sender, EventArgs e) => mainPanelBehavior.SetDefaultPanelSolarSystem(SolarSystemPanel);
        private void LibrarySpacePanel_MouseEnter(object sender, EventArgs e) => mainPanelBehavior.SetBlackPanelLibrarySpace(LibrarySpacePanel);
        private void LibrarySpacePanel_MouseLeave(object sender, EventArgs e) => mainPanelBehavior.SetDefaultPanelLibrarySpace(LibrarySpacePanel);
    }
}
