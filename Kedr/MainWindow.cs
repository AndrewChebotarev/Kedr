namespace Kedr
{
    public partial class MainWindow : Form
    {
        MainPanelBehavior mainPanelBehavior = new();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButton exitButton = new();
        }
        private void RocketPanel_MouseEnter(object sender, EventArgs e) => mainPanelBehavior.SetPanelBlack(RocketPanel, "Путешествие по солнечной системе 🚀");
        private void RocketPanel_MouseLeave(object sender, EventArgs e) => mainPanelBehavior.SetPanelRocket(RocketPanel);
        private void SolarSystemPanel_MouseEnter(object sender, EventArgs e) => mainPanelBehavior.SetPanelBlack(SolarSystemPanel, "Симуляция движений планет ➰");
        private void SolarSystemPanel_MouseLeave(object sender, EventArgs e) => mainPanelBehavior.SetPanelSolarSystem(SolarSystemPanel);
        private void LibrarySpacePanel_MouseEnter(object sender, EventArgs e) => mainPanelBehavior.SetPanelBlack(LibrarySpace, "Справочник по космосу 🔰");
        private void LibrarySpacePanel_MouseLeave(object sender, EventArgs e) => mainPanelBehavior.SetPanelLibrarySpace(LibrarySpace);
    }
}
