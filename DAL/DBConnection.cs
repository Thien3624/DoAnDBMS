using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        private string connectionString = @"Data Source=.;Initial Catalog=QuanLyQuanAn;Persist Security Info=True;User ID=sa;Password=123;Encrypt=False";

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }


        public DataTable executeDisplayQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlCon = GetSqlConnection())
            {
                try
                {
                    sqlCon.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlCon))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    throw;
                }
            }
            return dt;
        }
    }
}
