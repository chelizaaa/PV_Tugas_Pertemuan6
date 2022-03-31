using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 1
using System.Data.SqlClient;

namespace PV_Tugas6
{
    class Koneksi
    {
        // 2
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = CHELIZA-SRIAYU; initial catalog = Kasir; integrated security = true";
            return Conn;
        }
    }
}
