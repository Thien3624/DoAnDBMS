﻿using System;
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
            if(tb_tenDangNhap.Text.Equals("123") && tb_matKhau.Text.Equals("123"))
            {
                TrangChu trangChu = new TrangChu();
                trangChu.Show();
            }
        }
    }
}
