/*
 * Arquivo: MainForm.Designer.cs
 * Criado em: 23-11-2021
 * Última modificação: 23-11-2021
 */
namespace PBLauncher
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.EnglishButton = new System.Windows.Forms.PictureBox();
            this.IndonesiaButton = new System.Windows.Forms.PictureBox();
            this.ConfigPBox = new System.Windows.Forms.PictureBox();
            this.MinPBox = new System.Windows.Forms.PictureBox();
            this.ExitPBox = new System.Windows.Forms.PictureBox();
            this.panel_end = new System.Windows.Forms.Panel();
            this.LDownload = new System.Windows.Forms.Label();
            this.Total_Bar = new System.Windows.Forms.PictureBox();
            this.Arquivo_Bar = new System.Windows.Forms.PictureBox();
            this.LTotalFixo = new System.Windows.Forms.Label();
            this.LAquivoFixo = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.Total_BarFixo = new System.Windows.Forms.PictureBox();
            this.Arquivo_BarFixo = new System.Windows.Forms.PictureBox();
            this.LArquivo = new System.Windows.Forms.Label();
            this.CheckPBox = new System.Windows.Forms.PictureBox();
            this.StartPBox = new System.Windows.Forms.PictureBox();
            this.UpdatePBox = new System.Windows.Forms.PictureBox();
            this.PBDetect = new System.Windows.Forms.Timer(this.components);
            this.LauncherConfig = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.OkConfig = new System.Windows.Forms.PictureBox();
            this.ConfigBox = new System.Windows.Forms.PictureBox();
            this.WEB_Announce = new System.Windows.Forms.WebBrowser();
            this.BackGround = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnglishButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndonesiaButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPBox)).BeginInit();
            this.panel_end.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_BarFixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_BarFixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePBox)).BeginInit();
            this.LauncherConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OkConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.Controls.Add(this.EnglishButton);
            this.panel_top.Controls.Add(this.IndonesiaButton);
            this.panel_top.Controls.Add(this.ConfigPBox);
            this.panel_top.Controls.Add(this.MinPBox);
            this.panel_top.Controls.Add(this.ExitPBox);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(791, 33);
            this.panel_top.TabIndex = 0;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // EnglishButton
            // 
            this.EnglishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnglishButton.Image = global::PBLauncher.Properties.Resources.btn_en_language_offpoint1;
            this.EnglishButton.Location = new System.Drawing.Point(127, 6);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(92, 24);
            this.EnglishButton.TabIndex = 27;
            this.EnglishButton.TabStop = false;
            this.EnglishButton.Click += new System.EventHandler(this.ButtonChangeLanguage_Click);
            this.EnglishButton.MouseLeave += new System.EventHandler(this.BtnEnglishOffPoint);
            this.EnglishButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnEnglishOnPoint);
            // 
            // IndonesiaButton
            // 
            this.IndonesiaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IndonesiaButton.Image = global::PBLauncher.Properties.Resources.btn_id_language_blockpoint;
            this.IndonesiaButton.Location = new System.Drawing.Point(35, 6);
            this.IndonesiaButton.Name = "IndonesiaButton";
            this.IndonesiaButton.Size = new System.Drawing.Size(92, 24);
            this.IndonesiaButton.TabIndex = 26;
            this.IndonesiaButton.TabStop = false;
            this.IndonesiaButton.Click += new System.EventHandler(this.ButtonChangeLanguage_Click);
            this.IndonesiaButton.MouseLeave += new System.EventHandler(this.BtnIndonesiaOffPoint);
            this.IndonesiaButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnIndonesiaOnPoint);
            // 
            // ConfigPBox
            // 
            this.ConfigPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfigPBox.Image = global::PBLauncher.Properties.Resources.config;
            this.ConfigPBox.Location = new System.Drawing.Point(4, 4);
            this.ConfigPBox.Name = "ConfigPBox";
            this.ConfigPBox.Size = new System.Drawing.Size(25, 25);
            this.ConfigPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConfigPBox.TabIndex = 10;
            this.ConfigPBox.TabStop = false;
            this.ConfigPBox.Click += new System.EventHandler(this.ConfigPBox_Click);
            this.ConfigPBox.MouseLeave += new System.EventHandler(this.ConfigPBox_MouseLeave);
            this.ConfigPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfigPBox_MouseMove);
            // 
            // MinPBox
            // 
            this.MinPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinPBox.Image = global::PBLauncher.Properties.Resources.minim;
            this.MinPBox.Location = new System.Drawing.Point(732, 4);
            this.MinPBox.Name = "MinPBox";
            this.MinPBox.Size = new System.Drawing.Size(25, 25);
            this.MinPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinPBox.TabIndex = 9;
            this.MinPBox.TabStop = false;
            this.MinPBox.Click += new System.EventHandler(this.MinPBox_Click);
            this.MinPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinPBox_MouseDown);
            this.MinPBox.MouseLeave += new System.EventHandler(this.MinPBox_MouseLeave);
            this.MinPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MinPBox_MouseMove);
            // 
            // ExitPBox
            // 
            this.ExitPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitPBox.Image = global::PBLauncher.Properties.Resources.exit;
            this.ExitPBox.Location = new System.Drawing.Point(763, 4);
            this.ExitPBox.Name = "ExitPBox";
            this.ExitPBox.Size = new System.Drawing.Size(25, 25);
            this.ExitPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPBox.TabIndex = 8;
            this.ExitPBox.TabStop = false;
            this.ExitPBox.Click += new System.EventHandler(this.ExitPBox_Click);
            this.ExitPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitPBox_MouseDown);
            this.ExitPBox.MouseLeave += new System.EventHandler(this.ExitPBox_MouseLeave);
            this.ExitPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitPBox_MouseMove);
            // 
            // panel_end
            // 
            this.panel_end.BackColor = System.Drawing.Color.Transparent;
            this.panel_end.Controls.Add(this.LDownload);
            this.panel_end.Controls.Add(this.Total_Bar);
            this.panel_end.Controls.Add(this.Arquivo_Bar);
            this.panel_end.Controls.Add(this.LTotalFixo);
            this.panel_end.Controls.Add(this.LAquivoFixo);
            this.panel_end.Controls.Add(this.LTitulo);
            this.panel_end.Controls.Add(this.Total_BarFixo);
            this.panel_end.Controls.Add(this.Arquivo_BarFixo);
            this.panel_end.Controls.Add(this.LArquivo);
            this.panel_end.Controls.Add(this.CheckPBox);
            this.panel_end.Controls.Add(this.StartPBox);
            this.panel_end.Controls.Add(this.UpdatePBox);
            this.panel_end.Location = new System.Drawing.Point(0, 441);
            this.panel_end.Name = "panel_end";
            this.panel_end.Size = new System.Drawing.Size(791, 90);
            this.panel_end.TabIndex = 1;
            this.panel_end.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.panel_end.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // LDownload
            // 
            this.LDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LDownload.BackColor = System.Drawing.Color.Transparent;
            this.LDownload.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDownload.ForeColor = System.Drawing.Color.White;
            this.LDownload.Location = new System.Drawing.Point(373, 24);
            this.LDownload.Name = "LDownload";
            this.LDownload.Size = new System.Drawing.Size(102, 15);
            this.LDownload.TabIndex = 28;
            this.LDownload.Text = "0/0 MB";
            this.LDownload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LDownload.Visible = false;
            this.LDownload.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LDownload.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // Total_Bar
            // 
            this.Total_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Total_Bar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Total_Bar.Location = new System.Drawing.Point(12, 72);
            this.Total_Bar.Name = "Total_Bar";
            this.Total_Bar.Size = new System.Drawing.Size(463, 10);
            this.Total_Bar.TabIndex = 25;
            this.Total_Bar.TabStop = false;
            this.Total_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.Total_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // Arquivo_Bar
            // 
            this.Arquivo_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Arquivo_Bar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Arquivo_Bar.Location = new System.Drawing.Point(12, 40);
            this.Arquivo_Bar.Name = "Arquivo_Bar";
            this.Arquivo_Bar.Size = new System.Drawing.Size(463, 10);
            this.Arquivo_Bar.TabIndex = 24;
            this.Arquivo_Bar.TabStop = false;
            this.Arquivo_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.Arquivo_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // LTotalFixo
            // 
            this.LTotalFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LTotalFixo.AutoSize = true;
            this.LTotalFixo.BackColor = System.Drawing.Color.Transparent;
            this.LTotalFixo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalFixo.ForeColor = System.Drawing.Color.White;
            this.LTotalFixo.Location = new System.Drawing.Point(9, 56);
            this.LTotalFixo.Name = "LTotalFixo";
            this.LTotalFixo.Size = new System.Drawing.Size(30, 13);
            this.LTotalFixo.TabIndex = 19;
            this.LTotalFixo.Text = "Total";
            this.LTotalFixo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LTotalFixo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // LAquivoFixo
            // 
            this.LAquivoFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LAquivoFixo.AutoSize = true;
            this.LAquivoFixo.BackColor = System.Drawing.Color.Transparent;
            this.LAquivoFixo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAquivoFixo.ForeColor = System.Drawing.Color.White;
            this.LAquivoFixo.Location = new System.Drawing.Point(9, 24);
            this.LAquivoFixo.Name = "LAquivoFixo";
            this.LAquivoFixo.Size = new System.Drawing.Size(43, 13);
            this.LAquivoFixo.TabIndex = 18;
            this.LAquivoFixo.Text = "Arquivo";
            this.LAquivoFixo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LAquivoFixo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.White;
            this.LTitulo.Location = new System.Drawing.Point(9, 8);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(39, 14);
            this.LTitulo.TabIndex = 17;
            this.LTitulo.Text = "Titulo";
            this.LTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // Total_BarFixo
            // 
            this.Total_BarFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Total_BarFixo.BackColor = System.Drawing.Color.White;
            this.Total_BarFixo.Location = new System.Drawing.Point(12, 72);
            this.Total_BarFixo.Name = "Total_BarFixo";
            this.Total_BarFixo.Size = new System.Drawing.Size(463, 10);
            this.Total_BarFixo.TabIndex = 26;
            this.Total_BarFixo.TabStop = false;
            // 
            // Arquivo_BarFixo
            // 
            this.Arquivo_BarFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Arquivo_BarFixo.BackColor = System.Drawing.Color.White;
            this.Arquivo_BarFixo.Location = new System.Drawing.Point(12, 40);
            this.Arquivo_BarFixo.Name = "Arquivo_BarFixo";
            this.Arquivo_BarFixo.Size = new System.Drawing.Size(463, 10);
            this.Arquivo_BarFixo.TabIndex = 27;
            this.Arquivo_BarFixo.TabStop = false;
            // 
            // LArquivo
            // 
            this.LArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LArquivo.BackColor = System.Drawing.Color.Transparent;
            this.LArquivo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LArquivo.ForeColor = System.Drawing.Color.White;
            this.LArquivo.Location = new System.Drawing.Point(48, 17);
            this.LArquivo.Name = "LArquivo";
            this.LArquivo.Size = new System.Drawing.Size(430, 21);
            this.LArquivo.TabIndex = 20;
            this.LArquivo.Text = "Arquivo...";
            this.LArquivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LArquivo.Visible = false;
            this.LArquivo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LArquivo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // CheckPBox
            // 
            this.CheckPBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckPBox.BackColor = System.Drawing.Color.Transparent;
            this.CheckPBox.Image = global::PBLauncher.Properties.Resources.btn_check_offpoint;
            this.CheckPBox.Location = new System.Drawing.Point(509, 12);
            this.CheckPBox.Name = "CheckPBox";
            this.CheckPBox.Size = new System.Drawing.Size(106, 76);
            this.CheckPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CheckPBox.TabIndex = 22;
            this.CheckPBox.TabStop = false;
            this.CheckPBox.Click += new System.EventHandler(this.CheckPBox_Click);
            this.CheckPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckPBox_MouseDown);
            this.CheckPBox.MouseLeave += new System.EventHandler(this.CheckPBox_MouseLeave);
            this.CheckPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckPBox_MouseMove);
            // 
            // StartPBox
            // 
            this.StartPBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartPBox.BackColor = System.Drawing.Color.Transparent;
            this.StartPBox.Image = global::PBLauncher.Properties.Resources.btn_start_offpoint;
            this.StartPBox.Location = new System.Drawing.Point(619, 12);
            this.StartPBox.Name = "StartPBox";
            this.StartPBox.Size = new System.Drawing.Size(166, 76);
            this.StartPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StartPBox.TabIndex = 23;
            this.StartPBox.TabStop = false;
            this.StartPBox.Click += new System.EventHandler(this.StartPBox_Click);
            this.StartPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartPBox_MouseDown);
            this.StartPBox.MouseLeave += new System.EventHandler(this.StartPBox_MouseLeave);
            this.StartPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartPBox_MouseMove);
            // 
            // UpdatePBox
            // 
            this.UpdatePBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatePBox.BackColor = System.Drawing.Color.Transparent;
            this.UpdatePBox.Image = global::PBLauncher.Properties.Resources.btn_update_offpoint;
            this.UpdatePBox.Location = new System.Drawing.Point(619, 12);
            this.UpdatePBox.Name = "UpdatePBox";
            this.UpdatePBox.Size = new System.Drawing.Size(166, 76);
            this.UpdatePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UpdatePBox.TabIndex = 21;
            this.UpdatePBox.TabStop = false;
            this.UpdatePBox.Click += new System.EventHandler(this.UpdatePBox_Click);
            this.UpdatePBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdatePBox_MouseDown);
            this.UpdatePBox.MouseLeave += new System.EventHandler(this.UpdatePBox_MouseLeave);
            this.UpdatePBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdatePBox_MouseMove);
            // 
            // PBDetect
            // 
            this.PBDetect.Tick += new System.EventHandler(this.PBDetect_Tick);
            // 
            // LauncherConfig
            // 
            this.LauncherConfig.BackColor = System.Drawing.Color.Black;
            this.LauncherConfig.Controls.Add(this.pictureBox4);
            this.LauncherConfig.Controls.Add(this.OkConfig);
            this.LauncherConfig.Controls.Add(this.ConfigBox);
            this.LauncherConfig.Location = new System.Drawing.Point(209, 167);
            this.LauncherConfig.Name = "LauncherConfig";
            this.LauncherConfig.Size = new System.Drawing.Size(373, 198);
            this.LauncherConfig.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PBLauncher.Properties.Resources.Separador;
            this.pictureBox4.Location = new System.Drawing.Point(0, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(373, 8);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // OkConfig
            // 
            this.OkConfig.Image = global::PBLauncher.Properties.Resources.Ok_1;
            this.OkConfig.Location = new System.Drawing.Point(126, 156);
            this.OkConfig.Name = "OkConfig";
            this.OkConfig.Size = new System.Drawing.Size(121, 33);
            this.OkConfig.TabIndex = 0;
            this.OkConfig.TabStop = false;
            this.OkConfig.Click += new System.EventHandler(this.pictureBox2_Click);
            this.OkConfig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OkConfig_MouseDown);
            this.OkConfig.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.OkConfig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OkConfig_MouseMove);
            // 
            // ConfigBox
            // 
            this.ConfigBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigBox.Image = global::PBLauncher.Properties.Resources.Warning;
            this.ConfigBox.Location = new System.Drawing.Point(0, 0);
            this.ConfigBox.Name = "ConfigBox";
            this.ConfigBox.Size = new System.Drawing.Size(373, 198);
            this.ConfigBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConfigBox.TabIndex = 5;
            this.ConfigBox.TabStop = false;
            // 
            // WEB_Announce
            // 
            this.WEB_Announce.Location = new System.Drawing.Point(0, 33);
            this.WEB_Announce.MinimumSize = new System.Drawing.Size(20, 20);
            this.WEB_Announce.Name = "WEB_Announce";
            this.WEB_Announce.ScrollBarsEnabled = false;
            this.WEB_Announce.Size = new System.Drawing.Size(791, 408);
            this.WEB_Announce.TabIndex = 2;
            this.WEB_Announce.TabStop = false;
            this.WEB_Announce.Url = new System.Uri("", System.UriKind.Relative);
            this.WEB_Announce.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WEB_Announce_DocumentCompleted);
            // 
            // BackGround
            // 
            this.BackGround.Image = global::PBLauncher.Properties.Resources.Bitmap230;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(790, 530);
            this.BackGround.TabIndex = 3;
            this.BackGround.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 533);
            this.Controls.Add(this.LauncherConfig);
            this.Controls.Add(this.panel_end);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.WEB_Announce);
            this.Controls.Add(this.BackGround);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBLauncher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnglishButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndonesiaButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPBox)).EndInit();
            this.panel_end.ResumeLayout(false);
            this.panel_end.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_BarFixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_BarFixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePBox)).EndInit();
            this.LauncherConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OkConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_end;
        private System.Windows.Forms.PictureBox ConfigPBox;
        private System.Windows.Forms.PictureBox MinPBox;
        private System.Windows.Forms.PictureBox ExitPBox;
        private System.Windows.Forms.Label LDownload;
        private System.Windows.Forms.PictureBox Total_Bar;
        private System.Windows.Forms.PictureBox Arquivo_Bar;
        public System.Windows.Forms.PictureBox StartPBox;
        private System.Windows.Forms.PictureBox CheckPBox;
        private System.Windows.Forms.PictureBox UpdatePBox;
        private System.Windows.Forms.Label LTotalFixo;
        private System.Windows.Forms.Label LAquivoFixo;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.PictureBox Total_BarFixo;
        private System.Windows.Forms.PictureBox Arquivo_BarFixo;
        private System.Windows.Forms.Label LArquivo;
        private System.Windows.Forms.Timer PBDetect;
        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.Panel LauncherConfig;
        private System.Windows.Forms.PictureBox OkConfig;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox ConfigBox;
        private System.Windows.Forms.WebBrowser WEB_Announce;
        private System.Windows.Forms.PictureBox IndonesiaButton;
        private System.Windows.Forms.PictureBox EnglishButton;
    }
}