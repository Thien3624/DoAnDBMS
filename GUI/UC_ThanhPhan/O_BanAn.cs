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
    public partial class O_BanAn : UserControl
    {
        public O_BanAn()
        {
            InitializeComponent();
        }

        public void themBanAn(int maBan, string sucChua)
        {
            lb_sucChua.BackColor = lb_banAn.BackColor;
            lb_maBan.BackColor = lb_banAn.BackColor;
            lb_maBan.Text = "Bàn " + maBan.ToString();
            lb_sucChua.Text = "Bàn " + sucChua;
        }
    }
}
