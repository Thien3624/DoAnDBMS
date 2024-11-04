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
            string maHoaMatKhau = MaHoa(matKhau); 

            string query = "SELECT UyQuyen FROM PHANQUYEN WHERE taiKhoan = @taiKhoan AND matKhau = @matKhau";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@taiKhoan", taiKhoan),
                new SqlParameter("@matKhau", maHoaMatKhau) 
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

        private string MaHoa(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Chuyển đổi byte thành chuỗi hex
                }
                return builder.ToString(); // Trả về mật khẩu đã mã hóa
            }
        }

    }
}
