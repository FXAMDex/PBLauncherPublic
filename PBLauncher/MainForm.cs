/*
 * Arquivo: MainForm.cs
 * Criado em: 23-11-2021
 * Última modificação: 04-06-2022
 */
using Core;
using Ionic.Zip;
using PBLauncher.AMDex;
using PBLauncher.Properties;
using PBLauncher.Utils;
using PBLauncher.Utils.Enum;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBLauncher.Login;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;

namespace PBLauncher
{
    public partial class MainForm : Form
    {
        private bool Updat, Verif;

        public Point NewPoint;
        private int AVersion;
        private readonly WebClient GameUpdate = new WebClient();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoSetLanguage();
            LauncherConfig.Visible = false;
            WEB_Announce.Refresh();
            Logger.Log("[LAUNCHER_STATE_CHECK] ->> Checking All Require Success...");
            LTitulo.Text = Instancia._strings.LOADING;
            LTotalFixo.Text = Instancia._strings.TOTAL;
            LAquivoFixo.Text = Instancia._strings.FILE;
            WEB_Announce.Navigate(Connect._webURL);
            WEB_Announce.Refresh(); 
            Buttons_Enable(false, false, false);
            Buttons_Visible(true, true, false);
            CheckUpdate(1);
            CheckAnnounce();
            CallDatabase.ValidateDevice();
        }

