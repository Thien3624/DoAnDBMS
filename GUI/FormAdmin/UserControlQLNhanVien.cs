using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI.FormAdmin.UC_ThanPhanAdmin
{
    public partial class UserControlQLNhanVien : UserControl
    {
        public UserControlQLNhanVien()
        {
            InitializeComponent();
        }
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();


        public void loadNhanVienLenGridView()
        {
            DataTable dt = new DataTable();
            dt = nhanVienDAL.hienThiNhanVien();
            gridViewHienThiNhanVien.DataSource = dt;
        }

        public void UserControlQLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_xemThongTinHoaDon_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.Show();
        }

        private void btn_xoaNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
