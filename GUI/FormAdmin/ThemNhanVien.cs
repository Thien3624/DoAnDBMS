using BLL;
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
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            NhanVien nhanVien = new NhanVien();

            string gioiTinh = "";

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrWhiteSpace(tb_maNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_cccd.Text) || tb_cccd.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng kiểm tra CCCD!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_hoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!");
                return;
            }
            if (!radio_nam.Checked && !radio_nu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_soDienThoai.Text) || tb_soDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng kiểm tra số điện thoại!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_diaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                return;
            }

            // Xác định giới tính
            if (radio_nam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (radio_nu.Checked)
            {
                gioiTinh = "Nữ";
            }

            // Nếu tất cả các trường đã nhập đầy đủ, thực hiện thêm nhân viên
            try
            {
                nhanVienDAL.themNhanVien(tb_maNhanVien.Text, tb_cccd.Text, tb_hoVaTen.Text, gioiTinh, datetime_ngaySinh.Value, tb_soDienThoai.Text, tb_diaChi.Text);
                MessageBox.Show("Thêm nhân viên thành công!");

                //Load loại gridview nhân viên
                
                //Đóng form thêm nhân viên
                this.Close();  // Đóng form sau khi thêm thành công

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

/*test case
    NV005
    192846172631
    NgocThanh
    0192827461

 */
