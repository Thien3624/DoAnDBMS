using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DAL
{
    public class DoanhThuDAL : DBConnection
    {
        public DataTable HienThiDoanhThuThang(int thang, int nam)
        {
            string query = "select * From TinhDoanhThuThang(@thang, @nam)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@thang", SqlDbType.Int) { Value = thang },
                new SqlParameter("@nam", SqlDbType.Int) { Value = nam }
            };
            return executeSearchQuery(query, parameters);
        }
        public DataTable HienThiDoanhThuNam(int nam)
        {
            string query = "select * From TinhDoanhThuNam( @nam)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@nam", SqlDbType.Int) { Value = nam }
            };
            return executeSearchQuery(query, parameters);
        }

        public DataTable DSNam()
        {
            string query = " SELECT* FROM dbo.LayTatCaNam() ORDER BY Nam;";
            return executeDisplayQuery(query);
        }
        
        public DataTable TongDoAnTieuThuTrongThang(int thang,int nam)
        {
            string query = "SELECT * FROM TongDoAnTieuThuTrongThang(@thang, @nam)";
            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@thang", SqlDbType.Int) { Value = thang },
                new SqlParameter("@nam", SqlDbType.Int) { Value = nam }
             };
            return executeSearchQuery(query, parameters);
        }
        public DataTable TongDoAnTieuThuTrongNam( int nam)
        {
            string query = "SELECT * FROM TongDoAnTieuThuTrongNam(@thang, @nam)";
            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@nam", SqlDbType.Int) { Value = nam }
             };
            return executeSearchQuery(query, parameters);
        }

        public DataTable TongKhachTrongThang(int thang, int nam)
        {
            string query = "SELECT * FROM TongKhachTrongThang(@thang, @nam)";
            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@thang", SqlDbType.Int) { Value = thang },
                new SqlParameter("@nam", SqlDbType.Int) { Value = nam }
             };
            return executeSearchQuery(query, parameters);
        }
        public DataTable TongKhachTrongNam(int nam)
        {
            string query = "SELECT * FROM TongKhachTrongNam(@thang, @nam)";
            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@nam", SqlDbType.Int) { Value = nam }
             };
            return executeSearchQuery(query, parameters);
        }

        public DataTable TongDoanhThu()
        {
            string query = "SELECT * FROM TinhDoanhThuTong()";
            
            return executeDisplayQuery(query);
        }
    }
}
