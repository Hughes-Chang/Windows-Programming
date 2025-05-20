namespace _13_3
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
            lblLight = new Label();
            SuspendLayout();
            // 
            // lblLight
            // 
            lblLight.BackColor = Color.Red;
            lblLight.Font = new Font("Microsoft JhengHei UI", 16F);
            lblLight.Location = new Point(42, 35);
            lblLight.Name = "lblLight";
            lblLight.Size = new Size(150, 150);
            lblLight.TabIndex = 0;
            lblLight.Text = "紅燈";
            lblLight.TextAlign = ContentAlignment.MiddleCenter;
            lblLight.MouseDown += lblLight_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLight);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblLight;
    }
}
