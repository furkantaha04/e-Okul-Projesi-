using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Okul_Projesi
{
    public partial class FrmMudurDetay : Form
    {
        public FrmMudurDetay()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti();
      
        public string tc;
        private void btnDersislemleri_Click(object sender, EventArgs e)
        {
            FrmDersIslemleri fr = new FrmDersIslemleri();
            fr.Show();
            this.Hide();
        }
        private void VerileriYukle()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Duyuru FROM [TBL-DUYURU]", baglan.baglanti());
            da.Fill(dt);
            dataMesaj.DataSource = dt;
            baglan.baglanti().Close();
        }
        private void FrmMudurDetay_Load(object sender, EventArgs e)
        {
           VerileriYukle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgrenciIslemleri f = new FrmOgrenciIslemleri();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOgretmenlerSayfası frm = new FrmOgretmenlerSayfası();
            frm.Show();
            this.Hide();
        }

     

        private void btnDersProgramı_Click(object sender, EventArgs e)
        {
            FrmDersProgramı fr = new FrmDersProgramı();
            fr.Show();
            this.Hide();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(richDuyuru.Text))
                {
                    MessageBox.Show("Duyuru metni boş olamaz. Lütfen bir duyuru yazın.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO [TBL-DUYURU] (duyuru) VALUES (@d1)", baglan.baglanti());
                    komut.Parameters.AddWithValue("@d1", richDuyuru.Text);
                    komut.ExecuteNonQuery(); 
                    baglan.baglanti().Close(); 

                    MessageBox.Show("Duyuru başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    richDuyuru.Clear(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string selectedDuyuruMetni = string.Empty;
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedDuyuruMetni))
            {
                MessageBox.Show("Lütfen silmek istediğiniz duyuruyu seçin!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;  // Eğer duyuru seçilmemişse işlem yapma
            }

            // Kullanıcıya onay sor
            DialogResult dialogResult = MessageBox.Show($"Silmek istediğiniz duyuru: {selectedDuyuruMetni} \nSilmek istediğinizden emin misiniz?", "Duyuru Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Duyuru veritabanından sil
                    string sqlDelete = "DELETE FROM [TBL-DUYURU] WHERE Duyuru = @duyuru";
                    SqlCommand komut = new SqlCommand(sqlDelete, baglan.baglanti());
                    komut.Parameters.AddWithValue("@duyuru", selectedDuyuruMetni);
                    komut.ExecuteNonQuery();
                    baglan.baglanti().Close();

                    // Verileri güncelle
                    VerileriYukle();

                    MessageBox.Show("Duyuru başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıyı bilgilendir
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataMesaj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Satır seçildiğinde
            {
                selectedDuyuruMetni = dataMesaj.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void picturKapatma_MouseLeave(object sender, EventArgs e)
        {
            picturKapatma.Image = e_Okul_Projesi.Properties.Resources.KapatmaLeave;
        }

        private void picturKapatma_MouseEnter(object sender, EventArgs e)
        {
            picturKapatma.Image = e_Okul_Projesi.Properties.Resources.ExitButton;
        }

        private void picturKapatma_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
              FrmGirisler t = new FrmGirisler();
                t.Show();
                this.Close();
            }
        }

        private void btnSınıf_Click(object sender, EventArgs e)
        {
            Sınıf a = new Sınıf();
            a.Show();
            this.Hide();
        }
    }
}
