namespace Kedr
{
    partial class RocketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.BackColor = Color.White;
            ExitButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExitButton.Location = new Point(751, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(37, 30);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "✖";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // RocketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RocketForm";
            Text = "Путешествие 🚀";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            Icon = Properties.Resources.Icon;
        }

        #endregion

        private Button ExitButton;
    }
}