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
            menuTableLayoutPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // menuTableLayoutPanel
            // 
            menuTableLayoutPanel.ColumnCount = 3;
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            menuTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            menuTableLayoutPanel.Dock = DockStyle.Fill;
            menuTableLayoutPanel.Location = new Point(0, 0);
            menuTableLayoutPanel.Name = "menuTableLayoutPanel";
            menuTableLayoutPanel.RowCount = 1;
            menuTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            menuTableLayoutPanel.Size = new Size(1182, 908);
            menuTableLayoutPanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1182, 908);
            Controls.Add(menuTableLayoutPanel);
            Name = "MainWindow";
            Text = "Кедр";
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel menuTableLayoutPanel;
    }
}
