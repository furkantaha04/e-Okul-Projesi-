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
    public partial class FrmÖğrenciler : Form
    {
        private string ogrtc;
        public FrmÖğrenciler(string _ogrtc)
        {
            ogrtc = _ogrtc;
            InitializeComponent();
           
        }


        private void FrmÖğrenciler_Load(object sender, EventArgs e)
        {
            SqlBaglanti baglan = new SqlBaglanti();
            SqlCommand komut = new SqlCommand("SELECT OGRID, OGRAD, OGRSOYAD, KURSAD AS KURS_ADI, OGRCINSIYET, OGRTC, OGRNO FROM [TBL-OGRENCİ] INNER JOIN [TBL-KURS] ON [TBL-OGRENCİ].OGRKURS = [TBL-KURS].KURSID", baglan.baglanti());

            try
            {
                SqlDataAdapter dü = new SqlDataAdapter(komut);
                DataTable dp = new DataTable();
                dü.Fill(dp); 

                dataOgrenciListe.DataSource = dp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message); 
            }
            finally
            {
                baglan.baglanti().Close();
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
            FrmÖgretmenDetay fr = new FrmÖgretmenDetay(ogrtc);
            fr.Show();
            this.Hide();
        }
    }
}
