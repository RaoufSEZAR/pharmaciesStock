namespace VTYS_Proje_App
{
    partial class frmUrunDuzenle
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.lblUrunTur = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.dudUrunTur = new System.Windows.Forms.DomainUpDown();
            this.upAdet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(13, 226);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(197, 226);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 1;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // lblUrunTur
            // 
            this.lblUrunTur.AutoSize = true;
            this.lblUrunTur.Location = new System.Drawing.Point(12, 15);
            this.lblUrunTur.Name = "lblUrunTur";
            this.lblUrunTur.Size = new System.Drawing.Size(61, 13);
            this.lblUrunTur.TabIndex = 2;
            this.lblUrunTur.Text = "Ürün Türü :";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(19, 41);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(54, 13);
            this.lblUrunAd.TabIndex = 4;
            this.lblUrunAd.Text = "Ürün Adı :";
            this.lblUrunAd.Click += new System.EventHandler(this.lblUrunAd_Click);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(141, 38);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(120, 20);
            this.txtUrunAd.TabIndex = 5;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(141, 64);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(120, 20);
            this.txtFiyat.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(140, 116);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(120, 69);
            this.txtAciklama.TabIndex = 7;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(38, 67);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(35, 13);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "Fiyat :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(19, 119);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 13);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // dudUrunTur
            // 
            this.dudUrunTur.Items.Add("Vitamin-Sağlık");
            this.dudUrunTur.Items.Add("Ağız-Diş Bakımı");
            this.dudUrunTur.Items.Add("Saç Bakımı");
            this.dudUrunTur.Items.Add("Bebek Ürünlei");
            this.dudUrunTur.Items.Add("İlaçlar");
            this.dudUrunTur.Location = new System.Drawing.Point(141, 13);
            this.dudUrunTur.Name = "dudUrunTur";
            this.dudUrunTur.Size = new System.Drawing.Size(120, 20);
            this.dudUrunTur.TabIndex = 10;
            this.dudUrunTur.SelectedItemChanged += new System.EventHandler(this.dudUrunTur_SelectedItemChanged);
            // 
            // upAdet
            // 
            this.upAdet.Location = new System.Drawing.Point(140, 90);
            this.upAdet.Name = "upAdet";
            this.upAdet.Size = new System.Drawing.Size(121, 20);
            this.upAdet.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adet :";
            // 
            // frmUrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upAdet);
            this.Controls.Add(this.dudUrunTur);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.lblUrunTur);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUrunDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Düzenle";
            this.Load += new System.EventHandler(this.frmUrunDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Label lblUrunTur;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DomainUpDown dudUrunTur;
        private System.Windows.Forms.TextBox upAdet;
        private System.Windows.Forms.Label label1;
    }
}