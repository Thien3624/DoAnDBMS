using BLL;
using DAL;
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

        // Phương thức để tải mã nhân viên vào ComboBox
        private DBConnection dBConnection = new DBConnection();
        private void LoadMaNV()
        {
            DBConnection dBConnection = new DBConnection();
            using (SqlConnection connection = dBConnection.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT maNhanVien FROM NHANVIEN";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Xóa các item hiện có trong ComboBox (nếu có)
                cbb_maNhanVien.Items.Clear();

                // Đọc dữ liệu và thêm vào ComboBox
                while (reader.Read())
                {
                    cbb_maNhanVien.Items.Add(reader["maNhanVien"].ToString());
                }

                connection.Close();
            }
        }

        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            LoadMaNV();
            LoadMaNhanVien();
        }

        private void LoadMaNhanVien()
        {
            try
            {
                using (SqlConnection conn = dBConnection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "SELECT maNhanVien FROM NHANVIEN";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbb_maNhanVien.Items.Clear();
                    while (reader.Read())
                    {
                        cbb_maNhanVien.Items.Add(reader["maNhanVien"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbb_maNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_maNhanVien.SelectedItem != null)
            {
                try
                {
                    using (SqlConnection conn = dBConnection.GetSqlConnection())
                    {
                        conn.Open();
                        string query = "SELECT * FROM NHANVIEN WHERE maNhanVien = @maNhanVien";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@maNhanVien", cbb_maNhanVien.SelectedItem.ToString());

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Đổ dữ liệu vào các control
                            tb_cccd.Text = reader["CCCD"].ToString();
                            tb_hoVaTen.Text = reader["hoVaTen"].ToString();

                            // Xử lý giới tính
                            if (reader["gioiTinh"].ToString() == "Nam")
                                radio_nam.Checked = true;
                            else
                                radio_nu.Checked = true;

                            // Xử lý ngày sinh
                            if (reader["ngaySinh"] != DBNull.Value)
                                datetime_ngaySinh.Value = Convert.ToDateTime(reader["NgaySinh"]);

                            tb_soDienThoai.Text = reader["soDienThoai"].ToString();
                            tb_diaChi.Text = reader["diaChi"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
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
            }catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
            
            
        }
    }
}
