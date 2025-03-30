using Core.Properties;
using Npgsql;
using PBLauncher.AMDex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using Resources = PBLauncher.Properties.Resources;

namespace PBLauncher
{
    public partial class RegisterPanel : Form
    {
        public RegisterPanel()
        {
            InitializeComponent();
            RandomCodeNumber();
            //ShowHideText();
        }

        private string originalText;
        private void RandomCodeNumber()
        {
            Random random = new Random();
            string chars = "0123456789";
            string code = "";
            for (int i = 0; i < 6; i++)
            {
                code += chars[random.Next(0, chars.Length)];
            }
            STR_RANDOM_CODE.Text = code;
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                // TextBox Input & String Output
                string username = InputUsername.Text.Trim();
                string password = InputPassword.Text.Trim();
                string reEnterPassword = ReInputPassword.Text.Trim();
                string email = InputEmail.Text.Trim();
                string verif_human = INSERT_RANDOM_CODE.Text.Trim();
                string code_verif_human = STR_RANDOM_CODE.Text;
                string secret_hint = InputSecretHint.Text.Trim();


                string lastip = AMDexCustom.GetPublicIpAddress();
                string lasthwid = AMDexCustom.GetHwid();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(reEnterPassword))
                {
                    MessageBox.Show("Semua Data harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (username.Length < 4 || username.Length > 16)
                {
                    MessageBox.Show("Username harus minimal 4 karakter dan maksimal 16 karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password.Length < 4 || password.Length > 16)
                {
                    MessageBox.Show("Password harus minimal 4 karakter dan maksimal 16 karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (email != null)
                {
                    MessageBox.Show("Email tidak boleh kosong!");
                    return;
                }

                if (!email.Contains("@gmail.com") && !email.Contains("@yahoo.com"))
                {
                    MessageBox.Show("Email harus berupa @gmail.com atau @yahoo.com!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password != reEnterPassword)
                {
                    MessageBox.Show("Password & Re Password tidak Sesuai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (verif_human != code_verif_human)
                {
                    MessageBox.Show("Human Code Tidak Valid, Silahkan Isi Secara Tepat !!");
                    RandomCodeNumber();
                    return;
                }

                string connectionString = CallDatabase.DBConfig.DBCallConfig;
                string query = "SELECT * FROM accounts WHERE login = @login OR email = @email";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", username);
                        command.Parameters.AddWithValue("@email", email);

                        NpgsqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            if (reader["login"].ToString() == username)
                            {
                                MessageBox.Show("Username Telah Digunakan Oleh Pengguna Lain!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (reader["email"].ToString() == email)
                            {
                                MessageBox.Show("Email Telah Digunakan Oleh Pengguna Lain!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            return;
                        }
                    }
                }

                // Save To Database
                query = "INSERT INTO accounts (login, password, lastip, email, token, hwid, hint) VALUES (@login, @password, @lastip, @email, @token, @hwid, @hint)";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@lastip", lastip);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@token", password);
                        command.Parameters.AddWithValue("@hwid", lasthwid);
                        command.Parameters.AddWithValue("@hint", secret_hint);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Register Berhasil", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void DefaultChecked()
        {
            
        }
        private void ShowHideTextPassword(object sender, EventArgs e)
        {
            if (ShowHidePassword.Checked)
            {
                originalText = InputPassword.Text;
                InputPassword.PasswordChar = '*';
                InputPassword.Text = new string('*', originalText.Length);
            }
            else
            {
                InputPassword.PasswordChar = '\0';
                InputPassword.Text = originalText;
            }
        }
        private void ShowHideTextRePassword(object sender, EventArgs e)
        {
            if (ShowHidePassword2.Checked)
            {
                originalText = ReInputPassword.Text;
                ReInputPassword.PasswordChar = '*';
                ReInputPassword.Text = new string('*', originalText.Length);
            }
            else
            {
                ReInputPassword.PasswordChar = '\0';
                ReInputPassword.Text = originalText;
            }
        }
        private void ShowHideTextHintHuman(object sender, EventArgs e)
        {
            if (ShowHideHint.Checked)
            {
                originalText = InputSecretHint.Text;
                InputSecretHint.PasswordChar = '*';
                InputSecretHint.Text = new string('*', originalText.Length);
            }
            else
            {
                InputSecretHint.PasswordChar = '\0';
                InputSecretHint.Text = originalText;
            }
        }
        private void RegisterButtonOnPoint(object sender, EventArgs e)
        {
            Register_ClickButton.Image = Resources.btn_register_onpoint;
        }
        private void RegisterButtonOffPoint(object sender, EventArgs e)
        {
            Register_ClickButton.Image = Resources.btn_register_offpoint;
        }
        private void CloseButton_OffPoint(object sender, EventArgs e)
        {
            ExitPBox.Image = Resources.exit;
        }
        private void CloseButton_OnPoint(object sender, EventArgs e)
        {
            ExitPBox.Image = Resources.exit_mouse;
        }
        private void CloseButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
