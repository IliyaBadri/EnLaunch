using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;

namespace EnLaunch
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();

            string defaultPath = MinecraftPath.GetOSDefaultPath();

            AddressTextBox.Text = defaultPath;
            AddressBrowserDialog.SelectedPath = defaultPath;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            AddressBrowserDialog.ShowDialog();

            AddressTextBox.Text = AddressBrowserDialog.SelectedPath;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            string selectedPath = AddressTextBox.Text;

            if(!Directory.Exists(selectedPath))
            {
                MessageDialog messageDialog = new("Error", "Invalid game path.");

                messageDialog.ShowDialog();
                return;
            }

            ControlForm controlForm = new(selectedPath);

            this.Hide();
            controlForm.ShowDialog();
            this.Close();
        }
    }
}
