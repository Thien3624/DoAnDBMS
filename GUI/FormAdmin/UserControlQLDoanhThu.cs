using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI.FormAdmin
{
    public partial class UserControlQLDoanhThu : UserControl
    {
        DoanhThuDAL DoanhThuDAL = new DoanhThuDAL();
        public UserControlQLDoanhThu()
        {
            InitializeComponent();
        }

        private void UserControlQLDoanhThu_Load(object sender, EventArgs e)
        {
            HienThiDoanhThuThang(10,2024);
            DataTable dt = DoanhThuDAL.DSNam();
            cboNam.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int nam = Convert.ToInt32(row["Nam"]);
                cboNam.Items.Add(nam);
            }
            if (cboNam.Items.Count > 0)
            {
                cboNam.SelectedIndex = -1;
            }
        }
            private void HienThiDoanhThuThang(int thang, int nam)
        {
            DataTable dt = DoanhThuDAL.HienThiDoanhThuThang(thang, nam);
            ChartValues<double> values = new ChartValues<double>();
            List<string> labels = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                values.Add(Convert.ToDouble(row["DoanhThuNgay"])); // Thêm dữ liệu vào trục Y
                labels.Add(row["Ngay"].ToString()); // Thêm nhãn vào trục X
            }

            // Thiết lập biểu đồ như trên với dữ liệu từ DataTable
            doanhThuChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Doanh thu từng ngày trong tháng " + thang + "/" + nam,
                    Values = values
                }
            };
            if (doanhThuChart.AxisX.Count == 0)
            {
                doanhThuChart.AxisX.Add(new Axis());
            }

            doanhThuChart.AxisX[0].Labels = labels;
        }

        private void HienThiDoanhThuNam( int nam)
        {
            DataTable dt = DoanhThuDAL.HienThiDoanhThuNam(nam);
            ChartValues<double> values = new ChartValues<double>();
            List<string> labels = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                values.Add(Convert.ToDouble(row["DoanhThuThang"])); // Thêm dữ liệu vào trục Y
                labels.Add(row["Thang"].ToString()); // Thêm nhãn vào trục X
            }

            // Thiết lập biểu đồ như trên với dữ liệu từ DataTable
            doanhThuChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Doanh thu từng tháng của năm " + nam,
                    Values = values
                }
            };
            if (doanhThuChart.AxisX.Count == 0)
            {
                doanhThuChart.AxisX.Add(new Axis());
            }

            doanhThuChart.AxisX[0].Labels = labels;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Kiểm tra cboLoai
            if (string.IsNullOrEmpty(cboLoai.Text))
            {
                MessageBox.Show("Chưa chọn loại để lọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(cboLoai.Text == "Doanh thu")
                {
                    bool namSelected = !string.IsNullOrEmpty(cboNam.Text);
                    bool thangSelected = !string.IsNullOrEmpty(cboThang.Text);
                    if (!namSelected && !thangSelected)
                    {
                        //HienThiDoanhThuTong();
                    }
                    else if (namSelected && !thangSelected)
                    {
                        int nam = int.Parse(cboNam.Text);

                        HienThiDoanhThuNam(nam);
                    }
                    else if (!namSelected)
                    {
                        MessageBox.Show("Chưa chọn năm để lọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int nam = int.Parse(cboNam.Text);
                        int thang = int.Parse(cboThang.Text);
                        doanhThuChart.Series.Clear();
                        HienThiDoanhThuThang(thang, nam);
                    }
                } 
                else if (cboLoai.Text == "Khách")
                {
                    bool namSelected = !string.IsNullOrEmpty(cboNam.Text);
                    bool thangSelected = !string.IsNullOrEmpty(cboThang.Text);
                    if (!namSelected && !thangSelected)
                    {
                        //HienThiKhachTong();
                    }
                    else if (namSelected && !thangSelected)
                    {
                        int nam = int.Parse(cboNam.Text);
                        doanhThuChart.Series.Clear();
                        HienThiKhachTheoNam(nam);
                    }
                    else if (!namSelected)
                    {
                        MessageBox.Show("Chưa chọn năm để lọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int nam = int.Parse(cboNam.Text);
                        int thang = int.Parse(cboThang.Text);
                        doanhThuChart.Series.Clear();
                        HienThiKhachTheoThang( thang, nam);
                    }
                }
                else 
                {
                    bool namSelected = !string.IsNullOrEmpty(cboNam.Text);
                    bool thangSelected = !string.IsNullOrEmpty(cboThang.Text);
                    if (!namSelected && !thangSelected)
                    {
                        //HienThiLuongThucAnTong();
                    }
                    else if (namSelected && !thangSelected)
                    {
                        int nam = int.Parse(cboNam.Text);
                        doanhThuChart.Series.Clear();
                        HienThiLuongThucAnNam(nam);
                    }
                    else if (!namSelected)
                    {
                        MessageBox.Show("Chưa chọn năm để lọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int nam = int.Parse(cboNam.Text);
                        int thang = int.Parse(cboThang.Text);
                        doanhThuChart.Series.Clear();
                        HienThiLuongThucAnThang(thang, nam);
                    }
                }
            }    
            
        }



        private void HienThiLuongThucAnThang(int thang, int nam)
        {
            DataTable dt = DoanhThuDAL.TongDoAnTieuThuTrongThang(thang, nam);
            ChartValues<double> values = new ChartValues<double>();
            List<string> labels = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                values.Add(Convert.ToDouble(row["TongSoLuong"])); // Thêm dữ liệu vào trục Y
                labels.Add(row["Ngay"].ToString()); // Thêm nhãn vào trục X
            }

            // Thiết lập biểu đồ như trên với dữ liệu từ DataTable
            doanhThuChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Lượng thức ăn từng ngày trong tháng " + thang + "/" + nam,
                    Values = values
                }
            };
            if (doanhThuChart.AxisX.Count == 0)
            {
                doanhThuChart.AxisX.Add(new Axis());
            }

            doanhThuChart.AxisX[0].Labels = labels;
        }

        private void HienThiLuongThucAnNam( int nam)
        {
            DataTable dt = DoanhThuDAL.TongDoAnTieuThuTrongNam( nam);
            ChartValues<double> values = new ChartValues<double>();
            List<string> labels = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                values.Add(Convert.ToDouble(row["TongSoLuong"])); // Thêm dữ liệu vào trục Y
                labels.Add(row["Thang"].ToString()); // Thêm nhãn vào trục X
            }

            // Thiết lập biểu đồ như trên với dữ liệu từ DataTable
            doanhThuChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Lượng thức ăn tiêu thụ trong " + nam,
                    Values = values
                }
            };
            if (doanhThuChart.AxisX.Count == 0)
            {
                doanhThuChart.AxisX.Add(new Axis());
            }

            doanhThuChart.AxisX[0].Labels = labels;
        }

        private void HienThiKhachTheoThang(int thang, int nam)
        {
            DataTable dt = DoanhThuDAL.TongKhachTrongThang(thang, nam);
            ChartValues<double> values = new ChartValues<double>();
            List<string> labels = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                values.Add(Convert.ToDouble(row["SoLuongKhach"])); // Thêm dữ liệu vào trục Y
                labels.Add(row["Ngay"].ToString()); // Thêm nhãn vào trục X
            }

            // Thiết lập biểu đồ như trên với dữ liệu từ DataTable
            doanhThuChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Lượng khách từng ngày trong tháng " + thang + "/" + nam,
                    Values = values
                }
            };
            if (doanhThuChart.AxisX.Count == 0)
            {
                doanhThuChart.AxisX.Add(new Axis());
            }

            doanhThuChart.AxisX[0].Labels = labels;
        }

        private void HienThiKhachTheoNam(int nam)
        {
            DataTable dt = DoanhThuDAL.TongKhachTrongNam(nam);
            ChartValues<double> values = new ChartValues<double>();
            List<string> labels = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                values.Add(Convert.ToDouble(row["SoLuongKhach"])); // Thêm dữ liệu vào trục Y
                labels.Add(row["Nam"].ToString()); // Thêm nhãn vào trục X
            }

            // Thiết lập biểu đồ như trên với dữ liệu từ DataTable
            doanhThuChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Lượng thức khách trong " + nam,
                    Values = values
                }
            };
            if (doanhThuChart.AxisX.Count == 0)
            {
                doanhThuChart.AxisX.Add(new Axis());
            }

            doanhThuChart.AxisX[0].Labels = labels;
        }
    }
}
