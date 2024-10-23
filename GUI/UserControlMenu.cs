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
            string tenSP = row["tenMonAn"].ToString();
            int gia = row.Field<int>("gia");
            byte[] b = row.Field<byte[]>("anhMoTa");
            Image anh = ByteArrToImage(b);

            oMonAn.themMonAn(tenSP, gia, anh);
            panelNoiDung.Controls.Add(oMonAn);
            oMonAn.BringToFront();
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
    }
}
