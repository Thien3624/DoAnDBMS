using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class MonAn
    {
        private String maMonAn;
        private String tenMonAn;
        private String loaiMonAn;
        private int gia;
        private String trangThai;
        private Byte[] images;

        public MonAn(string maMonAn, string tenMonAn, string loaiMonAn, int gia, string trangThai, byte[] images)
        {
            this.maMonAn = maMonAn;
            this.tenMonAn = tenMonAn;
            this.loaiMonAn = loaiMonAn;
            this.gia = gia;
            this.trangThai = trangThai;
            this.images = images;
        }

        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public string LoaiMonAn { get => loaiMonAn; set => loaiMonAn = value; }
        public int Gia { get => gia; set => gia = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public byte[] Images { get => images; set => images = value; }
    }
}
