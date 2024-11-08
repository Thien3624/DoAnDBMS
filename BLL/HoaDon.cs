using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDon
    {
        private int maHoaDon;
        int maDonHang; 
        string maKhachHang;
        private int tongTien;
        private DateTime ngayInHoaDon;
        private bool trangThai;
        int maBan;
        string maNhanVien;

        public HoaDon(int maHoaDon, int maDonHang,string maKhachHang,  int tongTien, DateTime ngayInHoaDon, bool trangThai, int maBan, string maNhanVien)
        {

            this.maHoaDon = maHoaDon;
            this.tongTien = tongTien;
            this.ngayInHoaDon = ngayInHoaDon;
            this.trangThai = trangThai;
            this.maBan = maBan;
            this.maNhanVien = maNhanVien;
        }

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaDonHang { get => maDonHang; set => maDonHang = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayInHoaDon { get => ngayInHoaDon; set => ngayInHoaDon = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public int MaBan { get => maBan; set => maBan = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}