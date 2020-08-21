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
    public partial class frmMusteriEkle : Form
    {
        private void txtTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            frmAna frmAna = new frmAna();
            this.Close();
            frmAna.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string cnnstringTCKontrol = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryTCKontrol = "select * from Musteriler where TCKimlikNo='" + txtTCKimlikNo.Text + "'";

            SqlConnection cnnTCKontrol = new SqlConnection(cnnstringTCKontrol);
            cnnTCKontrol.Open();
            SqlCommand cmdTCKontrol = new SqlCommand(queryTCKontrol);
            cmdTCKontrol.Connection = cnnTCKontrol;
            SqlDataAdapter daTCKontrol = new SqlDataAdapter(queryTCKontrol, cnnTCKontrol);
            SqlDataReader drTCKontrol = cmdTCKontrol.ExecuteReader();

            if (drTCKontrol.Read())
            {
                MessageBox.Show("Mevcut Müşteri!");
            }
            else
            {
                try
                {
                    string telefon=txtTel1.Text+'-'+txtTel2.Text+'-'+txtTel3.Text+'-'+txtTel4.Text;
                    string mail = txtMail1.Text + '@' + txtMail2.Text;
  
                    string cnnstringKaydet = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    string queryKaydet = " insert into Musteriler (TCKimlikNo,Ad,SoyAd,DogumTarih,Tel,Mail,Cinsiyet,il) values ('" + txtTCKimlikNo.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + dtpDogumTarih.Value.ToString("yyyy-MM-dd") + "','" + telefon + "','" + mail + "','" + cBoxCinsiyet.Text + "','"+cBoxİl.Text+"')";
                    SqlConnection cnnKaydet = new SqlConnection(cnnstringKaydet);
                    SqlDataAdapter daKaydet = new SqlDataAdapter(queryKaydet, cnnKaydet);
                    DataTable dtKaydet = new DataTable();
                    daKaydet.Fill(dtKaydet);

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

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void txtTCKimlikNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
