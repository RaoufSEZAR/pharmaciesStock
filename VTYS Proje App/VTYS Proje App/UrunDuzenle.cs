using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTYS_Proje_App
{
    public partial class frmUrunDuzenle : Form
    {
        public frmUrunDuzenle()
        {
            InitializeComponent();
        }

        public int UrunKod;

        private void frmUrunDuzenle_Load(object sender, EventArgs e)
        {
            string cnnstringUrunDuzenle = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryUrunDuzenle = "select * from Urunler where UrunKod='" + UrunKod + "'";
            SqlConnection cnnUrunDuzenle = new SqlConnection(cnnstringUrunDuzenle);
            cnnUrunDuzenle.Open();
            SqlCommand cmdUrunDuzenle = new SqlCommand(queryUrunDuzenle);
            cmdUrunDuzenle.Connection = cnnUrunDuzenle;
            SqlDataAdapter daUrunDuzenle = new SqlDataAdapter(queryUrunDuzenle, cnnUrunDuzenle);
            SqlDataReader drUrunDuzenle = cmdUrunDuzenle.ExecuteReader();

            if (drUrunDuzenle.Read())
            {
                string cnnstringUrunDuzenle2 = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                string queryUrunDuzenle2 = "select UrunTur,UrunAd,UrunFiyat,UrunAciklama,UrunAdet from Urunler where UrunKod='" + UrunKod + "'";
                SqlConnection cnnUrunDuzenle2 = new SqlConnection(cnnstringUrunDuzenle2);
                SqlDataAdapter daUrunDuzenle2 = new SqlDataAdapter(queryUrunDuzenle2, cnnUrunDuzenle2);
                DataTable dtUrunDuzenle2 = new DataTable();
                daUrunDuzenle2.Fill(dtUrunDuzenle2);

                dudUrunTur.Text = dtUrunDuzenle2.Rows[0][0].ToString();
                txtUrunAd.Text = dtUrunDuzenle2.Rows[0][1].ToString();
                txtFiyat.Text = (Convert.ToInt32(dtUrunDuzenle2.Rows[0][2])).ToString();
                txtAciklama.Text = dtUrunDuzenle2.Rows[0][3].ToString();
                upAdet.Text = (Convert.ToInt32(dtUrunDuzenle2.Rows[0][4])).ToString();
            }
            else
            {
                MessageBox.Show("Hatalı Urun kodu!");
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAna frmAna = new frmAna();
            frmAna.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string cnnstringKaydet = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                string queryKaydet = " update Urunler set UrunTur='" + dudUrunTur.Text + "', UrunAd='" + txtUrunAd.Text + "', UrunFiyat='" + Convert.ToInt32(txtFiyat.Text) + "', UrunAciklama='" + txtAciklama.Text + "',UrunAdet='" + Convert.ToInt32(upAdet.Text) + "' where UrunKod='" + UrunKod + "'";
                SqlConnection cnnKaydet = new SqlConnection(cnnstringKaydet);
                SqlDataAdapter daKaydet = new SqlDataAdapter(queryKaydet, cnnKaydet);
                DataTable dtKaydet = new DataTable();
                daKaydet.Fill(dtKaydet);
                MessageBox.Show("Güncelleme başarılı");
                this.Close();
                frmAna frmAna = new frmAna();
                frmAna.Show();
            }
            catch
            {
                MessageBox.Show("Güncelleme başarısız.Lütfen bilgileri kontrol ediniz.");
            }
        }

        private void dudUrunTur_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void lblUrunAd_Click(object sender, EventArgs e)
        {

        }
    }
}
