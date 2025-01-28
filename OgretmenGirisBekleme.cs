using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Okul_Projesi
{
    public partial class OgretmenGirisBekleme : Form
    {
        public OgretmenGirisBekleme()
        {
            InitializeComponent();
        }

        private void OgretmenGirisBekleme_Load(object sender, EventArgs e)
        {
            ProgessBarLoading();
        }

        private async void ProgessBarLoading()
        {
           
            await Task.Delay(RandomSayi());
            prgbarr.Value = 40;

            await Task.Delay(RandomSayi());
            prgbarr.Value = 80;

            await Task.Delay(RandomSayi());
            prgbarr.Value = 100;
            await Task.Delay(500);
            this.Close();

        }
        private int RandomSayi()
        {
            Random R = new Random();
            int code = R.Next(1000, 3000);
            return code;

        }

        private void prgbarr_Click(object sender, EventArgs e)
        {

        }
    }
}
