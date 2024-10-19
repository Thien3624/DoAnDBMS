using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
