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
    public partial class NotişlemleriPaneli : Form
    {
        private string ogrtc;
        public NotişlemleriPaneli(string _ogrtc)
        {
            ogrtc = _ogrtc;
            InitializeComponent();
        }

   
        _e_OkulDataSetTableAdapters.TBL_NOTLARTableAdapter ds = new _e_OkulDataSetTableAdapters.TBL_NOTLARTableAdapter();
        private void btnAra_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtogrıd.Text))
            {
                MessageBox.Show("Öğrenci ıd boş olamaz .", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataOgrenciNot.DataSource = ds.NotListesi(int.Parse(txtogrıd.Text), byte.Parse(txtDers.SelectedValue.ToString()));
            dataOgrenciNot.ClearSelection();
        }
        SqlBaglanti baglan = new SqlBaglanti();
        private void NotişlemleriPaneli_Load(object sender, EventArgs e)
        {
           
            SqlConnection Baglan = baglan.baglanti();
            using (SqlConnection conn = new SqlConnection(Baglan.ConnectionString))
            {
                conn.Open();

                SqlCommand komut = new SqlCommand("SELECT * FROM [TBL-DERSLER]", conn);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtDers.DisplayMember = "DERSAD";
                txtDers.ValueMember = "DERSID";
                txtDers.DataSource = dt;
            }
            dataOgrenciNot.DataSource = ds.listele();
            dataOgrenciNot.Columns["DERSID"].Visible = false;
            dataOgrenciNot.ClearSelection();
        }
        int notid;
        private void dataOgrenciNot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataOgrenciNot.Rows[e.RowIndex].Cells[0].Value.ToString());

                var selectedValue = dataOgrenciNot.Rows[e.RowIndex].Cells[7].Value;
                if (selectedValue != null)
                {
                    txtDers.Text = selectedValue.ToString(); 
                }
            txtSinıav1.Text = dataOgrenciNot.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSinav2.Text = dataOgrenciNot.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSınav3.Text = dataOgrenciNot.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtProje.Text = dataOgrenciNot.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtOrtalama.Text = dataOgrenciNot.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDurum.Text = dataOgrenciNot.Rows[e.RowIndex].Cells[6].Value.ToString();
           
        }
        int sınav1, sınav2, sınav3, proje;
        double ortalama;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantıyı aç
                using (SqlConnection connection = baglan.baglanti())
                {
                    // TBL-DERSLER tablosundan tüm ID'leri al
                    List<string> dersIdList = new List<string>();
                    SqlCommand dersCmd = new SqlCommand("SELECT DERSID FROM [TBL-DERSLER]", connection);
                    SqlDataReader reader = dersCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dersIdList.Add(reader["DERSID"].ToString());
                    }
                    reader.Close();

                    // Gerekli kontroller
                    if (string.IsNullOrEmpty(txtogrıd.Text))
                    {
                        MessageBox.Show("Lütfen öğrenci ID giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(txtDers.Text))
                    {
                        MessageBox.Show("Lütfen Kurs Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Her bir ders ID'si için öğrenci ekleme işlemi
                        foreach (string dersId in dersIdList)
                        {
                            using (SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO [TBL-NOTLAR] (OGRID, DERSID)
                    SELECT @OGRID, @DERSID
                    WHERE NOT EXISTS (
                        SELECT 1 FROM [TBL-NOTLAR] 
                        WHERE OGRID = @OGRID AND DERSID = @DERSID
                    )", connection))
                            {
                                cmd.Parameters.AddWithValue("@OGRID", txtogrıd.Text.Trim());
                                cmd.Parameters.AddWithValue("@DERSID", dersId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Öğrenci ekleme işlemi başarılı bir şekilde gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtogrıd.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataOgrenciNot.DataSource = ds.listele();
            dataOgrenciNot.Columns["DERSID"].Visible = false;

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrenci listeleme işlemi başarılı bir şekilde Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataOgrenciNot.DataSource = ds.listele();
            dataOgrenciNot.Columns["DERSID"].Visible = false;
            dataOgrenciNot.ClearSelection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtogrıd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtogrıd.Clear();
            txtOrtalama.Clear();
            txtSinıav1.Clear();
            txtSinav2.Clear();
            txtSınav3.Clear();
            txtProje.Clear();
            txtOrtalama.Clear();
            txtDurum.Clear();
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
            FrmÖgretmenDetay tr = new FrmÖgretmenDetay(ogrtc);
            tr.Show();
            this.Hide();
        }

        string durum;
        
        
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {

            if ( txtogrıd.Text == "" || txtogrıd.Text == null || txtSinıav1.Text == "" || txtSinıav1.Text == null || txtSinav2.Text == "" || txtSinav2.Text == null || txtSınav3.Text == "" || txtSınav3.Text == null || txtProje.Text == "" || txtProje.Text == null)
            {
                MessageBox.Show("Alanı Boş bırakma doldur .", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            sınav1 = Convert.ToInt16(txtSinıav1.Text);
            sınav2 = Convert.ToInt16(txtSinav2.Text);
            sınav3 = Convert.ToInt16(txtSınav3.Text);
            proje = Convert.ToInt16(txtProje.Text);
            ortalama=(sınav1+sınav2+sınav3+proje)/4;
            txtOrtalama.Text=ortalama.ToString();
            if(ortalama>=50)
            {

                txtDurum.Text = "True";

            }
            else
            {
                txtDurum.Text = "False";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if ( txtogrıd.Text == "" || txtogrıd.Text == null || txtSinıav1.Text == "" || txtSinıav1.Text == null || txtSinav2.Text == "" || txtSinav2.Text == null || txtSınav3.Text == "" || txtSınav3.Text == null || txtProje.Text == "" || txtProje.Text == null)
            {
                MessageBox.Show("Alanı Boş bırakma doldur .", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ds.Guncelle(int.Parse(txtogrıd.Text),byte.Parse(txtSinıav1.Text),byte.Parse(txtSinav2.Text),byte.Parse(txtSınav3.Text),decimal.Parse(txtOrtalama.Text),byte.Parse(txtProje.Text),bool.Parse(txtDurum.Text),notid);

            dataOgrenciNot.DataSource = ds.NotListesi(int.Parse(txtogrıd.Text), byte.Parse(txtDers.SelectedValue.ToString()));
            dataOgrenciNot.ClearSelection();

        }
    }
}
