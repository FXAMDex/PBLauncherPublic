using Core;
using Core.Properties;
using Npgsql;
using NpgsqlTypes;
using PBLauncher.AMDex;
using PBLauncher.Properties;
using PBLauncher.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Resources = PBLauncher.Properties.Resources;

namespace PBLauncher.Login
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            Load += UserSaveLoad;
            HideFormImage();
            GetInfoVersionLogin();
        }

        private string connectionString = CallDatabase.DBConfig.DBCallConfig.ToString();
        private string phpUrl = "http://server.spacegridgame.xyz/HTDOCS/hash_encoder.php";

        private void HideFormImage()
        {
            MessageBoxPack.Hide();
            OKButtonMessage.Hide();
            Line_Message.Hide();
            STR_MESSAGE.Hide();
        }
        private void ShowFormImage()
        {
            STR_MESSAGE.Show();
            STR_MESSAGE.Text = Instancia._strings.MAINTENANCE_FEATURE;
            OKButtonMessage.Show();
            Line_Message.Show();
            MessageBoxPack.Show();
        }
        private void MessageNullID()
        {
            STR_MESSAGE.Show();
            STR_MESSAGE.Text = Instancia._strings.ID_PASSWORD_NULL;
            OKButtonMessage.Show();
            Line_Message.Show();
            MessageBoxPack.Show();
        }
        private void MessageWrongPassOrID()
        {
            STR_MESSAGE.Show();
            STR_MESSAGE.Text = Instancia._strings.WRONG_ID_PASSWORD;
            OKButtonMessage.Show();
            Line_Message.Show();
            MessageBoxPack.Show();
        }
        private void MessageErrorTypeLogin()
        {
            STR_MESSAGE.Show();
            STR_MESSAGE.Text = "Error Launcher Login Code Type!\nPlease Contact Administrator";
            OKButtonMessage.Show();
            Line_Message.Show();
            MessageBoxPack.Show();
        }
        private void GetInfoVersionLogin()
        {
            STR_VERSIIN_LOGIN.Text = Connect.VersionGameLogin;
        }
        private string GenerateTokenPHPV42()
        {
            string url = "http://localhost/HTDOCS/settoken.php";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result;
            }
        }
        private void InputPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // 13 adalah kode ASCII untuk tombol Enter
            {
                MessageBox.Show(Instancia._strings.CLICK_LOGIN);
                e.Handled = true;
            }
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string VersionLoginPB = Connect.VersionGameLogin;
            string VersionPBv142 = "1.15.42";
            string VersionPBv316 = "3.16.1711";
            string VersionPBv324 = "3.24";
            string VersionPBv330 = "3.30.1807";
            string VersionPBv368 = "3.68";
            try
            {
                if (VersionLoginPB == "1.15.42")
                {
                    RunGameV11542();
                }
                else if (VersionLoginPB == "3.16.1711")
                {
                    RunGameV316RU();
                }
                else if (VersionLoginPB == "3.24")
                {
                    RunGameV324TH();
                }
                else if (VersionLoginPB == "3.30")
                {
                    RunGameV330ID();
                }
                else if (VersionLoginPB == "3.68")
                {
                    RunGameV368();
                }
                else if (
                    VersionLoginPB != VersionPBv316 ||
                    VersionLoginPB != VersionPBv142 ||
                    VersionLoginPB != VersionPBv330 ||
                    VersionLoginPB != VersionPBv368)

                {
                    MessageErrorTypeLogin();
                }
            }
            catch (Exception ex)
            {
                Logger.Log("[!] Kesalahan: " + ex.Message);
                MessageBox.Show("Kesalahan: " + ex.Message, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        private async Task<string> GetHashedPassword(string password)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(phpUrl, new StringContent("password=" + password, Encoding.UTF8, "application/x-www-form-urlencoded"));
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
        private bool ValidasiLoginV1(string login, string hashedPassword)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT password FROM accounts WHERE login = @login";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);

                    string storedHashedPassword = (string)cmd.ExecuteScalar();
                    return storedHashedPassword == hashedPassword;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message);
                return false;
            }
        }
        private bool ValidasiLoginV3(string login, string password)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT password FROM accounts WHERE login = @login";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@login", NpgsqlDbType.Varchar).Value = login;
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string storedPassword = reader["password"].ToString();
                                if (storedPassword == password)
                                {
                                    //Logger.Log("Login berhasil");
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Logger.Log("Kesalahan Server Database: " + ex.Message + " " + ex.InnerException);
                return false;
            }
            catch (Exception ex)
            {
                Logger.Log("Kesalahan: " + ex.Message + " " + ex.InnerException);
                return false;
            }
            return false;
        }
        private async void RunGameV11542()
        {
            try
            {
                string username = InputUsername.Text;
                string password = InputPassword.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageNullID();
                    return;
                }

                string hashedPassword = await GetHashedPassword(password);

                if (ValidasiLoginV1(username, hashedPassword))
                {
                    if (Connect._useXCLoader == "1") // ON GUARD
                    {
                        await CallDatabase.ValidateDevice();
                        //LoginButton.Visible = false;
                        this.Hide();
                        await Task.Delay(10);
                        string spinnetACPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "SpinnetAC.exe");
                        string pointBlankPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "PointBlank.exe");
                        if (File.Exists(spinnetACPath))
                        {
                            Process.Start(spinnetACPath);
                            await Task.Delay(10);
                            if (File.Exists(pointBlankPath))
                            {
                                string connectionString = CallDatabase.DBConfig.DBCallConfig;
                                string query = "UPDATE accounts SET hwid = @hwid WHERE login = @login";
                                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                                {
                                    connection.Open();
                                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@hwid", AMDexCustom.GetHwid());
                                        command.Parameters.AddWithValue("@login", username);
                                        command.ExecuteNonQuery();
                                    }
                                }
                                Process.Start(Application.StartupPath + @"\PointBlank.exe", Connect._keyHost ? Connect._launcherKey.ToString() : Param.key_dll);
                                Application.Exit();
                            }
                            else
                            {
                                MessageBox.Show(Instancia._strings.GAME_NOT_FOUND, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(Instancia._strings.GAME_NOT_FOUND, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (Connect._useXCLoader == "0") //Off Guard
                    {
                        await CallDatabase.ValidateDevice();
                        //LoginButton.Visible = false;
                        this.Hide();
                        await Task.Delay(10);
                        string pointBlankPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "PointBlank.exe");
                        if (File.Exists(pointBlankPath))
                        {
                            string connectionString = CallDatabase.DBConfig.DBCallConfig;
                            string query = "UPDATE accounts SET hwid = @hwid WHERE login = @login";
                            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                            {
                                connection.Open();
                                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@hwid", AMDexCustom.GetHwid());
                                    command.Parameters.AddWithValue("@login", username);
                                    command.ExecuteNonQuery();
                                }
                            }
                            Process.Start(Application.StartupPath + @"\PointBlank.exe", Connect._keyHost ? Connect._launcherKey.ToString() : Param.key_dll);
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show(Instancia._strings.GAME_NOT_FOUND, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Application.Exit();
                }
                else
                {
                    MessageWrongPassOrID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex);
            }
        }
        private async void RunGameV316RU()
        {
            try
            {
                string username = InputUsername.Text;
                string password = InputPassword.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageNullID();
                    return;
                }

                if (ValidasiLoginV3(username, password))
                {
                    if (Connect._useXCLoader == "1") // ON GUARD
                    {
                        await CallDatabase.ValidateDevice();
                        //LoginButton.Visible = false;
                        this.Hide();
                        await Task.Delay(10);
                        string spinnetACPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "SpinnetAC.exe");
                        string pointBlankPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "PointBlank.exe");
                        if (File.Exists(spinnetACPath))
                        {
                            Process.Start(spinnetACPath);
                            await Task.Delay(10);
                            if (File.Exists(pointBlankPath))
                            {
                                string connectionString = CallDatabase.DBConfig.DBCallConfig;
                                string query = "UPDATE accounts SET hwid = @hwid WHERE login = @login";
                                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                                {
                                    connection.Open();
                                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@hwid", AMDexCustom.GetHwid());
                                        command.Parameters.AddWithValue("@login", username);
                                        command.ExecuteNonQuery();
                                    }
                                }
                                Process.Start(Application.StartupPath + @"\PointBlank.exe", " " + password + " " + password);
                                Application.Exit();
                            }
                            else
                            {
                                MessageBox.Show(Instancia._strings.GAME_NOT_FOUND, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(Instancia._strings.GAME_NOT_FOUND, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (Connect._useXCLoader == "0") // OFF GUARD
                    {
                        await CallDatabase.ValidateDevice();
                        //LoginButton.Visible = false;
                        this.Hide();
                        await Task.Delay(10);
                        string spinnetACPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "SpinnetAC.exe");
                        string pointBlankPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "PointBlank.exe");
                        if (File.Exists(pointBlankPath))
                        {
                            string connectionString = CallDatabase.DBConfig.DBCallConfig;
                            string query = "UPDATE accounts SET hwid = @hwid WHERE login = @login";
                            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                            {
                                connection.Open();
                                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@hwid", AMDexCustom.GetHwid());
                                    command.Parameters.AddWithValue("@login", username);
                                    command.ExecuteNonQuery();
                                }
                            }
                            Process.Start(Application.StartupPath + @"\PointBlank.exe", " " + password + " " + password);
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show(Instancia._strings.GAME_NOT_FOUND, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Application.Exit();
                }
                else
                {
                    MessageWrongPassOrID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex);
            }
        }
        private async void RunGameV324TH()
        {

        }
        private async void RunGameV330ID()
        {

        }
        private async void RunGameV368()
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SimpanUsername();
            }
        }

        public class ChipperEncryption
        {
            private static readonly string password = "your_password";

            public static string Encrypt(string plaintext)
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

            public static string Decrypt(string ciphertext)
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

        private void SimpanUsername()
        {
            string path = "Config/Config.Data";
            string usernameBaru = ChipperEncryption.Encrypt(InputUsername.Text);

            if (File.Exists(path))
            {
                string usernameLama = ChipperEncryption.Decrypt(File.ReadAllText(path));

                if (usernameLama != InputUsername.Text)
                {
                    File.WriteAllText(path, usernameBaru);
                    //MessageBox.Show("Username diperbarui");
                }
            }
            else
            {
                File.WriteAllText(path, usernameBaru);
                //MessageBox.Show("Username disimpan");
            }
        }

        private void UserSaveLoad(object sender, EventArgs e)
        {
            string path = "Config/Config.Data";

            if (File.Exists(path))
            {
                string ciphertext = File.ReadAllText(path);
                string username = ChipperEncryption.Decrypt(ciphertext);
                InputUsername.Text = username;
                checkBox1.Checked = true;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Button Base
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
        private void OnPointButton_Login(object sender, EventArgs e)
        {
            LoginButton.Image = Resources.login_btn_onpoint;
        }
        private void OffPointButton_Login(Object sender, EventArgs e)
        {
            LoginButton.Image = Resources.login_btn_offpoint;
        }
        #endregion

        private void Lb_Regist(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://www.spacegridgame.xyz/register");
            PBLauncher.RegisterPanel Registerform = new PBLauncher.RegisterPanel();
            Registerform.Show();
        }
        private void Lb_Regist_OnPoint(object sender, EventArgs e)
        {
            Lb_Register.ForeColor = Color.White;
        }
        private void Lb_Regist_OffPoint(object sender, EventArgs e)
        {
            Lb_Register.ForeColor = Color.DodgerBlue;
        }
        private void Lb_ForgetPass(object sender, EventArgs e)
        {
            ShowFormImage();
        }
        private void Lb_ForgetPass_OnPoint(object sender, EventArgs e)
        {
            Lb_ForgetPassword.ForeColor = Color.White;
        }
        private void Lb_ForgetPass_OffPoint(object sender, EventArgs e)
        {
            Lb_ForgetPassword.ForeColor = Color.DodgerBlue;
        }
        private void OKButtonMessage_OnPoint(Object sender, EventArgs e)
        {
            OKButtonMessage.Image = Resources.Ok_3;
        }
        private void OKButtonMessage_OffPoint(Object sender, EventArgs e)
        {
            OKButtonMessage.Image = Resources.Ok_1;
        }

        private void OkConfig_Click(object sender, EventArgs e)
        {
            MessageBoxPack.Visible = false;
            Line_Message.Visible = false;
            OKButtonMessage.Visible = false;
            STR_MESSAGE.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Lb_Regist_OnPoint(object sender, MouseEventArgs e)
        {

        }
    }
}
