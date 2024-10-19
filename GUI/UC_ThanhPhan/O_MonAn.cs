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
        public O_MonAn()
        {
            InitializeComponent();
        }
        public void themMonAn(string tenMonAn, int gia, Image images)
        {
            lb_tenMonAn.Text = tenMonAn;
            lb_giaMonAn.Text = "Giá: " + gia.ToString("N0") + " VNĐ";
            picb_anhMonAn.Image = images;
        }
    }
}
