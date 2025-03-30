using System.Resources;

namespace PBLauncher.Login
{
    partial class LoginForm
    {
        public static ResourceManager ResourceManager { get; private set; }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ExitPBox = new System.Windows.Forms.PictureBox();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.Lb_Register = new System.Windows.Forms.Label();
            this.Lb_ForgetPassword = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.PictureBox();
            this.UsernameText = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.MessageBoxPack = new System.Windows.Forms.PictureBox();
            this.Line_Message = new System.Windows.Forms.PictureBox();
            this.OKButtonMessage = new System.Windows.Forms.PictureBox();
            this.STR_MESSAGE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.STR_VERSIIN_LOGIN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageBoxPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line_Message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OKButtonMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitPBox
            // 
            this.ExitPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitPBox.Image = global::PBLauncher.Properties.Resources.exit;
            this.ExitPBox.Location = new System.Drawing.Point(744, 20);
            this.ExitPBox.Name = "ExitPBox";
            this.ExitPBox.Size = new System.Drawing.Size(28, 28);
            this.ExitPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPBox.TabIndex = 9;
            this.ExitPBox.TabStop = false;
            this.ExitPBox.Click += new System.EventHandler(this.pictureBox1_Click);
            this.ExitPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitPBox_MouseDown);
            this.ExitPBox.MouseLeave += new System.EventHandler(this.ExitPBox_MouseLeave);
            this.ExitPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitPBox_MouseMove);
            // 
            // InputUsername
            // 
            this.InputUsername.BackColor = System.Drawing.Color.Black;
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputUsername.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.InputUsername.Location = new System.Drawing.Point(468, 170);
            this.InputUsername.Multiline = true;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(259, 25);
            this.InputUsername.TabIndex = 10;
            this.InputUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPassword_KeyPress);
            // 
            // InputPassword
            // 
            this.InputPassword.BackColor = System.Drawing.Color.Black;
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.InputPassword.Location = new System.Drawing.Point(468, 270);
            this.InputPassword.Multiline = true;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '*';
            this.InputPassword.Size = new System.Drawing.Size(259, 25);
            this.InputPassword.TabIndex = 11;
            this.InputPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPassword_KeyPress);
            // 
            // Lb_Register
            // 
            this.Lb_Register.AutoSize = true;
            this.Lb_Register.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_Register.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Register.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Lb_Register.Location = new System.Drawing.Point(593, 424);
            this.Lb_Register.Name = "Lb_Register";
            this.Lb_Register.Size = new System.Drawing.Size(151, 17);
            this.Lb_Register.TabIndex = 12;
            this.Lb_Register.Text = "Belum Memiliki Akun ?";
            this.Lb_Register.Click += new System.EventHandler(this.Lb_Regist);
            this.Lb_Register.MouseLeave += new System.EventHandler(this.Lb_Regist_OffPoint);
            this.Lb_Register.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lb_Regist_OnPoint);
            // 
            // Lb_ForgetPassword
            // 
            this.Lb_ForgetPassword.AutoSize = true;
            this.Lb_ForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_ForgetPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ForgetPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Lb_ForgetPassword.Location = new System.Drawing.Point(614, 463);
            this.Lb_ForgetPassword.Name = "Lb_ForgetPassword";
            this.Lb_ForgetPassword.Size = new System.Drawing.Size(130, 17);
            this.Lb_ForgetPassword.TabIndex = 13;
            this.Lb_ForgetPassword.Text = "Lupa ID/Password ?";
            this.Lb_ForgetPassword.Click += new System.EventHandler(this.Lb_ForgetPass);
            this.Lb_ForgetPassword.MouseLeave += new System.EventHandler(this.Lb_ForgetPass_OffPoint);
            this.Lb_ForgetPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lb_ForgetPass_OnPoint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox1.Location = new System.Drawing.Point(468, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 21);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Save ID";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Image = global::PBLauncher.Properties.Resources.login_btn_offpoint;
            this.LoginButton.Location = new System.Drawing.Point(468, 339);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(234, 43);
            this.LoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoginButton.TabIndex = 23;
            this.LoginButton.TabStop = false;
            this.LoginButton.Click += new System.EventHandler(this.ButtonLogin_Click);
            this.LoginButton.MouseLeave += new System.EventHandler(this.OffPointButton_Login);
            this.LoginButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPointButton_Login);
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.BackColor = System.Drawing.Color.Transparent;
            this.UsernameText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameText.ForeColor = System.Drawing.Color.DarkGray;
            this.UsernameText.Location = new System.Drawing.Point(464, 148);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(87, 19);
            this.UsernameText.TabIndex = 25;
            this.UsernameText.Text = "Username";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.BackColor = System.Drawing.Color.Transparent;
            this.PasswordText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordText.Location = new System.Drawing.Point(464, 248);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(86, 19);
            this.PasswordText.TabIndex = 26;
            this.PasswordText.Text = "Password";
            // 
            // MessageBoxPack
            // 
            this.MessageBoxPack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MessageBoxPack.Image = global::PBLauncher.Properties.Resources.Warning;
            this.MessageBoxPack.Location = new System.Drawing.Point(200, 170);
            this.MessageBoxPack.Name = "MessageBoxPack";
            this.MessageBoxPack.Size = new System.Drawing.Size(373, 198);
            this.MessageBoxPack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MessageBoxPack.TabIndex = 27;
            this.MessageBoxPack.TabStop = false;
            // 
            // Line_Message
            // 
            this.Line_Message.Image = global::PBLauncher.Properties.Resources.Separador;
            this.Line_Message.Location = new System.Drawing.Point(200, 312);
            this.Line_Message.Name = "Line_Message";
            this.Line_Message.Size = new System.Drawing.Size(373, 8);
            this.Line_Message.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Line_Message.TabIndex = 29;
            this.Line_Message.TabStop = false;
            this.Line_Message.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // OKButtonMessage
            // 
            this.OKButtonMessage.Image = global::PBLauncher.Properties.Resources.Ok_1;
            this.OKButtonMessage.Location = new System.Drawing.Point(329, 326);
            this.OKButtonMessage.Name = "OKButtonMessage";
            this.OKButtonMessage.Size = new System.Drawing.Size(121, 33);
            this.OKButtonMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OKButtonMessage.TabIndex = 28;
            this.OKButtonMessage.TabStop = false;
            this.OKButtonMessage.Click += new System.EventHandler(this.OkConfig_Click);
            this.OKButtonMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitPBox_MouseDown);
            this.OKButtonMessage.MouseLeave += new System.EventHandler(this.OKButtonMessage_OffPoint);
            this.OKButtonMessage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OKButtonMessage_OnPoint);
            // 
            // STR_MESSAGE
            // 
            this.STR_MESSAGE.AllowDrop = true;
            this.STR_MESSAGE.BackColor = System.Drawing.Color.Transparent;
            this.STR_MESSAGE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STR_MESSAGE.ForeColor = System.Drawing.Color.Transparent;
            this.STR_MESSAGE.Image = global::PBLauncher.Properties.Resources.BGLabel;
            this.STR_MESSAGE.Location = new System.Drawing.Point(201, 239);
            this.STR_MESSAGE.Name = "STR_MESSAGE";
            this.STR_MESSAGE.Size = new System.Drawing.Size(371, 35);
            this.STR_MESSAGE.TabIndex = 30;
            this.STR_MESSAGE.Text = "STR_MESSAGE";
            this.STR_MESSAGE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Login Version :";
            // 
            // STR_VERSIIN_LOGIN
            // 
            this.STR_VERSIIN_LOGIN.AutoSize = true;
            this.STR_VERSIIN_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.STR_VERSIIN_LOGIN.Cursor = System.Windows.Forms.Cursors.Default;
            this.STR_VERSIIN_LOGIN.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STR_VERSIIN_LOGIN.ForeColor = System.Drawing.Color.DodgerBlue;
            this.STR_VERSIIN_LOGIN.Location = new System.Drawing.Point(111, 504);
            this.STR_VERSIIN_LOGIN.Name = "STR_VERSIIN_LOGIN";
            this.STR_VERSIIN_LOGIN.Size = new System.Drawing.Size(136, 17);
            this.STR_VERSIIN_LOGIN.TabIndex = 32;
            this.STR_VERSIIN_LOGIN.Text = "STR_VERSION_LOGIN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 530);
            this.Controls.Add(this.STR_VERSIIN_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.STR_MESSAGE);
            this.Controls.Add(this.Line_Message);
            this.Controls.Add(this.OKButtonMessage);
            this.Controls.Add(this.MessageBoxPack);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.Lb_Register);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Lb_ForgetPassword);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputUsername);
            this.Controls.Add(this.ExitPBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ExitPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageBoxPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line_Message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OKButtonMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitPBox;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label Lb_Register;
        private System.Windows.Forms.Label Lb_ForgetPassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox LoginButton;
        private System.Windows.Forms.Label UsernameText;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.PictureBox MessageBoxPack;
        private System.Windows.Forms.PictureBox Line_Message;
        private System.Windows.Forms.PictureBox OKButtonMessage;
        private System.Windows.Forms.Label STR_MESSAGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label STR_VERSIIN_LOGIN;
    }
}