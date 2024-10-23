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

            oMonAn.themMonAn(maMonAn,tenSP, gia, anh);
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
            List<string> IdBanAnList = banAnDAL.LayDanhSachIdBanAn();
            cbo_maBan.DataSource = IdBanAnList;
        }

        public void ThemMonAnVaoDonHang(string maMonAn, string tenMonAn, int soLuong, int gia)
        {
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dtGVDonHang.Rows)
            {
                if (row.Cells["TenMonAn"].Value.ToString() == tenMonAn)
                {
                    int existingQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["SoLuong"].Value = existingQuantity + soLuong; 
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
            DonHangDAO donHangDAO = new DonHangDAO();
            KhachHangDAO khachHangDAO = new KhachHangDAO();
            try
            {
                string hoVaTen = txt_hoVaTen.Text;
                string sDT = txt_sDT.Text;
                string gioiTinh;
                if (cb_gioiTinhNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else if (cb_gioiTinhNu.Checked)
                {
                    gioiTinh = "Nữ";
                }
                else
                {
                    gioiTinh = "Khác"; 
                }
                string maBan = cbo_maBan.ToString();
                string dsMaMonAn = "";

                foreach (DataGridViewRow row in dtGVDonHang.Rows)
                {
                    if (row.IsNewRow) continue;

                    string maMonAn = row.Cells["maMonAn"].Value.ToString();
                    string tenMonAn = row.Cells["tenMonAn"].Value.ToString();
                    dsMaMonAn += maMonAn;
                    int soLuong = Convert.ToInt32(row.Cells["soLuong"].Value);
                    int gia = Convert.ToInt32(row.Cells["gia"].Value);

                    DonHang donHang = new DonHang(maBan, soLuong, dsMaMonAn);
                    donHangDAO.themDonHang(donHang);

                }

                KhachHang khachHang = new KhachHang(sDT, hoVaTen, gioiTinh, sDT);
                khachHangDAO.themKhachHang(khachHang);
                MessageBox.Show("Đơn hàng đã được thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn hàng." + ex.Message);
            }
        }
    }
}
