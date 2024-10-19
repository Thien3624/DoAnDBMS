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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        private MonAnDAL monAnDAL = new MonAnDAL();
        public Image ByteArrToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        private void addSanPham()
        {
            DataTable dt = new DataTable();
            dt = monAnDAL.HienThiMonAn();
            foreach (DataRow row in dt.Rows)
            {
                O_MonAn oMonAn = new O_MonAn();
                // Lấy giá trị từng cột trong hàng hiện tại
                string tenSP = row["tenMonAn"].ToString();
                int gia = row.Field<int>("gia");
                byte[] b = row.Field<byte[]>("anhMoTa");
                Image anh = ByteArrToImage(b);
                oMonAn.themMonAn(tenSP, gia, anh);
                panelNoiDung.Controls.Add(oMonAn);
                oMonAn.BringToFront();
            }
        }

        public void Menu_Load(object sender, EventArgs e)
        {
            addSanPham();
        }
    }
}
