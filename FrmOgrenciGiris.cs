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

namespace e_Okul_Projesi
{
    public partial class FrmOgrenciGiris : Form
    {
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

       

        private void btnÖgrenciDetay_Click(object sender, EventArgs e)
        {
            
            OgrenciBekleme frm = new OgrenciBekleme();
            FrmÖgrenciDetay fr = new FrmÖgrenciDetay();

            SqlConnection Baglan = baglan.baglanti();
            SqlCommand komut = new SqlCommand("Select * From [TBL-OGRENCİ] Where OGRTC=@p1 and OGRNO=@p2",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            komut.Parameters.AddWithValue("@p2",txtNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (txtKod.Text == "KOD")
                {
                    MessageBox.Show("Lütfen kod yazan butona basarak giriş yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lblKod.Text == txtKod.Text)
                {    
                    
                    fr.tc =mskTc.Text;
                    this.Hide();
                    frm.ShowDialog();
                    fr.Show();

                }
                else
                {
                    MessageBox.Show("Lütfen kod alanını boş veya yalnış yazmayınız bırakmayınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKod.Clear();
                }

            }
            else
            {
                lblUyarı.Visible = true;
               txtNo.Clear();
                mskTc.Clear();
            }

            
           
        }

        private void btnKod_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "A", "B", "C", "D", "G", "O", "f", "w", "u", "o", "l", "E", "n", "X", "z", "P" };
            string[] sembol2 = { "+", "-", "/", "*", "_", "3", "6", "0", "8", "2", "?", "&" };
            Random rnd = new Random();
            int s1 , s2 ,s3;
          s1 = rnd.Next(0, sembol1.Length);
          s2 = rnd.Next(0, sembol2.Length);
          s3= rnd.Next(0, 10);
            lblKod.Text = sembol1[s1].ToString() +sembol2[s2].ToString()+s3.ToString();
        }

        private void FrmOgrenciGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnÖgrenciDetay_Click(sender, e);
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
            FrmGirisler f = new FrmGirisler();  
            f.Show();   
            this.Hide();
        }

        private void mskTc_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mskTc.Text))
            {
                lblUyarı.Visible = false;
            }
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNo.Text))
            {
                lblUyarı.Visible = false;
            }

        }

        private void FrmOgrenciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
