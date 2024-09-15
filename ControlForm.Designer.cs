namespace EnLaunch
{
    partial class ControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            TableLayoutPanel = new TableLayoutPanel();
            UsernameTableLayoutPanel = new TableLayoutPanel();
            SignoutButton = new Button();
            OfflineUsernameLabel = new Label();
            OfflineUsernameTextBox = new TextBox();
            OnlineAccountsLabel = new Label();
            AccountsComboBox = new ComboBox();
            ChangeAccountModeButton = new Button();
            MicrosoftLoginButton = new Button();
            DownloadTableLayoutPanel = new TableLayoutPanel();
            DownloadLabel = new Label();
            DownloadsComboBox = new ComboBox();
            DownloadControlsTableLayoutPanel = new TableLayoutPanel();
            DownloadButton = new Button();
            RefreshDownloadsButton = new Button();
            PlayTableLayoutPanel = new TableLayoutPanel();
            PlayLabel = new Label();
            PlayVersionComboBox = new ComboBox();
            PlayControlsTableLayoutPanel = new TableLayoutPanel();
            PlayButton = new Button();
            RefreshButton = new Button();
            MemoryTrackBar = new TrackBar();
            MemoryLabel = new Label();
            UpdateCheckBox = new CheckBox();
            RootTableLayoutPanel = new TableLayoutPanel();
            ProgressTrackerTableLayoutPanel = new TableLayoutPanel();
            StatusLabel = new Label();
            ProgressBar = new ProgressBar();
            TableLayoutPanel.SuspendLayout();
            UsernameTableLayoutPanel.SuspendLayout();
            DownloadTableLayoutPanel.SuspendLayout();
            DownloadControlsTableLayoutPanel.SuspendLayout();
            PlayTableLayoutPanel.SuspendLayout();
            PlayControlsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MemoryTrackBar).BeginInit();
            RootTableLayoutPanel.SuspendLayout();
            ProgressTrackerTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel.ColumnCount = 5;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            TableLayoutPanel.Controls.Add(UsernameTableLayoutPanel, 1, 1);
            TableLayoutPanel.Controls.Add(DownloadTableLayoutPanel, 3, 1);
            TableLayoutPanel.Controls.Add(PlayTableLayoutPanel, 2, 1);
            TableLayoutPanel.Location = new Point(3, 3);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 2;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3355522F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 66.66445F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanel.Size = new Size(794, 418);
            TableLayoutPanel.TabIndex = 0;
            // 
            // UsernameTableLayoutPanel
            // 
            UsernameTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameTableLayoutPanel.ColumnCount = 1;
            UsernameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            UsernameTableLayoutPanel.Controls.Add(SignoutButton, 0, 4);
            UsernameTableLayoutPanel.Controls.Add(OfflineUsernameLabel, 0, 0);
            UsernameTableLayoutPanel.Controls.Add(OfflineUsernameTextBox, 0, 1);
            UsernameTableLayoutPanel.Controls.Add(OnlineAccountsLabel, 0, 2);
            UsernameTableLayoutPanel.Controls.Add(AccountsComboBox, 0, 3);
            UsernameTableLayoutPanel.Controls.Add(ChangeAccountModeButton, 0, 6);
            UsernameTableLayoutPanel.Controls.Add(MicrosoftLoginButton, 0, 5);
            UsernameTableLayoutPanel.Location = new Point(102, 142);
            UsernameTableLayoutPanel.Name = "UsernameTableLayoutPanel";
            UsernameTableLayoutPanel.RowCount = 7;
            UsernameTableLayoutPanel.RowStyles.Add(new RowStyle());
            UsernameTableLayoutPanel.RowStyles.Add(new RowStyle());
            UsernameTableLayoutPanel.RowStyles.Add(new RowStyle());
            UsernameTableLayoutPanel.RowStyles.Add(new RowStyle());
            UsernameTableLayoutPanel.RowStyles.Add(new RowStyle());
            UsernameTableLayoutPanel.RowStyles.Add(new RowStyle());
            UsernameTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            UsernameTableLayoutPanel.Size = new Size(192, 273);
            UsernameTableLayoutPanel.TabIndex = 0;
            // 
            // SignoutButton
            // 
            SignoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SignoutButton.Location = new Point(3, 91);
            SignoutButton.Name = "SignoutButton";
            SignoutButton.Size = new Size(186, 32);
            SignoutButton.TabIndex = 6;
            SignoutButton.Text = "Signout";
            SignoutButton.UseVisualStyleBackColor = true;
            SignoutButton.Click += SignoutButton_Click;
            // 
            // OfflineUsernameLabel
            // 
            OfflineUsernameLabel.AutoSize = true;
            OfflineUsernameLabel.Location = new Point(3, 0);
            OfflineUsernameLabel.Name = "OfflineUsernameLabel";
            OfflineUsernameLabel.Size = new Size(101, 15);
            OfflineUsernameLabel.TabIndex = 0;
            OfflineUsernameLabel.Text = "Offline username:";
            // 
            // OfflineUsernameTextBox
            // 
            OfflineUsernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OfflineUsernameTextBox.Location = new Point(3, 18);
            OfflineUsernameTextBox.Name = "OfflineUsernameTextBox";
            OfflineUsernameTextBox.Size = new Size(186, 23);
            OfflineUsernameTextBox.TabIndex = 1;
            OfflineUsernameTextBox.Text = "steve";
            OfflineUsernameTextBox.Visible = false;
            // 
            // OnlineAccountsLabel
            // 
            OnlineAccountsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OnlineAccountsLabel.AutoSize = true;
            OnlineAccountsLabel.Location = new Point(3, 44);
            OnlineAccountsLabel.Name = "OnlineAccountsLabel";
            OnlineAccountsLabel.Size = new Size(91, 15);
            OnlineAccountsLabel.TabIndex = 3;
            OnlineAccountsLabel.Text = "Online account:";
            // 
            // AccountsComboBox
            // 
            AccountsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AccountsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AccountsComboBox.FormattingEnabled = true;
            AccountsComboBox.Location = new Point(3, 62);
            AccountsComboBox.Name = "AccountsComboBox";
            AccountsComboBox.Size = new Size(186, 23);
            AccountsComboBox.TabIndex = 4;
            // 
            // ChangeAccountModeButton
            // 
            ChangeAccountModeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ChangeAccountModeButton.Location = new Point(3, 167);
            ChangeAccountModeButton.Name = "ChangeAccountModeButton";
            ChangeAccountModeButton.Size = new Size(186, 32);
            ChangeAccountModeButton.TabIndex = 5;
            ChangeAccountModeButton.Text = "Switch to online mode";
            ChangeAccountModeButton.UseVisualStyleBackColor = true;
            ChangeAccountModeButton.Click += ChangeAccountModeButton_Click;
            // 
            // MicrosoftLoginButton
            // 
            MicrosoftLoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MicrosoftLoginButton.Location = new Point(3, 129);
            MicrosoftLoginButton.Name = "MicrosoftLoginButton";
            MicrosoftLoginButton.Size = new Size(186, 32);
            MicrosoftLoginButton.TabIndex = 2;
            MicrosoftLoginButton.Text = "Add Microsoft account";
            MicrosoftLoginButton.UseVisualStyleBackColor = true;
            MicrosoftLoginButton.Click += MicrosoftLoginButton_Click;
            // 
            // DownloadTableLayoutPanel
            // 
            DownloadTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DownloadTableLayoutPanel.ColumnCount = 1;
            DownloadTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            DownloadTableLayoutPanel.Controls.Add(DownloadLabel, 0, 0);
            DownloadTableLayoutPanel.Controls.Add(DownloadsComboBox, 0, 1);
            DownloadTableLayoutPanel.Controls.Add(DownloadControlsTableLayoutPanel, 0, 2);
            DownloadTableLayoutPanel.Location = new Point(498, 142);
            DownloadTableLayoutPanel.Name = "DownloadTableLayoutPanel";
            DownloadTableLayoutPanel.RowCount = 3;
            DownloadTableLayoutPanel.RowStyles.Add(new RowStyle());
            DownloadTableLayoutPanel.RowStyles.Add(new RowStyle());
            DownloadTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DownloadTableLayoutPanel.Size = new Size(192, 273);
            DownloadTableLayoutPanel.TabIndex = 1;
            // 
            // DownloadLabel
            // 
            DownloadLabel.AutoSize = true;
            DownloadLabel.Location = new Point(3, 0);
            DownloadLabel.Name = "DownloadLabel";
            DownloadLabel.Size = new Size(105, 15);
            DownloadLabel.TabIndex = 0;
            DownloadLabel.Text = "Download Version:";
            // 
            // DownloadsComboBox
            // 
            DownloadsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DownloadsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DownloadsComboBox.Location = new Point(3, 18);
            DownloadsComboBox.Name = "DownloadsComboBox";
            DownloadsComboBox.Size = new Size(186, 23);
            DownloadsComboBox.TabIndex = 1;
            // 
            // DownloadControlsTableLayoutPanel
            // 
            DownloadControlsTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DownloadControlsTableLayoutPanel.ColumnCount = 2;
            DownloadControlsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DownloadControlsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DownloadControlsTableLayoutPanel.Controls.Add(DownloadButton, 0, 0);
            DownloadControlsTableLayoutPanel.Controls.Add(RefreshDownloadsButton, 1, 0);
            DownloadControlsTableLayoutPanel.Location = new Point(3, 47);
            DownloadControlsTableLayoutPanel.Name = "DownloadControlsTableLayoutPanel";
            DownloadControlsTableLayoutPanel.RowCount = 1;
            DownloadControlsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DownloadControlsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            DownloadControlsTableLayoutPanel.Size = new Size(186, 223);
            DownloadControlsTableLayoutPanel.TabIndex = 2;
            // 
            // DownloadButton
            // 
            DownloadButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DownloadButton.Location = new Point(3, 3);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(87, 32);
            DownloadButton.TabIndex = 0;
            DownloadButton.Text = "Download";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += DownloadButton_Click;
            // 
            // RefreshDownloadsButton
            // 
            RefreshDownloadsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RefreshDownloadsButton.Location = new Point(96, 3);
            RefreshDownloadsButton.Name = "RefreshDownloadsButton";
            RefreshDownloadsButton.Size = new Size(87, 32);
            RefreshDownloadsButton.TabIndex = 1;
            RefreshDownloadsButton.Text = "Refresh";
            RefreshDownloadsButton.UseVisualStyleBackColor = true;
            RefreshDownloadsButton.Click += RefreshDownloadsButton_Click;
            // 
            // PlayTableLayoutPanel
            // 
            PlayTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlayTableLayoutPanel.ColumnCount = 1;
            PlayTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PlayTableLayoutPanel.Controls.Add(PlayLabel, 0, 0);
            PlayTableLayoutPanel.Controls.Add(PlayVersionComboBox, 0, 1);
            PlayTableLayoutPanel.Controls.Add(PlayControlsTableLayoutPanel, 0, 2);
            PlayTableLayoutPanel.Controls.Add(MemoryTrackBar, 0, 5);
            PlayTableLayoutPanel.Controls.Add(MemoryLabel, 0, 4);
            PlayTableLayoutPanel.Controls.Add(UpdateCheckBox, 0, 3);
            PlayTableLayoutPanel.Location = new Point(300, 142);
            PlayTableLayoutPanel.MinimumSize = new Size(0, 150);
            PlayTableLayoutPanel.Name = "PlayTableLayoutPanel";
            PlayTableLayoutPanel.RowCount = 6;
            PlayTableLayoutPanel.RowStyles.Add(new RowStyle());
            PlayTableLayoutPanel.RowStyles.Add(new RowStyle());
            PlayTableLayoutPanel.RowStyles.Add(new RowStyle());
            PlayTableLayoutPanel.RowStyles.Add(new RowStyle());
            PlayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            PlayTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PlayTableLayoutPanel.Size = new Size(192, 273);
            PlayTableLayoutPanel.TabIndex = 2;
            // 
            // PlayLabel
            // 
            PlayLabel.AutoSize = true;
            PlayLabel.Location = new Point(3, 0);
            PlayLabel.Name = "PlayLabel";
            PlayLabel.Size = new Size(139, 15);
            PlayLabel.TabIndex = 0;
            PlayLabel.Text = "Choose a version to play:";
            // 
            // PlayVersionComboBox
            // 
            PlayVersionComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PlayVersionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayVersionComboBox.FormattingEnabled = true;
            PlayVersionComboBox.Location = new Point(3, 18);
            PlayVersionComboBox.Name = "PlayVersionComboBox";
            PlayVersionComboBox.Size = new Size(186, 23);
            PlayVersionComboBox.TabIndex = 1;
            // 
            // PlayControlsTableLayoutPanel
            // 
            PlayControlsTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlayControlsTableLayoutPanel.ColumnCount = 2;
            PlayControlsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PlayControlsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PlayControlsTableLayoutPanel.Controls.Add(PlayButton, 0, 0);
            PlayControlsTableLayoutPanel.Controls.Add(RefreshButton, 1, 0);
            PlayControlsTableLayoutPanel.Location = new Point(3, 47);
            PlayControlsTableLayoutPanel.Name = "PlayControlsTableLayoutPanel";
            PlayControlsTableLayoutPanel.RowCount = 1;
            PlayControlsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PlayControlsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PlayControlsTableLayoutPanel.Size = new Size(186, 43);
            PlayControlsTableLayoutPanel.TabIndex = 2;
            // 
            // PlayButton
            // 
            PlayButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PlayButton.Location = new Point(3, 3);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(87, 32);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RefreshButton.Location = new Point(96, 3);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(87, 32);
            RefreshButton.TabIndex = 1;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MemoryTrackBar
            // 
            MemoryTrackBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MemoryTrackBar.Location = new Point(3, 151);
            MemoryTrackBar.Maximum = 1;
            MemoryTrackBar.Minimum = 1;
            MemoryTrackBar.Name = "MemoryTrackBar";
            MemoryTrackBar.Size = new Size(186, 45);
            MemoryTrackBar.TabIndex = 4;
            MemoryTrackBar.Value = 1;
            MemoryTrackBar.ValueChanged += MemoryTrackBar_ValueChanged;
            // 
            // MemoryLabel
            // 
            MemoryLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MemoryLabel.AutoSize = true;
            MemoryLabel.Location = new Point(3, 133);
            MemoryLabel.Name = "MemoryLabel";
            MemoryLabel.Size = new Size(106, 15);
            MemoryLabel.TabIndex = 3;
            MemoryLabel.Text = "Runtime Memory: ";
            // 
            // UpdateCheckBox
            // 
            UpdateCheckBox.Anchor = AnchorStyles.Top;
            UpdateCheckBox.AutoSize = true;
            UpdateCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            UpdateCheckBox.Checked = true;
            UpdateCheckBox.CheckState = CheckState.Checked;
            UpdateCheckBox.Location = new Point(35, 96);
            UpdateCheckBox.Name = "UpdateCheckBox";
            UpdateCheckBox.Size = new Size(122, 19);
            UpdateCheckBox.TabIndex = 5;
            UpdateCheckBox.Text = "Check for updates";
            UpdateCheckBox.TextAlign = ContentAlignment.MiddleRight;
            UpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // RootTableLayoutPanel
            // 
            RootTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RootTableLayoutPanel.ColumnCount = 1;
            RootTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RootTableLayoutPanel.Controls.Add(TableLayoutPanel, 0, 0);
            RootTableLayoutPanel.Controls.Add(ProgressTrackerTableLayoutPanel, 0, 1);
            RootTableLayoutPanel.Location = new Point(0, 0);
            RootTableLayoutPanel.Name = "RootTableLayoutPanel";
            RootTableLayoutPanel.RowCount = 2;
            RootTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RootTableLayoutPanel.RowStyles.Add(new RowStyle());
            RootTableLayoutPanel.Size = new Size(800, 450);
            RootTableLayoutPanel.TabIndex = 1;
            // 
            // ProgressTrackerTableLayoutPanel
            // 
            ProgressTrackerTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProgressTrackerTableLayoutPanel.ColumnCount = 2;
            ProgressTrackerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ProgressTrackerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ProgressTrackerTableLayoutPanel.Controls.Add(StatusLabel, 0, 0);
            ProgressTrackerTableLayoutPanel.Controls.Add(ProgressBar, 1, 0);
            ProgressTrackerTableLayoutPanel.Location = new Point(3, 427);
            ProgressTrackerTableLayoutPanel.Name = "ProgressTrackerTableLayoutPanel";
            ProgressTrackerTableLayoutPanel.RowCount = 1;
            ProgressTrackerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ProgressTrackerTableLayoutPanel.Size = new Size(794, 20);
            ProgressTrackerTableLayoutPanel.TabIndex = 1;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(3, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(29, 15);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Halt";
            // 
            // ProgressBar
            // 
            ProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProgressBar.Location = new Point(400, 3);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(391, 14);
            ProgressBar.TabIndex = 1;
            // 
            // ControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RootTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ControlForm";
            Text = "EnLaunch";
            TableLayoutPanel.ResumeLayout(false);
            UsernameTableLayoutPanel.ResumeLayout(false);
            UsernameTableLayoutPanel.PerformLayout();
            DownloadTableLayoutPanel.ResumeLayout(false);
            DownloadTableLayoutPanel.PerformLayout();
            DownloadControlsTableLayoutPanel.ResumeLayout(false);
            PlayTableLayoutPanel.ResumeLayout(false);
            PlayTableLayoutPanel.PerformLayout();
            PlayControlsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MemoryTrackBar).EndInit();
            RootTableLayoutPanel.ResumeLayout(false);
            ProgressTrackerTableLayoutPanel.ResumeLayout(false);
            ProgressTrackerTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private TableLayoutPanel RootTableLayoutPanel;
        private TableLayoutPanel ProgressTrackerTableLayoutPanel;
        private Label StatusLabel;
        private TableLayoutPanel UsernameTableLayoutPanel;
        private Label OfflineUsernameLabel;
        private TextBox OfflineUsernameTextBox;
        private TableLayoutPanel DownloadTableLayoutPanel;
        private Label DownloadLabel;
        private ComboBox DownloadsComboBox;
        private ProgressBar ProgressBar;
        private TableLayoutPanel PlayTableLayoutPanel;
        private Label PlayLabel;
        private ComboBox PlayVersionComboBox;
        private TableLayoutPanel PlayControlsTableLayoutPanel;
        private Button PlayButton;
        private Button RefreshButton;
        private TableLayoutPanel DownloadControlsTableLayoutPanel;
        private Button DownloadButton;
        private Button RefreshDownloadsButton;
        private Button MicrosoftLoginButton;
        private Label MemoryLabel;
        private TrackBar MemoryTrackBar;
        private Label OnlineAccountsLabel;
        private ComboBox AccountsComboBox;
        private Button ChangeAccountModeButton;
        private Button SignoutButton;
        private CheckBox UpdateCheckBox;
    }
}