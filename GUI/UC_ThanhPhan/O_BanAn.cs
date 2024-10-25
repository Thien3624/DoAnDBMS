using BLL;
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
        public event EventHandler<BanAnEventArgs> BanAnClicked;
        public O_BanAn()
        {
            InitializeComponent();
            this.Click += O_BanAn_Click;
        }
        private void O_BanAn_Click(object sender, EventArgs e)
        {
            // Khi bàn ăn được click, kích hoạt event và truyền dữ liệu
            if (BanAnClicked != null)
            {
                string tenBan = lb_maBan.Text;
                List<string> lst = tenBan.Split(' ').ToList();
                int maBan = int.Parse(lst[1]);
                BanAnEventArgs args = new BanAnEventArgs(maBan);
                BanAnClicked(this, args);
            }
        }
        public void themBanAn(int maBan)
        {
            lb_maBan.BackColor = lb_banAn.BackColor;
            lb_maBan.Text = "Bàn " + maBan.ToString();
        }

        public class BanAnEventArgs : EventArgs
        {
            public int MaBan { get; }

            public BanAnEventArgs(int maBan)
            {
                MaBan = maBan;
            }
        }

        private void lb_banAn_Click(object sender, EventArgs e)
        {

        }
    }
}
