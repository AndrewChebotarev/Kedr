namespace Kedr
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            InitializeMainMenu initializeMainMenu = new(menuTableLayoutPanel);
        }
    }
}
