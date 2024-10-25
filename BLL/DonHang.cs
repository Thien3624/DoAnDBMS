using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonHang
    {
        private int maDonHang;
        private int maBan;
        private string maKhachHang;
        private DateTime ngayDatMon;

        public DonHang(int maBan, string maKhachHang, DateTime ngayDatMon)
        {
            this.maBan = maBan;
            this.maKhachHang = maKhachHang;
            this.ngayDatMon = ngayDatMon;
        }

        public int MaDonHang { get => maDonHang; set => maDonHang = value; }
        public int MaBan { get => maBan; set => maBan = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime NgayDatMon { get => ngayDatMon; set => ngayDatMon = value; }
    }
}
