using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using CryptSharp.Utility;

namespace FileScan.Encryption
{
    internal class Cryptography
    {
        public static string Hash(string secret, string salt)
        {
            var keyBytes = Encoding.UTF8.GetBytes(secret);
            var saltBytes = Encoding.UTF8.GetBytes(salt);
            var cost = 262144;
            var blockSize = 8;
            var parallel = 1;
            var maxThreads = (int?)null;
            var derivedKeyLength = 128;

            var bytes = SCrypt.ComputeDerivedKey(keyBytes, saltBytes, cost, blockSize, parallel, maxThreads, derivedKeyLength);
            return Convert.ToBase64String(bytes);
        }

        public static string Encrypt(string encryptString)
        {
            if (!String.IsNullOrEmpty(encryptString))
            {
                string EncryptionKey = "0abs1lgdy4xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement    
                byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    encryptor.Padding = PaddingMode.PKCS7;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        encryptString = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return encryptString;
            }
            else
            {
                return null;
            }
        }

        public static string Decrypt(string cipherText)
        {
            if (!String.IsNullOrEmpty(cipherText))
            {
                string EncryptionKey = "0abs1lgdy4xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement, but the decryption key should be same as encryption key    
                cipherText = cipherText.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                });

                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    encryptor.Padding = PaddingMode.PKCS7;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
                return cipherText;
            }
            else
            {
                return null;
            }

        }
    }
}
