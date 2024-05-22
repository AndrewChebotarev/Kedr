using Kedr.RocketWindow;

namespace Kedr
{
    public partial class RocketForm : Form
    {
        public RocketForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            RocketWindowExitButton RocketWindowExitButton = new RocketWindowExitButton(this);
        }
    }
}
