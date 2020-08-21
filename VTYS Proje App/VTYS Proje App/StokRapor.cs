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
    public partial class frmStokRapor : Form
    {
        public frmStokRapor()
        {
            InitializeComponent();
        }

        private void frmStokRapor_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection StokFull = new SqlConnection();
                StokFull.ConnectionString = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                SqlCommand komutStokFull = new SqlCommand();
                komutStokFull.CommandText = "SELECT UrunAd FROM Urunler";
                komutStokFull.Connection = StokFull;
                komutStokFull.CommandType = CommandType.Text;

                SqlDataReader dr;
                StokFull.Open();
                dr = komutStokFull.ExecuteReader();
                while (dr.Read())
                {
                    cBoxUrunAd.Items.Add(dr["UrunAd"]);
                }
                StokFull.Close();
            }
            catch
            {
                MessageBox.Show("Hata!");
            }
        }

        private void cBoxUrunTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cBoxUrunAd.Items.Clear();

                if (cBoxUrunTur.Text == "Ağız-Diş Bakımı")
                {
                    SqlConnection StokFull = new SqlConnection();
                    StokFull.ConnectionString = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='Ağız-Diş Bakımı'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else if (cBoxUrunTur.Text == "Bebek Ürünleri")
                {
                    SqlConnection StokFull = new SqlConnection();
                    StokFull.ConnectionString = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='Bebek Ürünleri'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else if (cBoxUrunTur.Text == "Saç Bakımı")
                {
                    SqlConnection StokFull = new SqlConnection();
                    StokFull.ConnectionString = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='Saç Bakımı'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else if (cBoxUrunTur.Text == "Vitamin-Sağlık")
                {
                    SqlConnection StokFull = new SqlConnection();
                    StokFull.ConnectionString = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='Vitamin-Sağlık'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else if (cBoxUrunTur.Text == "İaçlar")
                {
                    SqlConnection StokFull = new SqlConnection();
                    StokFull.ConnectionString = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='İaçlar'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else
                {
                    SqlConnection StokFull = new SqlConnection();
                    StokFull.ConnectionString = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }

            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            try
            {
                string cnnstringKalan = @"Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True";
                string queryKalan = " Select UrunAdet from Urunler where UrunKod=(Select UrunKod from Urunler where UrunAd='" + cBoxUrunAd.Text + "')";
                SqlConnection cnnKalan = new SqlConnection(cnnstringKalan);
                SqlDataAdapter daKalan = new SqlDataAdapter(queryKalan, cnnKalan);
                DataTable dtKalan = new DataTable();
                daKalan.Fill(dtKalan);

                lblStoktaKalanAdet.Text = dtKalan.Rows[0][0].ToString();

            }
            catch
            {
                MessageBox.Show("Hata!");
            }
        }

        private void btnKalanModelGoster_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-EQDG4D1;Initial Catalog=Eczane;Integrated Security=True");
                DataTable DT = new DataTable();
                if (cBoxKalanModel.Text.Length > 0)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select UrunAd,UrunTur,UrunAdet,UrunFiyat  from [Urunler] WHERE UrunTur like '" + cBoxKalanModel.Text + "%' ", con);
                    sda.Fill(DT);

                }
                dataGridView3.DataSource = DT;
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAna frmAna = new frmAna();
            this.Close();
            frmAna.Show();
        }

        private void cBoxUrunTur_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cBoxUrunAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblUrunAd_Click(object sender, EventArgs e)
        {

        }

        private void lblStoktaKalan_Click(object sender, EventArgs e)
        {

        }
        private void copyAlltoClipboard()
        {
            dataGridView3.SelectAll();
            DataObject dataObj = dataGridView3.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
            Clipboard.SetDataObject(dataObj);
        }
        private void Button1_Click(object sender, EventArgs e)
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
    }
}
