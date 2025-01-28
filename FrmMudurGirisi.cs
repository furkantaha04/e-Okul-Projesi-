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
    public partial class FrmMudurGirisi : Form
    {
        public FrmMudurGirisi()
        {
            InitializeComponent();
        }
        SqlBaglanti baglan = new SqlBaglanti();
      
        
        private void btnKodMud_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "A", "B", "C", "D", "G", "O", "f", "w", "u", "o", "l", "E", "n", "X", "z", "P" };
            string[] sembol2 = { "+", "-", "/", "*", "_", "3", "6", "0", "8", "2", "?", "&" };
            Random rnd = new Random();
            int s1, s2, s3;
            s1 = rnd.Next(0, sembol1.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, 10);
            lblKod.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();
        }

        private void btnMudurDetay_Click(object sender, EventArgs e)
        {
            MüdürGirisBekleme m = new MüdürGirisBekleme();
            FrmMudurDetay frm = new FrmMudurDetay();

            SqlConnection Baglan = baglan.baglanti();
            SqlCommand komut = new SqlCommand("Select * From [TBL-MUDUR] Where MUDURTC=@p1 and MUDURSİFRE=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", mskMudur.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
           if(dr.Read())
            {

                if (txtKod.Text == "KOD")
                {
                    MessageBox.Show("Lütfen kod yazan butona basarak giriş yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lblKod.Text == txtKod.Text)
                {
                    
                    this.Hide();
                    m.ShowDialog();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Lütfen kod alanını boş veya eksik yazmayınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKod.Clear();
                }
            }
            else
            {
                lblUyarı.Visible = true;
                mskMudur.Clear();
                txtSifre.Clear();
            }
            
        }

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

        private void FrmMudurGirisi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMudurDetay_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void lnkSifreMudur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MudurSifreYenile fr = new MudurSifreYenile();
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
            FrmGirisler r = new FrmGirisler();  
            r.Show();
            this.Hide();
        }

        private void mskMudur_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(mskMudur.Text))
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
    }
}
