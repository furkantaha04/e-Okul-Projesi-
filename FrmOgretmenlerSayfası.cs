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
using System.Runtime.InteropServices.ComTypes;
namespace e_Okul_Projesi
{
    public partial class FrmOgretmenlerSayfası : Form
    {
        SqlBaglanti baglan = new SqlBaglanti();
        public FrmOgretmenlerSayfası()
        {
            InitializeComponent();
        }
        _e_OkulDataSetTableAdapters.DataTable1TableAdapter ds = new _e_OkulDataSetTableAdapters.DataTable1TableAdapter();
    
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtogretmenAd.Text == "" || txtogretmenAd.Text == null)
                {
                    MessageBox.Show("Lutfen öğretmen adı giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtogrtSoyad.Text == "" || txtogrtSoyad.Text == null)
                {
                    MessageBox.Show("Lutfen Öğretmen Soyadı giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (mskTc.Text == "" || mskTc.Text == null || mskTc.Text.Length != 11)
                {
                    MessageBox.Show("Lutfen TC no yu eksiksiz veya boş bırakmayın, doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtSifre.Text == "" || txtSifre.Text == null || txtSifre.Text.Length != 6)
                {
                    MessageBox.Show("Lutfen en fazla 6 haneli bir şifre oluşturunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSifre.Clear();
                }
                else if (int.Parse(cmbBrans.SelectedValue.ToString()) == -1 || cmbBrans.Text == null)
                {
                    MessageBox.Show("Lutfen Branşı eksiksiz veya boş bırakmayın, doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand komut6 = new SqlCommand("SELECT COUNT(*) FROM [TBL-OGRETMENLER] WHERE OGRTTC = @OGRTTC", baglan.baglanti());
                    komut6.Parameters.AddWithValue("@OGRTTC", mskTc.Text);
                    int count = (int)komut6.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Bu TC kimlik numarası zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SqlCommand cmd = new SqlCommand("INSERT INTO [TBL-OGRETMENLER] (OGRTAD, OGRTSOYAD, OGRTTC, OGRTSİFRE, OGRTBRANS) VALUES (@OGRTAD,@OGRTSOYAD,@OGRTTC,@OGRTSİFRE,@OGRTBRANS)", baglan.baglanti());
                    cmd.Parameters.AddWithValue("@OGRTAD", txtogretmenAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@OGRTSOYAD", txtogrtSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@OGRTTC", mskTc.Text.Trim());
                    cmd.Parameters.AddWithValue("@OGRTSİFRE", txtSifre.Text.Trim());
                    cmd.Parameters.AddWithValue("@OGRTBRANS", cmbBrans.SelectedValue);
                    cmd.ExecuteNonQuery();
                    baglan.baglanti().Close();

                    MessageBox.Show(" Başarılı bir şekilde eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataOgretmen.DataSource = ds.Listele();
                    


                }
                
              
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmOgretmenlerSayfası_Load(object sender, EventArgs e)
        {
            dataOgretmen.DataSource = ds.Listele();
            SqlConnection Baglan = baglan.baglanti();
            using (SqlConnection conn = new SqlConnection(Baglan.ConnectionString))
            {
                conn.Open();

                SqlCommand komut = new SqlCommand("SELECT * FROM [TBL-DERSLER]", conn);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBrans.DisplayMember = "DERSAD";
                cmbBrans.ValueMember = "DERSID";
                cmbBrans.DataSource = dt;
            }
          
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataOgretmen.DataSource = ds.Listele();
            dataOgretmen.ClearSelection();
            MessageBox.Show("Listeleme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataOgretmen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtogretmenAd.Text = dataOgretmen.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtogrtSoyad.Text = dataOgretmen.Rows[e.RowIndex].Cells[1].Value.ToString();
            mskTc.Text = dataOgretmen.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSifre.Text = dataOgretmen.Rows[e.RowIndex].Cells[3].Value.ToString();
            var selectedValue = dataOgretmen.Rows[e.RowIndex].Cells[4].Value;
            if (selectedValue != null)
            {
                cmbBrans.Text = selectedValue.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seçili öğretmeni silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                string Ogrtad = txtogretmenAd.Text; 
                string tc = mskTc.Text;

                if (!string.IsNullOrEmpty(Ogrtad))
                {
                    // Öğrenciyi sil
                    ds.Silme(Ogrtad,tc); 
                    MessageBox.Show("Öğretmen başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    dataOgretmen.DataSource = ds.Listele();
                   


                }
                else
                {
                    MessageBox.Show("Silmek için bir Öğretmen seçin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtogretmenAd.Text == "" || txtogretmenAd.Text == null)
            {
                MessageBox.Show("Lutfen öğretmen adı giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtogrtSoyad.Text == "" || txtogrtSoyad.Text == null)
            {
                MessageBox.Show("Lutfen Öğretmen Soyadı giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (mskTc.Text == "" || mskTc.Text == null || mskTc.Text.Length != 11)
            {
                MessageBox.Show("Lutfen TC no yu eksiksiz veya boş bırakmayın, doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSifre.Text == "" || txtSifre.Text == null || txtSifre.Text.Length != 6)
            {
                MessageBox.Show("Lutfen en fazla 6 haneli bir şifre oluşturunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(cmbBrans.SelectedValue.ToString()) == -1 || cmbBrans.Text == null)
            {
                MessageBox.Show("Lutfen Branşı eksiksiz veya boş bırakmayın, doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ds.Guncelle(txtogretmenAd.Text, txtogrtSoyad.Text, mskTc.Text, txtSifre.Text, byte.Parse(cmbBrans.SelectedValue.ToString()));
            }
            MessageBox.Show("Başarılı bir şekilde Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataOgretmen.DataSource = ds.Listele();
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtogretmenAd.Clear();
            txtogrtSoyad.Clear();
            txtSifre.Clear();   
            mskTc.Clear();
            cmbBrans.DisplayMember="KURS SEÇİNİZ";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtogretmenAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Girişi engelle
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
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
            FrmMudurDetay f = new FrmMudurDetay();
            f.Show();
            this.Hide();
        }
    }
}
