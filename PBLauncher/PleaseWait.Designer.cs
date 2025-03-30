﻿/*
 * Arquivo: PleaseWait.Designer.cs
 * Criado em: 23-11-2021
 * Última modificação: 23-11-2021
 */
namespace PBLauncher
{
    partial class PleaseWait
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer
        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PleaseWait));
            this.panel_label = new System.Windows.Forms.Panel();
            this.lb_loading = new System.Windows.Forms.Label();
            this.CEDetect = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel_label
            // 
            this.panel_label.BackColor = System.Drawing.Color.Transparent;
            this.panel_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_label.Location = new System.Drawing.Point(0, 16);
            this.panel_label.Name = "panel_label";
            this.panel_label.Size = new System.Drawing.Size(380, 29);
            this.panel_label.TabIndex = 0;
            // 
            // lb_loading
            // 
            this.lb_loading.BackColor = System.Drawing.Color.White;
            this.lb_loading.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loading.ForeColor = System.Drawing.Color.Black;
            this.lb_loading.Location = new System.Drawing.Point(0, 7);
            this.lb_loading.Name = "lb_loading";
            this.lb_loading.Size = new System.Drawing.Size(377, 29);
            this.lb_loading.TabIndex = 0;
            this.lb_loading.Text = "NonString";
            this.lb_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CEDetect
            // 
            this.CEDetect.Enabled = true;
            this.CEDetect.Interval = 1;
            this.CEDetect.Tick += new System.EventHandler(this.CEDetect_Tick);
            // 
            // PleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 45);
            this.Controls.Add(this.lb_loading);
            this.Controls.Add(this.panel_label);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PleaseWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please Wait";
            this.Load += new System.EventHandler(this.PleaseWait_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_label;
        private System.Windows.Forms.Label lb_loading;
        private System.Windows.Forms.Timer CEDetect;
    }
}

