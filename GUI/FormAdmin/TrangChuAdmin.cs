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
            UserControlQLThucDon menu = new UserControlQLThucDon();
            addHienThi(menu);
            menu.Load += new EventHandler(menu.Menu_Load);
        }
    }
}
