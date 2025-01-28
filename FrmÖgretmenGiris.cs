using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Okul_Projesi
{
    public partial class FrmÖgretmenGiris : Form
    {
   
        public FrmÖgretmenGiris()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlBaglanti baglan = new SqlBaglanti();
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtSifre.PasswordChar = '\0';
            pictureBox3.Image = e_Okul_Projesi.Properties.Resources.eye;
        }
        
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtSifre.PasswordChar = '*';
            pictureBox3.Image = e_Okul_Projesi.Properties.Resources.hidden;
        }

    

        private void btnOgretmenDetay_Click(object sender, EventArgs e)
        {
            OgretmenGirisBekleme frm = new OgretmenGirisBekleme();
            

            SqlConnection Baglan = baglan.baglanti();
            SqlCommand komut = new SqlCommand("Select * From [TBL-OGRETMENLER] Where OGRTTC=@p1 and OGRTSİFRE=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedOgrt.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (txtKod.Text == "KOD")
                {
                    MessageBox.Show("Lütfen kod yazan butona basarak giriş yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                else if (lblKod.Text == txtKod.Text)
                {
                    FrmÖgretmenDetay fr = new FrmÖgretmenDetay(maskedOgrt.Text);
                    
                    this.Hide();
                    frm.ShowDialog();
                    fr.Show();

                }
                else
                {
                    MessageBox.Show("Lütfen kod alanını boş veya yalnış yazmayınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKod.Clear();
                }
            }
            else
            {
               lblUyarı.Visible=true;

                maskedOgrt.Clear();
                txtSifre.Clear();
            }

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

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maskedOgrt.Text))
            {
                lblUyarı.Visible = false;
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSifre.Text))
            {
                lblUyarı.Visible = false;
            }
        }

        private void FrmÖgretmenGiris_Load(object sender, EventArgs e)
        {
            maskedOgrt.Focus();
        }

        private void lnkSifreOgrt_Click(object sender, EventArgs e)
        {
          
            OgrtSifremiUnuttum t = new OgrtSifremiUnuttum();
            this.Hide();
            t.ShowDialog();
            if (t.AccessibleName == "Onaylandı")
            {
                t.ShowDialog();
            }
            else if (t.AccessibleName == "Onaylanmadı")
            {

            }
        }

        private void FrmÖgretmenGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOgretmenDetay_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void lnkSifreOgrt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OgrtSifremiUnuttum fr = new OgrtSifremiUnuttum();
                fr.Show();
            this.Hide();
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
            FrmGirisler y = new FrmGirisler();  
            y.Show();
            this.Hide();
        }
    }
}
