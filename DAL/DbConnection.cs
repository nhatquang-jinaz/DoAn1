using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DoAn1.DAL
{
    public class DbConnection
    {
        public static string StrCon = @"Data Source = DESKTOP-IEFQDS8\SQLEXPRESS; Initial Catalog=DoAn1; Integrated Security=True; TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(StrCon);
        }
    }
}
