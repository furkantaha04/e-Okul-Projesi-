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
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            FrmÖgretmenGiris fr = new FrmÖgretmenGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgrenciGiris fr = new FrmOgrenciGiris();
            fr.Show();
            this.Hide();
        }

       
        
     
        SqlBaglanti baglan = new SqlBaglanti();
        private void FrmGirisler_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Duyuru From [TBL-DUYURU]", baglan.baglanti());
            da.Fill(dt);
            dataDuyuru.DataSource= dt;
        }

        private void picturKapatma_MouseLeave(object sender, EventArgs e)
        {
            picturKapatma.Image = e_Okul_Projesi.Properties.Resources.KapatmaLeave;
        }

        private void picturKapatma_MouseEnter(object sender, EventArgs e)
        {
            picturKapatma.Image = e_Okul_Projesi.Properties.Resources.ExitButton;
        }

        private void picturKapatma_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureMinimize_MouseLeave(object sender, EventArgs e)
        {
            pictureMinimize.Image = e_Okul_Projesi.Properties.Resources.MinimizeLeave;
        }

        private void pictureMinimize_MouseEnter(object sender, EventArgs e)
        {
            pictureMinimize.Image = e_Okul_Projesi.Properties.Resources.minimizeEnter;
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }

        private void pictureMudur_MouseLeave(object sender, EventArgs e)
        {
            pictureMudur.Image = e_Okul_Projesi.Properties.Resources.MudurLeave;
        }

        private void pictureMudur_MouseEnter(object sender, EventArgs e)
        {
            pictureMudur.Image = e_Okul_Projesi.Properties.Resources.mudurEnter;
        }

        private void pictureMudur_Click(object sender, EventArgs e)
        {
            FrmMudurGirisi fr = new FrmMudurGirisi();   
            fr.Show();
            this.Hide();
        }
    }
}
