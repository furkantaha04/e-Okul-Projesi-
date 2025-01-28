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
    public partial class Sınıf : Form
    {
        public Sınıf()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti(); 
        private void Sınıf_Load(object sender, EventArgs e)
        {
            try
            {
                // Bağlantıyı aç
                using (SqlConnection connection = baglan.baglanti())
                {
                  

                    // TBL-SINIF tablosundan tüm verileri çek
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [TBL-SINIF]", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    // DataTable oluştur
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e verileri aktar
                    datasınıfProgram.DataSource = dataTable;
                    cmbsınıf.DataSource = dataTable;
                    cmbsınıf.DisplayMember = "SINIFAD";
                    cmbsınıf.ValueMember = "SINIFID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantıyı aç
                using (SqlConnection connection = baglan.baglanti())
                {
                   

                    // TBL-SINIF tablosundan tüm verileri çek
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [TBL-SINIF]", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    // DataTable oluştur
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e verileri aktar
                    datasınıfProgram.DataSource = dataTable;
                    cmbsınıf.DataSource = dataTable;
                    cmbsınıf.DisplayMember = "SINIFAD";
                    cmbsınıf.ValueMember = "SINIFID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Güncellendi ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            datasınıfProgram.ClearSelection();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSınıfad.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSınıfad.Text))
            {
                try
                {
                    using (SqlConnection connection = baglan.baglanti())
                    {
                  

                        // Sınıf adının zaten var olup olmadığını kontrol et
                        SqlCommand kontrolCmd = new SqlCommand("SELECT COUNT(*) FROM [TBL-SINIF] WHERE SINIFAD = @SINIFAD", connection);
                        kontrolCmd.Parameters.AddWithValue("@SINIFAD", txtSınıfad.Text.Trim());
                        int mevcutKayit = (int)kontrolCmd.ExecuteScalar();

                        if (mevcutKayit > 0)
                        {
                            MessageBox.Show("Bu sınıf adı zaten mevcut. Lütfen farklı bir sınıf adı giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Sınıf adını eklemek için SQL sorgusu
                        SqlCommand cmd = new SqlCommand("INSERT INTO [TBL-SINIF] (SINIFAD) VALUES (@SINIFAD); SELECT SCOPE_IDENTITY();", connection);
                        cmd.Parameters.AddWithValue("@SINIFAD", txtSınıfad.Text.Trim());

                        int sinifId = Convert.ToInt32(cmd.ExecuteScalar());

                      
                        for (int i = 0; i < 9; i++)
                        {
                            SqlCommand dersProgramCmd = new SqlCommand("INSERT INTO [TBL-DERSPROGRAMI] (SINIFID) VALUES (@SinifID)", connection);
                            dersProgramCmd.Parameters.AddWithValue("@SinifID", sinifId); // Eklenen sınıf ID'si

                           
                            dersProgramCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Sınıf adı ve ders programı başarıyla oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen sınıf adı giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (datasınıfProgram.SelectedRows.Count > 0)
            {
                // Seçilen satırın sınıf adını al
                string sinifAd = datasınıfProgram.SelectedRows[0].Cells["SINIFAD"].Value.ToString();

                try
                {
                    using (SqlConnection connection = baglan.baglanti())
                    {
                      

                        // Sınıf adını silmek için SQL sorgusu
                        SqlCommand cmd = new SqlCommand("DELETE FROM [TBL-SINIF] WHERE SINIFAD = @SinifAd", connection);
                        cmd.Parameters.AddWithValue("@SinifAd", sinifAd.Trim());

                        // Sorguyu çalıştır
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Seçilen sınıf adı başarılı bir şekilde silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnListele_Click(sender, e);


                        }
                        else
                        {
                            MessageBox.Show("Silinecek sınıf adı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir sınıf seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (datasınıfProgram.SelectedRows.Count > 0)
            {
                // Seçilen satırdan eski sınıf adını al
                string eskiSinifAd = datasınıfProgram.SelectedRows[0].Cells["SINIFAD"].Value.ToString();

                // Yeni sınıf adını al
                string yeniSinifAd = txtSınıfad.Text.Trim(); // txtSınıfad kontrolünden yeni ad alınıyor

                if (!string.IsNullOrEmpty(yeniSinifAd))
                {
                    try
                    {
                        using (SqlConnection connection = baglan.baglanti())
                        {
                  

                            // Sınıf adını güncellemek için SQL sorgusu
                            SqlCommand cmd = new SqlCommand("UPDATE [TBL-SINIF] SET SINIFAD = @YeniSinifAd WHERE SINIFAD = @EskiSinifAd", connection);
                            cmd.Parameters.AddWithValue("@YeniSinifAd", yeniSinifAd);
                            cmd.Parameters.AddWithValue("@EskiSinifAd", eskiSinifAd);

                            // Sorguyu çalıştır
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Seçilen sınıf adı başarılı bir şekilde güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnListele_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Güncellenecek sınıf adı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen yeni sınıf adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir sınıf seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datasınıfProgram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
            
                string sinifAd = datasınıfProgram.Rows[e.RowIndex].Cells["SINIFAD"].Value.ToString();

              
                txtSınıfad.Text = sinifAd;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (SqlConnection connection = baglan.baglanti())
                {
             

                    // TBL-SINIF tablosundan tüm verileri çek
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [TBL-SINIF] WHERE SINIFID = @SINIFID", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@SINIFID", cmbsınıf.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                  
                    datasınıfProgram.DataSource = dataTable;
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
