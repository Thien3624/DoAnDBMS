using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class KhachHang
    {
        private string maKhachHang;
        private string hoVaTen;
        private string gioiTinh;
        private string sDT;

        public KhachHang(string maKhachHang, string hoVaTen, string gioiTinh, string sDT)
        {
            this.maKhachHang = maKhachHang;
            this.hoVaTen = hoVaTen;
            this.gioiTinh = gioiTinh;
            this.sDT = sDT;
        }

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
