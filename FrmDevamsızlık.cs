using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Okul_Projesi
{
    public partial class FrmDevamsızlık : Form
    {
        private string connectionString = "Data Source=FURKAN-TAHA;Initial Catalog=e-Okul;Integrated Security=True;TrustServerCertificate=True";
        private string ogrtc;
        public FrmDevamsızlık(string _ogrtc)
        {
            InitializeComponent();
          ogrtc = _ogrtc;
        }
        private void Listele()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT d.DEVAMID,d.OGRID, o.OGRAD, d.OZURLU, d.OZURSUZ, d.DURUM FROM [TBL-DEVAMSIZLIK] d JOIN [TBL-OGRENCİ] o ON d.OGRID = o.OGRID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataDevam.DataSource = dt;
            }
        }

        private void Guncelle()
        {
            if (!int.TryParse(txtOzurlu.Text, out int ozurlu) || !int.TryParse(txtOzursuz.Text, out int ozursuz))
            {
                MessageBox.Show("Lütfen OZURLU ve OZURSUZ alanlarına geçerli bir sayı girin.");
                return;
            }

           
            string durum = ozurlu >= 5 ? "False" : "True";
            txtDurum.Text = durum;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

              
                SqlCommand cmd = new SqlCommand("UPDATE [TBL-DEVAMSIZLIK] SET  OZURLU = @OZURLU, OZURSUZ = @OZURSUZ, DURUM = @DURUM WHERE DEVAMID = @DEVAMID", conn);
                cmd.Parameters.AddWithValue("@DEVAMID", int.Parse(txtDevamId.Text));
              
                cmd.Parameters.AddWithValue("@OZURLU", ozurlu);
                cmd.Parameters.AddWithValue("@OZURSUZ", ozursuz);
                cmd.Parameters.AddWithValue("@DURUM", durum); 

               
                if (ozursuz > 30)
                {
                    MessageBox.Show("OZURSUZ hakkı 30 günden fazla olamaz.");
                    return; 
                }

                cmd.ExecuteNonQuery();
            }
            Listele();
        }

      

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            dataDevam.ClearSelection();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            Guncelle();
        }

        private void FrmDevamsızlık_Load(object sender, EventArgs e)
        {
           
            Listele();
        }

        private void dataDevam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataDevam.Rows[e.RowIndex];

                txtDevamId.Text = row.Cells["DEVAMID"].Value.ToString();
                txtOzurlu.Text = row.Cells["OZURLU"].Value.ToString();
                txtOzursuz.Text = row.Cells["OZURSUZ"].Value.ToString();
                txtDurum.Text = row.Cells["DURUM"].Value.ToString();
                txtıd.Text = row.Cells["OGRID"].Value.ToString();
            }
        }


        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtıd.Text))
                {
                    MessageBox.Show("Lütfen öğrenci ID giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"
            INSERT INTO [TBL-DEVAMSIZLIK] (OGRID)
            SELECT @OGRID
            WHERE NOT EXISTS (
                SELECT 1 FROM [TBL-DEVAMSIZLIK] WHERE OGRID = @OGRID
            )", conn);

                    cmd.Parameters.AddWithValue("@OGRID", txtıd.Text.Trim());
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Öğrenci ekleme işlemi başarılı bir şekilde gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bu öğrenci ID zaten mevcut.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    txtıd.Clear();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("ID bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        _e_OkulDataSetTableAdapters.TBL_DEVAMSIZLIKTableAdapter ds = new _e_OkulDataSetTableAdapters.TBL_DEVAMSIZLIKTableAdapter();
        private void btnAra_Click(object sender, EventArgs e)
        {
            if(txtıd.Text == "" || txtıd.Text==null)
            {
                MessageBox.Show("ID bulunamadı boş bırakma .", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataDevam.DataSource = ds.Ara(int.Parse(txtıd.Text));
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDevamId.Clear();
            txtDurum.Clear();
            txtOzurlu.Clear();
            txtOzursuz.Clear();
            txtıd.Clear() ;
        }

        private void txtıd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
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
            FrmÖgretmenDetay f = new FrmÖgretmenDetay(ogrtc);
            f.Show();
            this.Hide();
        }
    }
}
