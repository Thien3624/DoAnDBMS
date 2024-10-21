using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        public void addHienThi(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelHienThi.Controls.Clear();
            panelHienThi.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btn_thucDon_Click(object sender, EventArgs e)
        {
            UserControlMenu menu = new UserControlMenu();
            addHienThi(menu);
            menu.Load += new EventHandler(menu.Menu_Load);
        }

        private void btn_banAn_Click(object sender, EventArgs e)
        {
            UserControlBanAn banAn = new UserControlBanAn();
            addHienThi(banAn);
            banAn.Load += new EventHandler(banAn.UserControlBanAn_Load);
        }
    }
}
