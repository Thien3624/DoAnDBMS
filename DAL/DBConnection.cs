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
        public int executeNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection sqlCon = GetSqlConnection())
            {
                try
                {
                    sqlCon.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlCon))
                    {
                        if (parameters != null)
                        {
                            sqlCommand.Parameters.AddRange(parameters);
                        }
                        return sqlCommand.ExecuteNonQuery(); // Trả về số hàng bị ảnh hưởng
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    throw;
                }
            }
        }

        public void executeInsertQuery(string query, SqlParameter[] sqlParameters)
        {
            using (SqlConnection sqlConnection = GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure; // Đặt loại lệnh
                    sqlCommand.Parameters.AddRange(sqlParameters); // Thêm tham số

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        public void executeUpdateOrDeleteQuery(string query, SqlParameter[] sqlParameter)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    if (sqlParameter != null)
                    {
                        foreach (var param in sqlParameter)
                        {
                            sqlCommand.Parameters.AddWithValue(param.ParameterName, param.Value);
                        }
                    }

                    try
                    {
                        connection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        public DataTable executeSearchQuery(string query, SqlParameter[] parameters = null)
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
                        if (parameters != null)
                        {
                            sqlCommand.Parameters.AddRange(parameters);
                        }
                        SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            return dt;
        }
    }
}
