using DAL;
using GUI.FormAdmin.UC_ThanPhanAdmin;
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
    public partial class UserControlQLThucDon : UserControl
    {
        public UserControlQLThucDon()
        {
            InitializeComponent();
        }
        MonAnDAL monAnDAL = new MonAnDAL();
        public Image ByteArrToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void ThemMonAnVaoPanel(DataRow row)
        {
            O_MonAnAdmin oMonAnAdmin = new O_MonAnAdmin();
            string maMonAn = row["maMonAn"].ToString();
            string tenMonAn = row["tenMonAn"].ToString();
            string loaiMonAn = row["loaiMonAn"].ToString();
            int gia = row.Field<int>("gia");
            int soLuong = row.Field<int>("soLuong");
            byte[] b = row.Field<byte[]>("anhMoTa");
            Image anh = ByteArrToImage(b);

            oMonAnAdmin.themMonAnAdmin(maMonAn, tenMonAn, loaiMonAn, gia, soLuong, anh);
            panelNoiDung.Controls.Add(oMonAnAdmin);
            oMonAnAdmin.BringToFront();
        }

        private void ThemSanPhamAdmin()
        {
            DataTable dt = new DataTable();
            dt = monAnDAL.HienThiMonAn();
            foreach (DataRow row in dt.Rows)
            {
                ThemMonAnVaoPanel(row);
            }
        }
        private void LoadLoaiMonAnAdmin()
        {
            List<string> loaiMonAnList = monAnDAL.LayDanhSachLoaiMonAn();
            loaiMonAnList.Insert(0, "Tất cả");
            cboLoaiMonAn.DataSource = loaiMonAnList;
        }

        private void Btn_ThemMonAn_Click(object sender, EventArgs e)
        {
            ThemMonAn themMonAn = new ThemMonAn();
            themMonAn.ShowDialog();
        }

        private void CboLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLoaiMonAn = cboLoaiMonAn.SelectedItem.ToString();
            if (selectedLoaiMonAn == "Tất cả")
            {
                panelNoiDung.Controls.Clear();
                ThemSanPhamAdmin();
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

        public void UserControlQLThucDon_Load(object sender, EventArgs e)
        {
            LoadLoaiMonAnAdmin();
        }


    }
}
