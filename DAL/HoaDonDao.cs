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
    public class HoaDonDao : DBConnection
    {
        public HoaDonDao() : base() { }

        public void ThemHoaDon(int maDonHang, string maKhachHang, int tongTien, DateTime ngayInHoaDon, bool trangThai, int maBan, string maNhanVien)
        {
            string storedProcedure = "ThemHoaDon";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maDonHang", maDonHang),
                new SqlParameter("@maKhachHang ", maKhachHang),
                new SqlParameter("@tongTien", tongTien),
                new SqlParameter("@ngayInHoaDon", ngayInHoaDon),
                new SqlParameter("@trangThai", trangThai),
                new SqlParameter("@maBan", maBan),
                new SqlParameter("@maNhanVien", maNhanVien),
                new SqlParameter("@maHoaDon", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                }
            };
            executeInsertQuery(storedProcedure, parameters);
        }

    }
}
