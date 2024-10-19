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

        private void trangchu_menu_Click(object sender, EventArgs e)
        {
            userControlMenu1.BringToFront();
        }

        private void userControlMenu1_Load(object sender, EventArgs e)
        {

        }

        private void btn_banAn_Click(object sender, EventArgs e)
        {
            userControlBanAn1.BringToFront();
        }
    }
}
