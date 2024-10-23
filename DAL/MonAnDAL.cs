using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonAnDAL : DBConnection
    {
        public MonAnDAL() : base() { }

        public DataTable HienThiMonAn()
        {
            const string sql = "SELECT * FROM XemMenu";
            return executeDisplayQuery(sql);
        }
        public List<string> LayDanhSachLoaiMonAn()
        {
            const string sql = "SELECT DISTINCT loaiMonAn FROM XemMenu";
            return ExecuteQueryAndGetList(sql);
        }

        public DataTable HienThiMonAnTheoLoai(string loaiMonAn)
        {
            string sql = $"SELECT * FROM XemMenu WHERE loaiMonAn = N'{loaiMonAn}'";
            return executeDisplayQuery(sql);
        }

    }
}
