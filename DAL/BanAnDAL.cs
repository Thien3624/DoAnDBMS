using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanAnDAL : DBConnection
    {
        public BanAnDAL() : base() { }
        public DataTable HienThiBanAn()
        {
            const string sql = "SELECT * FROM QuanLyBanAn";
            return executeDisplayQuery(sql);
        }

        public void doiTrangThaiBan(int maBan)
        {
            string storedProcedure = "DoiTrangThaiBanAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maBan", SqlDbType.Int) { Value = maBan },
            };
            executeUpdateOrDeleteQuery(storedProcedure, parameters);
        }
        public void ThemBanAn(string maBan)
        {
            string storedProcedure = "ThemBanAn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maBanAn", SqlDbType.Int) { Value = maBan }, 
            };

            executeInsertQuery(storedProcedure, parameters);
        }

        public List<string> LayDanhSachIdBanAnChuaDat()
        {
            const string sql = "SELECT maBan FROM QuanLyBanAn where [trangThai] = 0";
            return ExecuteQueryAndGetList(sql);
        }
        public DataTable HienThiHoaDonTheoBan(int maBan)
        {
            string sql = "SELECT * FROM [dbo].[HienThiHoaDonTheoBan](@maBan)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@maBan", SqlDbType.Int) { Value = maBan }
            };
            return executeSearchQuery(sql, parameters);
        }

    }
}
