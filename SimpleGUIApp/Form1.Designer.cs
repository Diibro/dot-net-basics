namespace SimpleGUIApp
{
    partial class Form1
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
            screenValue = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // screenValue
            // 
            screenValue.AutoSize = true;
            screenValue.BackColor = SystemColors.InactiveBorder;
            screenValue.Location = new Point(12, 239);
            screenValue.MinimumSize = new Size(720, 50);
            screenValue.Name = "screenValue";
            screenValue.Padding = new Padding(10);
            screenValue.RightToLeft = RightToLeft.Yes;
            screenValue.Size = new Size(720, 50);
            screenValue.TabIndex = 0;
            screenValue.Text = "0\r\n";
            screenValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 76);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(745, 690);
            Controls.Add(panel1);
            Controls.Add(screenValue);
            Name = "Form1";
            Text = "Scientific Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel screenValue;
        private Label screen;
        private Panel panel1;
    }
}
