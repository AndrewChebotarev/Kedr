using System.Windows.Forms;

namespace Kedr.MainMenu
{
    public class MainPanelBehavior
    {
        public void SetPanelBlack(Panel panel, string text)
        {
            panel.BackgroundImage = Properties.Resources.BlackImg;
        }
        public void SetPanelRocket(Panel RocketPanel)
        {
            RocketPanel.BackgroundImage = Properties.Resources.RocketImg;
        }
        public void SetPanelSolarSystem(Panel SolarSystemPanel)
        {
            SolarSystemPanel.BackgroundImage = Properties.Resources.kandinsky_download_1716283402112;
        }
        public void SetPanelLibrarySpace(Panel LibrarySpace)
        {
            LibrarySpace.BackgroundImage = Properties.Resources.SpaceBookImg;
        }
        public void RocketPanel_MouseLeave(Panel RocketPanel)
        {
            RocketPanel.BackgroundImage = Properties.Resources.RocketImg;
        }
    }
}
