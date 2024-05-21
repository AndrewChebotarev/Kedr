namespace Kedr
{
    partial class MainWindow
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
            button1 = new Button();
            label1 = new Label();
            SolarSystemPanel = new Panel();
            LibrarySpace = new Panel();
            ExitButton = new Button();
            MenuTableLayoutPanel.SuspendLayout();
            RocketPanel.SuspendLayout();
            SolarSystemPanel.SuspendLayout();
            LibrarySpace.SuspendLayout();
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
            MenuTableLayoutPanel.Controls.Add(LibrarySpace, 2, 0);
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
            RocketPanel.Controls.Add(button1);
            RocketPanel.Dock = DockStyle.Fill;
            RocketPanel.Location = new Point(3, 3);
            RocketPanel.Name = "RocketPanel";
            RocketPanel.Size = new Size(388, 902);
            RocketPanel.TabIndex = 0;
            RocketPanel.MouseEnter += RocketPanel_MouseEnter;
            RocketPanel.MouseLeave += RocketPanel_MouseLeave;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(125, 470);
            button1.Name = "button1";
            button1.Size = new Size(119, 41);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(-397, 358);
            label1.Name = "label1";
            label1.Size = new Size(729, 54);
            label1.TabIndex = 0;
            label1.Text = "Путишествие по солнченой системе";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SolarSystemPanel
            // 
            SolarSystemPanel.BackgroundImage = Properties.Resources.kandinsky_download_1716283402112;
            SolarSystemPanel.BackgroundImageLayout = ImageLayout.Zoom;
            SolarSystemPanel.Controls.Add(label1);
            SolarSystemPanel.Dock = DockStyle.Fill;
            SolarSystemPanel.Location = new Point(397, 3);
            SolarSystemPanel.Name = "SolarSystemPanel";
            SolarSystemPanel.Size = new Size(388, 902);
            SolarSystemPanel.TabIndex = 1;
            SolarSystemPanel.MouseEnter += SolarSystemPanel_MouseEnter;
            SolarSystemPanel.MouseLeave += SolarSystemPanel_MouseLeave;
            // 
            // LibrarySpace
            // 
            LibrarySpace.BackColor = Color.Black;
            LibrarySpace.BackgroundImage = Properties.Resources.SpaceBookImg;
            LibrarySpace.BackgroundImageLayout = ImageLayout.Stretch;
            LibrarySpace.Controls.Add(ExitButton);
            LibrarySpace.Dock = DockStyle.Fill;
            LibrarySpace.Location = new Point(791, 3);
            LibrarySpace.Name = "LibrarySpace";
            LibrarySpace.Size = new Size(388, 902);
            LibrarySpace.TabIndex = 2;
            LibrarySpace.MouseEnter += LibrarySpacePanel_MouseEnter;
            LibrarySpace.MouseLeave += LibrarySpacePanel_MouseLeave;
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
            RocketPanel.ResumeLayout(false);
            SolarSystemPanel.ResumeLayout(false);
            SolarSystemPanel.PerformLayout();
            LibrarySpace.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MenuTableLayoutPanel;
        private Panel RocketPanel;
        private Panel SolarSystemPanel;
        private Panel LibrarySpace;
        private Button ExitButton;
        private Button button1;
        private Label label1;
    }
}
