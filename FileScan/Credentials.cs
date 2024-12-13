using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileScan.Encryption;

namespace FileScan
{
    public partial class Credentials : Form
    {
        public Credentials()
        {
            InitializeComponent();
        }

        private void Credentials_Load(object sender, EventArgs e)
        {
            try
            {
                tbServer.Text = Properties.Settings.Default.SqlServer;
                tbSqlUsername.Text = Properties.Settings.Default.SqlUsername;
                tbSqlPassword.Text = Cryptography.Decrypt(Properties.Settings.Default.SqlPassword);
                tbDatabase.Text = Properties.Settings.Default.SqlDatabase;

                if (Properties.Settings.Default.WindowsAuthentication)
                    chWindowsAuth.Checked = true;
                else
                    chWindowsAuth.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.SqlServer = tbServer.Text;
                Properties.Settings.Default.SqlUsername = tbSqlUsername.Text;
                Properties.Settings.Default.SqlPassword = Cryptography.Encrypt(tbSqlPassword.Text);
                Properties.Settings.Default.SqlDatabase = tbDatabase.Text;

                if (chWindowsAuth.Checked)
                    Properties.Settings.Default.WindowsAuthentication = true;
                else
                    Properties.Settings.Default.WindowsAuthentication = false;

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
