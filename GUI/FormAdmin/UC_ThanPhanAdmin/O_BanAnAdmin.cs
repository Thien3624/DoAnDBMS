﻿using System;
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
    public partial class O_BanAnAdmin : UserControl
    {
        public O_BanAnAdmin()
        {
            InitializeComponent();
        }
        public void themBanAn(int maBan)
        {
            lb_maBan.Text = "Bàn " + maBan.ToString();
        }
    }
}
