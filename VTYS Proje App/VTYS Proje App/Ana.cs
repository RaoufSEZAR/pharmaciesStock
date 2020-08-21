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
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.IO;
using Excel;
using System.Data.OleDb;



namespace VTYS_Proje_App
{
    public partial class frmAna : Form
    {
        OleDbConnection co;
        OleDbDataAdapter de;
        DataTable dm;

        frmKullaniciEkle frmKullaniciEkle = new frmKullaniciEkle();
        frmKullaniciDuzenle frmKullaniciDuzenle = new frmKullaniciDuzenle();
        frmUrunDuzenle frmUrunDuzenle = new frmUrunDuzenle();
        frmMusteriDuzenle frmMusteriDuzenle = new frmMusteriDuzenle();

        public static string Yetki;

        public void GosterMusteriler()
        {
            string cnnstringMusteriler = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryMusteriler = "Select MusteriID,TCKimlikNo,Ad,SoyAd,DogumTarih,Cinsiyet,Mail,Tel,il from Musteriler where Aktif=1";
            SqlConnection cnnMusteriler = new SqlConnection(cnnstringMusteriler);
            SqlDataAdapter daMusteriler = new SqlDataAdapter(queryMusteriler, cnnMusteriler);
            DataTable dtMusteriler = new DataTable();
            daMusteriler.Fill(dtMusteriler);
            dgvMusteriler.DataSource = dtMusteriler;
            dgvMusteriler.Refresh();
            cnnMusteriler.Close();
        }
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True");
        public void GosterUrunler()
        {
            string cnnstringUrunler = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
             string queryUrunler = "select UrunKod,UrunTur,UrunAd,UrunFiyat,UrunAciklama,UrunAdet from Urunler  ";
          //  string queryUrunler = "select * from Urunler  ";
            SqlConnection cnnUrunler = new SqlConnection(cnnstringUrunler);
            SqlDataAdapter da = new SqlDataAdapter(queryUrunler, cnnUrunler);
            DataTable dt = new DataTable();
            da.Fill(dt);    
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            cnnUrunler.Close();
        }
        public void GosterSatis()
        {
            string cnnstringsatis = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string querysatis = "select S.SatisKod, S.MusteriID ,U.UrunAd, S.SatisTarih, S.Adet from Satislar as S inner join Urunler as U on U.UrunKod=S.UrunKod ";

            SqlConnection cnnsatis = new SqlConnection(cnnstringsatis);
            SqlDataAdapter dd = new SqlDataAdapter(querysatis, cnnsatis);
            DataTable de = new DataTable();
            dd.Fill(de);
            dataGridView2.DataSource = de;
            dataGridView2.Refresh();
            cnnsatis.Close();
        }
        private void txtMusteriTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void GosterKullanicilar()
        {
            string cnnstringKullanicilar = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryKullanicilar = "Select * from Kullanicilar";
            SqlConnection cnnKullanicilar = new SqlConnection(cnnstringKullanicilar);
            SqlDataAdapter daKullanicilar = new SqlDataAdapter(queryKullanicilar, cnnKullanicilar);
            DataTable dtKullanicilar = new DataTable();
            daKullanicilar.Fill(dtKullanicilar);

            dgwKullanicilar.DataSource = dtKullanicilar;
            dgwKullanicilar.Refresh();
            cnnKullanicilar.Close();
        }

        public frmAna()
        {
            InitializeComponent();
        }

