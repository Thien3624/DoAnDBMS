using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrangChu());*/

                // Khởi tạo đối tượng NhanVien với thông tin mẫu
                NhanVien nv = new NhanVien(
                    maNhanVien: "1",  // Mã nhân viên kiểu int
                    cCCD: "123456789",  // CCCD kiểu string
                    hoVaTen: "Nguyen Van A",  // Họ và tên kiểu string
                    gioiTinh: "Nam",  // Giới tính kiểu string
                    ngaySinh: new DateTime(1990, 1, 1),  // Ngày sinh kiểu DateTime
                    soDienThoai: "0901234567",  // Số điện thoại kiểu string
                    diaChi: "123 Nguyen Trai, HCM"  // Địa chỉ kiểu string
                   /* trangThaiLamViec: "Dang Lam Viec"  // Trạng thái làm việc kiểu string*/
                );

                // Khởi tạo đối tượng NhanVienDAO để gọi phương thức themNV
                NhanVienDAO nvDao = new NhanVienDAO();

                try
                {
                    // Gọi phương thức themNV để thêm nhân viên vào cơ sở dữ liệu
                    nvDao.themNV(nv);
                    Console.WriteLine("Thêm nhân viên thành công!");
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi
                    Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }
    }
