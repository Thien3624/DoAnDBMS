﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Web.UI.WebControls;

namespace DAL
{
    public class NhanVienDAL : DBConnection
    {
        public NhanVienDAL() : base() { }

        public DataTable hienThiNhanVien()
        {
            const string sql = "SELECT * FROM NHANVIEN WHERE TrangThaiLamViec = 1";
            return executeDisplayQuery(sql);
        }

        public void themNhanVien(NhanVien nhanVien)
        {
            string storedProcedure = "ThemNhanVien";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maNhanVien", SqlDbType.NVarChar) { Value = nhanVien.MaNhanVien },
                new SqlParameter("@CCCD", SqlDbType.NVarChar) { Value = nhanVien.CCCD },
                new SqlParameter("@hoVaTen", SqlDbType.NVarChar) { Value = nhanVien.HoVaTen },
                new SqlParameter("@gioiTinh", SqlDbType.NVarChar) { Value = nhanVien.GioiTinh },
                new SqlParameter("@ngaySinh", SqlDbType.DateTime) { Value = nhanVien.NgaySinh },
                new SqlParameter("@soDienThoai", SqlDbType.NVarChar) { Value = nhanVien.SoDienThoai },
                new SqlParameter("@diaChi", SqlDbType.NVarChar) { Value = nhanVien.DiaChi },

            };

            executeInsertQuery(storedProcedure, parameters);
        }

        public void XoaNhanVien(NhanVien nhanVien)
        {
            string storedProcedure = "XoaNhanVien";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maNhanVien", SqlDbType.NVarChar) { Value = nhanVien.MaNhanVien }
            };

            executeUpdateOrDeleteQuery(storedProcedure, parameters); // Giả sử bạn đã định nghĩa phương thức này để thực hiện stored procedure
        }

        public void SuaNhanVien(NhanVien nhanVien)
        {
            string storedProcedure = "SuaNhanVien";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maNhanVien", SqlDbType.NVarChar) { Value = nhanVien.MaNhanVien },
                new SqlParameter("@CCCD", SqlDbType.NVarChar) { Value = nhanVien.CCCD },
                new SqlParameter("@hoVaTen", SqlDbType.NVarChar) { Value = nhanVien.HoVaTen },
                new SqlParameter("@gioiTinh", SqlDbType.NVarChar) { Value = nhanVien.GioiTinh },
                new SqlParameter("@ngaySinh", SqlDbType.DateTime) { Value = nhanVien.NgaySinh },
                new SqlParameter("@soDienThoai", SqlDbType.NVarChar) { Value = nhanVien.SoDienThoai },
                new SqlParameter("@diaChi", SqlDbType.NVarChar) { Value = nhanVien.DiaChi },
            };

            try
            {
                executeUpdateOrDeleteQuery(storedProcedure, parameters);
                Console.WriteLine("Cập nhật thông tin nhân viên thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message);
            }
        }
    }
}
