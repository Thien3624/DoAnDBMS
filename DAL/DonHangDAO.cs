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

        // Method to insert DonHang and return the generated maDonHang
        public int ThemDonHang(DonHang donHang)
        {
            using (SqlConnection conn = GetSqlConnection())
            {
                conn.Open();
                try
                {
                    // Insert DonHang
                    using (SqlCommand cmd = new SqlCommand("ThemDonHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@maBan", donHang.MaBan);
                        cmd.Parameters.AddWithValue("@maKhachHang", donHang.MaKhachHang);
                        cmd.Parameters.AddWithValue("@ngayDatMon", donHang.NgayDatMon);
                        SqlParameter outputIdParam = new SqlParameter("@maDonHang", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputIdParam);
                        cmd.ExecuteNonQuery();
                        // Return the generated maDonHang
                        return (int)outputIdParam.Value;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // Method to insert ChiTietDonHang
        public void ThemChiTietDonHang(List<ChiTietDonHang> chiTietDonHangs)
        {
            using (SqlConnection conn = GetSqlConnection())
            {
                conn.Open();
                try
                {
                    foreach (var chiTiet in chiTietDonHangs)
                    {
                        using (SqlCommand cmd = new SqlCommand("ThemChiTietDonHang", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maDonHang", chiTiet.MaDonHang);
                            cmd.Parameters.AddWithValue("@maMonAn", chiTiet.MaMonAn);
                            cmd.Parameters.AddWithValue("@soLuong", chiTiet.SoLuong);
                            cmd.Parameters.AddWithValue("@donGia", chiTiet.DonGia);
                            cmd.Parameters.AddWithValue("@thanhTien", chiTiet.ThanhTien);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}