using BLL;
using DAL;
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
    public partial class UserControlHoaDon : UserControl
    {
        HoaDonDao hoaDonDao = new HoaDonDao();
        public UserControlHoaDon()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void UserControlHoaDon_Load(object sender, EventArgs e)
        {
            this.HienThiHoaDon();
        }

        private void btn_xemThongTinHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void HienThiHoaDon()
        {
            DataTable dt = new DataTable();
            dt = hoaDonDao.HienThiDSHoaDon();
            dgHoaDon.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int maHoaDon = int.Parse(row["maHoaDon"].ToString());
                    string hoTenKhach = row["hoTenKhach"].ToString();
                    string SDT = row["SDT"].ToString();
                    DateTime ngayInHoaDon = DateTime.Parse(row["ngayInHoaDon"].ToString());
                    dgHoaDon.Rows.Add(maHoaDon, hoTenKhach, SDT, ngayInHoaDon);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu hóa đơn ");
            }
        }

        private void dgHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgHoaDon.Rows[e.RowIndex];
                var maHoaDon = row.Cells["maHoaDon"].Value;
                int maHoaDonInt = Convert.ToInt32(maHoaDon);
                dt = hoaDonDao.HienThiChiTietHoaDon(maHoaDonInt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row1 in dt.Rows)
                    {
                        string hoTenKhachHang = row1["hoTenKhachHang"].ToString();
                        int maBan = int.Parse(row1["maBan"].ToString());
                        string hoTenNhanVien = row1["hoTenNhanVien"].ToString();
                        DateTime ngayInHoaDon = DateTime.Parse(row1["ngayInHoaDon"].ToString());
                        int tongTien = int.Parse(row1["tongTien"].ToString());

                        tb_maHoaDon.Text = maHoaDonInt.ToString();
                        tb_tenKhachHang.Text = hoTenKhachHang;
                        tb_maBan.Text = maBan.ToString();
                        tb_tenNhanVien.Text = hoTenNhanVien;
                        tb_ngayTaoHoaDon.Text = ngayInHoaDon.ToString();
                        tb_tongTienThanhToan.Text = tongTien.ToString("N0") + "VNĐ";
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu hóa đơn");
                }

                dt1 = hoaDonDao.HienThiMonAnTrongHoaDon(maHoaDonInt);
                if (dt1.Rows.Count > 0)
                {
                    dgMonAn.Rows.Clear();
                    foreach (DataRow row1 in dt1.Rows)
                    {
                        string tenMonAn = row1["tenMonAn"].ToString();
                        int soLuong = Convert.ToInt32(row1["soLuong"]);
                        decimal thanhTien = Convert.ToDecimal(row1["ThanhTien"]);

                        // Thêm một dòng mới vào DataGridView (dgMonAn)
                        dgMonAn.Rows.Add(tenMonAn, soLuong, thanhTien);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu món ăn của hóa đơn");
                }

            }
        }
    }
}
