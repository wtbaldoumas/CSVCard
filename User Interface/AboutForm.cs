using System;
using System.Windows.Forms;

namespace CSVCard
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}