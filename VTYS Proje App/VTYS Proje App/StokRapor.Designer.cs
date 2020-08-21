namespace VTYS_Proje_App
{
    partial class frmStokRapor
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
            this.cBoxUrunTur = new System.Windows.Forms.ComboBox();
            this.lnlUrunTur = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.cBoxUrunAd = new System.Windows.Forms.ComboBox();
            this.lblStoktaKalan = new System.Windows.Forms.Label();
            this.lblStoktaKalanAdet = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lblKalanModel = new System.Windows.Forms.Label();
            this.cBoxKalanModel = new System.Windows.Forms.ComboBox();
            this.lblKalanModel2 = new System.Windows.Forms.Label();
            this.btnKalanModelGoster = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxUrunTur
            // 
            this.cBoxUrunTur.FormattingEnabled = true;
            this.cBoxUrunTur.Items.AddRange(new object[] {
            "Vitamin-Sağlık",
            "Ağız-Diş Bakımı",
            "Saç Bakımı",
            "Bebek Ürünlei",
            "İlaçlar"});
            this.cBoxUrunTur.Location = new System.Drawing.Point(176, 15);
            this.cBoxUrunTur.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxUrunTur.Name = "cBoxUrunTur";
            this.cBoxUrunTur.Size = new System.Drawing.Size(243, 24);
            this.cBoxUrunTur.TabIndex = 0;
            this.cBoxUrunTur.SelectedIndexChanged += new System.EventHandler(this.cBoxUrunTur_SelectedIndexChanged);
            this.cBoxUrunTur.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBoxUrunTur_MouseClick);
            // 
            // lnlUrunTur
            // 
            this.lnlUrunTur.AutoSize = true;
            this.lnlUrunTur.Location = new System.Drawing.Point(16, 18);
            this.lnlUrunTur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnlUrunTur.Name = "lnlUrunTur";
            this.lnlUrunTur.Size = new System.Drawing.Size(81, 17);
            this.lnlUrunTur.TabIndex = 1;
            this.lnlUrunTur.Text = "Ürün Türü :";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(16, 52);
            this.lblUrunAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(71, 17);
            this.lblUrunAd.TabIndex = 2;
            this.lblUrunAd.Text = "Ürün Adı :";
            this.lblUrunAd.Click += new System.EventHandler(this.lblUrunAd_Click);
            // 
            // cBoxUrunAd
            // 
            this.cBoxUrunAd.FormattingEnabled = true;
            this.cBoxUrunAd.Location = new System.Drawing.Point(176, 48);
            this.cBoxUrunAd.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxUrunAd.Name = "cBoxUrunAd";
            this.cBoxUrunAd.Size = new System.Drawing.Size(243, 24);
            this.cBoxUrunAd.TabIndex = 3;
            this.cBoxUrunAd.SelectedIndexChanged += new System.EventHandler(this.cBoxUrunAd_SelectedIndexChanged);
            // 
            // lblStoktaKalan
            // 
            this.lblStoktaKalan.AutoSize = true;
            this.lblStoktaKalan.Location = new System.Drawing.Point(16, 87);
            this.lblStoktaKalan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStoktaKalan.Name = "lblStoktaKalan";
            this.lblStoktaKalan.Size = new System.Drawing.Size(129, 17);
            this.lblStoktaKalan.TabIndex = 4;
            this.lblStoktaKalan.Text = "Stokta Kalan Adet :";
            this.lblStoktaKalan.Click += new System.EventHandler(this.lblStoktaKalan_Click);
            // 
            // lblStoktaKalanAdet
            // 
            this.lblStoktaKalanAdet.AutoSize = true;
            this.lblStoktaKalanAdet.Location = new System.Drawing.Point(172, 87);
            this.lblStoktaKalanAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStoktaKalanAdet.Name = "lblStoktaKalanAdet";
            this.lblStoktaKalanAdet.Size = new System.Drawing.Size(16, 17);
            this.lblStoktaKalanAdet.TabIndex = 5;
            this.lblStoktaKalanAdet.Text = "0";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(320, 81);
            this.btnGoster.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(100, 28);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lblKalanModel
            // 
            this.lblKalanModel.AutoSize = true;
            this.lblKalanModel.Location = new System.Drawing.Point(16, 121);
            this.lblKalanModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalanModel.Name = "lblKalanModel";
            this.lblKalanModel.Size = new System.Drawing.Size(48, 17);
            this.lblKalanModel.TabIndex = 7;
            this.lblKalanModel.Text = "Kalan ";
            // 
            // cBoxKalanModel
            // 
            this.cBoxKalanModel.FormattingEnabled = true;
            this.cBoxKalanModel.Items.AddRange(new object[] {
            "Vitamin-Sağlık",
            "Ağız-Diş Bakımı",
            "Saç Bakımı",
            "Bebek Ürünlei",
            "İlaçlar"});
            this.cBoxKalanModel.Location = new System.Drawing.Point(73, 114);
            this.cBoxKalanModel.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxKalanModel.Name = "cBoxKalanModel";
            this.cBoxKalanModel.Size = new System.Drawing.Size(156, 24);
            this.cBoxKalanModel.TabIndex = 8;
            // 
            // lblKalanModel2
            // 
            this.lblKalanModel2.AutoSize = true;
            this.lblKalanModel2.Location = new System.Drawing.Point(239, 121);
            this.lblKalanModel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalanModel2.Name = "lblKalanModel2";
            this.lblKalanModel2.Size = new System.Drawing.Size(65, 17);
            this.lblKalanModel2.TabIndex = 9;
            this.lblKalanModel2.Text = "Modelleri";
            // 
            // btnKalanModelGoster
            // 
            this.btnKalanModelGoster.Location = new System.Drawing.Point(320, 114);
            this.btnKalanModelGoster.Margin = new System.Windows.Forms.Padding(4);
            this.btnKalanModelGoster.Name = "btnKalanModelGoster";
            this.btnKalanModelGoster.Size = new System.Drawing.Size(100, 28);
            this.btnKalanModelGoster.TabIndex = 10;
            this.btnKalanModelGoster.Text = "Göster";
            this.btnKalanModelGoster.UseVisualStyleBackColor = true;
            this.btnKalanModelGoster.Click += new System.EventHandler(this.btnKalanModelGoster_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(496, 479);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 41);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 145);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(607, 310);
            this.dataGridView3.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "excel kalan urunler raporu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmStokRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 629);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKalanModelGoster);
            this.Controls.Add(this.lblKalanModel2);
            this.Controls.Add(this.cBoxKalanModel);
            this.Controls.Add(this.lblKalanModel);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblStoktaKalanAdet);
            this.Controls.Add(this.lblStoktaKalan);
            this.Controls.Add(this.cBoxUrunAd);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.lnlUrunTur);
            this.Controls.Add(this.cBoxUrunTur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStokRapor";
            this.Text = "Stok Durumu Raporları";
            this.Load += new System.EventHandler(this.frmStokRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxUrunTur;
        private System.Windows.Forms.Label lnlUrunTur;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.ComboBox cBoxUrunAd;
        private System.Windows.Forms.Label lblStoktaKalan;
        private System.Windows.Forms.Label lblStoktaKalanAdet;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label lblKalanModel;
        private System.Windows.Forms.ComboBox cBoxKalanModel;
        private System.Windows.Forms.Label lblKalanModel2;
        private System.Windows.Forms.Button btnKalanModelGoster;
        private System.Windows.Forms.Button btnGeri;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
    }
}