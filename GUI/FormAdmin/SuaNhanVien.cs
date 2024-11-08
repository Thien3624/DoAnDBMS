using BLL;
using DAL;
using GUI.FormAdmin.UC_ThanPhanAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormAdmin
{
    public partial class SuaNhanVien : Form
    {
        public SuaNhanVien()
        {
            InitializeComponent();
        }

        NhanVienDAL nhanVienDAL = new NhanVienDAL();
        private void LoadMaNV()
        {
            List<string> dsMaNhanVien = nhanVienDAL.layDanhSachMaNhanVien();
            cbb_maNhanVien.DataSource = dsMaNhanVien;
        }

        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            LoadMaNV();
        }

        private void cbb_maNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = nhanVienDAL.layThongTinNhanVienDuocChon(cbb_maNhanVien.SelectedItem.ToString());
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                tb_cccd.Text = row["CCCD"].ToString();
                tb_hoVaTen.Text = row["hoVaTen"].ToString();
                cbb_maNhanVien.SelectedText = row["maNhanVien"].ToString();

                // Gán giới tính
                string gioiTinh = row["gioiTinh"].ToString();
                if (gioiTinh == "Nam")
                {
                    radio_nam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    radio_nu.Checked = true;
                }

                datetime_ngaySinh.Value = Convert.ToDateTime(row["ngaySinh"]);

                tb_soDienThoai.Text = row["soDienThoai"].ToString();
                tb_diaChi.Text = row["diaChi"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên.");
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = cbb_maNhanVien.Text;
                string CCCD = tb_cccd.Text;
                string hoVaTen = tb_hoVaTen.Text;
                DateTime ngaySinh = datetime_ngaySinh.Value;
                string soDienThoai = tb_soDienThoai.Text;
                string diaChi = tb_diaChi.Text;

                string gioiTinh = "";
                if (radio_nam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else if (radio_nu.Checked)
                {
                    gioiTinh = "Nữ";
                }
                 
                NhanVien nhanVien = new NhanVien(cbb_maNhanVien.Text, tb_cccd.Text, tb_hoVaTen.Text, gioiTinh, datetime_ngaySinh.Value, tb_soDienThoai.Text, tb_diaChi.Text, true);
                NhanVienDAL nhanVienDAL = new NhanVienDAL(); 
                nhanVienDAL.SuaNhanVien(nhanVien);
                MessageBox.Show("Sửa thông tin nhân viên thành công!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }
    }
}
