using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class HoaDon
    {
        private string maHoaDon;
        private int tongTien;
        private DateTime ngayInHoaDon;
        private bool trangThai;

        public HoaDon(string maHoaDon, int tongTien, DateTime ngayInHoaDon, bool trangThai)
        {
            this.maHoaDon = maHoaDon;
            this.tongTien = tongTien;
            this.ngayInHoaDon = ngayInHoaDon;
            this.trangThai = trangThai;
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayInHoaDon { get => ngayInHoaDon; set => ngayInHoaDon = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}