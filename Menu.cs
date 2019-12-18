using System;
using System.Collections.Generic;
using System.Text;

namespace DKHP2711
{
    class Menu
    {
        public void xuatthongtinchoncuaadmin()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Bạn muốn chọn");
            Console.WriteLine("1_Quản Lý Giảng Viên: ");
            Console.WriteLine("2_Quản lý Sinh Viên: ");
            Console.WriteLine("-------------------------------------------");
        }
        public void xuatthongtinQuanlygiangvien()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Bạn muốn chọn");
            Console.WriteLine("1_Quản Lý Danh Sách Giảng Viên");
            Console.WriteLine("2_Thêm Giảng Viên ");
            Console.WriteLine("3_Xóa Giảng Viên ");
            Console.WriteLine("4_Sửa Thông Tin Giảng Viên");
            Console.WriteLine("5_Thông Tin Cá Nhân Giảng Viên");
            Console.WriteLine("-------------------------------------------");
        }
        public void xuatthongtinQuanlysinhvien()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Bạn muốn chọn");
            Console.WriteLine("1_Quản Lý Danh Sách Sinh Viên");
            Console.WriteLine("2_Thêm Sinh Viên ");
            Console.WriteLine("3_Xóa Sinh Viên ");
            Console.WriteLine("4_Sửa Thông Tin Sinh Viên");
            Console.WriteLine("5_Thông Tin Cá Nhân Sinh Viên");
            Console.WriteLine("-------------------------------------------");
        }
        public void xuatthongtin()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1.Sửa thông tin ");
            Console.WriteLine("2.Đăng kí học phần");
            //Console.WriteLine("3.Sửa môn học");
            //Console.WriteLine("4.Thông tin cá nhân");
            Console.WriteLine("3.Thời khóa biểu.");
            Console.WriteLine("-------------------------------------------");
        }
        public void SuaThongTin()
        {
            Console.WriteLine("--------------------------------:");
            Console.WriteLine("bạn hãy chọn số bạn muốn sữa ở dưới đây");
            Console.WriteLine("1.Chỉnh sửa Username: ");
            Console.WriteLine("2.Chỉnh sửa Họ Và Tên:");
            Console.WriteLine("3.chỉnh sửa MS:");
            Console.WriteLine("4.chỉnh sửa ID:");
            Console.WriteLine("5.chỉnh sửa Password:");
            Console.WriteLine("6.chỉnh sửa Giới Tính:");
            Console.WriteLine("7.chỉnh sửa Thuộc Khoa:");
            Console.WriteLine("8.chỉnh sửa Quê Quán:");
           
            Console.WriteLine("--------------------------------:");
        }
        
    }
}
