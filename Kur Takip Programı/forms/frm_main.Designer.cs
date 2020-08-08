namespace Kur_Takip_Programı
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.lbl_euro = new System.Windows.Forms.Label();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.tmr_cek = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerDolar = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerEuro = new System.ComponentModel.BackgroundWorker();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_minmaxdolar = new System.Windows.Forms.Label();
            this.lbl_sondeger1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_minmaxeuro = new System.Windows.Forms.Label();
            this.lbl_sondeger2 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_baglanti = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncellemeleriKontrolEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_euro.Location = new System.Drawing.Point(22, 50);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(133, 36);
            this.lbl_euro.TabIndex = 1;
            this.lbl_euro.Text = "0.0000 ₺";
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dolar.Location = new System.Drawing.Point(22, 50);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(133, 36);
            this.lbl_dolar.TabIndex = 0;
            this.lbl_dolar.Text = "0.0000 ₺";
            // 
            // tmr_cek
            // 
            this.tmr_cek.Interval = 3000;
            this.tmr_cek.Tick += new System.EventHandler(this.tmr_cek_Tick);
            // 
            // backgroundWorkerDolar
            // 
            this.backgroundWorkerDolar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDolar_DoWork);
            this.backgroundWorkerDolar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDolar_RunWorkerCompleted);
            // 
            // backgroundWorkerEuro
            // 
            this.backgroundWorkerEuro.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerEuro_DoWork);
            this.backgroundWorkerEuro.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerEuro_RunWorkerCompleted);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.lbl_minmaxdolar);
            this.groupControl1.Controls.Add(this.lbl_sondeger1);
            this.groupControl1.Controls.Add(this.lbl_dolar);
            this.groupControl1.Location = new System.Drawing.Point(43, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(175, 120);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Dolar Değeri";
            // 
            // lbl_minmaxdolar
            // 
            this.lbl_minmaxdolar.AutoSize = true;
            this.lbl_minmaxdolar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbl_minmaxdolar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_minmaxdolar.Location = new System.Drawing.Point(24, 93);
            this.lbl_minmaxdolar.Name = "lbl_minmaxdolar";
            this.lbl_minmaxdolar.Size = new System.Drawing.Size(73, 13);
            this.lbl_minmaxdolar.TabIndex = 2;
            this.lbl_minmaxdolar.Text = "min:0 - max:0";
            // 
            // lbl_sondeger1
            // 
            this.lbl_sondeger1.AutoSize = true;
            this.lbl_sondeger1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbl_sondeger1.ForeColor = System.Drawing.Color.Red;
            this.lbl_sondeger1.Location = new System.Drawing.Point(43, 93);
            this.lbl_sondeger1.Name = "lbl_sondeger1";
            this.lbl_sondeger1.Size = new System.Drawing.Size(89, 13);
            this.lbl_sondeger1.TabIndex = 1;
            this.lbl_sondeger1.Text = "Alınan Son Değer";
            this.lbl_sondeger1.Visible = false;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.lbl_minmaxeuro);
            this.groupControl2.Controls.Add(this.lbl_sondeger2);
            this.groupControl2.Controls.Add(this.lbl_euro);
            this.groupControl2.Location = new System.Drawing.Point(224, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(175, 120);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Euro Değeri";
            // 
            // lbl_minmaxeuro
            // 
            this.lbl_minmaxeuro.AutoSize = true;
            this.lbl_minmaxeuro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbl_minmaxeuro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_minmaxeuro.Location = new System.Drawing.Point(24, 93);
            this.lbl_minmaxeuro.Name = "lbl_minmaxeuro";
            this.lbl_minmaxeuro.Size = new System.Drawing.Size(73, 13);
            this.lbl_minmaxeuro.TabIndex = 3;
            this.lbl_minmaxeuro.Text = "min:0 - max:0";
            // 
            // lbl_sondeger2
            // 
            this.lbl_sondeger2.AutoSize = true;
            this.lbl_sondeger2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbl_sondeger2.ForeColor = System.Drawing.Color.Red;
            this.lbl_sondeger2.Location = new System.Drawing.Point(43, 93);
            this.lbl_sondeger2.Name = "lbl_sondeger2";
            this.lbl_sondeger2.Size = new System.Drawing.Size(89, 13);
            this.lbl_sondeger2.TabIndex = 2;
            this.lbl_sondeger2.Text = "Alınan Son Değer";
            this.lbl_sondeger2.Visible = false;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.groupControl3.Controls.Add(this.groupControl1);
            this.groupControl3.Controls.Add(this.groupControl2);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl3.Location = new System.Drawing.Point(12, 43);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(408, 132);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Kur Bilgileri";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_baglanti});
            this.statusStrip1.Location = new System.Drawing.Point(0, 178);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(424, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_baglanti
            // 
            this.lbl_baglanti.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_baglanti.Name = "lbl_baglanti";
            this.lbl_baglanti.Size = new System.Drawing.Size(409, 17);
            this.lbl_baglanti.Spring = true;
            this.lbl_baglanti.Text = "Bağlantı kuruluyor ...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.güncellemeleriKontrolEtToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarToolStripMenuItem.Image")));
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hakkındaToolStripMenuItem.Image")));
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // güncellemeleriKontrolEtToolStripMenuItem
            // 
            this.güncellemeleriKontrolEtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("güncellemeleriKontrolEtToolStripMenuItem.Image")));
            this.güncellemeleriKontrolEtToolStripMenuItem.Name = "güncellemeleriKontrolEtToolStripMenuItem";
            this.güncellemeleriKontrolEtToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.güncellemeleriKontrolEtToolStripMenuItem.Text = "Güncellemeleri Kontrol Et";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(0, 22);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(424, 19);
            this.separatorControl1.TabIndex = 6;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 200);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kur Takip Programı";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Timer tmr_cek;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDolar;
        private System.Windows.Forms.Label lbl_euro;
        private System.ComponentModel.BackgroundWorker backgroundWorkerEuro;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_baglanti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label lbl_sondeger1;
        private System.Windows.Forms.Label lbl_sondeger2;
        private System.Windows.Forms.Label lbl_minmaxdolar;
        private System.Windows.Forms.Label lbl_minmaxeuro;
        private System.Windows.Forms.ToolStripMenuItem güncellemeleriKontrolEtToolStripMenuItem;
    }
}

