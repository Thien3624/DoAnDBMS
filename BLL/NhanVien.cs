using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class NhanVien
    {
        private string maNhanVien;
        private string cCCD;
        private string hoVaTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string soDienThoai;
        private string diaChi;
        private bool trangThaiLamViec;

        public NhanVien(string maNhanVien, string cCCD, string hoVaTen, string gioiTinh, DateTime ngaySinh, string soDienThoai, string diaChi, bool trangThaiLamViec)
        {
            this.maNhanVien = maNhanVien;
            this.cCCD = cCCD;
            this.hoVaTen = hoVaTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
            this.trangThaiLamViec = trangThaiLamViec;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public bool TrangThaiLamViec { get => trangThaiLamViec; set => trangThaiLamViec = value; }
    }
}
