using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace e_Okul_Projesi
{
    public partial class FrmOgrenciIslemleri : Form
    {
        SqlBaglanti baglan = new SqlBaglanti();
        public FrmOgrenciIslemleri()
        {
            InitializeComponent();
        }
       
        _e_OkulDataSetTableAdapters.TBL_OGRENCİTableAdapter ds = new _e_OkulDataSetTableAdapters.TBL_OGRENCİTableAdapter();
        private void FrmOgrenciIslemleri_Load(object sender, EventArgs e)
        {
            dataOgrenciİslemi.DataSource = ds.GetData();
            dataOgrenciİslemi.Columns["OGRID"].Visible = false;

            SqlConnection Baglan = baglan.baglanti();
           using (SqlConnection conn = new SqlConnection(Baglan.ConnectionString))
            {
                conn.Open();

                SqlCommand komut = new SqlCommand("SELECT * FROM [TBL-KURS]", conn);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbKurs.DisplayMember = "KURSAD";
                cmbKurs.ValueMember = "KURSID";
                cmbKurs.DataSource = dt;
            }

            try
            {
                // Bağlantıyı aç
                using (SqlConnection connection = baglan.baglanti())
                {


                    // TBL-SINIF tablosundan tüm verileri çek
                    SqlCommand c = new SqlCommand("SELECT * FROM [TBL-SINIF]", connection);
                    SqlDataAdapter r = new SqlDataAdapter(c);

                    // DataTable oluştur
                    DataTable dataTable2 = new DataTable();
                    r.Fill(dataTable2);

                  
                    cmbsınıf.DataSource = dataTable2;
                    cmbsınıf.DisplayMember = "SINIFAD";
                    cmbsınıf.ValueMember = "SINIFID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            
           
        
      
    
        string c = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {
            

            try
            {


                if (txtOgrAd.Text == "" || txtOgrAd.Text == null)
                {
                    MessageBox.Show("Lutfen öğrenci adı giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtOgrSoyad.Text == "" || txtOgrSoyad.Text == null)
                {
                    MessageBox.Show("Lutfen öğrenci Soyadı giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (int.Parse(cmbKurs.SelectedValue.ToString()) == -1 || cmbKurs.Text == null)
                {
                    MessageBox.Show("Lutfen Kurs Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (c == "" || c == null)
                {
                    MessageBox.Show("Lutfen Cinsiyet seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                else if (txtNo.Text.Length != 3 || txtNo.Text == "" || txtNo.Text == null)
                {
                    MessageBox.Show("Lutfen Numarayı eksiksiz veya boş bırakmayın, doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                   
                
                else
                {
                    SqlCommand komut6 = new SqlCommand("SELECT COUNT(*) FROM [TBL-OGRENCİ] WHERE OGRTC = @OGRTC",baglan.baglanti());
                    komut6.Parameters.AddWithValue("@OGRTC", mskTCOGRİS.Text);
                    int count = (int)komut6.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Bu TC kimlik numarası zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SqlCommand komut7 = new SqlCommand("SELECT COUNT(*) FROM [TBL-OGRENCİ] WHERE OGRNO = @OGRNO", baglan.baglanti());
                    komut7.Parameters.AddWithValue("@OGRNO", txtNo.Text);
                    int sayac = (int)komut7.ExecuteScalar();

                    if (sayac > 0)
                    {
                        MessageBox.Show("Bu   numara zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }

                SqlCommand cmd = new SqlCommand("INSERT INTO [TBL-OGRENCİ] (OGRAD, OGRSOYAD, OGRKURS, OGRCINSIYET, OGRTC, OGRNO,SINIFID) VALUES (@OGRAD,@OGRSOYAD,@OGRKURS,@OGRCINSIYET,@OGRTC,@OGRNO,@SINIFID)", baglan.baglanti());
                cmd.Parameters.AddWithValue("@OGRAD", txtOgrAd.Text.Trim());
                cmd.Parameters.AddWithValue("@OGRSOYAD", txtOgrSoyad.Text.Trim());
                cmd.Parameters.AddWithValue("@OGRKURS", cmbKurs.SelectedValue);
                cmd.Parameters.AddWithValue("@SINIFID", cmbsınıf.SelectedValue);
                cmd.Parameters.AddWithValue("@OGRCINSIYET", c);
                cmd.Parameters.AddWithValue("@OGRTC", mskTCOGRİS.Text.Trim());
                cmd.Parameters.AddWithValue("@OGRNO", txtNo.Text.Trim());
                cmd.ExecuteNonQuery();
                baglan.baglanti().Close();
                MessageBox.Show("Kurs ekleme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOgrAd.Clear();
                txtOgrSoyad.Clear();
                txtNo.Clear();
                mskTCOGRİS.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            dataOgrenciİslemi.DataSource = ds.GetData();
            dataOgrenciİslemi.ClearSelection();
            dataOgrenciİslemi.Columns["OGRID"].Visible = false; 
            MessageBox.Show("Listeleme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           
            var result = MessageBox.Show("Seçili öğrenciyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                string ogrenciAd = txtOgrAd.Text;
                string tc = mskTCOGRİS.Text;

                if (!string.IsNullOrEmpty(ogrenciAd))
                {
                   
                    ds.OgrenciSil(ogrenciAd,tc); 
                    MessageBox.Show("Öğrenci başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                 
                  

                    radioKız.Checked = false;
                    RadioErkek.Checked = false;

                    
                    dataOgrenciİslemi.DataSource = ds.GetData(); 
                }
                else
                {
                    MessageBox.Show("Silmek için bir öğrenci seçin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataOgrenciİslemi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedValue = dataOgrenciİslemi.Rows[e.RowIndex].Cells[5].Value;
            if (selectedValue != null)
            {
                cmbKurs.Text = selectedValue.ToString();
            }
            txtOgrAd.Text = dataOgrenciİslemi.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOgrSoyad.Text = dataOgrenciİslemi.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNo.Text = dataOgrenciİslemi.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskTCOGRİS.Text = dataOgrenciİslemi.Rows[e.RowIndex].Cells[3].Value.ToString();



            // Cinsiyet RadioButton'larını ayarlama
            string cinsiyet = dataOgrenciİslemi.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (cinsiyet == "Erkek")
            {
                RadioErkek.Checked = true;
                radioKız.Checked = false;
            }
            else
            {
                RadioErkek.Checked = false;
                radioKız.Checked = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtOgrAd.Clear();
            txtOgrSoyad.Clear();
            mskTCOGRİS.Clear();
            txtNo.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.Guncelle(txtOgrAd.Text,txtOgrSoyad.Text,byte.Parse(cmbKurs.SelectedValue.ToString()),c,mskTCOGRİS.Text,txtNo.Text,int.Parse(cmbsınıf.SelectedValue.ToString()));
        }

        private void radioKız_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKız.Checked == true)
            {
                c = "KIZ";
            }
        }

        private void RadioErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioErkek.Checked == true)
            {
                c = "ERKEK";
            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           dataOgrenciİslemi.DataSource =    ds.OgrenciGetir(txtarama.Text);
            txtarama.Clear();
        }

        private void txtOgrAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Girişi engelle
            }
        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
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
            FrmMudurDetay fr = new FrmMudurDetay();
            fr.Show();
            this.Hide();
        }
    }
}
