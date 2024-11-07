using BLL;
using DAL;
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
    public partial class SuaMonAn : Form
    {
        public SuaMonAn()
        {
            InitializeComponent();
        }
        MonAnDAL monAnDAL = new MonAnDAL();
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maMonAn = txt_maMonAn.Text;
            string tenMonAn = txt_tenMonAn.Text;
            string loaiMonAn = cbo_loaiMonAn.Text;
            int gia = int.Parse(txt_gia.Text);
            byte[] anhMoTa = ImageToByteArray(pic_AnhMonAn.Image);

            MonAn monAn = new MonAn(maMonAn, tenMonAn, loaiMonAn, gia, anhMoTa);
            monAnDAL.SuaMonAn(monAn);
            MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //Chọn ảnh
        private byte[] imageBytes;
        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh trong PictureBox
                    pic_AnhMonAn.Image = Image.FromFile(openFileDialog.FileName);

                    // Chuyển đổi ảnh thành byte[]
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pic_AnhMonAn.Image.Save(ms, pic_AnhMonAn.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }
            }
        }
        //Chuyển ảnh sang byte[]
        private byte[] ImageToByteArray(Image imageIn)
        {
            using (Bitmap bmp = new Bitmap(imageIn))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    bmp.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                    return m.ToArray();
                }
            }
        }

        //Hiển thị dữ liệu của món muốn sửa lên form
        public SuaMonAn(string maMonAn, string tenMonAn, string loaiMonAn, int gia, byte[] anhMoTa)
        {
            InitializeComponent();
            txt_maMonAn.Text = maMonAn;
            txt_tenMonAn.Text = tenMonAn;
            txt_gia.Text = gia.ToString();
            pic_AnhMonAn.Image = ByteArrayToImage(anhMoTa);
            LoadLoaiMonAn();
            cbo_loaiMonAn.SelectedItem = loaiMonAn;
        }
        //Chuyển byte[] sang image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return new Bitmap(Image.FromStream(ms));
            }
        }
        private void LoadLoaiMonAn()
        {
            List<string> loaiMonAnList = monAnDAL.LayDanhSachLoaiMonAn();
            cbo_loaiMonAn.DataSource = loaiMonAnList;
        }
        private void SuaMonAn_Load(object sender, EventArgs e)
        {
        }
    }
}
