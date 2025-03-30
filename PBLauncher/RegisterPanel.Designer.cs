namespace PBLauncher
{
    partial class RegisterPanel
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPanel));
            this.Register_ClickButton = new System.Windows.Forms.PictureBox();
            this.UsernameText = new System.Windows.Forms.Label();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.Label();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.STR_REENTER_PASSWORD = new System.Windows.Forms.Label();
            this.ReInputPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.ExitPBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StringNameRandomCode = new System.Windows.Forms.Label();
            this.STR_RANDOM_CODE = new System.Windows.Forms.Label();
            this.INSERT_RANDOM_CODE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputSecretHint = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowHidePassword = new System.Windows.Forms.CheckBox();
            this.ShowHidePassword2 = new System.Windows.Forms.CheckBox();
            this.ShowHideHint = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Register_ClickButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Register_ClickButton
            // 
            this.Register_ClickButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Register_ClickButton.BackgroundImage")));
            this.Register_ClickButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Register_ClickButton.Location = new System.Drawing.Point(51, 508);
            this.Register_ClickButton.Name = "Register_ClickButton";
            this.Register_ClickButton.Size = new System.Drawing.Size(398, 60);
            this.Register_ClickButton.TabIndex = 0;
            this.Register_ClickButton.TabStop = false;
            this.Register_ClickButton.Click += new System.EventHandler(this.RegisterButton_Click);
            this.Register_ClickButton.MouseLeave += new System.EventHandler(this.RegisterButtonOffPoint);
            this.Register_ClickButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterButtonOnPoint);
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.BackColor = System.Drawing.Color.Transparent;
            this.UsernameText.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic);
            this.UsernameText.ForeColor = System.Drawing.Color.White;
            this.UsernameText.Location = new System.Drawing.Point(46, 55);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(82, 25);
            this.UsernameText.TabIndex = 26;
            this.UsernameText.Text = "Username :";
            // 
            // InputUsername
            // 
            this.InputUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InputUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputUsername.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.InputUsername.Location = new System.Drawing.Point(51, 75);
            this.InputUsername.Multiline = true;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(398, 25);
            this.InputUsername.TabIndex = 27;
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.BackColor = System.Drawing.Color.Transparent;
            this.PasswordText.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic);
            this.PasswordText.ForeColor = System.Drawing.Color.White;
            this.PasswordText.Location = new System.Drawing.Point(46, 110);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(82, 25);
            this.PasswordText.TabIndex = 28;
            this.PasswordText.Text = "Password :";
            // 
            // InputPassword
            // 
            this.InputPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.InputPassword.Location = new System.Drawing.Point(51, 130);
            this.InputPassword.Multiline = true;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '*';
            this.InputPassword.Size = new System.Drawing.Size(300, 25);
            this.InputPassword.TabIndex = 29;
            // 
            // STR_REENTER_PASSWORD
            // 
            this.STR_REENTER_PASSWORD.AutoSize = true;
            this.STR_REENTER_PASSWORD.BackColor = System.Drawing.Color.Transparent;
            this.STR_REENTER_PASSWORD.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic);
            this.STR_REENTER_PASSWORD.ForeColor = System.Drawing.Color.White;
            this.STR_REENTER_PASSWORD.Location = new System.Drawing.Point(46, 165);
            this.STR_REENTER_PASSWORD.Name = "STR_REENTER_PASSWORD";
            this.STR_REENTER_PASSWORD.Size = new System.Drawing.Size(140, 25);
            this.STR_REENTER_PASSWORD.TabIndex = 30;
            this.STR_REENTER_PASSWORD.Text = "Re Enter Password :";
            // 
            // ReInputPassword
            // 
            this.ReInputPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReInputPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReInputPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReInputPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReInputPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReInputPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ReInputPassword.Location = new System.Drawing.Point(51, 185);
            this.ReInputPassword.Multiline = true;
            this.ReInputPassword.Name = "ReInputPassword";
            this.ReInputPassword.PasswordChar = '*';
            this.ReInputPassword.Size = new System.Drawing.Size(300, 25);
            this.ReInputPassword.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Email :";
            // 
            // InputEmail
            // 
            this.InputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEmail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.InputEmail.Location = new System.Drawing.Point(51, 240);
            this.InputEmail.Multiline = true;
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(398, 25);
            this.InputEmail.TabIndex = 33;
            // 
            // ExitPBox
            // 
            this.ExitPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitPBox.Image = global::PBLauncher.Properties.Resources.exit;
            this.ExitPBox.Location = new System.Drawing.Point(460, 12);
            this.ExitPBox.Name = "ExitPBox";
            this.ExitPBox.Size = new System.Drawing.Size(28, 28);
            this.ExitPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPBox.TabIndex = 35;
            this.ExitPBox.TabStop = false;
            this.ExitPBox.Click += new System.EventHandler(this.CloseButton);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 600);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Location = new System.Drawing.Point(497, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 600);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(500, 3);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.Location = new System.Drawing.Point(0, 597);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(500, 3);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(48, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 32);
            this.label2.TabIndex = 40;
            this.label2.Text = "*Dengan mengklik REGISTRY, Anda menyetujui \r\n  Persyaratan, Kebijakan Privasi, da" +
    "n Aturan Yang Terlampir";
            // 
            // StringNameRandomCode
            // 
            this.StringNameRandomCode.AutoSize = true;
            this.StringNameRandomCode.BackColor = System.Drawing.Color.Transparent;
            this.StringNameRandomCode.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StringNameRandomCode.ForeColor = System.Drawing.Color.White;
            this.StringNameRandomCode.Location = new System.Drawing.Point(46, 330);
            this.StringNameRandomCode.Name = "StringNameRandomCode";
            this.StringNameRandomCode.Size = new System.Drawing.Size(94, 25);
            this.StringNameRandomCode.TabIndex = 41;
            this.StringNameRandomCode.Text = "Human Code :";
            // 
            // STR_RANDOM_CODE
            // 
            this.STR_RANDOM_CODE.AutoSize = true;
            this.STR_RANDOM_CODE.BackColor = System.Drawing.Color.Transparent;
            this.STR_RANDOM_CODE.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STR_RANDOM_CODE.ForeColor = System.Drawing.Color.White;
            this.STR_RANDOM_CODE.Location = new System.Drawing.Point(135, 330);
            this.STR_RANDOM_CODE.Name = "STR_RANDOM_CODE";
            this.STR_RANDOM_CODE.Size = new System.Drawing.Size(126, 25);
            this.STR_RANDOM_CODE.TabIndex = 42;
            this.STR_RANDOM_CODE.Text = "STR_RANDOM_CODE";
            // 
            // INSERT_RANDOM_CODE
            // 
            this.INSERT_RANDOM_CODE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.INSERT_RANDOM_CODE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.INSERT_RANDOM_CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.INSERT_RANDOM_CODE.Cursor = System.Windows.Forms.Cursors.Default;
            this.INSERT_RANDOM_CODE.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERT_RANDOM_CODE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.INSERT_RANDOM_CODE.Location = new System.Drawing.Point(227, 355);
            this.INSERT_RANDOM_CODE.Multiline = true;
            this.INSERT_RANDOM_CODE.Name = "INSERT_RANDOM_CODE";
            this.INSERT_RANDOM_CODE.Size = new System.Drawing.Size(139, 25);
            this.INSERT_RANDOM_CODE.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Verification Human Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Secret Hint";
            // 
            // InputSecretHint
            // 
            this.InputSecretHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputSecretHint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InputSecretHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputSecretHint.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputSecretHint.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSecretHint.ForeColor = System.Drawing.Color.RoyalBlue;
            this.InputSecretHint.Location = new System.Drawing.Point(51, 295);
            this.InputSecretHint.Multiline = true;
            this.InputSecretHint.Name = "InputSecretHint";
            this.InputSecretHint.PasswordChar = '*';
            this.InputSecretHint.Size = new System.Drawing.Size(300, 25);
            this.InputSecretHint.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(137, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "*Hint Untuk Melakukan Reset Password";
            // 
            // ShowHidePassword
            // 
            this.ShowHidePassword.AutoSize = true;
            this.ShowHidePassword.BackColor = System.Drawing.Color.Transparent;
            this.ShowHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowHidePassword.Checked = true;
            this.ShowHidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShowHidePassword.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHidePassword.ForeColor = System.Drawing.Color.White;
            this.ShowHidePassword.Location = new System.Drawing.Point(357, 129);
            this.ShowHidePassword.Name = "ShowHidePassword";
            this.ShowHidePassword.Size = new System.Drawing.Size(70, 30);
            this.ShowHidePassword.TabIndex = 48;
            this.ShowHidePassword.Text = "HIDE  ";
            this.ShowHidePassword.UseVisualStyleBackColor = false;
            this.ShowHidePassword.CheckedChanged += new System.EventHandler(this.ShowHideTextPassword);
            // 
            // ShowHidePassword2
            // 
            this.ShowHidePassword2.AutoSize = true;
            this.ShowHidePassword2.BackColor = System.Drawing.Color.Transparent;
            this.ShowHidePassword2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowHidePassword2.Checked = true;
            this.ShowHidePassword2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHidePassword2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShowHidePassword2.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHidePassword2.Location = new System.Drawing.Point(357, 184);
            this.ShowHidePassword2.Name = "ShowHidePassword2";
            this.ShowHidePassword2.Size = new System.Drawing.Size(67, 30);
            this.ShowHidePassword2.TabIndex = 49;
            this.ShowHidePassword2.Text = "HIDE ";
            this.ShowHidePassword2.UseVisualStyleBackColor = false;
            this.ShowHidePassword2.CheckedChanged += new System.EventHandler(this.ShowHideTextRePassword);
            // 
            // ShowHideHint
            // 
            this.ShowHideHint.AutoSize = true;
            this.ShowHideHint.BackColor = System.Drawing.Color.Transparent;
            this.ShowHideHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowHideHint.Checked = true;
            this.ShowHideHint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHideHint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShowHideHint.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHideHint.Location = new System.Drawing.Point(357, 294);
            this.ShowHideHint.Name = "ShowHideHint";
            this.ShowHideHint.Size = new System.Drawing.Size(70, 30);
            this.ShowHideHint.TabIndex = 50;
            this.ShowHideHint.Text = "HIDE  ";
            this.ShowHideHint.UseVisualStyleBackColor = false;
            this.ShowHideHint.CheckedChanged += new System.EventHandler(this.ShowHideTextHintHuman);
            // 
            // RegisterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.ShowHideHint);
            this.Controls.Add(this.ShowHidePassword2);
            this.Controls.Add(this.ShowHidePassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputSecretHint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.INSERT_RANDOM_CODE);
            this.Controls.Add(this.STR_RANDOM_CODE);
            this.Controls.Add(this.StringNameRandomCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitPBox);
            this.Controls.Add(this.InputEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReInputPassword);
            this.Controls.Add(this.STR_REENTER_PASSWORD);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.InputUsername);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.Register_ClickButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPanel";
            ((System.ComponentModel.ISupportInitialize)(this.Register_ClickButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Register_ClickButton;
        private System.Windows.Forms.Label UsernameText;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label STR_REENTER_PASSWORD;
        private System.Windows.Forms.TextBox ReInputPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.PictureBox ExitPBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StringNameRandomCode;
        private System.Windows.Forms.Label STR_RANDOM_CODE;
        private System.Windows.Forms.TextBox INSERT_RANDOM_CODE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputSecretHint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ShowHidePassword;
        private System.Windows.Forms.CheckBox ShowHidePassword2;
        private System.Windows.Forms.CheckBox ShowHideHint;
    }
}