namespace Kur_Takip_Programı.forms
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tmrSiniri = new DevExpress.XtraEditors.TextEdit();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_euroSiniri = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.txt_dolarSiniri = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tmrSiniri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_euroSiniri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dolarSiniri.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_tmrSiniri);
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txt_euroSiniri);
            this.groupControl1.Controls.Add(this.separatorControl1);
            this.groupControl1.Controls.Add(this.lbl_dolar);
            this.groupControl1.Controls.Add(this.txt_dolarSiniri);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(489, 188);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ayarlarınızı Seçin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(239, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sınırlama yaparken virgül yerine nokta kullanınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Güncelleme Sıklığı (sn):";
            // 
            // txt_tmrSiniri
            // 
            this.txt_tmrSiniri.Location = new System.Drawing.Point(163, 116);
            this.txt_tmrSiniri.Name = "txt_tmrSiniri";
            this.txt_tmrSiniri.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_tmrSiniri.Properties.Appearance.Options.UseFont = true;
            this.txt_tmrSiniri.Properties.MaxLength = 2;
            this.txt_tmrSiniri.Size = new System.Drawing.Size(47, 22);
            this.txt_tmrSiniri.TabIndex = 7;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.ImageOptions.Image")));
            this.btn_kaydet.Location = new System.Drawing.Point(12, 153);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(198, 23);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(244, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 72);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yan tarafta dolar ve euro kurları\r\nhangi değerin altına düştüğünde uyarı\r\nalmak i" +
    "stiyorsanız lütfen o değeri \r\nbelirtilen formatta yanlarında bulunan\r\nkutulara g" +
    "iriniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Euro:";
            // 
            // txt_euroSiniri
            // 
            this.txt_euroSiniri.EditValue = "";
            this.txt_euroSiniri.Location = new System.Drawing.Point(60, 88);
            this.txt_euroSiniri.Name = "txt_euroSiniri";
            this.txt_euroSiniri.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_euroSiniri.Properties.Appearance.Options.UseFont = true;
            this.txt_euroSiniri.Properties.MaxLength = 6;
            this.txt_euroSiniri.Size = new System.Drawing.Size(87, 22);
            this.txt_euroSiniri.TabIndex = 3;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(216, 42);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(22, 141);
            this.separatorControl1.TabIndex = 2;
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_dolar.Location = new System.Drawing.Point(9, 63);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(45, 17);
            this.lbl_dolar.TabIndex = 1;
            this.lbl_dolar.Text = "Dolar:";
            // 
            // txt_dolarSiniri
            // 
            this.txt_dolarSiniri.EditValue = "";
            this.txt_dolarSiniri.Location = new System.Drawing.Point(60, 60);
            this.txt_dolarSiniri.Name = "txt_dolarSiniri";
            this.txt_dolarSiniri.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_dolarSiniri.Properties.Appearance.Options.UseFont = true;
            this.txt_dolarSiniri.Properties.MaxLength = 6;
            this.txt_dolarSiniri.Size = new System.Drawing.Size(87, 22);
            this.txt_dolarSiniri.TabIndex = 0;
            // 
            // frm_settings
            // 
            this.AcceptButton = this.btn_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 188);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar - Kur Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tmrSiniri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_euroSiniri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dolarSiniri.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_dolarSiniri;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_euroSiniri;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_tmrSiniri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}