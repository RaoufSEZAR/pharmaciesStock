namespace VTYS_Proje_App
{
    partial class frmKullaniciEkle
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
            this.lblKullaniciAdi.Location = new System.Drawing.Point(17, 20);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(92, 17);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(17, 52);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 17);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(17, 84);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(33, 17);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(17, 116);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(56, 17);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(17, 146);
            this.lblYetki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(39, 17);
            this.lblYetki.TabIndex = 4;
            this.lblYetki.Text = "Yetki";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(160, 16);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(132, 22);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(160, 48);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(132, 22);
            this.txtSifre.TabIndex = 6;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(160, 80);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 22);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(160, 112);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtSoyad.TabIndex = 8;
            // 
            // dudYetki
            // 
            this.dudYetki.Items.Add("Admin");
            this.dudYetki.Items.Add("Yönetici");
            this.dudYetki.Items.Add("Personel");
            this.dudYetki.Location = new System.Drawing.Point(160, 144);
            this.dudYetki.Margin = new System.Windows.Forms.Padding(4);
            this.dudYetki.Name = "dudYetki";
            this.dudYetki.ReadOnly = true;
            this.dudYetki.Size = new System.Drawing.Size(133, 22);
            this.dudYetki.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(16, 223);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 28);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(263, 223);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(100, 28);
            this.btnİptal.TabIndex = 11;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(442, 346);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKullaniciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Ekle";
            this.Load += new System.EventHandler(this.frmKullaniciEkle_Load);
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