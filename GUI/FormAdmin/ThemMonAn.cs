using BLL;
using DAL;
using GUI.UC_ThanhPhan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormAdmin
{
    public partial class ThemMonAn : Form
    {
        public ThemMonAn()
        {
            InitializeComponent();
        }
        private byte[] imageBytes;
        MonAnDAL monAnDAL = new MonAnDAL();
        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh trong PictureBox
                    pic_MonAn.Image = Image.FromFile(openFileDialog.FileName);

                    // Chuyển đổi ảnh thành byte[]
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pic_MonAn.Image.Save(ms, pic_MonAn.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string maMonAn = txt_maMonAn.Text;
                string tenMonAn = txt_tenMonAn.Text;
                string loaiMonAn = cbo_loaiMonAn.SelectedItem?.ToString(); // Kiểm tra null
                int gia = int.Parse(txt_gia.Text);
                int soLuong = int.Parse(txt_soLuong.Text);

                if (imageBytes == null)
                {
                    MessageBox.Show("Vui lòng chọn ảnh cho món ăn.");
                    return;
                }

                MonAn monAn = new MonAn(maMonAn, tenMonAn, loaiMonAn, gia, soLuong, imageBytes);
                monAnDAL.ThemMonAn(maMonAn, tenMonAn, loaiMonAn, gia, soLuong, imageBytes);
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void LoadLoaiMonAn()
        {
            List<string> loaiMonAnList = monAnDAL.LayDanhSachLoaiMonAn();
            cbo_loaiMonAn.DataSource = loaiMonAnList;
        }

        private void ThemMonAn_Load(object sender, EventArgs e)
        {
            LoadLoaiMonAn();
        }
    }
}
