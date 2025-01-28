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
    public partial class Kurs_islemleri_Paneli : Form
    {
        SqlBaglanti baglan = new SqlBaglanti();
        private string ogrtc;
        public Kurs_islemleri_Paneli(string _ogrtc)
        {
            ogrtc = _ogrtc;
            InitializeComponent();
        }



        
        void liste()
        {
            SqlConnection Baglan = baglan.baglanti();
            using (SqlConnection conn = new SqlConnection(Baglan.ConnectionString)) 
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [TBL-KURS]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                DataTable dtWithId = new DataTable();
                dtWithId.Columns.Add("KURSID", typeof(int));
                dtWithId.Columns.Add("ID", typeof(int));
                dtWithId.Columns.Add("KURSAD", typeof(string));


               
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dtWithId.Rows.Add(dt.Rows[i]["KURSID"], i + 1, dt.Rows[i]["KURSAD"]);
                }

                dataKurs.DataSource = dtWithId; 
               dataKurs.Columns["KURSID"].Visible = false;
            }
        }


        private void Kurs_islemleri_Paneli_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            liste();
            dataKurs.ClearSelection();
            MessageBox.Show("Listeleme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtKursAd.Text))
                {
                    MessageBox.Show("Lütfen kurs adı giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = baglan.baglanti())
                {
                  

                    // KURSAD mevcut mu kontrol et
                    SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM [TBL-KURS] WHERE KURSAD = @P1", connection);
                    kontrolKomut.Parameters.AddWithValue("@P1", txtKursAd.Text.Trim());
                    int mevcutKayit = (int)kontrolKomut.ExecuteScalar();

                    if (mevcutKayit > 0)
                    {
                        MessageBox.Show("Bu kurs adı zaten mevcut!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // KURSAD ekle
                        SqlCommand komut = new SqlCommand("INSERT INTO [TBL-KURS] (KURSAD) VALUES (@P1)", connection);
                        komut.Parameters.AddWithValue("@P1", txtKursAd.Text.Trim());
                        komut.ExecuteNonQuery();

                        MessageBox.Show("Kurs ekleme işlemi başarılı bir şekilde gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hatalı işlem: {ex.Message}", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtKursAd.Clear();

        }


        private void dataKurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKursıd.Text = dataKurs.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKursAd.Text = dataKurs.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKursAd.Text == "" || txtKursAd.Text == null)
            {
                MessageBox.Show("Lutfen Kurs Seçip işlem yapınız", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Delete From [TBL-KURS] WHERE KURSID=@P1", baglan.baglanti());
                komut.Parameters.AddWithValue("@P1", txtKursıd.Text);

                komut.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Kurs Silme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txtKursAd.Clear();
                txtKursıd.Clear();

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKursAd.Text == "" || txtKursAd.Text == null)
            {
                MessageBox.Show("Lutfen Güncellenecek satırı seçiniz....","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Update [TBL-KURS] SET KURSAD=@P1 WHERE KURSID=@P2", baglan.baglanti());
                komut.Parameters.AddWithValue("@P1", txtKursAd.Text);
                komut.Parameters.AddWithValue("@P2", txtKursıd.Text);

                komut.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Kurs Güncelleme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                txtKursAd.Clear();
                txtKursıd.Clear();
            }
      
        }

        private void txtKursAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
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
            FrmÖgretmenDetay R = new FrmÖgretmenDetay(ogrtc);
            R.Show();
            this.Hide();
        }
    }
}