        public void frmAna_Load_()
        {

            if (Yetki == "Admin" )
            {
                GosterKullanicilar();
            }

            if (Yetki != "Admin")
            {
                pnlKullaniciKontrol.Visible = false;
            
            }

            if (Yetki != "Admin" && Yetki != "Yönetici")
            {
                pnlStokKontrol.Visible = false;
            }

            GosterMusteriler();
            GosterUrunler();
            GosterSatis();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            frmAna_Load_();

            string cnnstringUrunler = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryUrunler = "exec sp_UrunBilgi";
            SqlConnection cnnUrunler = new SqlConnection(cnnstringUrunler);
            SqlDataAdapter daUrunler = new SqlDataAdapter(queryUrunler, cnnUrunler);
            DataTable dtUrunler = new DataTable();
            daUrunler.Fill(dtUrunler);
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GosterKullanicilar();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (txtSilID.Text == "")
            {
                txtSilID.Text = "0";
            }

            string cnnstringKullaniciIDKontrol = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryKullaniciIDKontrol = "select * from Kullanicilar where KullaniciID='" + Convert.ToInt32(txtSilID.Text) + "'";
             
            SqlConnection cnnKullaniciIDKontrol = new SqlConnection(cnnstringKullaniciIDKontrol);
            cnnKullaniciIDKontrol.Open();
            SqlCommand cmdKullaniciIDKontrol = new SqlCommand(queryKullaniciIDKontrol);
            cmdKullaniciIDKontrol.Connection = cnnKullaniciIDKontrol;
            SqlDataAdapter daKullaniciIDKontrol = new SqlDataAdapter(queryKullaniciIDKontrol, cnnKullaniciIDKontrol);
            SqlDataReader drKullaniciIDKontrol = cmdKullaniciIDKontrol.ExecuteReader();

            if (drKullaniciIDKontrol.Read())
            {
                try
                {
                    string cnnstringKullaniciSil = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    string queryKullaniciSil = " delete  from Kullanicilar where KullaniciID='" + Convert.ToInt32(txtSilID.Text) + "'";
                    
                    SqlConnection cnnKullaniciSil = new SqlConnection(cnnstringKullaniciSil);
                    SqlDataAdapter daKullaniciSil = new SqlDataAdapter(queryKullaniciSil, cnnKullaniciSil);
                    DataTable dtKullaniciSil = new DataTable();
                    daKullaniciSil.Fill(dtKullaniciSil);

                    MessageBox.Show("Kullanıcı Silindi");
                    GosterKullanicilar();
                    cnnKullaniciSil.Close();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı ID'si");
            }
            cnnKullaniciIDKontrol.Close();
        }
        private void btnKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            if (txtDuzenleID.Text == "")
            {
                txtDuzenleID.Text = "0";
            }

            string cnnstringKullaniciIDKontrol = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryKullaniciIDKontrol = "select * from Kullanicilar where KullaniciID='" + Convert.ToInt32(txtDuzenleID.Text) + "'";

            SqlConnection cnnKullaniciIDKontrol = new SqlConnection(cnnstringKullaniciIDKontrol);
            cnnKullaniciIDKontrol.Open();
            SqlCommand cmdKullaniciIDKontrol = new SqlCommand(queryKullaniciIDKontrol);
            cmdKullaniciIDKontrol.Connection = cnnKullaniciIDKontrol;
            SqlDataAdapter daKullaniciIDKontrol = new SqlDataAdapter(queryKullaniciIDKontrol, cnnKullaniciIDKontrol);
            SqlDataReader drKullaniciIDKontrol = cmdKullaniciIDKontrol.ExecuteReader();

            if (drKullaniciIDKontrol.Read())
            {
                frmKullaniciDuzenle.KullaniciID = Convert.ToInt32(txtDuzenleID.Text);
                this.Hide();
                frmKullaniciDuzenle.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı ID'si!");
            }
            cnnKullaniciIDKontrol.Close();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUrunEkle frmUrunEkle = new frmUrunEkle();
            frmUrunEkle.Show();
            GosterUrunler();
        }

        private void UrunKaldir_Click(object sender, EventArgs e)
        {
            if (txtKaldirUrun.Text == "")
            {
                txtKaldirUrun.Text = "0";
            }

            string cnnstringUrunKodKontrol = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryUrunKodKontrol = "select * from Urunler where UrunKod='" + Convert.ToInt32(txtKaldirUrun.Text) + "'";

            SqlConnection cnnUrunKodKontrol = new SqlConnection(cnnstringUrunKodKontrol);
            cnnUrunKodKontrol.Open();
            SqlCommand cmdUrunKodKontrol = new SqlCommand(queryUrunKodKontrol);
            cmdUrunKodKontrol.Connection = cnnUrunKodKontrol;
            SqlDataAdapter daUrunKodKontrol = new SqlDataAdapter(queryUrunKodKontrol, cnnUrunKodKontrol);
            SqlDataReader drUrunKodKontrol = cmdUrunKodKontrol.ExecuteReader();

            if (drUrunKodKontrol.Read())
            {
                try
                {
                    string cnnstringUrunSil = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    string queryUrunSil = " delete from Urunler where UrunKod='" + Convert.ToInt32(txtKaldirUrun.Text) + "'";
                    SqlConnection cnnUrunSil = new SqlConnection(cnnstringUrunSil);
                    SqlDataAdapter daUrunSil = new SqlDataAdapter(queryUrunSil, cnnUrunSil);
                    DataTable dtUrunSil = new DataTable();
                    daUrunSil.Fill(dtUrunSil);

                    MessageBox.Show("Ürün kaldırıldı.");
                    GosterUrunler();
                    txtKaldirUrun.Text = "";
                    cnnUrunSil.Close();

            }
                catch
            {
                MessageBox.Show("Hata!");
            }
        }
            else
            {
                MessageBox.Show("Yanlış Ürün Kodu!");
            }
            cnnUrunKodKontrol.Close();
        }

