namespace VTYS_Proje_App
{
    partial class frmUrunEkle
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
            this.lblUrunTur = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.dudUrunTur = new System.Windows.Forms.DomainUpDown();
            this.TurAdet = new System.Windows.Forms.Label();
            this.TAdet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUrunTur
            // 
            this.lblUrunTur.AutoSize = true;
            this.lblUrunTur.Location = new System.Drawing.Point(22, 22);
            this.lblUrunTur.Name = "lblUrunTur";
            this.lblUrunTur.Size = new System.Drawing.Size(61, 13);
            this.lblUrunTur.TabIndex = 0;
            this.lblUrunTur.Text = "Ürün Türü :";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(29, 48);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(54, 13);
            this.lblUrunAd.TabIndex = 1;
            this.lblUrunAd.Text = "Ürün Adı :";
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(22, 74);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(61, 13);
            this.lblUrunFiyat.TabIndex = 2;
            this.lblUrunFiyat.Text = "Ürün Fiyat :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(27, 124);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 13);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(121, 45);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(139, 20);
            this.txtUrunAd.TabIndex = 5;
            this.txtUrunAd.TextChanged += new System.EventHandler(this.txtUrunAd_TextChanged);
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(121, 71);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(139, 20);
            this.txtUrunFiyat.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(121, 124);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(139, 82);
            this.txtAciklama.TabIndex = 7;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(25, 239);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(185, 239);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 9;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // dudUrunTur
            // 
            this.dudUrunTur.Items.Add("Vitamin-Sağlık");
            this.dudUrunTur.Items.Add("Ağız-Diş Bakımı");
            this.dudUrunTur.Items.Add("Saç Bakımı");
            this.dudUrunTur.Items.Add("Bebek Ürünleri");
            this.dudUrunTur.Items.Add("İlaçlar");
            this.dudUrunTur.Location = new System.Drawing.Point(121, 19);
            this.dudUrunTur.Name = "dudUrunTur";
            this.dudUrunTur.Size = new System.Drawing.Size(139, 20);
            this.dudUrunTur.TabIndex = 10;
            this.dudUrunTur.SelectedItemChanged += new System.EventHandler(this.dudUrunTur_SelectedItemChanged);
            // 
            // TurAdet
            // 
            this.TurAdet.AutoSize = true;
            this.TurAdet.Location = new System.Drawing.Point(48, 101);
            this.TurAdet.Name = "TurAdet";
            this.TurAdet.Size = new System.Drawing.Size(35, 13);
            this.TurAdet.TabIndex = 11;
            this.TurAdet.Text = "Adet :";
            // 
            // TAdet
            // 
            this.TAdet.Location = new System.Drawing.Point(121, 98);
            this.TAdet.Name = "TAdet";
            this.TAdet.Size = new System.Drawing.Size(139, 20);
            this.TAdet.TabIndex = 12;
            this.TAdet.TextChanged += new System.EventHandler(this.TAdet_TextChanged);
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(290, 290);
            this.ControlBox = false;
            this.Controls.Add(this.TAdet);
            this.Controls.Add(this.TurAdet);
            this.Controls.Add(this.dudUrunTur);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblUrunFiyat);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.lblUrunTur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunTur;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.DomainUpDown dudUrunTur;
        private System.Windows.Forms.Label TurAdet;
        private System.Windows.Forms.TextBox TAdet;
    }
}