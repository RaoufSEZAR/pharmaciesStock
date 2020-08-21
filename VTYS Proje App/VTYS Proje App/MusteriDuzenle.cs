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
    public partial class frmMusteriDuzenle : Form
    {
        public string TCYeni;
        private void txtMusteriTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public frmMusteriDuzenle()
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

            if(txtTCKimlikNo.Text!=TCYeni)
            {
                if (drTCKontrol.Read()) 
                {
                    MessageBox.Show("Mevcut Müşteri!");
                }
                else
                {
                    try
                    {
                        string telefon = txtTel1.Text + '-' + txtTel2.Text + '-' + txtTel3.Text + '-' + txtTel4.Text;
                        string mail = txtMail1.Text + '@' + txtMail2.Text;

                        string cnnstringKaydet = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                        string queryKaydet = " update Musteriler set TCKimlikNo='" + txtTCKimlikNo.Text + "',Ad='" + txtAd.Text + "',SoyAd='" + txtSoyad.Text + "',DogumTarih='" + dtpDogumTarih.Value.ToString("yyyy-MM-dd") + "',Tel='" + telefon + "',Mail='" + mail + "',Cinsiyet='" + cBoxCinsiyet.Text + "',il='" + cBoxİl.Text + "' where TCKimlikNo='"+TCYeni+"'";
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
            }
            else
            {
                try
                {
                    string telefon = txtTel1.Text + '-' + txtTel2.Text + '-' + txtTel3.Text + '-' + txtTel4.Text;
                    string mail = txtMail1.Text + '@' + txtMail2.Text;

                    string cnnstringKaydet = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    string queryKaydet = " update Musteriler set TCKimlikNo='" + txtTCKimlikNo.Text + "',Ad='" + txtAd.Text + "',SoyAd='" + txtSoyad.Text + "',DogumTarih='" + dtpDogumTarih.Value.ToString("yyyy-MM-dd") + "',Tel='" + telefon + "',Mail='" + mail + "',Cinsiyet='" + cBoxCinsiyet.Text + "',il='" + cBoxİl.Text + "' where TCKimlikNo='" + TCYeni + "'";
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
        }

        private void frmMusteriDuzenle_Load(object sender, EventArgs e)
        {
            string cnnstringMusteriDuzenle = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryMusteriDuzenle = "select * from Musteriler where TCKimlikNo='" + TCYeni + "'";
            SqlConnection cnnMusteriDuzenle = new SqlConnection(cnnstringMusteriDuzenle);
            cnnMusteriDuzenle.Open();
            SqlCommand cmdMusteriDuzenle = new SqlCommand(queryMusteriDuzenle);
            cmdMusteriDuzenle.Connection = cnnMusteriDuzenle;
            SqlDataAdapter daMusteriDuzenle = new SqlDataAdapter(queryMusteriDuzenle, cnnMusteriDuzenle);
            SqlDataReader drMusteriDuzenle = cmdMusteriDuzenle.ExecuteReader();

            if (drMusteriDuzenle.Read())
            {
                try
                {
                    string cnnstringMusteriDuzenle2 = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    string queryMusteriDuzenle2 = "select TCKimlikNo,Ad,SoyAd,DogumTarih,Tel,Mail,Cinsiyet,il from Musteriler where TCKimlikNo='" + TCYeni + "'";
                    SqlConnection cnnMusteriDuzenle2 = new SqlConnection(cnnstringMusteriDuzenle2);
                    SqlDataAdapter daMusteriDuzenle2 = new SqlDataAdapter(queryMusteriDuzenle2, cnnMusteriDuzenle2);
                    DataTable dtMusteriDuzenle2 = new DataTable();
                    daMusteriDuzenle2.Fill(dtMusteriDuzenle2);

                    txtTCKimlikNo.Text = dtMusteriDuzenle2.Rows[0][0].ToString();
                    txtAd.Text = dtMusteriDuzenle2.Rows[0][1].ToString();
                    txtSoyad.Text = dtMusteriDuzenle2.Rows[0][2].ToString();
                    dtpDogumTarih.Text = dtMusteriDuzenle2.Rows[0][3].ToString();
                    string tel = dtMusteriDuzenle2.Rows[0][4].ToString();
                    tel = tel.Replace("-", "");
                    txtTel1.Text = tel.Substring(0, 4);
                    txtTel2.Text = tel.Substring(4, 3);
                    txtTel3.Text = tel.Substring(7, 2);
                    txtTel4.Text = tel.Substring(9, 2);
                    string mail = dtMusteriDuzenle2.Rows[0][5].ToString();
                    txtMail1.Text = mail.Substring(0, mail.IndexOf('@'));
                    int x = mail.Length - mail.Substring(0, mail.IndexOf('@')).Length;
                    txtMail2.Text = mail.Substring(mail.IndexOf('@') + 1, x - 1);
                    cBoxCinsiyet.Text = dtMusteriDuzenle2.Rows[0][6].ToString();
                    cBoxİl.Text = dtMusteriDuzenle2.Rows[0][7].ToString();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
                
            }
            else
            {
                MessageBox.Show("Hatalı TCKimlikNo!");
            }
        }
    }
}
