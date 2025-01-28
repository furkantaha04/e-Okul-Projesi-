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
    public partial class MudurSifreYenile : Form
    {
        public MudurSifreYenile()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti();
      

        private void btnKodMudur_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "A", "B", "C", "D", "G", "O", "f", "w", "u", "o", "l", "E", "n", "X", "z", "P" };
            string[] sembol2 = { "+", "-", "/", "*", "3", "6", "0", "8", "2", "?" };
            Random rnd = new Random();
            int s1, s2, s3;
            s1 = rnd.Next(0, sembol1.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, 10);
            lblKod.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();
        }

        private void btnMudur_Click(object sender, EventArgs e)
        {
            SqlConnection Baglan = baglan.baglanti();
            SqlCommand komut = new SqlCommand("Select MUDURSİFRE From [TBL-MUDUR] Where MUDURTC=@p1 ", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedMudur.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (txtKod.Text == "KOD")
                {
                    MessageBox.Show("Lütfen kod yazan butona basarak giriş yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lblKod.Text == txtKod.Text)
                {
                    int Sifre = int.Parse(dr[0].ToString());
                    MudurSifre y = new MudurSifre(Sifre);
                    y.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen kod alanını boş veya yalnış yazmayınız bırakmayınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKod.Clear();
                }

            }
            else
            {
                MessageBox.Show("TC kimlik veya numara hatalı !!  ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedMudur.Clear();
            }
        }

        private void MudurSifreYenile_Load(object sender, EventArgs e)
        {
            maskedMudur.Focus();
        }

        private void MudurSifreYenile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMudur_Click(this, EventArgs.Empty);
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
            FrmMudurGirisi f = new FrmMudurGirisi();    
            f.Show();
            this.Hide();
        }
    }
}