        private void AutoSetLanguage()
        {
            string filePath = "language.set";
            string password = "your_password"; // Ganti dengan password yang Anda inginkan

            if (File.Exists(filePath))
            {
                string encryptedText = File.ReadAllText(filePath).Trim();
                string decryptedText = ChipperEncryption.Decrypt(encryptedText, password);

                if (decryptedText == "language=id")
                {
                    IndonesiaButton.Enabled = false;
                    IndonesiaButton.Image = Resources.btn_id_language_blockpoint;
                    EnglishButton.Image = Resources.btn_en_language_offpoint1;
                }
                else if (decryptedText == "language=en")
                {
                    EnglishButton.Enabled = false;
                    EnglishButton.Image = Resources.btn_en_language_selected;
                    IndonesiaButton.Image = Resources.btn_id_language_offpoint;
                }
            }
            else
            {
                string encryptedText = ChipperEncryption.Encrypt("language=id", password);
                File.WriteAllText(filePath, encryptedText);
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
        private async void CheckAnnounce()
        {
            if (Connect._state == HostStatus.ONLINEALERT && !string.IsNullOrEmpty(Connect._message))
            {
                await Task.Delay(40);
                MessageBox.Show(Connect._message.Replace("\\n", Environment.NewLine), Connect.GameName);
            }
        }

        #region Buttons
        private void ConfigPBox_Click(object sender, EventArgs e)
        {
            if (!Updat)
            {
                try
                {
                    Process.Start("PBConfig.exe");
                }
                catch
                {
                    MessageBox.Show(Instancia._strings.CONFIG_ERROR, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        #endregion
        #region
        private async void StartPBox_Click(object sender, EventArgs e)
        {
            string LoginMethode = Connect.LoginForm;
            try
            {
                if (LoginMethode == "1")
                {
                    await ShowLoginForm();
                }
                else if (LoginMethode == "2")
                {
                    await StartGame();
                }
            }
            catch (Exception ex)
            {
                Logger.Log("[!] Kesalahan: " + ex.Message);
                MessageBox.Show("Kesalahan: " + ex.Message, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private async Task ShowLoginForm()
        {
            PBLauncher.Login.LoginForm loginForm = new PBLauncher.Login.LoginForm();
            loginForm.FormClosed += (sender, e) =>
            {
                StartPBox.Enabled = true;
            };
            loginForm.ShowDialog();
            StartPBox.Image = Resources.btn_start_onpoint;
            StartPBox.Enabled = false;

            while (loginForm.Visible)
            {
                await Task.Delay(10);
            }
            StartPBox.Enabled = true;
            StartPBox.Image = Resources.btn_start_offpoint;
        }
        private async Task StartGame()
        {
            if (Connect._useXCLoader == "1" && !File.Exists(string.Concat(Application.StartupPath, "\\SpinnetAC.exe")))
            {
                Logger.Log("[!!] Tidak Dapat Menemukan SpinnetAC.exe");
                MessageBox.Show("Tidak Dapat Menemukan Program SpinnetAC.exe", Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (File.Exists(string.Concat(Application.StartupPath, "\\PointBlank.exe")))
            {
                StartPBox.Image = Resources.start_click;
                CheckPBox.Image = Resources.check_click;
                StartPBox.Enabled = false;
                LTitulo.Update();
                await Task.Delay(10);

                try
                {
                    if (Connect._useXCLoader == "1")
                    {
                        string filePath = Application.StartupPath + "\\SpinnetAC.exe";
                        string expectedMd5Hash = "";
                        using (var md5 = MD5.Create())
                        {
                            using (var stream = File.OpenRead(filePath))
                            {
                                byte[] hashBytes = md5.ComputeHash(stream);
                                string actualMd5Hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                                /*if (actualMd5Hash != expectedMd5Hash)
                                {
                                    MessageBox.Show("Kode SpinnetAC.exe tidak sesuai!", Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    Application.Exit();
                                    return;
                                }*/
                            }
                        }
                        Process.Start(filePath);
                        await Task.Delay(1000);
                    }
                    Process.Start(string.Concat(Application.StartupPath, "\\PointBlank.exe"), Connect._keyHost ? Connect._launcherKey.ToString() : Param.key_dll);
                    Hide();
                }
                catch (Exception ex)
                {
                    Logger.Log("[!] Permainan Belum Dimulai! [" + ex.Message + "]");
                    MessageBox.Show("Permainan Belum Dimulai! \n[" + ex.Message + "]", Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                Logger.Log("[!] Game Started !");
                await Task.Delay(10);
                //this.PBDetect.Start();
                //this.Hide();
                Application.Exit();
            }
            else
            {
                MessageBox.Show(Instancia._strings.GAME_NOT_FOUND, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logger.Log("[!!] Tidak Dapat Menemukan Program PointBlank.exe");
                return;
            }
        }
        #endregion

        #region Check Client
        private async void CheckPBox_Click(object sender, EventArgs e)
        {
            Verif = true;
            CheckPBox.Image = Resources.btn_check_block;
            StartPBox.Image = Resources.btn_start_onpoint;
            LTitulo.Text = Instancia._strings.CHECKING_FILES;
            LTitulo.Refresh();
            Logger.Log("[>] Game file verification started.");
            Buttons_Enable(false, false, false);
            Buttons_Visible(true, true, false);
            LArquivo.Visible = true;

            string path = @"Pack"; // Jalur folder PACK
            string[] fileNames = Directory.GetFiles(path, "*.i3Pack"); // Pilih file .i3Pack

            int totalFile = fileNames.Length;
            int progress = 0;

            foreach (string fileName in fileNames)
            {
                string namaFile = Path.GetFileName(fileName);
                LArquivo.Text = $"Verification {namaFile}...";
                //Logger.Log($"Verification {namaFile}...");

                // Lakukan verifikasi file
                // ...

                progress++;
                Bar1SetProgress((int)((double)progress / totalFile * 100), 100);
                await Task.Delay(20);
            }

            Verif = false;
            LDownload.Visible = false;
            Logger.Log("[<] Verification of game files completed.");
            await Clear.Trash();
            CheckPBox.Image = Resources.btn_check_offpoint;
            StartPBox.Image = Resources.btn_start_offpoint;
            Buttons_Enable(true, true, false);
            Buttons_Visible(true, true, false);
            Arquivo_Bar.Width = Arquivo_BarFixo.Width;
            Total_Bar.Width = Total_BarFixo.Width;
            LTitulo.Text = Instancia._strings.GAME_IS_UPDATE;
            LArquivo.Visible = false;
        }
        #endregion

        #region Update
        private async void CheckUpdate(short start)
        {
            long LVersion;
            if (start == 1)
                LVersion = Connect._version;
            else
                LVersion = await Connect.GetVersionUP();
           await  Clear.Trash();
            if (LVersion == -1)
            {
                Logger.Log("[>!] There is no update available. [RECEIVE_COUNT_NULL]");
                MessageBox.Show(Instancia._strings.GET_UPDATE_ERROR, "[RECEIVE_NULL] ~ " + Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AVersion = LerVersion();
            Arquivo_Bar.Width = Arquivo_BarFixo.Width;
            Total_Bar.Width = Total_BarFixo.Width;
            LArquivo.Visible = false;
            UpdatePBox.Image = Resources.btn_update_offpoint;
            Updat = false;
            if (LVersion > AVersion)
            {
                Logger.Log("Waiting for client update.");
                Logger.Log("Version : " + AVersion + "/" + LVersion);
                Arquivo_Bar.Width = 0;
                Total_Bar.Width = 0;
                LTitulo.Text = Instancia._strings.UPDATE_REC;
                Buttons_Enable(false, false, true);
                Buttons_Visible(false, true, true);
                CheckPBox.Image = Resources.btn_check_block;
            }
            else if (LVersion == AVersion)
            {
                Logger.Log("The client is up to date.");

                Logger.Log("[!] ClientFilesCount: " + Directory.GetFiles(Application.StartupPath, "*.*", SearchOption.AllDirectories).Count().ToString());
                Logger.Log("[!] ClientFilesCount[SERVER]: " + Connect._fcountCompare);
                Logger.Log("Version : " + AVersion + "/" + LVersion);
                LArquivo.Visible = false;
                LTitulo.Text = Instancia._strings.GAME_IS_UPDATE;
                Buttons_Enable(true, true, false);
                Buttons_Visible(true, true, false);
                CheckPBox.Image = Resources.btn_check_offpoint;
                StartPBox.Image = Resources.btn_start_offpoint;
            }
            else
            {
                Logger.Log("Client version greater than server version.");
                Logger.Log("Version : " + AVersion + "/" + LVersion);
                Logger.Log("Resetting updates...");
                await Task.Delay(50);
                MessageBox.Show(Instancia._strings.LARGER_VERSION, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                File.Delete(string.Concat(Application.StartupPath, "\\config.zpt"));
                await Task.Delay(50);
                EscreverVersion(0);
                CheckUpdate(0);
            }
        }

        private void UpdatePBox_Click(object sender, EventArgs e)
        {
            Buttons_Enable(false, false, false);
            Updat = true;
            UpdatePBox.Image = Resources.update_click;
            GameUpdate.DownloadFileCompleted += GameUpdate_DownloadFileCompleted;
            GameUpdate.DownloadProgressChanged += GameUpdate_DownloadProgressChanged;
            LTitulo.Text = Instancia._strings.GET_UPDATE_INFO;
            StartUpdate();
        }

        private void GameUpdate_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Bar1SetProgress(e.BytesReceived, e.TotalBytesToReceive); 
            LDownload.Text = string.Format("{0}/{1} MB", (e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), (e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
        }

        private async void GameUpdate_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                LDownload.Visible = false;
                LTitulo.Text = Instancia._strings.EXTRACT_FILE_UPDATE;
                LTitulo.Update();
                Total_Bar.Width = 0;
                string startupPath = Application.StartupPath;
                object[] actualVersion = new object[] { Application.StartupPath, "\\_DownloadPatchFiles\\patch_", AVersion + 1, ".zip" };
                await Unzip(startupPath, string.Concat(actualVersion));
                Total_Bar.Width = Total_BarFixo.Width;
                StartUpdate();
            }
        }

        private void StartUpdate()
        {
            AVersion = LerVersion();
            int LVersion = Connect._version;
            if (LVersion != AVersion)
            {
                int newV = AVersion + 1;
                Arquivo_Bar.Width = 0;
                LArquivo.Text = string.Concat("Patch_", newV, ".zip");
                LArquivo.Visible = true;
                Logger.Log("Starting client update.");
                Logger.Log("Downloading " + LArquivo.Text);
                Bar2SetProgress(newV, LVersion);
                Directory.CreateDirectory(string.Concat(Application.StartupPath, "\\_DownloadPatchFiles"));
                try
                {
                    Uri uri = new Uri(Connect._upURL + "patch_" + newV + ".zip");
                    object[] startupPath = new object[] { Application.StartupPath, "\\_DownloadPatchFiles\\patch_", newV, ".zip" };
                    LDownload.Visible = true;
                    GameUpdate.DownloadFileAsync(uri, string.Concat(startupPath));
                }
                catch (Exception arg)
                {
                    Logger.Log("The file [" + newV + "] was not found on the server. \n[" + arg.Message + "]");
                    MessageBox.Show(string.Format(Instancia._strings.DOWNLOAD_FILE_ERROR, newV), Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
                CheckUpdate(0);
        }

        private int LerVersion()
        {
            IniFile fileini = new IniFile(Application.StartupPath + "\\config.zpt");
            return fileini.IniReadInt("UPDATE", "version");
        }

        private void EscreverVersion(int version)
        {
            IniFile fileini = new IniFile(Application.StartupPath + "\\config.zpt");
            fileini.IniWriteInt("UPDATE", "version", version);
        }

        #endregion

        #region Image buttons
        private void ExitPBox_MouseMove(object sender, MouseEventArgs e)
        {
            ExitPBox.Image = Resources.exit_mouse;
        }

        private void ExitPBox_MouseLeave(object sender, EventArgs e)
        {
            ExitPBox.Image = Resources.exit;
        }

        private void ExitPBox_MouseDown(object sender, MouseEventArgs e)
        {
            ExitPBox.Image = Resources.exit_click;
        }

        private void MinPBox_MouseMove(object sender, MouseEventArgs e)
        {
            MinPBox.Image = Resources.minim_mouse;
        }

        private void MinPBox_MouseLeave(object sender, EventArgs e)
        {
            MinPBox.Image = Resources.minim;
        }

        private void MinPBox_MouseDown(object sender, MouseEventArgs e)
        {
            MinPBox.Image = Resources.minim_click;
        }

        private void ConfigPBox_MouseMove(object sender, MouseEventArgs e)
        {
            ConfigPBox.Image = Resources.config_mouse;
        }

        private void ConfigPBox_MouseLeave(object sender, EventArgs e)
        {
            ConfigPBox.Image = Resources.config;
        }

        private void UpdatePBox_MouseDown(object sender, MouseEventArgs e)
        {
            UpdatePBox.Image = Resources.btn_update_onpoint;
        }

        private void UpdatePBox_MouseLeave(object sender, EventArgs e)
        {
            if (Updat)
                UpdatePBox.Image = Resources.btn_update_onpoint;
            else
                UpdatePBox.Image = Resources.btn_update_offpoint;
        }

        private void UpdatePBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Updat)
                UpdatePBox.Image = Resources.btn_update_onpoint;
            else
                UpdatePBox.Image = Resources.btn_update_onpoint;
        }

        private void StartPBox_MouseDown(object sender, MouseEventArgs e)
        {
            StartPBox.Image = Resources.btn_start_onpoint;
        }

        private void StartPBox_MouseLeave(object sender, EventArgs e)
        {
            StartPBox.Image = Resources.btn_start_offpoint;
        }

        private void StartPBox_MouseMove(object sender, MouseEventArgs e)
        {
            StartPBox.Image = Resources.btn_start_onpoint;
        }

        private void CheckPBox_MouseDown(object sender, MouseEventArgs e)
        {
            CheckPBox.Image = Resources.btn_check_onpoint;
        }

        private void CheckPBox_MouseLeave(object sender, EventArgs e)
        {
            if (Verif)
                CheckPBox.Image = Resources.btn_check_onpoint;
            else
                CheckPBox.Image = Resources.btn_check_offpoint;
        }

        private void CheckPBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Verif)
                CheckPBox.Image = Resources.btn_check_onpoint;
            else
                CheckPBox.Image = Resources.btn_check_onpoint;
        }
        #endregion

        #region Movimentação e saida do Form
        
        private void ExitPBox_Click(object sender, EventArgs e)
        {       
            if (MessageBox.Show(Instancia._strings.EXIT_ASK, Connect.GameName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Logger.Log("[><] PBLauncher was finalized.");
                System.Environment.Exit(0);
            }
            else
            {
               //Launcher continua aberto
            }

        }

        private void MinPBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Launcher_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int left = Left;
                Point mousePosition = MousePosition;
                NewPoint.X = left - mousePosition.X;
                int top = Top;
                Point point = MousePosition;
                NewPoint.Y = top - point.Y;
            }
        }

        private void Launcher_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int x = NewPoint.X;
                Point mousePosition = MousePosition;
                Left = x + mousePosition.X;
                int y = NewPoint.Y;
                mousePosition = MousePosition;
                Top = y + mousePosition.Y;
            }
        }

        private void Launcher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Log("[><] PBLauncher has been finalized.");
        }
       // => Logger.Log("[><] PBLauncher foi finalizado.");


        #endregion

        #region Códigos base
        public async Task Unzip(string TargetDir, string ZipToUnpack)
        {
            try
            {
                int x = 0;
                ZipFile zipFile = ZipFile.Read(ZipToUnpack);
                try
                {
                    zipFile.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(Unzip_ExtractProgressChanged);
                    LArquivo.Visible = true;
                    foreach (ZipEntry zipEntry in zipFile)
                    {
                        Arquivo_Bar.Width = 0;
                        Bar2SetProgress(x++, zipFile.Count);

                        //Pausa necessaria para atualizar os elementos visuais.
                        await Task.Delay(1);

                        string fileName = zipEntry.FileName;
                        if (fileName.Contains("/"))
                        {
                            int num2 = fileName.LastIndexOf("/");
                            fileName = fileName.Substring(num2 + 1);
                        }
                        if (!zipEntry.IsDirectory)
                        {
                            LArquivo.Text = fileName;
                            zipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                        }
                    }
                }
                finally
                {
                    Arquivo_Bar.Width = Arquivo_BarFixo.Width;
                    if (zipFile != null)
                        zipFile.Dispose();
                }
            }
            catch (Exception)
            {
            }
        }

        private void Unzip_ExtractProgressChanged(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer != 0)
            {
                Bar1SetProgress(e.BytesTransferred, e.TotalBytesToTransfer);
                Arquivo_Bar.Update();
            }

        }

        public void Bar1SetProgress(long received, long maximum) => Arquivo_Bar.Width = (int)(received * Arquivo_BarFixo.Width / maximum);

        public void Bar2SetProgress(int received, int maximum) => Total_Bar.Width = received * Total_BarFixo.Width / maximum;
        
        private void Buttons_Enable(bool Start, bool Check, bool Update)
        {
            StartPBox.Enabled = Start;
            CheckPBox.Enabled = Check;
            UpdatePBox.Enabled = Update;
        }

      
        private void WEB_Announce_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void BAN()
        {
            if (File.Exists(string.Concat(Application.StartupPath, "\\Gui\\ban.ban")))
            {
                Logger.Log("[XX] Usuário banido permanentemente do launcher.");
                MessageBox.Show(Instancia._strings.AUTH_ACC_BANNED, Connect.GameName);
                Close();
            }
            else
            {

            }
        }
        private void PBDetect_Tick(object sender, EventArgs e)
        {
            
           try
            {
                Process[] PB = Process.GetProcessesByName("PointBlank");
                if (PB.Length == 0)
                {
                    //Game closed
                    Logger.Log("[><] Game Telah Ditutup");
                    Close();

                }
                else
                {
                    //Jogo aberto
                    try
                    {
                        Process[] CE = Process.GetProcessesByName("cheatengine-x86_64-SSE4-AVX2");
                        if (CE.Length == 0)
                        {

                        }
                        else
                        {
                            var PBK = Process.GetProcessesByName("PointBlank");
                            foreach (var pb in PBK)
                                pb.Kill();
                        }
                        Process[] TaskManager = Process.GetProcessesByName("Taskmgr");
                        if (TaskManager.Length > 0)
                        {
                            // Task Manager sedang berjalan
                            //Logger.Log("[!] Task Manager sedang berjalan");
                        }
                        else
                        {
                            // Task Manager tidak sedang berjalan
                            //Logger.Log("[!] Task Manager tidak sedang berjalan");
                        }

                    }


                    catch (Exception arg)
                    {
                        // Logger.Log("[!] Erro [" + arg.Message + "]");
                    }

                }
            }
            catch (Exception arg)
            {
               // Logger.Log("[!] Exception [" + arg.Message + "]");
            }
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LauncherConfig.Visible = false;
            StartPBox.Enabled = true;
            CheckPBox.Enabled = true;
            WEB_Announce.Visible = true;
            StartPBox.Image = Resources.btn_start_offpoint;
            CheckPBox.Image = Resources.btn_check_offpoint;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            OkConfig.Image = Resources.Ok_1;
        }

        private void OkConfig_MouseMove(object sender, MouseEventArgs e)
        {
            OkConfig.Image = Resources.Ok_2;
        }

        private void OkConfig_MouseDown(object sender, MouseEventArgs e)
        {
            OkConfig.Image = Resources.Ok_3;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Updat)
            {
                try
                {
                    Process.Start("PBConfig.exe");
                }
                catch
                {
                    MessageBox.Show(Instancia._strings.CONFIG_ERROR, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Buttons_Visible(bool Start, bool Check, bool Update)
        {
            StartPBox.Visible = Start;
            CheckPBox.Visible = Check;
            UpdatePBox.Visible = Update;
        }
        #endregion

        private void ButtonChangeLanguage_Click(object sender, EventArgs e)
        {
            PBLauncher.ChangeLangauge ChangeLanguage = new PBLauncher.ChangeLangauge();
            ChangeLanguage.Show();
        }
        private void MessageCloseButtonPB(object sender, EventArgs e)
        {

        }
        private void BtnEnglishOnPoint(object sender, EventArgs e)
        {
            EnglishButton.Image = Resources.btn_en_language_onpoint;
        }
        private void BtnEnglishOffPoint(object sender, EventArgs e)
        {
            EnglishButton.Image = Resources.btn_en_language_offpoint1;
        }
        private void BtnIndonesiaOnPoint(object sender, EventArgs e)
        {
            IndonesiaButton.Image = Resources.btn_id_language_onpoint;
        }
        private void BtnIndonesiaOffPoint(object sender, EventArgs e)
        {
            IndonesiaButton.Image = Resources.btn_id_language_offpoint;
        }
    }
}
