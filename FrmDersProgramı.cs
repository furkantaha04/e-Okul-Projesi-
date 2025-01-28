using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace e_Okul_Projesi
{
    public partial class FrmDersProgramı : Form
    {
        private int sayac = 0;
        private bool isInitializing = false;
        Dictionary<int, string> derslerDictionary = new Dictionary<int, string>();
        public FrmDersProgramı()
        {
            InitializeComponent();


        }
        private string sutunad;
        private int id;
        SqlBaglanti baglan = new SqlBaglanti();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            GuncelleDersProgrami(sutunad, id);
            InitializeDataGridView();
            dataDersProgram.ClearSelection();
        }

        private void FrmDersProgramı_Load(object sender, EventArgs e)
        {
            load();
            dataDersProgram.ClearSelection();

        }
        private void load()
        {
            try
            {
               
                using (SqlConnection connection = baglan.baglanti())
                {


                    SqlCommand cmd = new SqlCommand("SELECT * FROM [TBL-SINIF]", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    cmbsınıf.DataSource = dataTable;
                    cmbsınıf.DisplayMember = "SINIFAD";
                    cmbsınıf.ValueMember = "SINIFID";

                    SqlCommand cd = new SqlCommand("SELECT * FROM [TBL-DERSLER]", connection);
                    SqlDataAdapter AD = new SqlDataAdapter(cd);


                    DataTable dt2 = new DataTable();
                    AD.Fill(dt2);


                    cmbders.DataSource = dt2;
                    cmbders.DisplayMember = "DERSAD";
                    cmbders.ValueMember = "DERSID";



                    foreach (DataRow dersRow in dt2.Rows)
                    {
                        int dersID = Convert.ToInt32(dersRow["DERSID"]);
                        string dersAd = dersRow["DERSAD"].ToString();
                        derslerDictionary[dersID] = dersAd;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void InitializeDataGridView()
        {

            dataDersProgram.Rows.Clear();
            dataDersProgram.Columns.Clear();

            
            
            dataDersProgram.Columns.Add("Saat", "Saat");
            dataDersProgram.Columns.Add("ID", "ID");

            dataDersProgram.Columns.Add("Pazartesi", "Pazartesi");
            dataDersProgram.Columns.Add("Salı", "Salı");
            dataDersProgram.Columns.Add("Çarşamba", "Çarşamba");
            dataDersProgram.Columns.Add("Perşembe", "Perşembe");
            dataDersProgram.Columns.Add("Cuma", "Cuma");


            for (int hour = 8; hour <= 16; hour++)
            {
                string time = hour.ToString("D2") + ":00"; 
                dataDersProgram.Rows.Add(time); 
            }

            LoadDersProgramiVerileri();
        }

        private void LoadDersProgramiVerileri()
        {
            try
            {
                using (SqlConnection connection = baglan.baglanti())
                {

               
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [TBL-DERSPROGRAMI] WHERE SINIFID =@SINIFID", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@SINIFID", cmbsınıf.SelectedValue);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    int satir = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {


                        int c = satir;
                        
                        string saat = dataDersProgram.Rows[c].Cells[0].Value.ToString(); 
                        int rowIndex = Convert.ToInt32(saat.Split(':')[0]) - 8; 
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
                                dataDersProgram.Rows[c].Cells["ID"].Value = row["DERSPROGRAMID"];
                              
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

                           
                                if (row["Salı"] != DBNull.Value)
                                {
                                    int saliDersID = Convert.ToInt32(row["Salı"]);
                                    dataDersProgram.Rows[c].Cells["Salı"].Value = derslerDictionary.ContainsKey(saliDersID) ? derslerDictionary[saliDersID].ToString() : "Ders Boş";
                                }
                                else
                                {
                                    dataDersProgram.Rows[c].Cells["Salı"].Value = "Ders Boş";
                                }

                             
                                if (row["Çarşamba"] != DBNull.Value)
                                {
                                    int carsambaDersID = Convert.ToInt32(row["Çarşamba"]);
                                    dataDersProgram.Rows[c].Cells["Çarşamba"].Value = derslerDictionary.ContainsKey(carsambaDersID) ? derslerDictionary[carsambaDersID] : "Ders Boş";
                                }
                                else
                                {
                                    dataDersProgram.Rows[c].Cells["Çarşamba"].Value = "Ders Boş";
                                }

                              
                                if (row["Perşembe"] != DBNull.Value)
                                {
                                    int persembeDersID = Convert.ToInt32(row["Perşembe"]);
                                    dataDersProgram.Rows[c].Cells["Perşembe"].Value = derslerDictionary.ContainsKey(persembeDersID) ? derslerDictionary[persembeDersID] : "Ders Boş";
                                }
                                else
                                {
                                    dataDersProgram.Rows[c].Cells["Perşembe"].Value = "Ders Boş";
                                }

                            
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
                    dataDersProgram.Columns["ID"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void dataDersProgram_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

 
                var cellValue = dataDersProgram.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var sutunAdi = dataDersProgram.Columns[e.ColumnIndex].Name;
                sutunad = sutunAdi.ToString();
                int ID = int.Parse(dataDersProgram.Rows[e.RowIndex].Cells[1].Value.ToString());
                id = ID;
               
                string columnName = dataDersProgram.Columns[e.ColumnIndex].Name;

             
                if (cellValue != null && cellValue.ToString() != "Ders Boş" &&
                    (columnName == "Pazartesi" || columnName == "Salı" ||
                     columnName == "Çarşamba" || columnName == "Perşembe" ||
                     columnName == "Cuma"))

                {
                    cmbders.Text = cellValue.ToString();
                  

                }

                txtisim.Text = cellValue.ToString();
                
            }

            
        }

        public void GuncelleDersProgrami(string gun, int id)
        {
            string sorgu =$@"
        UPDATE [TBL-DERSPROGRAMI]
        SET {gun} = @gun
      
        WHERE DERSPROGRAMID = @ID";

            try
            {
                
                using (SqlCommand komut = new SqlCommand(sorgu, baglan.baglanti()))
                {
 
            
                    komut.Parameters.AddWithValue("@gun", cmbders.SelectedValue);
                    komut.Parameters.AddWithValue("@ID", id);

             
                    int etkilenenSatir = komut.ExecuteNonQuery();
                    Console.WriteLine($"{etkilenenSatir} satır güncellendi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
            dataDersProgram.ClearSelection();
        }


        private void cmbsınıf_SelectedIndexChanged(object sender, EventArgs e)
        {
            sayac++;
            if (isInitializing)
            {
                InitializeDataGridView();
            }
            if (sayac == 2)
            {
                isInitializing = true;
            }

        }



        private void txtbul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = e_Okul_Projesi.Properties.Resources.GeriSiyah;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = e_Okul_Projesi.Properties.Resources.Back;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMudurDetay M = new FrmMudurDetay();
            M.Show();
            this.Hide();
        }
    }
}
