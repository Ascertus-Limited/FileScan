using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
