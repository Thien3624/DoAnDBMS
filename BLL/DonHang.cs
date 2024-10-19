using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class DonHang
    {
        private string maDonHang;
        private DateTime ngayDatMon;
        private int soLuong;
        private string trangThai;

        public DonHang(string maDonHang, DateTime ngayDatMon, int soLuong, string trangThai)
        {
            this.maDonHang = maDonHang;
            this.ngayDatMon = ngayDatMon;
            this.soLuong = soLuong;
            this.trangThai = trangThai;
        }

        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        public DateTime NgayDatMon { get => ngayDatMon; set => ngayDatMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
