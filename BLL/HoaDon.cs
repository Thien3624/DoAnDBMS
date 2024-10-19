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
        private String maHoaDon;
        private int tongTien;
        private DateTime ngayInHoaDon;
        private String phuongThucThanhToan;
        private String trangThai;

        public HoaDon(string maHoaDon, int tongTien, DateTime ngayInHoaDon, string phuongThucThanhToan, string trangThai)
        {
            this.maHoaDon = maHoaDon;
            this.tongTien = tongTien;
            this.ngayInHoaDon = ngayInHoaDon;
            this.phuongThucThanhToan = phuongThucThanhToan;
            this.trangThai = trangThai;
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayInHoaDon { get => ngayInHoaDon; set => ngayInHoaDon = value; }
        public string PhuongThucThanhToan { get => phuongThucThanhToan; set => phuongThucThanhToan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}