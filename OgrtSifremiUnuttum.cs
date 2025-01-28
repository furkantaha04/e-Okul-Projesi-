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
    public partial class OgrtSifremiUnuttum : Form
    {
        public OgrtSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void OgrtSifremiUnuttum_Load(object sender, EventArgs e)
        {
            maskedOgrt.Focus();
        }

        private void btnKodOgrt_Click(object sender, EventArgs e)
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
        SqlBaglanti baglan = new SqlBaglanti(); 
        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            
            SqlConnection Baglan = baglan.baglanti();
            SqlCommand komut = new SqlCommand("Select OGRTSİFRE From [TBL-OGRETMENLER] Where OGRTTC=@p1 ", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedOgrt.Text);
            
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (txtKod.Text == "KOD")
                {
                    MessageBox.Show("Lütfen kod yazan butona basarak giriş yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lblKod.Text == txtKod.Text)
                {
                        int sifre = int.Parse(dr[0].ToString());
                        Yenileme y = new Yenileme(sifre);
                        y.Show();
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen kod alanını boş bırakmayınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   txtKod.Clear();
                }

            }
            else
            {
                MessageBox.Show("TC kimlik veya numara hatalı !!  ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedOgrt.Clear();
            }


        }


        private void maskedOgrt_KeyDown(object sender, KeyEventArgs e)
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
            FrmÖgretmenGiris fr = new FrmÖgretmenGiris();
            fr.Show();
            this.Hide();
        }
    }
}
