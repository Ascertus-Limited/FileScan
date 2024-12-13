using System;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace FileScan
{
    public partial class Form1 : Form
    {
        BackgroundWorker bgwDirectories;
        BackgroundWorker bgwFiles;

        public Form1()
        {
            InitializeComponent();

            bgwDirectories = new BackgroundWorker();
            bgwFiles = new BackgroundWorker();

            bgwFiles.WorkerSupportsCancellation = true;
            bgwFiles.WorkerReportsProgress = true;

            bgwDirectories.WorkerSupportsCancellation = true;
            bgwDirectories.WorkerReportsProgress = true;

            bgwDirectories.DoWork += BgwDirectories_DoWork;
            bgwDirectories.ProgressChanged += BgwDirectories_ProgressChanged;
            bgwDirectories.RunWorkerCompleted += BgwDirectories_RunWorkerCompleted;

            bgwFiles.DoWork += BgwFiles_DoWork;
            bgwFiles.ProgressChanged += BgwFiles_ProgressChanged;
            bgwFiles.RunWorkerCompleted += BgwFiles_RunWorkerCompleted;
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Owner = this;
            settings.StartPosition = FormStartPosition.CenterParent;
            settings.ShowDialog();
        }

        private void credentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credentials credentials = new Credentials();
            credentials.Owner = this;
            credentials.StartPosition = FormStartPosition.CenterParent;
            credentials.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            License license = new License();

            if (!license.IsLicensed())
            {
                MessageBox.Show("This product isn't licensed. Please obtain a License from Ascertus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LocationPicker locationPicker = new LocationPicker();
            locationPicker.Owner = this;
            locationPicker.ShowDialog();

            if(locationPicker.accepted == true)
            {
                if(!String.IsNullOrEmpty(locationPicker.tbLocation.Text))
                    lbLocationsToScan.Items.Add(locationPicker.tbLocation.Text);
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            bgwDirectories.RunWorkerAsync(argument: lbLocationsToScan);
        }

        private void BgwFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BgwFiles_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BgwFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BgwDirectories_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BgwDirectories_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BgwDirectories_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
