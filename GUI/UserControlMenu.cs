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
using Constant;
using System.Globalization;


namespace GUI
{
    public partial class UserControlMenu : UserControl
    {
        DonHangDAO donHangDAO = new DonHangDAO();
        public UserControlMenu()
        {
            InitializeComponent();
        }
        private MonAnDAL monAnDAL = new MonAnDAL();
        private BanAnDAL banAnDAL = new BanAnDAL();
        private KhachHangDAO khachHangDAO = new KhachHangDAO();
        private HoaDonDao hoaDonDao = new HoaDonDao();
        public Image ByteArrToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void ThemMonAnVaoPanel(DataRow row)
        {
            O_MonAn oMonAn = new O_MonAn();
            string maMonAn = row["maMonAn"].ToString();
            string tenSP = row["tenMonAn"].ToString();
            int gia = row.Field<int>("gia");
            byte[] b = row.Field<byte[]>("anhMoTa");
            Image anh = ByteArrToImage(b);

            oMonAn.themMonAn(maMonAn, tenSP, gia, anh);
            panelNoiDung.Controls.Add(oMonAn);
            oMonAn.BringToFront();

            oMonAn.DatMonAn += ThemMonAnVaoDonHang;
        }

        private void addSanPham()
        {
            DataTable dt = new DataTable();
            dt = monAnDAL.HienThiMonAn();
            foreach (DataRow row in dt.Rows)
            {
                ThemMonAnVaoPanel(row);
            }
        }

        public void Menu_Load(object sender, EventArgs e)
        {
            LoadLoaiMonAn();
            LoadIdBanAn();
        }
        private void cboLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLoaiMonAn = cboLoaiMonAn.SelectedItem.ToString();
            if (selectedLoaiMonAn == "Tất cả")
            {
                panelNoiDung.Controls.Clear();
                addSanPham();
            }
            else
            {
                DataTable dt = monAnDAL.HienThiMonAnTheoLoai(selectedLoaiMonAn);
                panelNoiDung.Controls.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ThemMonAnVaoPanel(row);
                }
            }
        }
        private void LoadLoaiMonAn()
        {
            List<string> loaiMonAnList = monAnDAL.LayDanhSachLoaiMonAn();
            loaiMonAnList.Insert(0, "Tất cả");
            cboLoaiMonAn.DataSource = loaiMonAnList;
        }

        private void LoadIdBanAn()
        {
            List<string> IdBanAnList = banAnDAL.LayDanhSachIdBanAnChuaDat();
            cbo_maBan.DataSource = IdBanAnList;
        }

        public void ThemMonAnVaoDonHang(string maMonAn, string tenMonAn, int soLuong, int gia)
        {

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chuoiTienTe = lb_tongTien.Text.Replace("VNĐ", "").Trim(); // Loại bỏ "VNĐ" và khoảng trắng
            int tongTien = int.Parse(chuoiTienTe, NumberStyles.AllowThousands); // Chuyển đổi chuỗi thành số nguyên
            tongTien += gia * soLuong;;
            lb_tongTien.Text = tongTien.ToString("N0") + "VNĐ";
            foreach (DataGridViewRow row in dtGVDonHang.Rows)
            {
                if (row.Cells["TenMonAn"].Value.ToString() == tenMonAn)
                {
                    int existingQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["SoLuong"].Value = existingQuantity + soLuong;
                    row.Cells["gia"].Value = gia * (existingQuantity + soLuong);
                    return;
                }  
            }

            int rowIndex = dtGVDonHang.Rows.Add();
            DataGridViewRow newRow = dtGVDonHang.Rows[rowIndex];
            newRow.Cells["maMonAn"].Value = maMonAn;
            newRow.Cells["tenMonAn"].Value = tenMonAn;
            newRow.Cells["soLuong"].Value = soLuong;
            newRow.Cells["gia"].Value = gia * soLuong;
            
            
        }

        private void btn_themDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txt_hoVaTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_sDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dtGVDonHang.Rows.Count <= 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hoVaTen = txt_hoVaTen.Text;
                string sDT = txt_sDT.Text;
                string gioiTinh = cb_gioiTinhNam.Checked ? "Nam" : (cb_gioiTinhNu.Checked ? "Nữ" : "Khác");
                KhachHang khachHang = new KhachHang(sDT, hoVaTen, gioiTinh, sDT);
                KhachHangDAO khachHangDAO = new KhachHangDAO();
                khachHangDAO.themKhachHang(khachHang);

                int maBan = int.Parse(cbo_maBan.SelectedValue.ToString());
                DateTime ngayDatMon = DateTime.Now;



                // Khởi tạo đối tượng DonHang
                DonHang donHang = new DonHang(maBan, khachHang.MaKhachHang, ngayDatMon);
                // Thêm DonHang và lấy maDonHang vừa được thêm
                int generatedMaDonHang = donHangDAO.ThemDonHang(donHang);

                List<ChiTietDonHang> chiTietDonHangs = new List<ChiTietDonHang>();
                // Gather order details from DataGridView
                foreach (DataGridViewRow row in dtGVDonHang.Rows)
                {
                    if (row.IsNewRow) continue;
                    string maMonAn = row.Cells["maMonAn"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["soLuong"].Value);
                    int donGia = Convert.ToInt32(row.Cells["gia"].Value) / soLuong;
                    int thanhTien = Convert.ToInt32(row.Cells["gia"].Value);
                    chiTietDonHangs.Add(new ChiTietDonHang
                    {
                        MaDonHang = generatedMaDonHang,
                        MaMonAn = maMonAn,
                        SoLuong = soLuong,
                        DonGia = donGia,
                        ThanhTien = thanhTien
                    });
                }
                banAnDAL.doiTrangThaiBan(maBan);
                // Save the order details to the database
                donHangDAO.ThemChiTietDonHang(chiTietDonHangs);
                // thêm vào hóa đơn
                string chuoiTienTe = lb_tongTien.Text.Replace("VNĐ", "").Trim();
                int tongTien = int.Parse(chuoiTienTe, NumberStyles.AllowThousands);
                hoaDonDao.ThemHoaDon(generatedMaDonHang, khachHang.MaKhachHang, tongTien, ngayDatMon, false, maBan, TaiKhoanDangNhap.maNhanVien);
                
                MessageBox.Show("Đơn hàng đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            string tenMonAn = txt_tenMonAn.Text;
            DataTable dt = new DataTable();
            dt = monAnDAL.TimKiemMonAn('%'+ tenMonAn + '%');
            panelNoiDung.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {

                ThemMonAnVaoPanel(row);
            }
        }

        private void btn_ktraKH_Click(object sender, EventArgs e)
        {
            string sDT = txt_sDT.Text;
            DataTable dt = new DataTable();
            dt = khachHangDAO.timKiemKhachHangTheoSDT(sDT);
            foreach (DataRow row in dt.Rows)
            {
                txt_hoVaTen.Text = row["hoVaTen"].ToString();
                txt_sDT.Text = row["SDT"].ToString();
                cb_gioiTinhNam.Checked = row["gioiTinh"].ToString() == "Nam" ? true : false;
                cb_gioiTinhNu.Checked = row["gioiTinh"].ToString() == "Nữ" ? true : false;
            }
        }

        private void btn_bestSeller_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = monAnDAL.BestSeller();
            panelNoiDung.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ThemMonAnVaoPanel(row);
            }
        }
    }
}