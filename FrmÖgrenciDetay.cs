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
    public partial class FrmÖgrenciDetay : Form
    {
        Dictionary<int, string> derslerDictionary = new Dictionary<int, string>();
  
        public FrmÖgrenciDetay()
        {
            InitializeComponent();
        }

        public string tc;
        public int sınıfıd;
        
        SqlBaglanti baglan = new SqlBaglanti();
        private void FrmÖgrenciDetay_Load(object sender, EventArgs e)
        {
            SqlConnection Baglan = baglan.baglanti();

            lblogrTcNo.Text = tc; // TC kimlik numarasını bir label'a atıyoruz.
   SqlCommand komut = new SqlCommand(@"
    SELECT O.OGRAD, 
           O.OGRSOYAD, 
           S.SINIFAD, 
           O.SINIFID 
    FROM [TBL-OGRENCİ] AS O
    JOIN [TBL-SINIF] AS S ON O.SINIFID = S.SINIFID
    WHERE O.OGRTC = @p1", Baglan);


            komut.Parameters.AddWithValue("@p1", lblogrTcNo.Text);

            try
            {
               
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    // Öğrenci adını ve soyadını birleştirerek label'a atıyoruz.
                    lblogrAdSoyad.Text = dr["OGRAD"].ToString() + " " + dr["OGRSOYAD"].ToString();
                    lblsınıf.Text = dr["SINIFAD"].ToString(); // Sınıf adını label'a atıyoruz.
                    sınıfıd = int.Parse(dr["SINIFID"].ToString()); // SINIFID değerini alıyoruz.
                }
                dr.Close(); // DataReader'ı kapatıyoruz.
            }
            catch (Exception ex)
            {
                // Hata mesajını işleyebilirsiniz.
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı güvenli bir şekilde kapatıyoruz.
                Baglan.Close();
            }
;


            SqlDataAdapter da = new SqlDataAdapter($"Select DERSAD,SINAV1,SINAV2,SINAV3,ORTALAMA,PROJE,DURUM From [TBL-NOTLAR]  JOIN [TBL-DERSLER]   ON [TBL-NOTLAR].DERSID=[TBL-DERSLER].DERSID JOIN [TBL-OGRENCİ] ON [TBL-NOTLAR].OGRID=[TBL-OGRENCİ].OGRID Where OGRTC ={tc}" , baglan.baglanti());
            
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlDataAdapter db = new SqlDataAdapter($"Select OZURLU,OZURSUZ,DURUM From [TBL-DEVAMSIZLIK] JOIN [TBL-OGRENCİ] ON [TBL-DEVAMSIZLIK].OGRID=[TBL-OGRENCİ].OGRID Where OGRTC ={tc}" , baglan.baglanti());
            DataTable dt2 = new DataTable();    
            db.Fill(dt2);
            dataDevamsızlık.DataSource = dt2;

 

            SqlCommand komut2 = new SqlCommand("SELECT OGRTAD, OGRTSOYAD, OGRTTC FROM [TBL-OGRETMENLER]",baglan.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

           
            cmbOgretmen.Items.Clear();

           
            while (dr2.Read())
            {
                
                string ogretmenTamAd = dr2["OGRTAD"].ToString() + " " + dr2["OGRTSOYAD"].ToString();
                cmbOgretmen.Items.Add(new { Name = ogretmenTamAd, TC = dr2["OGRTTC"].ToString() });
            }

            
            cmbOgretmen.DisplayMember = "Name"; 
            cmbOgretmen.ValueMember = "TC"; 

            dr2.Close();

            SqlCommand cd = new SqlCommand("SELECT * FROM [TBL-DERSLER]", baglan.baglanti());
            SqlDataAdapter AD = new SqlDataAdapter(cd);

            // DataTable oluştur
            DataTable dt23 = new DataTable();
            AD.Fill(dt23);



            foreach (DataRow dersRow in dt23.Rows)
            {
                int dersID = Convert.ToInt32(dersRow["DERSID"]);
                string dersAd = dersRow["DERSAD"].ToString();
                derslerDictionary[dersID] = dersAd;
            }
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            // DataGridView'i temizle
            dataDersProgram.Rows.Clear();
            dataDersProgram.Columns.Clear();

            // Saatler için sütunu ekle


            dataDersProgram.Columns.Add("Saat", "Saat");

            // Günler için sütunları ekle
            dataDersProgram.Columns.Add("Pazartesi", "Pazartesi");
            dataDersProgram.Columns.Add("Salı", "Salı");
            dataDersProgram.Columns.Add("Çarşamba", "Çarşamba");
            dataDersProgram.Columns.Add("Perşembe", "Perşembe");
            dataDersProgram.Columns.Add("Cuma", "Cuma");

            // Saatleri ekle (08:00 - 16:00 arası)
            for (int hour = 8; hour <= 16; hour++)
            {
                string time = hour.ToString("D2") + ":00"; // Saat formatı (08:00, 09:00, ...)
                dataDersProgram.Rows.Add(time); // Yeni satır ekle
            }

            // [TBL-DERSPROGRAMI] tablosundan verileri çek
            LoadDersProgramiVerileri();
        }

        private void LoadDersProgramiVerileri()
        {
            try
            {
                using (SqlConnection connection = baglan.baglanti())
                {

                    // Ders programı verilerini çek
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [TBL-DERSPROGRAMI] WHERE SINIFID =@SINIFID", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@SINIFID", sınıfıd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Verileri DataGridView'e ekle

                    int satir = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {


                        int c = satir;

                        string saat = dataDersProgram.Rows[c].Cells[0].Value.ToString(); // 0. hücrede saat bilgisi olduğunu varsayıyoruz
                        int rowIndex = Convert.ToInt32(saat.Split(':')[0]) - 8; // 08:00 için 0, 09:00 için 1, vb.
                        if (saat == "12:00")
                        {

                            dataDersProgram.Rows[c].Cells["Pazartesi"].Value = "Öğle Arası";


                            dataDersProgram.Rows[c].Cells["Salı"].Value = "Öğle Arası";


                            dataDersProgram.Rows[c].Cells["Çarşamba"].Value = "Öğle Arası";


                            dataDersProgram.Rows[c].Cells["Perşembe"].Value = "Öğle Arası";


                            dataDersProgram.Rows[c].Cells["Cuma"].Value = "Öğle Arası";


                        }
                        else
                        {

                            if (rowIndex >= 0 && rowIndex < dataDersProgram.Rows.Count)
                            {
                                // Pazartesi
                                if (row["Pazartesi"] != DBNull.Value)
                                {
                                    int pazartesiDersID = Convert.ToInt32(row["Pazartesi"]);
                                    dataDersProgram.Rows[c].Cells["Pazartesi"].Value =
                                        derslerDictionary.TryGetValue(pazartesiDersID, out var pazartesiDers) ? pazartesiDers : "Ders Boş";
                                }
                                else
                                {
                                    dataDersProgram.Rows[c].Cells["Pazartesi"].Value = "Ders Boş";
                                }

                                // Salı
                                if (row["Salı"] != DBNull.Value)
                                {
                                    int saliDersID = Convert.ToInt32(row["Salı"]);
                                    dataDersProgram.Rows[c].Cells["Salı"].Value = derslerDictionary.ContainsKey(saliDersID) ? derslerDictionary[saliDersID].ToString() : "Ders Boş";
                                }
                                else
                                {
                                    dataDersProgram.Rows[c].Cells["Salı"].Value = "Ders Boş";
                                }

                                // Çarşamba
                                if (row["Çarşamba"] != DBNull.Value)
                                {
                                    int carsambaDersID = Convert.ToInt32(row["Çarşamba"]);
                                    dataDersProgram.Rows[c].Cells["Çarşamba"].Value = derslerDictionary.ContainsKey(carsambaDersID) ? derslerDictionary[carsambaDersID] : "Ders Boş";
                                }
                                else
                                {
                                    dataDersProgram.Rows[c].Cells["Çarşamba"].Value = "Ders Boş";
                                }

                                // Perşembe
                                if (row["Perşembe"] != DBNull.Value)
                                {
                                    int persembeDersID = Convert.ToInt32(row["Perşembe"]);
                                    dataDersProgram.Rows[c].Cells["Perşembe"].Value = derslerDictionary.ContainsKey(persembeDersID) ? derslerDictionary[persembeDersID] : "Ders Boş";
                                }
                                else
                                {
                                    dataDersProgram.Rows[c].Cells["Perşembe"].Value = "Ders Boş";
                                }

                                // Cuma
                                if (row["Cuma"] != DBNull.Value)
                                {
                                    int cumaDersID = Convert.ToInt32(row["Cuma"]);
                                    dataDersProgram.Rows[c].Cells["Cuma"].Value = derslerDictionary.ContainsKey(cumaDersID) ? derslerDictionary[cumaDersID] : "Ders Boş";
                                }
                                else
                                {
                                    dataDersProgram.Rows[c].Cells["Cuma"].Value = "Ders Boş";
                                }
                            }
                        }
                        satir++;

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnGönder_Click(object sender, EventArgs e)
        {


            SqlCommand komut3 = new SqlCommand("INSERT INTO [TBL-MESAJ] ( OGRTC,OGRMESAJ,OGRTTC ) VALUES (@OGRTC ,@OGRMESAJ,@OGRTTC)", baglan.baglanti());
            komut3.Parameters.AddWithValue("@OGRTC", lblogrTcNo.Text);
            komut3.Parameters.AddWithValue("@OGRMESAJ", richOgr.Text);
            komut3.Parameters.AddWithValue("@OGRTTC", selectedTC);  
           komut3.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Mesaj gönderildi..", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richOgr.Clear();
        }
        string selectedTC = null;
        private void cmbOgretmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOgretmen.SelectedItem != null)
            {
                var selectedItem = (dynamic)cmbOgretmen.SelectedItem;
                 selectedTC = selectedItem.TC;
               
            }
        }

        private void pictureCikis_MouseLeave(object sender, EventArgs e)
        {
            pictureCikis.Image = e_Okul_Projesi.Properties.Resources.KapatmaLeave;
        }

        private void pictureCikis_MouseEnter(object sender, EventArgs e)
        {
            pictureCikis.Image = e_Okul_Projesi.Properties.Resources.ExitButton;
        }

        private void pictureCikis_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               FrmGirisler frmGirisler = new FrmGirisler();
                frmGirisler.Show();
                this.Close();
            }
        }
    }
}
