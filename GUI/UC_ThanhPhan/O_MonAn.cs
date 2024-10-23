using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC_ThanhPhan
{
    public partial class O_MonAn : UserControl
    {
        public event Action<string, string, int, int> DatMonAn;
        private int giaMonAn;

        public O_MonAn()
        {
            InitializeComponent();
        }
        public void themMonAn(string maMonAn, string tenMonAn, int gia, Image images)
        {
            lb_maMonAn.Text = maMonAn;
            lb_tenMonAn.Text = tenMonAn;
            lb_giaMonAn.Text = "Giá: " + gia.ToString("N0") + " VNĐ";
            picb_anhMonAn.Image = images;

            giaMonAn = gia;
        }

        private void btn_datMon_Click(object sender, EventArgs e)
        {
            DatMonAn(lb_maMonAn.Text, lb_tenMonAn.Text, (int)numeric_soLuong.Value, giaMonAn);
        }
    }
}
