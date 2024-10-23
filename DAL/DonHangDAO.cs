using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class DonHangDAO : DBConnection
    {
        public DonHangDAO() : base() { }

        public void themDonHang(DonHang donHang)
        {
            string sql = "dbo.ThemDonHang";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@maBan", donHang.MaBan),
                new SqlParameter("@maKhachHang", donHang.MaKhachHang),
                new SqlParameter("@ngayDatMon", donHang.NgayDatMon),
                new SqlParameter("@soLuong", donHang.SoLuong)
            };

            executeInsertQuery(sql, sqlParameters);
        }
    }
}
