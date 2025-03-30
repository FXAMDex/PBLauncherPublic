namespace PBLauncher
{
    partial class ChangeLangauge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLangauge));
            this.MessageBoxPack = new System.Windows.Forms.PictureBox();
            this.Line_Message = new System.Windows.Forms.PictureBox();
            this.OKButtonLanguage = new System.Windows.Forms.PictureBox();
            this.CancelButtonLanguage = new System.Windows.Forms.PictureBox();
            this.STR_MESSAGE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MessageBoxPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line_Message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OKButtonLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButtonLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageBoxPack
            // 
            this.MessageBoxPack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MessageBoxPack.Image = global::PBLauncher.Properties.Resources.Warning;
            this.MessageBoxPack.Location = new System.Drawing.Point(209, 166);
            this.MessageBoxPack.Name = "MessageBoxPack";
            this.MessageBoxPack.Size = new System.Drawing.Size(373, 198);
            this.MessageBoxPack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MessageBoxPack.TabIndex = 28;
            this.MessageBoxPack.TabStop = false;
            // 
            // Line_Message
            // 
            this.Line_Message.Image = global::PBLauncher.Properties.Resources.Separador;
            this.Line_Message.Location = new System.Drawing.Point(209, 300);
            this.Line_Message.Name = "Line_Message";
            this.Line_Message.Size = new System.Drawing.Size(373, 8);
            this.Line_Message.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Line_Message.TabIndex = 30;
            this.Line_Message.TabStop = false;
            // 
            // OKButtonLanguage
            // 
            this.OKButtonLanguage.Image = global::PBLauncher.Properties.Resources.Ok_1;
            this.OKButtonLanguage.Location = new System.Drawing.Point(271, 319);
            this.OKButtonLanguage.Name = "OKButtonLanguage";
            this.OKButtonLanguage.Size = new System.Drawing.Size(121, 33);
            this.OKButtonLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OKButtonLanguage.TabIndex = 31;
            this.OKButtonLanguage.TabStop = false;
            this.OKButtonLanguage.Click += new System.EventHandler(this.ButtonClick_Yes);
            this.OKButtonLanguage.MouseLeave += new System.EventHandler(this.OkButtonOffPoint);
            this.OKButtonLanguage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OkButtonOnPoint);
            // 
            // CancelButtonLanguage
            // 
            this.CancelButtonLanguage.Image = global::PBLauncher.Properties.Resources.btn_cancel_offpoint;
            this.CancelButtonLanguage.Location = new System.Drawing.Point(400, 319);
            this.CancelButtonLanguage.Name = "CancelButtonLanguage";
            this.CancelButtonLanguage.Size = new System.Drawing.Size(121, 33);
            this.CancelButtonLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CancelButtonLanguage.TabIndex = 32;
            this.CancelButtonLanguage.TabStop = false;
            this.CancelButtonLanguage.Click += new System.EventHandler(this.ButtonClick_Cancel);
            this.CancelButtonLanguage.MouseLeave += new System.EventHandler(this.CancelButtonOffPoint);
            this.CancelButtonLanguage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelButtonOnPoint);
            // 
            // STR_MESSAGE
            // 
            this.STR_MESSAGE.AllowDrop = true;
            this.STR_MESSAGE.BackColor = System.Drawing.Color.Transparent;
            this.STR_MESSAGE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STR_MESSAGE.ForeColor = System.Drawing.Color.Transparent;
            this.STR_MESSAGE.Image = global::PBLauncher.Properties.Resources.BGLabel;
            this.STR_MESSAGE.Location = new System.Drawing.Point(211, 232);
            this.STR_MESSAGE.Name = "STR_MESSAGE";
            this.STR_MESSAGE.Size = new System.Drawing.Size(371, 35);
            this.STR_MESSAGE.TabIndex = 33;
            this.STR_MESSAGE.Text = "STR_MESSAGE";
            this.STR_MESSAGE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeLangauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBLauncher.Properties.Resources.background_point_blank_2;
            this.ClientSize = new System.Drawing.Size(790, 530);
            this.Controls.Add(this.STR_MESSAGE);
            this.Controls.Add(this.CancelButtonLanguage);
            this.Controls.Add(this.OKButtonLanguage);
            this.Controls.Add(this.Line_Message);
            this.Controls.Add(this.MessageBoxPack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeLangauge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeLangauge";
            ((System.ComponentModel.ISupportInitialize)(this.MessageBoxPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line_Message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OKButtonLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButtonLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MessageBoxPack;
        private System.Windows.Forms.PictureBox Line_Message;
        private System.Windows.Forms.PictureBox OKButtonLanguage;
        private System.Windows.Forms.PictureBox CancelButtonLanguage;
        private System.Windows.Forms.Label STR_MESSAGE;
    }
}