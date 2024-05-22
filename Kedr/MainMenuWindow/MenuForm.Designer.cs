namespace Kedr
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuTableLayoutPanel = new TableLayoutPanel();
            RocketPanel = new Panel();
            SolarSystemPanel = new Panel();
            LibrarySpacePanel = new Panel();
            ExitButton = new Button();
            MenuTableLayoutPanel.SuspendLayout();
            LibrarySpacePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuTableLayoutPanel
            // 
            MenuTableLayoutPanel.ColumnCount = 3;
            MenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuTableLayoutPanel.Controls.Add(RocketPanel, 0, 0);
            MenuTableLayoutPanel.Controls.Add(SolarSystemPanel, 1, 0);
            MenuTableLayoutPanel.Controls.Add(LibrarySpacePanel, 2, 0);
            MenuTableLayoutPanel.Dock = DockStyle.Fill;
            MenuTableLayoutPanel.Location = new Point(0, 0);
            MenuTableLayoutPanel.Name = "MenuTableLayoutPanel";
            MenuTableLayoutPanel.RowCount = 1;
            MenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MenuTableLayoutPanel.Size = new Size(1182, 908);
            MenuTableLayoutPanel.TabIndex = 0;
            // 
            // RocketPanel
            // 
            RocketPanel.BackgroundImage = Properties.Resources.RocketImg;
            RocketPanel.BackgroundImageLayout = ImageLayout.Stretch;
            RocketPanel.Dock = DockStyle.Fill;
            RocketPanel.Location = new Point(3, 3);
            RocketPanel.Name = "RocketPanel";
            RocketPanel.Size = new Size(388, 902);
            RocketPanel.TabIndex = 0;
            RocketPanel.Click += RocketButton_Click;
            RocketPanel.MouseEnter += RocketPanel_MouseEnter;
            RocketPanel.MouseLeave += RocketPanel_MouseLeave;
            // 
            // SolarSystemPanel
            // 
            SolarSystemPanel.BackgroundImage = Properties.Resources.SolarSystemImg;
            SolarSystemPanel.BackgroundImageLayout = ImageLayout.Zoom;
            SolarSystemPanel.Dock = DockStyle.Fill;
            SolarSystemPanel.Location = new Point(397, 3);
            SolarSystemPanel.Name = "SolarSystemPanel";
            SolarSystemPanel.Size = new Size(388, 902);
            SolarSystemPanel.TabIndex = 1;
            SolarSystemPanel.MouseEnter += SolarSystemPanel_MouseEnter;
            SolarSystemPanel.MouseLeave += SolarSystemPanel_MouseLeave;
            // 
            // LibrarySpacePanel
            // 
            LibrarySpacePanel.BackColor = Color.Black;
            LibrarySpacePanel.BackgroundImage = Properties.Resources.SpaceBookImg;
            LibrarySpacePanel.BackgroundImageLayout = ImageLayout.Stretch;
            LibrarySpacePanel.Controls.Add(ExitButton);
            LibrarySpacePanel.Dock = DockStyle.Fill;
            LibrarySpacePanel.Location = new Point(791, 3);
            LibrarySpacePanel.Name = "LibrarySpacePanel";
            LibrarySpacePanel.Size = new Size(388, 902);
            LibrarySpacePanel.TabIndex = 2;
            LibrarySpacePanel.MouseEnter += LibrarySpacePanel_MouseEnter;
            LibrarySpacePanel.MouseLeave += LibrarySpacePanel_MouseLeave;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.BackColor = Color.White;
            ExitButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExitButton.Location = new Point(342, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(37, 30);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "✖";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1182, 908);
            Controls.Add(MenuTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainWindow";
            Text = "Кедр";
            WindowState = FormWindowState.Maximized;
            MenuTableLayoutPanel.ResumeLayout(false);
            LibrarySpacePanel.ResumeLayout(false);
            ResumeLayout(false);
            Icon = Properties.Resources.Icon;
        }

        #endregion

        private TableLayoutPanel MenuTableLayoutPanel;
        private Panel RocketPanel;
        private Panel SolarSystemPanel;
        private Panel LibrarySpacePanel;
        private Button ExitButton;
    }
}
