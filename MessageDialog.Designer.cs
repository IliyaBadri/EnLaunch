namespace EnLaunch
{
    partial class MessageDialog
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
            TitleLabel = new Label();
            TextLabel = new Label();
            OkButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(50, 50);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(64, 32);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title";
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(70, 100);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(28, 15);
            TextLabel.TabIndex = 1;
            TextLabel.Text = "Text";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(250, 200);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 2;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // MessageDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(OkButton);
            Controls.Add(TextLabel);
            Controls.Add(TitleLabel);
            Name = "MessageDialog";
            Text = "Message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label TextLabel;
        private Button OkButton;
    }
}