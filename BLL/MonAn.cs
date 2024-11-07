using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonAn
    {
        private string maMonAn;
        private string tenMonAn;
        private string loaiMonAn;
        private int gia;
        private Byte[] images;

        public MonAn(string maMonAn, string tenMonAn, string loaiMonAn, int gia, byte[] images)
        {
            this.maMonAn = maMonAn;
            this.tenMonAn = tenMonAn;
            this.loaiMonAn = loaiMonAn;
            this.gia = gia;
            this.images = images;
        }

        public MonAn(string maMonAn)
        {
            this.maMonAn = maMonAn;
        }

        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public string LoaiMonAn { get => loaiMonAn; set => loaiMonAn = value; }
        public int Gia { get => gia; set => gia = value; }
        public byte[] Images { get => images; set => images = value; }
    }
}
