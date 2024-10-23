using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class MonAnDAL : DBConnection
    {
        public MonAnDAL() : base() { }

        public DataTable HienThiMonAn()
        {
            const string sql = "SELECT * FROM XemMenu";
            return executeDisplayQuery(sql);
        }
        public List<string> LayDanhSachLoaiMonAn()
        {
            const string sql = "SELECT DISTINCT loaiMonAn FROM XemMenu";
            return ExecuteQueryAndGetList(sql);
        }

        public DataTable HienThiMonAnTheoLoai(string loaiMonAn)
        {
            string sql = $"SELECT * FROM XemMenu WHERE loaiMonAn = N'{loaiMonAn}'";
            return executeDisplayQuery(sql);
        }

        public void ThemMonAn(string maMonAn, string tenMonAn, string loaiMonAn, int gia, int soLuong, byte[] anhMoTa)
        {
            string storedProcedure = "ThemMonAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maMonAn", SqlDbType.NVarChar) { Value = maMonAn },
                new SqlParameter("@tenMonAn", SqlDbType.NVarChar) { Value = tenMonAn },
                new SqlParameter("@loaiMonAn", SqlDbType.NVarChar) { Value = loaiMonAn },
                new SqlParameter("@gia", SqlDbType.Int) { Value = gia },
                new SqlParameter("@soLuong", SqlDbType.Int) { Value = soLuong },
                new SqlParameter("@anhMoTa", SqlDbType.Image) { Value = (object)anhMoTa ?? DBNull.Value }
            };

            executeInsertQuery(storedProcedure, parameters);
        }
        public void XoaMonAn(string maMonAn)
        {
            string storedProcedure = "XoaMonAn"; // Tên của stored procedure
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maMonAn", SqlDbType.NVarChar) { Value = maMonAn }
            };

            executeUpdateOrDeleteQuery(storedProcedure, parameters); // Giả sử bạn đã định nghĩa phương thức này để thực hiện stored procedure
        }

        public void SuaMonAn(string maMonAn, string tenMonAn, string loaiMonAn, int gia, int soLuong, byte[] anhMoTa)
        {
            string storedProcedure = "SuaMonAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@maMonAn", SqlDbType.NVarChar) { Value = maMonAn },
        new SqlParameter("@tenMonAn", SqlDbType.NVarChar) { Value = tenMonAn },
        new SqlParameter("@loaiMonAn", SqlDbType.NVarChar) { Value = loaiMonAn },
        new SqlParameter("@gia", SqlDbType.Int) { Value = gia },
        new SqlParameter("@soLuong", SqlDbType.Int) { Value = soLuong },
        new SqlParameter("@anhMoTa", SqlDbType.Image) { Value = (object)anhMoTa ?? DBNull.Value }
            };

            try
            {
                executeUpdateOrDeleteQuery(storedProcedure, parameters);
                Console.WriteLine("Cập nhật món ăn thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật món ăn: " + ex.Message);
            }
        }
    }
}