        private void UrunDuzenle_Click(object sender, EventArgs e)
        {
            if (txtUrunDuzenle.Text == "")
            {
                txtUrunDuzenle.Text = "0";
            }

            string cnnstringUrunKodKontrol2 = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryUrunKodKontrol2 = "select * from Urunler where UrunKod='" + Convert.ToInt32(txtUrunDuzenle.Text) + "'";

            SqlConnection cnnUrunKodKontrol2 = new SqlConnection(cnnstringUrunKodKontrol2);
            cnnUrunKodKontrol2.Open();
            SqlCommand cmdUrunKodKontrol2 = new SqlCommand(queryUrunKodKontrol2);
            cmdUrunKodKontrol2.Connection = cnnUrunKodKontrol2;
            SqlDataAdapter daUrunKodKontrol2 = new SqlDataAdapter(queryUrunKodKontrol2, cnnUrunKodKontrol2);
            SqlDataReader drUrunKodKontrol2 = cmdUrunKodKontrol2.ExecuteReader();
        
            if (drUrunKodKontrol2.Read())
            {
                try
                {

                    frmUrunDuzenle.UrunKod = Convert.ToInt32(txtUrunDuzenle.Text);
                    this.Hide();
                    frmUrunDuzenle.Show();
                    GosterUrunler();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Yanlış Ürün Kodu!");
            }
            cnnUrunKodKontrol2.Close();
        }

        private void btnUrunBilgi_Click(object sender, EventArgs e)
        {
         
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frmMusteriEkle = new frmMusteriEkle();
            this.Hide();
            frmMusteriEkle.Show();
        }

        private void btnMusteriKaldir_Click(object sender, EventArgs e)
        {
            if (txtMusteriKaldir.Text == "")
            {
                txtMusteriKaldir.Text = "0";
            }

            string cnnstringTCKontrol = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryTCKontrol = "select * from Musteriler where TCKimlikNo='" + txtMusteriKaldir.Text + "'";

            SqlConnection cnnTCKontrol = new SqlConnection(cnnstringTCKontrol);
            cnnTCKontrol.Open();
            SqlCommand cmdTCKontrol = new SqlCommand(queryTCKontrol);
            cmdTCKontrol.Connection = cnnTCKontrol;
            SqlDataAdapter daTCKontrol = new SqlDataAdapter(queryTCKontrol, cnnTCKontrol);
            SqlDataReader drTCKontrol = cmdTCKontrol.ExecuteReader();

            if (drTCKontrol.Read())
            {
                try
                {
                    string cnnstringMusteriSil = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    string queryMusteriSil = " delete  from Musteriler where TCKimlikNo='" + txtMusteriKaldir.Text + "' ";
                    SqlConnection cnnMusteriSil = new SqlConnection(cnnstringMusteriSil);
                    SqlDataAdapter daMusteriSil = new SqlDataAdapter(queryMusteriSil, cnnMusteriSil);
                    DataTable dtMusteriSil = new DataTable();
                    daMusteriSil.Fill(dtMusteriSil);
                    MessageBox.Show("Kayıt Silindi");
                    GosterMusteriler();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Hatalı TC Kimlik No!");
            }
            cnnTCKontrol.Close();
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            if (txtMusteriDuzenle.Text == "")
            {
                txtMusteriDuzenle.Text = "0";
            }

            string cnnstringTCKontrol = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryTCKontrol = "select * from Musteriler where TCKimlikNo='" + txtMusteriDuzenle.Text + "'";

            SqlConnection cnnTCKontrol = new SqlConnection(cnnstringTCKontrol);
            cnnTCKontrol.Open();
            SqlCommand cmdTCKontrol = new SqlCommand(queryTCKontrol);
            cmdTCKontrol.Connection = cnnTCKontrol;
            SqlDataAdapter daTCKontrol = new SqlDataAdapter(queryTCKontrol, cnnTCKontrol);
            SqlDataReader drTCKontrol = cmdTCKontrol.ExecuteReader();

            if (drTCKontrol.Read())
            {
                try
                {
                    frmMusteriDuzenle.TCYeni = txtMusteriDuzenle.Text;
                    this.Hide();
                    frmMusteriDuzenle.Show();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Hatalı TC Kimlik No!");
            }
            cnnTCKontrol.Close();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            GosterMusteriler();
        }

        private void btnTCKontol_Click(object sender, EventArgs e)
        {
            if (txtMusteriTC.Text == "")
            {
                txtMusteriTC.Text = "0";
            }

            string cnnstringTCKontrol = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
            string queryTCKontrol = "select * from Musteriler where TCKimlikNo='" + txtMusteriTC.Text + "'";

            SqlConnection cnnTCKontrol = new SqlConnection(cnnstringTCKontrol);
            cnnTCKontrol.Open();
            SqlCommand cmdTCKontrol = new SqlCommand(queryTCKontrol);
            cmdTCKontrol.Connection = cnnTCKontrol;
            SqlDataAdapter daTCKontrol = new SqlDataAdapter(queryTCKontrol, cnnTCKontrol);
            SqlDataReader drTCKontrol = cmdTCKontrol.ExecuteReader();

            if (drTCKontrol.Read())
            {
                MessageBox.Show("Müşteri Kayıtlı");
            }
            else
            {
                MessageBox.Show("Yeni Müşteri");
                this.Hide();
                frmMusteriEkle frmMusteriEkle = new frmMusteriEkle();
                frmMusteriEkle.Show();
                GosterMusteriler();
            }
            cnnTCKontrol.Close();
        }

        private void btnSat_Click(object sender, EventArgs e)
        {

            if (txtMusteriTC.Text.Length == 0)
            {
                MessageBox.Show("lütfen bir müşteri TC giriniz");


            }
            else
            {

                try
                {

                    string cnnstringStokKontrol = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    string queryStokKontrol = " select UrunAdet from Urunler where UrunKod='" + Convert.ToInt32(txtUrunKod.Text) + "' ";
                    SqlConnection cnnStokKontrol = new SqlConnection(cnnstringStokKontrol);
                    SqlDataAdapter daStokKontrol = new SqlDataAdapter(queryStokKontrol, cnnStokKontrol);
                    DataTable dtStokKontrol = new DataTable();
                    daStokKontrol.Fill(dtStokKontrol);

                    int Adet = Convert.ToInt32(dtStokKontrol.Rows[0][0]);




                    if (Adet >= Convert.ToInt32(txtSatisAdet.Text))
                    {
                        try
                        {
                            string cnnstringUrunSat = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                            string queryUrunSat = " insert into Satislar(UrunKod,MusteriID,SatisTarih,Adet) values ('" + Convert.ToInt32(txtUrunKod.Text) + "',(select MusteriID from Musteriler where TCKimlikNo='" + txtMusteriTC.Text + "'),GETDATE(),'" + Convert.ToInt32(txtSatisAdet.Text) + "') ";
                            SqlConnection cnnUrunSat = new SqlConnection(cnnstringUrunSat);
                            SqlDataAdapter daUrunSat = new SqlDataAdapter(queryUrunSat, cnnUrunSat);
                            DataTable dtUrunSat = new DataTable();
                            daUrunSat.Fill(dtUrunSat);

                            MessageBox.Show("Satış Yapıldı");
                            GosterUrunler();
                            GosterSatis();
                        }
                        catch
                        {
                            MessageBox.Show("Satış Başarısız!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz Ütün Stoğu!");
                    }
                    cnnStokKontrol.Close();
                }
                catch
                {
                    MessageBox.Show("Hata! Lütfen Bilgileri Kontrol Edin.");
                }
                txtMusteriTC.Text = txtUrunKod.Text = txtSatisAdet.Text = "";

            }
        }

       
        private void btnStokRapolari_Click(object sender, EventArgs e)
        {
            frmStokRapor frmStokRapor = new frmStokRapor();
            this.Hide();
            frmStokRapor.Show();
        }

        private void btnSatisRapor_Click(object sender, EventArgs e)
        {
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void dgwKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUrunKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlKullaniciKontrol_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void pnlStokKontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            
        }

        private void tbpgSatis_Click(object sender, EventArgs e)
        {

        }

        private void tbpgStok_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmStokRapor frmStokRapor = new frmStokRapor();
            this.Hide();
            frmStokRapor.Show();
        }

        private void lblSatisUrunKod_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMusteriTC_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbpgStok_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_import_patch.Text = dlg.SelectedPath;
                btn_db_backup_imp1.Enabled = true;
            }
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (txt_import_patch.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen bir dosya yolu seçiniz ...");
                }
                else
                {
                    db.Open();
                    string qry = "BACKUP DATABASE ["+db.Database+"] TO  DISK = N'" + txt_import_patch.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand cmd = new SqlCommand(qry, db);
                    cmd.ExecuteNonQuery();
                    db.Close();


                    MessageBox.Show("İmport işlemi tamamlandı !");
                    
                }
            
            
        }
            catch
            {
                MessageBox.Show("Sistemsel hata ile karşılaşıldı !");
            }
}

