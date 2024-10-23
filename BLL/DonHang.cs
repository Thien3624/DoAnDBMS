using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonHang
    {
        private string maDonHang;
        private string maBan;
        private string maKhachHang;
        private DateTime ngayDatMon;
        private int soLuong;
        private string dsMaMonAn;

        public DonHang(string maBan, int soLuong, string dsMaMonAn) 
        { 
            this.maBan = maBan;
            this.soLuong = soLuong;
            this.dsMaMonAn = dsMaMonAn;
        }

        public DonHang(string maDonHang, string maBan, string maKhachHang, DateTime ngayDatMon, int soLuong, string dsMaMonAn)
        {
            this.maDonHang = maDonHang;
            this.maBan = maBan;
            this.maKhachHang = maKhachHang;
            this.ngayDatMon = ngayDatMon;
            this.soLuong = soLuong;
            this.dsMaMonAn = dsMaMonAn;
        }

        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        public string MaBan { get => maBan; set => maBan = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime NgayDatMon { get => ngayDatMon; set => ngayDatMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DsMaMonAn { get => dsMaMonAn; set => dsMaMonAn = value; }
    }
}
