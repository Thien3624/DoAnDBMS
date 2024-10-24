using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormAdmin.UC_ThanPhanAdmin
{
    public partial class O_MonAnAdmin : UserControl
    {
        public O_MonAnAdmin()
        {
            InitializeComponent();
        }
        public void themMonAnAdmin(string maMonAn, string tenMonAn, int gia, Image images)
        {
            lb_maMonAn.Text = maMonAn;
            lb_tenMonAn.Text = tenMonAn;
            lb_giaMonAn.Text = "Giá: " + gia.ToString("N0") + " VNĐ";
            picb_anhMonAn.Image = images;
        }

        private void btn_suaMonAn_Click(object sender, EventArgs e)
        {
            SuaMonAn suaMonAn = new SuaMonAn();
            suaMonAn.ShowDialog();
        }
    }
}
