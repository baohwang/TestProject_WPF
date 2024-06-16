using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source = DESKTOP-QIE438C\\MAYAO; Initial Catalog = Quan_Ly_Ban_Hang; Integrated Security = True");
    }
}
