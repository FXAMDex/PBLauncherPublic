﻿/*
 * Arquivo: PleaseWait.cs
 * Criado em: 23-11-2021
 * Última modificação: 04-06-2022
 */
using Core;
using Ionic.Zip;
using Npgsql;
using PBLauncher.AMDex;
using PBLauncher.Utils;
using PBLauncher.Utils.Enum;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLauncher
{
    public partial class PleaseWait : Form
    {
        public PleaseWait()
        {
            InitializeComponent();
            DeleteFileLog();
        }

        private async void PleaseWait_Load(object sender, EventArgs e)
        {
            lb_loading.Text = Instancia._strings.LOADING;
            Logger.Log("");
            Logger.Log("============================================");
            Logger.Log("[<>][" + Connect.GameName + "] Loaded.");
            Logger.Log("[!] Launcher Version: " + Application.ProductVersion);
            Logger.Log("[-] MachineName: " + Environment.MachineName);
            Logger.Log("[-] UserName: " + Environment.UserName);
            Logger.Log("[X] Is64BitOperatingSystem: " + Environment.Is64BitOperatingSystem);
            Logger.Log("[X] Is64BitProcess: " + Environment.Is64BitProcess);
            Logger.Log("[X] Region Machine: " + AMDexCustom.GetRegionData());
            Logger.Log("============================================");
            Logger.Log("");

            if (!CheckLF())
                Close();
            else
            {
                BAN();
                await Task.Delay(5);
                lb_loading.Text = Instancia._strings.CONNECTING_TO_SERVER;
                await Task.Delay(1000);
                CallDatabase.ValidateDevice();
                Status(await Connect.GetHostInfo());
                //AMDexCustom.GetPublicIpv6Address();
                //Logger.Log(AMDexCustom.GetPublicIpv6Address());
                //AMDexCustom.Test();
            }

        }

        /// <summary>
        /// Verifica se já existe um processo do launcher ou do jogo aberto
        /// </summary>
        /// <returns></returns>
        /// 

        private void DeleteFileLog()
        {
            string filename = "PBLauncher.log";
            if (File.Exists(filename))
            {
               File.Delete(filename);
            }
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
        private void CheckStringFile()
        {
            if (!File.Exists(string.Concat("\\StringEN.xml")))
            {
                MessageBox.Show("Unable To Find String [EN] Launcher");
                Application.Exit();
            }
            
        }
        private bool CheckLF()
        {
            lb_loading.Text = Instancia._strings.CHECK_IMPORTANT_FILES;
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                Logger.Log("[!] There is no Launcher window open.");
                MessageBox.Show(Instancia._strings.LAUNCHER_RUNNING, Connect.GameName);
                return false;
            }
            else if (Process.GetProcessesByName("PointBlank").Length > 0)
            {
                Logger.Log("[!] There is already a game window open.");
                MessageBox.Show(Instancia._strings.GAME_RUNNING, Connect.GameName);
                return false;
            }
            else if (!File.Exists(string.Concat(Application.StartupPath, "\\UserFileList.dat")))
            {
                StreamWriter streamWriter = new StreamWriter(string.Concat(Application.StartupPath, "\\UserFileList.dat"));
                streamWriter.Close();
            }
            lb_loading.Text = Instancia._strings.CONNECTING_TO_SERVER;
            Logger.Log("[LAUNCHER_CONNECT_STATUS] ->> Try Connect To Server...");
            return true;
        }

        private async void Status(HostStatus p)
        {
            if (p != HostStatus.UNK && await CheckLauncherUpdate() || p == HostStatus.UNK)
            {

                lb_loading.Text = Instancia._strings.CHECK_SERVER_STATUS;
                Logger.Log("[LAUNCHER_CHECKING_STATUS] ->> Prepare To Connect Server...");
                switch (p)
                {
                    case HostStatus.MAINTENANCE:
                        Logger.Log("[<<] [SERVER_MESSAGE_ALLERT] ->> Maintenance");
                        MessageBox.Show(Instancia._strings.SERVER_MAINTENANCE, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        break;
                    case HostStatus.MAINTENANCEALERT:
                        if (string.IsNullOrEmpty(Connect._message))
                            goto case HostStatus.MAINTENANCE;
                        Logger.Log("[<<] [SERVER_MESSAGE_ALLERT] ->> " + Connect._message);
                        MessageBox.Show(Connect._message, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        Close();
                        break;
                    case HostStatus.ONLINE:
                    case HostStatus.ONLINEALERT:
                        Userlist_check();
                        break;
                    case HostStatus.OFFLINE:
                        Logger.Log("[<<] [SERVER_CONNECT_INTERUPT] ->> Unknown Host Server");
                        MessageBox.Show(Instancia._strings.CONNECTION_LOST, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        break;
                    default:
                        Logger.Log("[<<] [SERVER_CONNECT_INFO] ->> Server Not Responding Code 404");
                        MessageBox.Show(Instancia._strings.SERVER_CONNECTION_UNKNOWN, "MAINTENANCE - " + Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        break;

                }
            }
        }


        /// <summary>
        /// Verifica se a versão do PBLauncher em execução é a mesma da vps
        /// </summary>
        /// <returns></returns>
        private async Task<bool> CheckLauncherUpdate()
        {
            lb_loading.Text = Instancia._strings.CHECK_LAUNCHER_UPDATE;

            //Pausa pra atualizar o label
            await Task.Delay(1);

            if (Connect._launcherVer.Equals(Application.ProductVersion))

                //Versão atual está atualizada
                return true;
             
            //Vamos atualizar
            else 
            {
                using (WebClient WCL = new WebClient())
                {
                    WCL.DownloadFileCompleted += new AsyncCompletedEventHandler(WCL_DownloadCompleted);
                    WCL.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WCL_DownloadProgressChanged);
                    try
                    {
                        Logger.Log("[!] [LAUNCHER_VERSION_CHECK] ->> Old Version");
                        Logger.Log("[LAUNCHER_VERSION_CHECK] ->> Try To Download New Version");
                        Directory.CreateDirectory(string.Concat(Application.StartupPath, "\\_LauncherPatchFiles"));
                        Uri uri = new Uri(Connect._fileURL + "//PBLauncher.zip");
                        await WCL.DownloadFileTaskAsync(uri, string.Concat(Application.StartupPath, "\\_LauncherPatchFiles\\PBLauncher.zip"));
                    }
                    catch (Exception ex)
                    {
                        lb_loading.Text = Instancia._strings.LAUNCHER_UPDATE_ERROR;
                        Logger.Log("[!] Ocorreu um erro ao baixar a Atualização do Launcher! -> " + ex.Message);
                        MessageBox.Show(Instancia._strings.LAUNCHER_UPDATE_ERROR, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
                return false;
            }
        }

        public async void Userlist_check()
        {
            try
            {
                string LocalMD5checksum = Get.FileMD5(string.Concat(Application.StartupPath, "\\UserFileList.dat"));
                if (Connect._userList.Equals(LocalMD5checksum))
                {
                    lb_loading.Text = Instancia._strings.DELET_TRASH;
                    await Clear.Trash();
                    OpenMain();
                }
                else
                {
                    lb_loading.Text = Instancia._strings.DOWNLOAD_FILE;
                    await Task.Delay(100);
                    using (WebClient WCU = new WebClient())
                    {
                        Logger.Log("[LAUNCHER_MISSING_FILE] ->> Try To Download...");
                        Directory.CreateDirectory(string.Concat(Application.StartupPath, "\\_LauncherPatchFiles"));
                        Uri uri = new Uri(Connect._fileURL + "//UserFileList.zip");
                        WCU.DownloadFile(uri, string.Concat(Application.StartupPath, "\\_LauncherPatchFiles\\UserFileList.zip"));
                        lb_loading.Text = Instancia._strings.EXTRACT_FILE;
                        Unzip(Application.StartupPath, string.Concat(Application.StartupPath, "\\_LauncherPatchFiles\\UserFileList.zip"));
                        await Task.Delay(100);
                        lb_loading.Text = Instancia._strings.DELET_TRASH;
                        await Clear.Trash(); 
                        OpenMain();
                    }
                }
            }
            catch
            {
                Logger.Log("[LAUNCHER_SENDING_REQUEST] ->> Failed To Download");
                MessageBox.Show(Instancia._strings.DOWNLOAD_USERLIST_ERROR, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public void Unzip(string TargetDir, string ZipToUnpack)
        {
            try
            {
                ZipFile zipFile = ZipFile.Read(ZipToUnpack);
                try
                {
                    foreach (ZipEntry zipEntry in zipFile)
                    {
                        zipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                finally
                {
                    if (zipFile != null)
                    {
                        zipFile.Dispose();
                    }
                }
            }
            catch 
            {
               
            }
        }

        private void OpenMain()
        {
            Instancia._main = new MainForm()
            {
                BackgroundImage = Core.Properties.Resources.bg
            };
            Instancia._main.Closed += (s, args) => Close();
            Hide();
            Instancia._main.Show();
        }

        private void WCL_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lb_loading.Text = string.Format(Instancia._strings.DOWNLOAD_LAUNCHER_UPDATE + "{0}/{1} MB", (e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), (e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
        }

        private async void WCL_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                lb_loading.Text = Instancia._strings.EXTRACT_FILE_UPDATE;
                await Task.Delay(2); //Pausa
                string startupPath = Application.StartupPath;
                object[] newLaunch = new object[] { Application.StartupPath, "\\_LauncherPatchFiles\\PBLauncher.zip" };
                Unzip(startupPath, string.Concat(newLaunch));
                Application.Restart();
            }

        }

        private void CEDetect_Tick(object sender, EventArgs e)
        {
           
         try
            {
                Process[] processes = Process.GetProcessesByName("cheatengine-x86_64-SSE4-AVX2");
                if (processes.Length == 0)
                {
                    //CE fechado      

                }
                else
                {
                    //CE aberto
                    CEDetect.Enabled = false;
                    WebClient banWEBCLIENT = new WebClient();
                    banWEBCLIENT.DownloadFile(Connect._banPermURL, (Application.StartupPath + "\\Gui\\ban.ban"));
                }

            }
               
                 catch (Exception arg)
            {
               // Logger.Log("[!] Erro [" + arg.Message + "]");
            }
        }
    }
}
