using GUI.FormAdmin.UC_ThanPhanAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormAdmin
{
    public partial class TrangChuAdmin : Form
    {
        public TrangChuAdmin()
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

        private void btn_quanLyThucDon_Click(object sender, EventArgs e)
        {
            UserControlQLThucDon qlmenu = new UserControlQLThucDon();
            addHienThi(qlmenu);
            qlmenu.Load += new EventHandler(qlmenu.UserControlQLThucDon_Load);
        }

        public void btn_quanLyNhanVien_Click(object sender, EventArgs e)
        {
            UserControlQLNhanVien userControlQLNhanVien = new UserControlQLNhanVien();
            addHienThi(userControlQLNhanVien);
            userControlQLNhanVien.Load += new EventHandler(userControlQLNhanVien.UserControlQLNhanVien_Load);

            userControlQLNhanVien.loadNhanVienLenGridView();
        }

        private void btn_quanLyBanAn_Click(object sender, EventArgs e)
        {
            UserControlQLBanAn qlBanAn = new UserControlQLBanAn();
            addHienThi(qlBanAn);
            qlBanAn.Load += new EventHandler(qlBanAn.UserControlBanAn_Load);
        }
    }
}
