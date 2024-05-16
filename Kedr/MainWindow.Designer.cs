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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ExitButton = new Button();
            MenuTableLayoutPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // MenuTableLayoutPanel
            // 
            MenuTableLayoutPanel.ColumnCount = 3;
            MenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuTableLayoutPanel.Controls.Add(panel1, 0, 0);
            MenuTableLayoutPanel.Controls.Add(panel2, 1, 0);
            MenuTableLayoutPanel.Controls.Add(panel3, 2, 0);
            MenuTableLayoutPanel.Dock = DockStyle.Fill;
            MenuTableLayoutPanel.Location = new Point(0, 0);
            MenuTableLayoutPanel.Name = "MenuTableLayoutPanel";
            MenuTableLayoutPanel.RowCount = 1;
            MenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MenuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MenuTableLayoutPanel.Size = new Size(1182, 908);
            MenuTableLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.RocketImg;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 902);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.SolarSystemOrbitsImg;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(397, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 902);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.SpaceBookImg;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(ExitButton);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(791, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 902);
            panel3.TabIndex = 2;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.BackgroundImage = Properties.Resources.ExitButton;
            ExitButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExitButton.Location = new Point(317, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(62, 44);
            ExitButton.TabIndex = 0;
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
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MenuTableLayoutPanel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button ExitButton;
    }
}
