﻿using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAO : DBConnection
    {
        public KhachHangDAO() : base() { }

        public void themKhachHang(KhachHang khachHang)
        {
            string sql = "dbo.ThemKhachHang";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maKhachHang", khachHang.MaKhachHang),
                new SqlParameter("@hoVaTen", khachHang.HoVaTen),
                new SqlParameter("@gioiTinh", khachHang.GioiTinh),
                new SqlParameter("@SDT", khachHang.SDT)
            };

            executeInsertQuery(sql, parameters);
        }


    }
}