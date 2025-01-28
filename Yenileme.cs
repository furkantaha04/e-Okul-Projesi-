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
    public partial class Yenileme : Form
    {
        private int tc;
        public Yenileme(int _tc)
        {
            tc = _tc;
            InitializeComponent();
        }

        private void Yenileme_Load(object sender, EventArgs e)
        {

        }

    

        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            string yeniSifre = txtYenisifre.Text.Trim().Replace(" ","");
            string yeniSifreOnay = txtsifreonay.Text.Trim().Replace(" ", "");


            if (yeniSifre == yeniSifreOnay && yeniSifre.Length == 6 && yeniSifreOnay.Length == 6)
            {
                // Veritabanı bağlantısını yap
                using (SqlConnection conn = new SqlConnection("Data Source=FURKAN-TAHA;Initial Catalog=e-Okul;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = "UPDATE [TBL-OGRETMENLER] SET OGRTSİFRE = @YeniSifre WHERE OGRTSİFRE = @OGRTSİFRE";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@YeniSifre", yeniSifre);
                        cmd.Parameters.AddWithValue("@OGRTSİFRE", tc); 

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Güncelleme başarılı. Giriş sekmesine yönlendiriliyorsunuz...", "İNFORMATİON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            FrmÖgretmenGiris fr = new FrmÖgretmenGiris();
                            fr.Show();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme Başarısız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(" Şifreler eşleşmiyor...    6 Haneli giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtYenisifre.PasswordChar = '\0';
            txtsifreonay.PasswordChar = '\0';
            
            pictureBox3.Image = e_Okul_Projesi.Properties.Resources.eye;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtYenisifre.PasswordChar = '*';
            txtsifreonay.PasswordChar = '*';
            pictureBox3.Image = e_Okul_Projesi.Properties.Resources.hidden;
        }

      

        private void txtYenisifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtYenisifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOgretmenGuncelle_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
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
            OgrtSifremiUnuttum f = new OgrtSifremiUnuttum();
            f.Show();
            this.Hide();
        }
    }
}
