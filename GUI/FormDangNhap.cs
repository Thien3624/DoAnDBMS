﻿using DAL;
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
using Constant;

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
                TaiKhoanDangNhap.maNhanVien = tb_tenDangNhap.Text;
                if (uyQuyen)
                {
                    TrangChuAdmin trangChuAdmin = new TrangChuAdmin();
                    trangChuAdmin.ShowDialog();
                    this.Close();
                }
                else
                {
                    TrangChu trangChu = new TrangChu();
                    trangChu.ShowDialog();
                    this.Close();

                }
            }
        }
    }
}
