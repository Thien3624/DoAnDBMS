using DAL;
using GUI.FormAdmin.UC_ThanPhanAdmin;
using GUI.UC_ThanhPhan;
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
    public partial class UserControlQLBanAn : UserControl
    {
        public UserControlQLBanAn()
        {
            InitializeComponent();
        }
        BanAnDAL BanAnDAL = new BanAnDAL();
        private void addBanAn()
        {
            DataTable dt = new DataTable();
            dt = BanAnDAL.HienThiBanAn();
            foreach (DataRow row in dt.Rows)
            {
                O_BanAnAdmin o_BanAnAdmin = new O_BanAnAdmin();
                // Lấy giá trị từng cột trong hàng hiện tại
                int maBan = row.Field<int>("maBan");
                
                o_BanAnAdmin.BackColor = Color.FromArgb(255, 128, 0);
               
                o_BanAnAdmin.themBanAn(maBan);

                panelNoiDung.Controls.Add(o_BanAnAdmin);
                o_BanAnAdmin.BringToFront();
            }
        }
        public void UserControlBanAn_Load(object sender, EventArgs e)
        {
            addBanAn();
        }
    }
}
