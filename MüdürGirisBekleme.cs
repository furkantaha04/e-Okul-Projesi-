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
    public partial class MüdürGirisBekleme : Form
    {
        public MüdürGirisBekleme()
        {
            InitializeComponent();
        }
        private void MüdürGirisBekleme_Load(object sender, EventArgs e)
        {
            ProgeBarLoading();
        }
        private async void ProgeBarLoading()
        {

            await Task.Delay(RadomSayi());
            prgbarr.Value = 40;

            await Task.Delay(RadomSayi());
            prgbarr.Value = 80;

            await Task.Delay(RadomSayi());
            prgbarr.Value = 100;
            await Task.Delay(500);
            this.Close();

        }
        private int RadomSayi()
        {
            Random l = new Random();
            int code = l.Next(1000, 3000);
            return code;

        }
    }
}
