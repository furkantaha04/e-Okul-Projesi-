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
    public partial class FrmÖgretmenDetay : Form
    {
        public string tc;
        public string tcOgr;
        public FrmÖgretmenDetay(string _tc)
        {
            InitializeComponent();
            tc = _tc;   
        }
        SqlBaglanti baglan = new SqlBaglanti();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Kurs_islemleri_Paneli k = new Kurs_islemleri_Paneli(tc);
            k.Show();
            this.Hide();
            
        }

     
        private void btnNotİŞLEMLERİ_Click(object sender, EventArgs e)
        {
            NotişlemleriPaneli fr = new NotişlemleriPaneli(tc);
            fr.Show();
            this.Hide();
            
        }

        private void btnDevamsızlık_Click(object sender, EventArgs e)
        {
            FrmDevamsızlık fr = new FrmDevamsızlık(tc);
            fr.Show();
            this.Hide();
            
        }

        private void MesajAl()
        {
            SqlCommand komut2 = new SqlCommand("Select MESAJID,OGRAD,OGRSOYAD,OGRMESAJ  From [TBL-MESAJ] INNER JOIN [TBL-OGRENCİ] ON  [TBL-OGRENCİ].OGRTC = [TBL-MESAJ].OGRTC WHERE OGRTTC=@OGRTTC ", baglan.baglanti());
            komut2.Parameters.AddWithValue("@OGRTTC", lblogrtTcNo.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter dü = new SqlDataAdapter(komut2);
            dü.Fill(dt);
            dataMesaj.DataSource = dt;
            baglan.baglanti().Close();
        }

     
        private void FrmÖgretmenDetay_Load(object sender, EventArgs e)
        {
            lblogrtTcNo.Text = tc;
            SqlCommand komut = new SqlCommand("Select OGRTAD,OGRTSOYAD From [TBL-OGRETMENLER] Where OGRTTC =@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                lblogrtAdSoyad.Text = dr[0] + "" + " " + dr[1];
            }
            baglan.baglanti().Close();

            MesajAl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmÖğrenciler frmo =   new FrmÖğrenciler(tc);
            frmo.Show();
            this.Hide();
           
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataMesaj.SelectedRows.Count > 0)
            {
                // Seçilen satırdan MESAJID değerini al
                int mesajId = int.Parse(dataMesaj.SelectedRows[0].Cells["MESAJID"].Value.ToString());

                // SQL komutunu hazırla
                using (SqlCommand komut3 = new SqlCommand("DELETE FROM [TBL-MESAJ] WHERE MESAJID = @MESAJID", baglan.baglanti()))
                {
                    // Parametreyi ekle
                    komut3.Parameters.AddWithValue("@MESAJID", mesajId);

                   
                    komut3.ExecuteNonQuery();
                    baglan.baglanti().Close();
                }

                // Mesajları tekrar al
                MesajAl();
            }

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
                FrmGirisler t = new FrmGirisler();
                t.Show();
                this.Close();
            }
        }
    }
}
