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

namespace e_Okul_Projesi
{
    public partial class FrmDersIslemleri : Form
    {
        SqlBaglanti baglan = new SqlBaglanti();
        public FrmDersIslemleri()
        {
            InitializeComponent();
        }

      
        void liste()
        {
            SqlConnection Baglan = baglan.baglanti();
            using (SqlConnection conn = new SqlConnection(Baglan.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [TBL-DERSLER]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                DataTable dtWithId = new DataTable();
                dtWithId.Columns.Add("DERSID", typeof(int));
                dtWithId.Columns.Add("ID", typeof(int));
                dtWithId.Columns.Add("DERSAD", typeof(string));



                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dtWithId.Rows.Add(dt.Rows[i]["DERSID"], i + 1, dt.Rows[i]["DERSAD"]);
                }

                dataDers.DataSource = dtWithId;
                dataDers.Columns["DERSID"].Visible = false;
            }
        }
       
        private void FrmDersIslemleri_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            liste();
            dataDers.ClearSelection();
            MessageBox.Show("Listeleme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtDersAd.Text == "" || txtDersAd.Text == null)
                {
                    MessageBox.Show("Lutfen ders adı giriniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO [TBL-DERSLER] (DERSAD) VALUES (@P1)", baglan.baglanti());
                    komut.Parameters.AddWithValue("@P1", txtDersAd.Text);
                    komut.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show("Kurs ekleme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"HATALI YETERİ KADAR ALAN DOLDURULDU = {ex.Message}", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            txtDersAd.Clear();
        }

        private void dataDers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersId.Text = dataDers.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersAd.Text = dataDers.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtDersAd.Text == "" || txtDersAd.Text == null)
            {
                MessageBox.Show("Lutfen Kurs Seçip işlem yapınız", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Delete From [TBL-DERSLER] WHERE DERSID=@P1", baglan.baglanti());
                komut.Parameters.AddWithValue("@P1", txtDersId.Text);

                komut.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Ders Silme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDersAd.Clear();
                txtDersId.Clear();

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtDersAd.Text == "" || txtDersAd.Text == null)
            {
                MessageBox.Show("Lutfen Güncellenecek satırı seçiniz....", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Update [TBL-DERSLER] SET DERSAD=@P1 WHERE DERSID=@P2", baglan.baglanti());
                komut.Parameters.AddWithValue("@P1", txtDersAd.Text);
                komut.Parameters.AddWithValue("@P2", txtDersId.Text);

                komut.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Ders Güncelleme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDersAd.Clear();
                txtDersId.Clear();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDersAd.Clear();
            txtDersId.Clear();
        }

        private void txtDersAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Girişi engelle
            }
        }

        private void Geri_MouseLeave(object sender, EventArgs e)
        {
            Geri.Image = e_Okul_Projesi.Properties.Resources.GeriSiyah;
        }

        private void Geri_MouseEnter(object sender, EventArgs e)
        {
            Geri.Image = e_Okul_Projesi.Properties.Resources.Back;
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            FrmMudurDetay f    = new FrmMudurDetay();
            f.Show();
            this.Hide();
        }
    }
}
