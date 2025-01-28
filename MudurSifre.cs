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
    public partial class MudurSifre : Form
    {
        private int TC;
      
        public MudurSifre(int _TC)
        {
            TC = _TC;
            InitializeComponent();
        }

     

        private void btnMudurGuncelle_Click(object sender, EventArgs e)
        {
            string yenisifre = txtYenisifre.Text.Trim().Replace(" ", "");
            string yeniSifreOnay = txtsifreonay.Text.Trim().Replace(" ", "");


            if (yenisifre == yeniSifreOnay && yenisifre.Length == 6 && yeniSifreOnay.Length == 6)
            {
                // Veritabanı bağlantısını yap
                using (SqlConnection conn = new SqlConnection("Data Source=FURKAN-TAHA;Initial Catalog=e-Okul;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = "UPDATE [TBL-MUDUR] SET MUDURSİFRE = @YeniSifre WHERE MUDURSİFRE = @MUDURSİFRE";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@YeniSifre", yenisifre);
                        cmd.Parameters.AddWithValue("@MUDURSİFRE", TC);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Güncelleme başarılı. Giriş sekmesine yönlendiriliyorsunuz...", "İNFORMATİON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            FrmMudurGirisi fr = new FrmMudurGirisi();
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

        private void MudurSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMudurGuncelle_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtsifreonay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Girişi engelle
            }
        }

        private void txtYenisifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMudurGuncelle_Click(this, EventArgs.Empty);
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
            MudurSifreYenile f = new MudurSifreYenile();
            f.Show();
            this.Hide();
        }
    }
}
