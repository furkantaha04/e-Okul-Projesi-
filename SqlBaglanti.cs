using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace e_Okul_Projesi
{
    internal class SqlBaglanti //Sql bağlantısını tek bir classa toplayıp ordan çekiyorum.
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=FURKAN-TAHA;Initial Catalog=e-Okul;Integrated Security=True;TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
