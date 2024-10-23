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
        public List<string> ExecuteQueryAndGetList(string query)
        {
            List<string> resultList = new List<string>();

            using (SqlConnection sqlCon = GetSqlConnection())
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlCon))
                {
                    sqlCon.Open();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultList.Add(reader[0].ToString());
                        }
                    }
                }
            }
            return resultList;
        }

        public void executeInsertQuery(string query, SqlParameter[] sqlParameters)
        {
            // Tạo kết nối với cơ sở dữ liệu
            using (SqlConnection sqlConnection = GetSqlConnection())
            {
                // Mở kết nối
                sqlConnection.Open();

                // Tạo lệnh SQL
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure; // Đặt loại lệnh
                    sqlCommand.Parameters.AddRange(sqlParameters); // Thêm tham số

                    try
                    {
                        // Thực thi lệnh SQL
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // In thông báo lỗi ra console
                        Console.WriteLine(ex.Message);
                    }
                }
            } // Kết nối sẽ tự động đóng ở đây
        }


    }
}
