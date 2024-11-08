using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAO : DBConnection 
    {
        public bool KiemTraDangNhap(string taiKhoan, string matKhau, out bool uyQuyen)
        {
            uyQuyen = false;

            string query = "SELECT UyQuyen FROM PHANQUYEN WHERE taiKhoan = @taiKhoan AND matKhau = @matKhau";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@taiKhoan", taiKhoan),
                new SqlParameter("@matKhau", matKhau) 
            };

            DataTable dt = executeSearchQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                uyQuyen = Convert.ToBoolean(dt.Rows[0]["UyQuyen"]);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
