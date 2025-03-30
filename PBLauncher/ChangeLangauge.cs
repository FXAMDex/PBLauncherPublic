using Core.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources = PBLauncher.Properties.Resources;

namespace PBLauncher
{
    public partial class ChangeLangauge : Form
    {
        public ChangeLangauge()
        {
            InitializeComponent();
            MessageInfoChangeLanguage();
        }

        private void MessageInfoChangeLanguage()
        {
            string filePath = "Language.set";
            string password = "your_password"; // Ganti dengan password yang Anda inginkan

            if (File.Exists(filePath))
            {
                string encryptedText = File.ReadAllText(filePath).Trim();
                string decryptedText = ChipperEncryption.Decrypt(encryptedText, password);

                if (decryptedText == "language=id")
                {
                    STR_MESSAGE.Text = "Kamu Akan Merubah Bahasa Launcher Ke Bahasa Inggris\nApakah Anda Yakin?";
                }
                else if (decryptedText == "language=en")
                {
                    STR_MESSAGE.Text = "You Will Change Launcher Language To Indonesia\nAre You Sure?";
                }
            }
        }

        private void ButtonClick_Yes(object sender, EventArgs e)
        {
            string filePath = "Language.set";
            string password = "your_password"; // Ganti dengan password yang Anda inginkan

            if (File.Exists(filePath))
            {
                string encryptedText = File.ReadAllText(filePath).Trim();
                string decryptedText = ChipperEncryption.Decrypt(encryptedText, password);

                if (decryptedText == "language=id")
                {
                    string encryptedEnText = ChipperEncryption.Encrypt("language=en", password);
                    File.WriteAllText(filePath, encryptedEnText);

                    Application.Restart();
                }
                else if (decryptedText == "language=en")
                {
                    string encryptedIdText = ChipperEncryption.Encrypt("language=id", password);
                    File.WriteAllText(filePath, encryptedIdText);

                    Application.Restart();
                }
            }
        }

        public static class ChipperEncryption
        {
            public static string Encrypt(string plaintext, string password)
            {
                string encryptedText = "";
                int key = 0;

                foreach (char c in plaintext)
                {
                    key = password[key % password.Length];
                    encryptedText += (char)(c + key);
                }

                return encryptedText;
            }

            public static string Decrypt(string ciphertext, string password)
            {
                string decryptedText = "";
                int key = 0;

                foreach (char c in ciphertext)
                {
                    key = password[key % password.Length];
                    decryptedText += (char)(c - key);
                }

                return decryptedText;
            }
        }
        private void ButtonClick_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButtonOnPoint(object sender, EventArgs e)
        {
            CancelButtonLanguage.Image = Resources.btn_cancel_onpoint;
        }
        private void CancelButtonOffPoint(object sender, EventArgs e)
        {
            CancelButtonLanguage.Image = Resources.btn_cancel_offpoint;
        }
        private void OkButtonOnPoint(Object sender, EventArgs e)
        {
            OKButtonLanguage.Image = Resources.Ok_3;
        }
        private void OkButtonOffPoint(Object sender, EventArgs e)
        {
            OKButtonLanguage.Image = Resources.Ok_1;
        }
    }
}
