namespace VTYS_Proje_App
{
    partial class frmSiparisVer
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
            this.lblUrunKod = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblSiparisTeslimTarih = new System.Windows.Forms.Label();
            this.txtUrunKod = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.dtpSiparisTeslim = new System.Windows.Forms.DateTimePicker();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrunKod
            // 
            this.lblUrunKod.AutoSize = true;
            this.lblUrunKod.Location = new System.Drawing.Point(13, 15);
            this.lblUrunKod.Name = "lblUrunKod";
            this.lblUrunKod.Size = new System.Drawing.Size(64, 13);
            this.lblUrunKod.TabIndex = 0;
            this.lblUrunKod.Text = "Ürün Kodu :";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(13, 41);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(35, 13);
            this.lblAdet.TabIndex = 1;
            this.lblAdet.Text = "Adet :";
            // 
            // lblSiparisTeslimTarih
            // 
            this.lblSiparisTeslimTarih.AutoSize = true;
            this.lblSiparisTeslimTarih.Location = new System.Drawing.Point(13, 70);
            this.lblSiparisTeslimTarih.Name = "lblSiparisTeslimTarih";
            this.lblSiparisTeslimTarih.Size = new System.Drawing.Size(106, 13);
            this.lblSiparisTeslimTarih.TabIndex = 2;
            this.lblSiparisTeslimTarih.Text = "Sipariş Teslim Tarihi :";
            // 
            // txtUrunKod
            // 
            this.txtUrunKod.Location = new System.Drawing.Point(125, 12);
            this.txtUrunKod.Name = "txtUrunKod";
            this.txtUrunKod.Size = new System.Drawing.Size(147, 20);
            this.txtUrunKod.TabIndex = 3;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(125, 38);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(147, 20);
            this.txtAdet.TabIndex = 4;
            // 
            // dtpSiparisTeslim
            // 
            this.dtpSiparisTeslim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSiparisTeslim.Location = new System.Drawing.Point(125, 64);
            this.dtpSiparisTeslim.Name = "dtpSiparisTeslim";
            this.dtpSiparisTeslim.Size = new System.Drawing.Size(147, 20);
            this.dtpSiparisTeslim.TabIndex = 5;
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(12, 137);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(75, 23);
            this.btnSiparis.TabIndex = 6;
            this.btnSiparis.Text = "Sipariş Ver";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(197, 137);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 7;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // frmSiparisVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.ControlBox = false;
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.dtpSiparisTeslim);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtUrunKod);
            this.Controls.Add(this.lblSiparisTeslimTarih);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblUrunKod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmSiparisVer";
            this.Text = "SiparisVer";
            this.Load += new System.EventHandler(this.frmSiparisVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunKod;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblSiparisTeslimTarih;
        private System.Windows.Forms.TextBox txtUrunKod;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.DateTimePicker dtpSiparisTeslim;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnİptal;
    }
}