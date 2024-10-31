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
using BLL;

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

        public void ThemMonAn(MonAn monAn)
        {
            string storedProcedure = "ThemMonAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maMonAn", monAn.MaMonAn) ,
                new SqlParameter("@tenMonAn", monAn.TenMonAn),
                new SqlParameter("@loaiMonAn", monAn.LoaiMonAn),
                new SqlParameter("@gia", monAn.Gia),
                new SqlParameter("@anhMoTa", (object)monAn.Images ?? DBNull.Value)
            };

            executeInsertQuery(storedProcedure, parameters);
        }
        public void XoaMonAn(MonAn monAn)
        {
            string storedProcedure = "XoaMonAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maMonAn", monAn.MaMonAn)
            };

            executeUpdateOrDeleteQuery(storedProcedure, parameters);
        }

        public void SuaMonAn(MonAn monAn)
        {
            string storedProcedure = "SuaMonAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maMonAn", monAn.MaMonAn) ,
                new SqlParameter("@tenMonAn", monAn.TenMonAn),
                new SqlParameter("@loaiMonAn", monAn.LoaiMonAn),
                new SqlParameter("@gia", monAn.Gia),
                new SqlParameter("@anhMoTa", (object)monAn.Images ?? DBNull.Value)
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

        public DataTable TimKiemMonAn(string tenMonAn)
        {
            string sql = "SELECT * FROM dbo.TimKiemMonAn(@tenMonAn)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenMonAn", SqlDbType.NVarChar) { Value = tenMonAn }
            };
            return executeSearchQuery(sql, parameters);
        }

        public DataTable BestSeller()
        {
            string sql = "SELECT * FROM dbo.BanChayNhat() ORDER BY tongSoLuong ASC;";
            return executeDisplayQuery(sql);
        }
    }
}
