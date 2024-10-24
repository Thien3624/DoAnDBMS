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
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Insert DonHang
                        using (SqlCommand cmd = new SqlCommand("ThemDonHang", conn, transaction))
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
                            transaction.Commit();
                            // Return the generated maDonHang
                            return (int)outputIdParam.Value;
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


        // Method to insert ChiTietDonHang
        public void ThemChiTietDonHang(List<ChiTietDonHang> chiTietDonHangs)
        {
            using (SqlConnection conn = GetSqlConnection())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (var chiTiet in chiTietDonHangs)
                        {
                            using (SqlCommand cmd = new SqlCommand("ThemChiTietDonHang", conn, transaction))
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
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
