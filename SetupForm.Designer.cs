namespace EnLaunch
{
    partial class SetupForm
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
            TableLayoutPanel = new TableLayoutPanel();
            AddressLabel = new Label();
            FileBrowserTableLayoutPanel = new TableLayoutPanel();
            AddressTextBox = new TextBox();
            BrowseButton = new Button();
            ContinueButton = new Button();
            AddressBrowserDialog = new FolderBrowserDialog();
            TableLayoutPanel.SuspendLayout();
            FileBrowserTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel.ColumnCount = 3;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(AddressLabel, 1, 1);
            TableLayoutPanel.Controls.Add(FileBrowserTableLayoutPanel, 1, 2);
            TableLayoutPanel.Controls.Add(ContinueButton, 1, 3);
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 5;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle());
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Size = new Size(585, 360);
            TableLayoutPanel.TabIndex = 0;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(42, 135);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(164, 15);
            AddressLabel.TabIndex = 0;
            AddressLabel.Text = "Please choose the game path:";
            // 
            // FileBrowserTableLayoutPanel
            // 
            FileBrowserTableLayoutPanel.ColumnCount = 2;
            FileBrowserTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            FileBrowserTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            FileBrowserTableLayoutPanel.Controls.Add(AddressTextBox, 0, 0);
            FileBrowserTableLayoutPanel.Controls.Add(BrowseButton, 1, 0);
            FileBrowserTableLayoutPanel.Location = new Point(42, 153);
            FileBrowserTableLayoutPanel.Name = "FileBrowserTableLayoutPanel";
            FileBrowserTableLayoutPanel.RowCount = 1;
            FileBrowserTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FileBrowserTableLayoutPanel.Size = new Size(500, 40);
            FileBrowserTableLayoutPanel.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(3, 3);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(413, 23);
            AddressTextBox.TabIndex = 0;
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new Point(422, 3);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(75, 23);
            BrowseButton.TabIndex = 1;
            BrowseButton.Text = "browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // ContinueButton
            // 
            ContinueButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContinueButton.Location = new Point(42, 199);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(500, 23);
            ContinueButton.TabIndex = 2;
            ContinueButton.Text = "continue";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(TableLayoutPanel);
            Name = "SetupForm";
            Text = "Setup";
            TableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel.PerformLayout();
            FileBrowserTableLayoutPanel.ResumeLayout(false);
            FileBrowserTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private Label AddressLabel;
        private TableLayoutPanel FileBrowserTableLayoutPanel;
        private TextBox AddressTextBox;
        private Button BrowseButton;
        private Button ContinueButton;
        private FolderBrowserDialog AddressBrowserDialog;
    }
}