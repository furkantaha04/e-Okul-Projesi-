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
    public partial class OgrenciBekleme : Form
    {
        public OgrenciBekleme()
        {
            InitializeComponent();
        }
        private void OgrenciBekleme_Load(object sender, EventArgs e)
        {
            progesbar();
        }
        private async void progesbar()
        {
            await Task.Delay(RandomSayi());
            prgbarr1.Value = 40;

            await Task.Delay(RandomSayi());
            prgbarr1.Value = 80;

            await Task.Delay(RandomSayi());
            prgbarr1.Value = 100;
            await Task.Delay(500);
            this.Close();
        }
        private int RandomSayi()
        {
            Random R = new Random();
            int code = R.Next(1000, 3000);
            return code;

        }

      
    }
}
