/*
 * Arquivo: Program.cs
 * Criado em: 23-11-2021
 * Última modificação: 23-11-2021
 */
using PBLauncher.Localize;
using PBLauncher.Utils;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PBLauncher
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filePath = "Language.set";
            string password = "your_password"; // Ganti dengan password yang Anda inginkan

            if (File.Exists(filePath))
            {
                string encryptedText = File.ReadAllText(filePath).Trim();
                string decryptedText = ChipperEncryption.Decrypt(encryptedText, password);

                if (decryptedText == "language=id")
                {
                    Instancia._strings = new LanguageID();
                }
                else if (decryptedText == "language=en")
                {
                    Instancia._strings = new LanguageEN();
                }
            }
            else
            {
                string encryptedText = ChipperEncryption.Encrypt("language=en", password);
                File.WriteAllText(filePath, encryptedText);
                Instancia._strings = new LanguageEN();
            }

            if (!File.Exists(string.Concat(Application.StartupPath, "\\launcher_core.dll")))
            {
                Logger.Log("[ERROR] Launcher_core.dll not found.");
                MessageBox.Show(Instancia._strings.CORE_NOTFOUND, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                Application.Run(new PleaseWait());
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
    }
}
