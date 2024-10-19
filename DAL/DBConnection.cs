using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DBConnection
    {
        string sqlStr = @"Data Source=.;Initial Catalog=QuanLyQuanAn;Persist Security Info=True;User ID=sa;Password=***********;Encrypt=True;Trust Server Certificate=True";
        SqlConnection sqlCon = null;
        
        public DBConnection() { 
            sqlCon = new SqlConnection(sqlStr);
        }

        public SqlConnection GetSqlConnection()
        {
            return  sqlCon;
        }
    }
}
