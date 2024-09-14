using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using CmlLib.Core.Downloader;
using CmlLib.Core.Version;
using CmlLib.Core.VersionLoader;
using CmlLib.Core.VersionMetadata;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnLaunch
{
    public partial class ControlForm : Form
    {
        private enum LauncherState
        {
            Idle,
            RefreshingDownloads,
            Downloading,
            Refreshing,
            LoadingMinecraft,
            SigningIn
        }

        private LauncherState launcherState = LauncherState.Idle;
        private readonly CMLauncher globalLauncher;
        private readonly MinecraftPath minecraftPath;
        private MSession? microsoftSession;

        public ControlForm(string launcherPath)
        {
            InitializeComponent();

            minecraftPath = new(launcherPath);

            globalLauncher = new(minecraftPath);

            globalLauncher.FileChanged += ChangeStatus;

            globalLauncher.ProgressChanged += ChangeProgress;

            MemoryTrackBar_ValueChanged(this, new EventArgs());
        }

        private async void RefreshDownloadsButton_Click(object sender, EventArgs e)
        {
            launcherState = LauncherState.RefreshingDownloads;
            UpdateBasedOnLauncherState();
            try
            {
                MVersionCollection versions = await globalLauncher.GetAllVersionsAsync();

                List<string> versionNames = [];
                foreach (MVersionMetadata version in versions)
                {
                    versionNames.Add(version.Name);
                }

                DownloadsComboBox.DataSource = versionNames;
            }
            catch
            {
                MessageDialog messageDialog = new("Error", "Couldn't get downloadable minecraft versions from server.");
                messageDialog.ShowDialog();
            }
            finally
            {
                launcherState = LauncherState.Idle;
                UpdateBasedOnLauncherState();
            }
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            if (DownloadsComboBox.SelectedItem == null)
            {
                return;
            }

            string? versionString = DownloadsComboBox.SelectedItem.ToString();

            if (versionString == null)
            {
                return;
            }
            launcherState = LauncherState.Downloading;
            UpdateBasedOnLauncherState();
            try
            {
                MVersion version = await globalLauncher.GetVersionAsync(versionString);
                await globalLauncher.CheckAndDownloadAsync(version);
            }
            catch
            { }
            finally
            {
                launcherState = LauncherState.Idle;
                UpdateBasedOnLauncherState();
            }
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            launcherState = LauncherState.Refreshing;
            UpdateBasedOnLauncherState();
            try
            {
                CMLauncher launcher = new(minecraftPath);

                launcher.VersionLoader = new LocalVersionLoader(launcher.MinecraftPath);
                launcher.FileDownloader = null;

                MVersionCollection versions = await launcher.GetAllVersionsAsync();

                List<string> versionNames = [];
                foreach (MVersionMetadata version in versions)
                {
                    versionNames.Add(version.Name);
                }

                PlayVersionComboBox.DataSource = versionNames;
            }
            catch
            {
                MessageDialog messageDialog = new("Error", "There was an error while trying to load the local minecraft versions.");
                messageDialog.ShowDialog();
            } finally
            {
                launcherState = LauncherState.Idle;
                UpdateBasedOnLauncherState();
            }
        }

        private async void PlayButton_Click(object sender, EventArgs e)
        {
            if (PlayVersionComboBox.SelectedItem == null)
            {
                return;
            }

            string? versionString = PlayVersionComboBox.SelectedItem.ToString();

            if (versionString == null)
            {
                return;
            }

            launcherState = LauncherState.LoadingMinecraft;
            UpdateBasedOnLauncherState();
            try
            {
                MSession session;

                if (microsoftSession == null)
                {
                    session = MSession.CreateOfflineSession(UsernameTextBox.Text);
                }
                else
                {
                    session = microsoftSession;
                }

                int selectedMemoryAmountMB = MemoryTrackBar.Value * 1024;
                MLaunchOption launchOptions;
                if(microsoftSession == null)
                {
                    launchOptions = new()
                    {
                        Session = session,
                        MinimumRamMb = 1024,
                        MaximumRamMb = selectedMemoryAmountMB,
                        JVMArguments = [
                            "-Dminecraft.api.env=custom",
                            "-Dminecraft.api.auth.host=https://invalid.invalid",
                            "-Dminecraft.api.account.host=https://invalid.invalid",
                            "-Dminecraft.api.session.host=https://invalid.invalid", 
                            "-Dminecraft.api.services.host=https://invalid.invalid"]
                    };
                } else
                {
                    launchOptions = new()
                    {
                        Session = session,
                        MinimumRamMb = 1024,
                        MaximumRamMb = selectedMemoryAmountMB
                    };
                }
                

                var process = await globalLauncher.CreateProcessAsync(versionString, launchOptions, checkAndDownload: false);
                process.Start();
            }
            catch
            {
                MessageDialog messageDialog = new("Error", "There was an error while starting the game process.");
                messageDialog.ShowDialog();
            } finally
            {
                launcherState = LauncherState.Idle;
                UpdateBasedOnLauncherState();
            }
        }

        private async void MicrosoftLoginButton_Click(object sender, EventArgs e)
        {
            launcherState = LauncherState.SigningIn;
            UpdateBasedOnLauncherState();
            try
            {
                JELoginHandler loginHandler = JELoginHandlerBuilder.BuildDefault();
                microsoftSession = await loginHandler.Authenticate();
                UsernameTextBox.ReadOnly = true;
                if (microsoftSession.Username != null)
                {
                    UsernameTextBox.Text = microsoftSession.Username;
                }
            }
            catch
            {
                MessageDialog messageDialog = new("Error", "There was an error while signing into your microsoft account.");
                messageDialog.ShowDialog();
            } finally
            {
                launcherState = LauncherState.Idle;
                UpdateBasedOnLauncherState();
            }
        }

        private void MemoryTrackBar_ValueChanged(object sender, EventArgs e)
        {
            int availableMemory = GetAvailableMemory();

            MemoryTrackBar.Maximum = availableMemory;

            MemoryLabel.Text = "Runtime Memory: " + MemoryTrackBar.Value + " / " + availableMemory + " GB";
        }

        private int GetAvailableMemory()
        {
            ComputerInfo computerInfo = new ComputerInfo();
            ulong availableMemoryBytes = computerInfo.TotalPhysicalMemory;
            float availableMemoryGB = availableMemoryBytes / (1024f * 1024f * 1024f);
            return (int)availableMemoryGB;
        }

        private void UpdateBasedOnLauncherState()
        {
            switch (launcherState)
            {
                case LauncherState.Idle:
                    ToggleFunctionality(true);
                    StatusLabel.Text = "Halt";
                    ProgressBar.Value = 0;
                    break;

                case LauncherState.RefreshingDownloads:
                    ToggleFunctionality(false);
                    StatusLabel.Text = "Fetching versions manifest from server . . .";
                    ProgressBar.Value = 0;
                    break;

                case LauncherState.Downloading:
                    ToggleFunctionality(false);
                    StatusLabel.Text = "Downloading . . .";
                    ProgressBar.Value = 0;
                    break;

                case LauncherState.Refreshing:
                    ToggleFunctionality(false);
                    StatusLabel.Text = "Searching for local versions . . .";
                    ProgressBar.Value = 0;
                    break;

                case LauncherState.LoadingMinecraft:
                    ToggleFunctionality(false);
                    StatusLabel.Text = "Loading version . . .";
                    ProgressBar.Value = 0;
                    break;

                case LauncherState.SigningIn:
                    ToggleFunctionality(false);
                    StatusLabel.Text = "Signing you in . . .";
                    ProgressBar.Value = 0;
                    break;


            }
        }

        private void ToggleFunctionality(bool enabled)
        {
            DownloadButton.Enabled = enabled;
            PlayButton.Enabled = enabled;
            RefreshButton.Enabled = enabled;
            RefreshDownloadsButton.Enabled = enabled;
            MicrosoftLoginButton.Enabled = enabled;
            MemoryTrackBar.Enabled = enabled;
        }

        private void ChangeStatus(DownloadFileChangedEventArgs eventArgs)
        {
            string downloadState = "Processing";

            switch (eventArgs.FileType)
            {
                case MFile.Library:
                    downloadState = "Downloading libraries";
                    break;
                case MFile.Resource:
                    downloadState = "Downloading resources";
                    break;
                case MFile.Minecraft:
                    downloadState = "Downloading minecraft";
                    break;
                case MFile.Runtime:
                    downloadState = "Downloading java";
                    break;
            }

            string status = downloadState + " [" + ProgressBar.Value.ToString() + "%] (" + eventArgs.ProgressedFileCount.ToString() + "/" + eventArgs.TotalFileCount.ToString() + "): " + eventArgs.FileName;
            StatusLabel.Text = status;
        }

        private void ChangeProgress(object? sender, ProgressChangedEventArgs eventArgs)
        {
            ProgressBar.Value = eventArgs.ProgressPercentage;
        }
    }
}
