namespace Kedr.MainMenuWindow
{
    public class MainPanelBehavior
    {
        public void SetBlackPanelRocket(Panel RocketPanel)
        {
            RocketPanel.BackgroundImage = Properties.Resources.BlackRocketImg;
        }
        public void SetBlackPanelSolarSystem(Panel SolarSystemPanel)
        {
            SolarSystemPanel.BackgroundImage = Properties.Resources.BlackSolarSystemImg;
        }
        public void SetBlackPanelLibrarySpace(Panel LibrarySpacePanel)
        {
            LibrarySpacePanel.BackgroundImage = Properties.Resources.BlackLibraryBookImg;
        }
        public void SetDefaultPanelRocket(Panel RocketPanel)
        {
            RocketPanel.BackgroundImage = Properties.Resources.RocketImg;
        }
        public void SetDefaultPanelSolarSystem(Panel SolarSystemPanel)
        {
            SolarSystemPanel.BackgroundImage = Properties.Resources.SolarSystemImg;
        }
        public void SetDefaultPanelLibrarySpace(Panel LibrarySpacePanel)
        {
            LibrarySpacePanel.BackgroundImage = Properties.Resources.SpaceBookImg;
        }
    }
}
