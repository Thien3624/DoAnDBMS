using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class KhachHang
    {
        private String maKhachHang;
        private String hoVaTen;
        private String gioiTinh;
        private String sDT;

        public KhachHang(string maKhachHang, string hoVaTen, string gioiTinh, string sDT)
        {
            this.MaKhachHang = maKhachHang;
            this.HoVaTen = hoVaTen;
            this.GioiTinh = gioiTinh;
            this.SDT = sDT;
        }

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
