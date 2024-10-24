using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietDonHang
    {
        private int maDonHang;
        private string maMonAn;
        private int soLuong;
        private decimal donGia;
        private decimal thanhTien;

        public ChiTietDonHang()
        {
        }

        public ChiTietDonHang(int maDonHang, string maMonAn, int soLuong, decimal donGia, decimal thanhTien)
        {
            MaDonHang = maDonHang;
            MaMonAn = maMonAn;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
        public int MaDonHang { get => maDonHang; set => maDonHang = value; }
        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
        public decimal ThanhTien { get => thanhTien; set => thanhTien = value; }

    }
}
