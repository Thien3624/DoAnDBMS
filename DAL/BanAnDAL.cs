using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanAnDAL : DBConnection
    {
        public BanAnDAL() : base() { }
        public DataTable HienThiBanAn()
        {
            const string sql = "SELECT * FROM QuanLyBanAn";
            return executeDisplayQuery(sql);
        }
        public List<string> LayDanhSachIdBanAn()
        {
            const string sql = "SELECT DISTINCT maBan FROM QuanLyBanAn";
            return ExecuteQueryAndGetList(sql);
        }
    }
}
