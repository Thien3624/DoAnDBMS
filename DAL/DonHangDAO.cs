using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DonHangDAO : DBConnection
    {
        public DonHangDAO() : base() { }
        public int ThemDonHang(DonHang donHang)
        {
            string storedProcedure = "ThemDonHang";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maBan", donHang.MaBan),
                new SqlParameter("@maKhachHang", donHang.MaKhachHang),
                new SqlParameter("@ngayDatMon", donHang.NgayDatMon),
                new SqlParameter("@maDonHang", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                }
            };
            executeInsertQuery(storedProcedure, parameters);
            return (int)parameters[3].Value;
        }

        // Method to insert ChiTietDonHang
        public void ThemChiTietDonHang(List<ChiTietDonHang> chiTietDonHangs)
        {
            string storedProcedure = "ThemChiTietDonHang";
            foreach (var chiTiet in chiTietDonHangs)
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@maDonHang", chiTiet.MaDonHang),
                    new SqlParameter("@maMonAn", chiTiet.MaMonAn),
                    new SqlParameter("@soLuong", chiTiet.SoLuong),
                    new SqlParameter("@donGia", chiTiet.DonGia),
                    new SqlParameter("@thanhTien", chiTiet.ThanhTien)
                };

                executeInsertQuery(storedProcedure, parameters);
            }
        }

    }
}