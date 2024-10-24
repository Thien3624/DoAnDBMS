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

namespace GUI.FormAdmin.UC_ThanPhanAdmin
{
    public partial class O_MonAnAdmin : UserControl
    {
        public O_MonAnAdmin()
        {
            InitializeComponent();
        }
        private int Gia;
        public void themMonAnAdmin(string maMonAn, string tenMonAn,string loaiMonAn, int gia,int soLuong, Image images)
        {
            lb_maMonAn.Text = maMonAn;
            lb_tenMonAn.Text = tenMonAn;
            lb_giaMonAn.Text = "Giá: " + gia.ToString("N0") + " VNĐ";
            lb_soLuong.Text = soLuong.ToString();
            lb_loaiMonAn.Text = loaiMonAn;
            picb_anhMonAn.Image = images;
            Gia = gia;
        }

        private void btn_suaMonAn_Click(object sender, EventArgs e)
        {
            string maMonAn = lb_maMonAn.Text;
            string tenMonAn = lb_tenMonAn.Text;
            string loaiMonAn = lb_loaiMonAn.Text;
            int gia = Gia;
            int soLuong = int.Parse(lb_soLuong.Text);
            byte[] anhMoTa = ImageToByteArray(picb_anhMonAn.Image);

            SuaMonAn suaMonAn = new SuaMonAn(maMonAn, tenMonAn, loaiMonAn, gia, soLuong, anhMoTa);
            suaMonAn.ShowDialog();
        }
        private byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void btn_xoaMonAn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string maMonAn = lb_maMonAn.Text;
                try
                {
                    MonAnDAL monAnDAL = new MonAnDAL();
                    monAnDAL.XoaMonAn(maMonAn);
                    MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
