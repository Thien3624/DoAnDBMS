using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI.FormAdmin.UC_ThanPhanAdmin
{
    public partial class UserControlQLNhanVien : UserControl
    {
        private string selectedMaNhanVien;
        public UserControlQLNhanVien()
        {
            InitializeComponent();
        }
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();


        public void loadNhanVienLenGridView()
        {
            DataTable dt = new DataTable();
            dt = nhanVienDAL.hienThiNhanVien();
            gridViewHienThiNhanVien.DataSource = dt;
        }

        public void UserControlQLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_xemThongTinHoaDon_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.Show();
        }

        private void btn_xoaNhanVien_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.MaNhanVien = selectedMaNhanVien;
                    NhanVienDAL nhanVienDAL = new NhanVienDAL();
                    nhanVienDAL.XoaNhanVien(nhanVien);

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridViewHienThiNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một dòng (không phải tiêu đề)
            if (e.RowIndex >= 0)
            {
                // Lấy ra dòng được click
                DataGridViewRow row = gridViewHienThiNhanVien.Rows[e.RowIndex];

                // Lấy giá trị của cột "MaNV" từ dòng đó
                selectedMaNhanVien = row.Cells["maNhanVien"].Value.ToString();
            }
        }

        private void btn_suaThongTinNhanVien_Click(object sender, EventArgs e)
        {
            SuaNhanVien suaNhanVien = new SuaNhanVien();
            suaNhanVien.ShowDialog();
        }
    }
}
