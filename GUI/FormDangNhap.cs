using DAL;
using GUI.FormAdmin;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
            bool uyQuyen;

            if (taiKhoanDAO.KiemTraDangNhap(tb_tenDangNhap.Text, tb_matKhau.Text, out uyQuyen))
            {
                if (uyQuyen)
                {
                    TrangChuAdmin trangChuAdmin = new TrangChuAdmin();
                    trangChuAdmin.Show();
                    this.Hide();
                }
                else
                {
                    TrangChu trangChu = new TrangChu();
                    trangChu.Show();
                    this.Hide();    
                }
            }
        }
    }
}
