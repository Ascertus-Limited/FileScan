using System;
using System.IO;
using FileScan.Encryption;
using System.Windows.Forms;
namespace FileScan
{
    internal class License
    {
        public bool IsLicensed()
        {
            try
            {
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                string encryptedString = File.ReadAllText(Path.Combine(appPath, "License.lic")).ToString();

                string decryptedString = Cryptography.Decrypt(encryptedString);

                string[] licenseDetails = decryptedString.Split('|');

                string product = licenseDetails[0];
                string expiryDate = licenseDetails[1];

                if (DateTime.Now < Convert.ToDateTime(expiryDate) && product == "File Scan")
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
