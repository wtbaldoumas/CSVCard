using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CSVCard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void OnLoad(object sender, EventArgs e)
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("CSVCard.Cross.png");
            Bitmap image = new Bitmap(myStream);
            _pictureBox.Image = image;

            Application.Idle += OnIdle;

        }

        private void OnIdle(object sender, EventArgs e)
        {
            if (!CSVCardManager.DataLoaded)
            {
                _exportVCardButton.Enabled = false;
            }
            else
            {
                _exportVCardButton.Enabled = true;
            }
        }

        private void OnFileDropDownOpening(object sender, EventArgs e)
        {
            if (!CSVCardManager.DataLoaded)
            {
                _exportVCardToolStripMenuItem.Enabled = false;
            }
            else
            {
                _exportVCardToolStripMenuItem.Enabled = true;
            }
        }

        private void OnLoadCSVClick(object sender, EventArgs e)
        {
            if (_fieldSelector.SeparateFieldsSelected())
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "CSV files (*.csv)|*.csv";

                if (openDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                CSVCardManager.Filename = openDialog.FileName;


                if (CSVCardManager.Open( _fieldSelector.HeaderIncluded(), _fieldSelector.FieldOrder()))
                {
                    System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                    Stream myStream = myAssembly.GetManifestResourceStream("CSVCard.Check.png");
                    Bitmap image = new Bitmap(myStream);
                    _pictureBox.Image = image;
                    _loadedLabel.Text = "CSV information loaded";
                    CSVCardManager.DataLoaded = true;
                }
                else
                {
                    MessageBox.Show("Error: missing fields or field order incorrect.", "CSVCard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CSVCardManager.DataLoaded = false;
                    CSVCardManager.VCards.Clear();
                }
            }
            else
            {
                MessageBox.Show("Error: duplicate fields selected.", "CSVCard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnExportVCardClick(object sender, EventArgs e)
        {
            if (_mergeCheckBox.Checked)
            {
                CSVCardManager.MergeSave();
            }
            else
            {
                CSVCardManager.SingleSave();
            }
        }

        private void OnAboutClick(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
