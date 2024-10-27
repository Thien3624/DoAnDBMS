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
using static GUI.UC_ThanhPhan.O_BanAn;

namespace GUI
{
    public partial class UserControlBanAn : UserControl
    {
        public UserControlBanAn()
        {
            InitializeComponent();
        }
        BanAnDAL BanAnDAL = new BanAnDAL();
        DonHangDAO DonHangDAO = new DonHangDAO();
        private void addBanAn()
        {
            DataTable dt = new DataTable();
            dt = BanAnDAL.HienThiBanAn();
            foreach (DataRow row in dt.Rows)
            {
                O_BanAn oBanAn = new O_BanAn();
                // Lấy giá trị từng cột trong hàng hiện tại
                int maBan = row.Field<int>("maBan");
                if ((bool)row["trangThai"])
                {
                    oBanAn.BackColor = Color.Red;
                }
                else
                {
                    oBanAn.BackColor = Color.Green;
                }
                oBanAn.themBanAn(maBan);
                oBanAn.BanAnClicked += O_BanAn_Clicked;
                panelNoiDung.Controls.Add(oBanAn);
                oBanAn.BringToFront();
            }
        }

        public void UserControlBanAn_Load(object sender, EventArgs e)
        {
            addBanAn();
        }

        private void O_BanAn_Clicked(object sender, BanAnEventArgs e)
        {
            HienThiDonHang(e.MaBan);
        }

        private void HienThiDonHang(int maBan)
        {
            DataTable dt = new DataTable();
            dt = BanAnDAL.HienThiHoaDonTheoBan(maBan);
            dgDonHang.Rows.Clear();
            int tongTien = 0;
            if (dt.Rows.Count > 0)
            {
                txt_tenKhachHang.Text = dt.Rows[0]["hoTenKhachHang"].ToString();
                txt_soDienThoai.Text = dt.Rows[0]["SDT"].ToString();

                foreach (DataRow row in dt.Rows)
                {
                    string tenMonAn = row["tenMonAn"].ToString();
                    int soLuong = int.Parse(row["soLuong"].ToString());
                    decimal thanhTien = decimal.Parse(row["thanhTien"].ToString());

                    dgDonHang.Rows.Add(tenMonAn, soLuong, thanhTien);

                    tongTien += int.Parse(row["thanhTien"].ToString());
                }
                lb_tongTien.Text = tongTien.ToString("N0") + "VNĐ";
            }
            else
            {
                MessageBox.Show("Không có dữ liệu hóa đơn cho bàn " + maBan);
            }


        }
    }
}
