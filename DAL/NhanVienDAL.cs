using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class NhanVienDAL : DBConnection
    {
        public NhanVienDAL() : base() { }

        public DataTable hienThiNhanVien()
        {
            const string sql = "SELECT * FROM NHANVIEN";
            return executeDisplayQuery(sql);
        }

        public void themNhanVien(string maNhanVien, string CCCD, string hoVaTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string diaChi)
        {
            string storedProcedure = "ThemNhanVien";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maNhanVien", SqlDbType.NVarChar) { Value = maNhanVien },
                new SqlParameter("@CCCD", SqlDbType.NVarChar) { Value = CCCD },
                new SqlParameter("@hoVaTen", SqlDbType.NVarChar) { Value = hoVaTen },
                new SqlParameter("@gioiTinh", SqlDbType.NVarChar) { Value = gioiTinh },
                new SqlParameter("@ngaySinh", SqlDbType.DateTime) { Value = ngaySinh },
                new SqlParameter("@soDienThoai", SqlDbType.NVarChar) { Value = soDienThoai },
                new SqlParameter("@diaChi", SqlDbType.NVarChar) { Value = diaChi },

            };

            executeInsertQuery(storedProcedure, parameters);
        }


    }
}
