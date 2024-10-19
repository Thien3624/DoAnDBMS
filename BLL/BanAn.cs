using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class BanAn
    {
        private int maBanAn;
        private string trangThai;
        private string sucChua;

        public BanAn(int maBanAn, string trangThai, string sucChua)
        {
            this.maBanAn = maBanAn;
            this.trangThai = trangThai;
            this.sucChua = sucChua;
        }

        public int MaBanAn { get => maBanAn; set => maBanAn = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string SucChua { get => sucChua; set => sucChua = value; }
    }
}