        private void Button7_Click(object sender, EventArgs e)
        {
            string database = db.Database.ToString();
            if (db.State != ConnectionState.Open)
            {
                db.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, db);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox1.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, db);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, db);
                bu4.ExecuteNonQuery();

                MessageBox.Show("İçe aktarma işlemi tamamlandı !");
                db.Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void copyAlltoClipboard()
        {
            dataGridView2.SelectAll();
            DataObject dataObj = dataGridView2.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
                Clipboard.SetDataObject(dataObj);
                Clipboard.SetDataObject(dataObj);
                Clipboard.SetDataObject(dataObj);
                Clipboard.SetDataObject(dataObj);
                Clipboard.SetDataObject(dataObj);
        }

        private void Button5_Click_2(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void copyAlltoClipboard1()
        {
            dgwKullanicilar.SelectAll();
            DataObject dataObj = dgwKullanicilar.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
        }

       

        private void Button7_Click_2(object sender, EventArgs e)
        {
            copyAlltoClipboard1();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void Button9_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER backup dosyası|*.bak";
            dlg.Title = "Veritabanı Geri Yükleme";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.FileName;
               
            }
        }

        private void Txt_import_patch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            RPT.rpt myReport = new RPT.rpt();
            myReport.SetParameterValue("@ID", this.dgvMusteriler.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_MUSTER myForm = new RPT.FRM_RPT_MUSTER();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True");
            DataTable DT = new DataTable();
            if (textBox2.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select *  from Musteriler WHERE Ad like '"+textBox2.Text+ "%' OR SoyAd like '" + textBox2.Text + "%' OR TCkimlikNo like '" + textBox2.Text + "%'  ", con);
                sda.Fill(DT);

            }
            dgvMusteriler.DataSource = DT;

        }
        
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport1 myReport1 = new RPT.CrystalReport1();
            myReport1.SetParameterValue("@ID", this.dataGridView2.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_SIPARIS myForm1 = new RPT.FRM_RPT_SIPARIS();
            myForm1.crystalReportViewer2.ReportSource = myReport1;
            myForm1.ShowDialog();
        }

        private void Button13_Click(object sender, EventArgs e)
        {

            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void TxtSilID_TextChanged(object sender, EventArgs e)
        {








        }

        private void button15_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (op.ShowDialog() == DialogResult.OK)
            {
              //  co = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source =" + op.FileName + ";  Extended Properties = Excel 16.0 ");
                co = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + op.FileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";");
                de = new OleDbDataAdapter("select * from [sayfa1$]", co);
                dm = new DataTable();
                de.Fill(dm);
                this.dataGridView33.DataSource = dm;
           }

                


        }

        private void lblMusteriler_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }
    }
}
