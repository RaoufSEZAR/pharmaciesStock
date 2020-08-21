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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAna frmAna = new frmAna();
            frmAna.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string cnnstringUrunAdiKontrol = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryUrunAdiKontrol = "select * from Urunler where UrunAd='" + txtUrunAd.Text + "'";
            SqlConnection cnnUrunAdiKontrol = new SqlConnection(cnnstringUrunAdiKontrol);
            cnnUrunAdiKontrol.Open();
            SqlCommand cmdUrunAdiKontrol = new SqlCommand(queryUrunAdiKontrol);
            cmdUrunAdiKontrol.Connection = cnnUrunAdiKontrol;
            SqlDataAdapter daUrunAdiKontrol = new SqlDataAdapter(queryUrunAdiKontrol, cnnUrunAdiKontrol);
            SqlDataReader drUrunAdiKontrol = cmdUrunAdiKontrol.ExecuteReader();
           

            if (drUrunAdiKontrol.Read())
            {
                MessageBox.Show("Mevcut Ürün!");
            }
          
            else
            {
                try
                {
                    string cnnstringKaydet = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
     
                    string queryKaydet = " insert into Urunler values ('" + dudUrunTur.Text + "','" + txtUrunAd.Text + "','" + Convert.ToInt32(txtUrunFiyat.Text) + "','" + txtAciklama.Text + "','" + Convert.ToInt32(TAdet.Text) + "')";
                    SqlConnection cnnKaydet = new SqlConnection(cnnstringKaydet);
                    SqlDataAdapter daKaydet = new SqlDataAdapter(queryKaydet, cnnKaydet);
                    DataTable dtKaydet = new DataTable();
                    daKaydet.Fill(dtKaydet);

              


                //
                MessageBox.Show("Kayıt başarılı");
                    this.Close();
                    frmAna frmAna = new frmAna();
                    frmAna.Show();
                }

                catch
                {
                    MessageBox.Show("Kayıt başarısız.Lütfen bilgileri kontrol ediniz.");
                }

            }
            
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void dudUrunTur_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrunAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void TAdet_TextChanged(object sender, EventArgs e)
        {
        
         
        }
    }
}
