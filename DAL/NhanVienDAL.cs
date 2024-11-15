using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Server;
using System.Data.Common;

namespace DAL
{
    public class NhanVienDAL : DBConnection
    {
        private DBConnection dBConnection = new DBConnection();
        public NhanVienDAL() : base() { }

        public DataTable hienThiNhanVien()
        {
            const string sql = "SELECT * FROM XemNhanVien WHERE TrangThaiLamViec = 1";
            return executeDisplayQuery(sql);
        }

        public void themNhanVien(NhanVien nhanVien)
        {
            string storedProcedure = "ThemNhanVien";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maNhanVien", SqlDbType.VarChar) { Value = nhanVien.MaNhanVien },
                new SqlParameter("@CCCD", SqlDbType.VarChar) { Value = nhanVien.CCCD },
                new SqlParameter("@hoVaTen", SqlDbType.NVarChar) { Value = nhanVien.HoVaTen },
                new SqlParameter("@gioiTinh", SqlDbType.NVarChar) { Value = nhanVien.GioiTinh },
                new SqlParameter("@ngaySinh", SqlDbType.DateTime) { Value = nhanVien.NgaySinh },
                new SqlParameter("@soDienThoai", SqlDbType.VarChar) { Value = nhanVien.SoDienThoai },
                new SqlParameter("@diaChi", SqlDbType.NVarChar) { Value = nhanVien.DiaChi },

            };

            executeInsertQuery(storedProcedure, parameters);
        }

        public void XoaNhanVien(NhanVien nhanVien)
        {
            string storedProcedure = "XoaNhanVien";
            //string storedProcedure1 = "";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maNhanVien", SqlDbType.NVarChar) { Value = nhanVien.MaNhanVien }
            };

            executeUpdateOrDeleteQuery(storedProcedure, parameters); 
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
                Console.WriteLine("Cập nhật thông tin nhân viên thành công");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message);
            }
        }

        public List<string> layDanhSachMaNhanVien()
        {
            string query = "SELECT maNhanVien FROM XemNhanVien WHERE TrangThaiLamViec = 1";
            return ExecuteQueryAndGetList(query);
        }

        public DataTable layThongTinNhanVienDuocChon(string maNhanVien)
        {
            string query = "SELECT * FROM XemNhanVien WHERE maNhanVien = @maNhanVien";

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@maNhanVien", SqlDbType.VarChar) { Value = maNhanVien }
            };

            return executeSearchQuery(query, parameters);
        }
    }
}
