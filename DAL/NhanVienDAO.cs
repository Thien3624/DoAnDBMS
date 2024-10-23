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
    public class NhanVienDAO : DBConnection
    {
        public NhanVienDAO() : base() { }

        public void themNV(NhanVien nv)
        {
            const string sql = "ThemNhanVien";
            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("@maNhanVien", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(nv.MaNhanVien);

            sqlParameters[1] = new SqlParameter("@CCCD", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(nv.CCCD);

            sqlParameters[2] = new SqlParameter("@hoVaTen", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(nv.HoVaTen);

            sqlParameters[3] = new SqlParameter("@gioiTinh", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(nv.GioiTinh);

            sqlParameters[4] = new SqlParameter("@ngaySinh", SqlDbType.Date);
            sqlParameters[4].Value = Convert.ToDateTime(nv.NgaySinh);

            sqlParameters[5] = new SqlParameter("@soDienThoai", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(nv.SoDienThoai);

            sqlParameters[6] = new SqlParameter("@diaChi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(nv.DiaChi);

/*            sqlParameters[7] = new SqlParameter("@trangThaiLamViec", SqlDbType.VarChar);
            sqlParameters[7].Value = Convert.ToString(nv.TrangThaiLamViec);*/

            executeInsertQuery(sql, sqlParameters);
        }

        
    }
}
