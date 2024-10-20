using DAL;
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

namespace GUI
{
    public partial class UserControlBanAn : UserControl
    {
        public UserControlBanAn()
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
                O_BanAn oBanAn = new O_BanAn();
                // Lấy giá trị từng cột trong hàng hiện tại
                int maBan = row.Field<int>("maBan");
                string sucChua = row["sucChua"].ToString();
                oBanAn.themBanAn(maBan, sucChua);
                panelNoiDung.Controls.Add(oBanAn);
                oBanAn.BringToFront();
            }
        }

        public void UserControlBanAn_Load(object sender, EventArgs e)
        {
            addBanAn();
        }
    }
}
