namespace VTYS_Proje_App
{
    partial class frmKullaniciDuzenle
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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblYetki = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dudYetki = new System.Windows.Forms.DomainUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(13, 12);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(70, 13);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(13, 38);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(34, 13);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Sifre :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(13, 64);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(13, 90);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(43, 13);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(13, 115);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(37, 13);
            this.lblYetki.TabIndex = 4;
            this.lblYetki.Text = "Yetki :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(118, 9);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(118, 35);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(118, 61);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(118, 87);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // dudYetki
            // 
            this.dudYetki.Items.Add("");
            this.dudYetki.Items.Add("Admin");
            this.dudYetki.Items.Add("Yönetici");
            this.dudYetki.Items.Add("Personel");
            this.dudYetki.Location = new System.Drawing.Point(118, 113);
            this.dudYetki.Name = "dudYetki";
            this.dudYetki.ReadOnly = true;
            this.dudYetki.Size = new System.Drawing.Size(100, 20);
            this.dudYetki.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(16, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(197, 160);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 11;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // frmKullaniciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.ControlBox = false;
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dudYetki);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmKullaniciDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Düzenle";
            this.Load += new System.EventHandler(this.frmKullaniciDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DomainUpDown dudYetki;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnİptal;
    }
}