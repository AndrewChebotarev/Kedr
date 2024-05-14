using System.Windows.Forms;

namespace Kedr.MainMenu
{
    public class InitializeMainMenu
    {
        public InitializeMainMenu(TableLayoutPanel menuTableLayoutPanel) 
        {
            CreatePanels(menuTableLayoutPanel);
        }
        private void CreatePanels(TableLayoutPanel menuTableLayoutPanel)
        {
            CreateFirstPanels(menuTableLayoutPanel);
            CreateSecondPanels(menuTableLayoutPanel);
            CreateThirdPanels(menuTableLayoutPanel);
        }

        private void CreateFirstPanels(TableLayoutPanel menuTableLayoutPanel)
        {
            Panel panel = new Panel
            {
                BackgroundImage = Properties.Resources.RocketImg,
                Dock = DockStyle.Fill,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            menuTableLayoutPanel.Controls.Add(panel, 0, 0);
        }

        private void CreateSecondPanels(TableLayoutPanel menuTableLayoutPanel)
        {
            Panel panel = new Panel
            {
                BackgroundImage = Properties.Resources.SolarSystemOrbitsImg,
                Dock = DockStyle.Fill,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            menuTableLayoutPanel.Controls.Add(panel, 1, 0);
        }

        private void CreateThirdPanels(TableLayoutPanel menuTableLayoutPanel)
        {
            Panel panel = new Panel
            {
                BackgroundImage = Properties.Resources.SpaceBookImg,
                Dock = DockStyle.Fill,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            menuTableLayoutPanel.Controls.Add(panel, 2, 0);
        }
    }
}
