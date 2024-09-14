using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnLaunch
{
    public partial class MessageDialog : Form
    {
        public MessageDialog(string Title, string Text)
        {
            InitializeComponent();
            this.Text = Title;
            TitleLabel.Text = Title;
            TextLabel.Text = Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
