using System;
using System.Text;

namespace DKHP2711
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bạn muốn đăng nhập với tư cách nào:\n 1_Admin \n 2_Giang Vien \n 3_Sinh Vien ");
            HeThong hethong = new HeThong();
            var menu = new Menu();
            SinhVien sinhVien = new SinhVien();
            
            switch (Console.ReadLine())
            {
                case "1":
                    a:
                    if (hethong.Loginadadmin())
                    {
                        Console.WriteLine("bạn đăng nhập thành công");
                        menu.xuatthongtinchoncuaadmin();
                       
                        switch (Console.ReadLine())
                        {
                            case "1":
                                n:
                                menu.xuatthongtinQuanlygiangvien();
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        hethong.listgiangvien();
                                        Console.WriteLine("Nếu bạn muốn quay lại thì nhấn: số 1");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        string quaylaidanhsachgiangvien = Console.ReadLine();
                                        if(quaylaidanhsachgiangvien=="1")
                                        {
                                            goto n;
                                        }
                                        else
                                        break;
                                    case "2":
                                    t:
                                        hethong.themgiangvien();
                                        Console.WriteLine("---------------------------------------------------------");
                                        Console.WriteLine("Nếu bạn muốn quay lại thì nhấn: số 1");
                                        Console.WriteLine("Nếu bạn muốn thêm tiếp một giảng viên nữa thì nhấn: số 2");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        string quaylaithemgiangvien = Console.ReadLine();
                                        if(quaylaithemgiangvien=="1")
                                        {
                                            goto n;
                                        }
                                        else if (quaylaithemgiangvien=="2")
                                        {
                                            goto t;
                                        }
                                        break;
                                    case "3":
                                        u:
                                        
                                        Console.WriteLine("-------------------------------------------");
                                        Console.WriteLine("Nhập MSSV Của giảng Viên Mà Bạn Muốn Xóa:");
                                        string MSGV = Console.ReadLine();
                                        hethong.xoagv(MSGV);
                                        hethong.listgiangvien();
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("Bạn đã xóa giảng viên thành công:");
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("Nếu bạn muốn quay lại thì nhấn: số 1");
                                        Console.WriteLine("Nếu bạn muốn xóa tiếp một giảng viên nữa thì nhấn: số 2");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");

                                        string quaylaixoagiangvien = Console.ReadLine();
                                        if (quaylaixoagiangvien == "1")
                                        {
                                            goto n;
                                        }
                                        else if (quaylaixoagiangvien == "2")
                                        {
                                            goto u;
                                        }
                                        else
                                        break;
                                    case "4":
                                        hethong.suathongtingiangvien();
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("Nếu bạn muốn quay lại trang quản lý thì nhấn: số 1");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        string quaylaixuatquanlygiangvien = Console.ReadLine();
                                        if (quaylaixuatquanlygiangvien == "1")
                                        {
                                            goto n;
                                        }
                                        else
                                        break;
                                    case "5":
                                    qlttgv:
                                        hethong.thongtincanhangv();
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("bạn muốn xem thêm thông tin của giảng viên khác thì nhấn: số 1");
                                        Console.WriteLine("bạn muốn quay lại quan lý giảng viên thì nhấn: số 2");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        string quaylaixuatthongtingiangvien = Console.ReadLine();
                                        if (quaylaixuatthongtingiangvien == "1")
                                        {
                                            goto qlttgv;
                                        }
                                        else if (quaylaixuatthongtingiangvien == "2")
                                        {
                                            goto n;
                                        }
                                        else
                                            break;
                                       
                                    default: 
                                        break;
                                }
                                break;
                            case "2":
                                m:
                                menu.xuatthongtinQuanlysinhvien();
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        hethong.listsinhvien();
                                        Console.WriteLine("Nếu bạn muốn quay lại thì nhấn: số 1");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        string quaylaidanhsachsinhvien = Console.ReadLine();
                                        if (quaylaidanhsachsinhvien == "1")
                                        {
                                            goto m;
                                        }
                                        else
                                            break;
                                    case "2":
                                        p:
                                        hethong.themsinhvien();
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("Nếu bạn muốn quay lại thì nhấn: số 1");
                                        Console.WriteLine("Nếu bạn muốn thêm tiếp một sinh viên nữa thì nhấn: số 2");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        string quaylaithemsinhvien = Console.ReadLine();
                                        if (quaylaithemsinhvien == "1")
                                        {
                                            goto m;
                                        }
                                        else if (quaylaithemsinhvien == "2")
                                        {
                                            goto p;
                                        }
                                        break;
                                    case "3":
                                        o:
                                        Console.WriteLine("-------------------------------------------");
                                        Console.WriteLine("Nhập MSSV Của Sinh Viên Mà Bạn Muốn Xóa:");
                                        string MSSV=Console.ReadLine();
                                        hethong.xoasv(MSSV);
                                        hethong.listsinhvien();
                                        Console.WriteLine("Bạn đã xóa sinh viên thành công:");
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("Nếu bạn muốn quay lại thì nhấn: số 1");
                                        Console.WriteLine("Nếu bạn muốn xóa tiếp một sinh viên nữa thì nhấn: số 2");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        
                                        string quaylaixoasinhvien = Console.ReadLine();
                                        if (quaylaixoasinhvien == "1")
                                        {
                                            goto m;
                                        }
                                        else if (quaylaixoasinhvien == "2")
                                        {
                                            goto o;
                                        }
                                        else
                                        break;
                                    case "4":
                                        hethong.suathongtinsinhvien();
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("Nếu bạn muốn quay lại trang quản lý thì nhấn: số 1");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        string quaylaixuatquanlysinhvien = Console.ReadLine();
                                        if (quaylaixuatquanlysinhvien == "1")
                                        {
                                            goto m;
                                        }
                                        else
                                            break;
                                    case "5":
                                    qlttsv:
                                        hethong.thongtincanhansv();
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("bạn muốn xem thêm thông tin của sinh viên khác thì nhấn: số 1");
                                        Console.WriteLine("bạn muốn quay lại quan lý sinh viên thì nhấn: số 2");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        string quaylaixuatthongtinsinhvien = Console.ReadLine();
                                        if (quaylaixuatthongtinsinhvien == "1")
                                        {
                                            goto qlttsv;
                                        }
                                        else if (quaylaixuatthongtinsinhvien == "2")
                                        {
                                            goto m;
                                        }
                                        else
                                            break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("sai!.Mời bạn nhập lại");
                        goto a;
                    }
                    break;
                case "2":
                    b:
                    if(hethong.Logingiangvien())
                    {
                        gv: 
                        Console.WriteLine("bạn đã vô được hệ thống của giảng viên:");
                        Console.WriteLine("sửa thông tin cá nhân số 1");
                        Console.WriteLine("quản lí sinh viên số 2");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("nhập lại MSGV lần nữa");
                                string MSGV = Console.ReadLine();
                                suathongtingv:
                                hethong.suathongtingiangviencuaminh(MSGV);
                                Console.WriteLine("bạn muốn quay lại thì nhấn số 1:\n nếu bạn muốn sữa thông tin nữa thì nhấn số 2:\n không thì nhấn phím còn lại");
                                string quaylailucdangnhapcuagiangvien = Console.ReadLine();
                                if (quaylailucdangnhapcuagiangvien == "1")
                                {
                                    goto gv;
                                }
                                else if(quaylailucdangnhapcuagiangvien == "2")
                                {
                                    goto suathongtingv;
                                }
                                else
                                    break;
                            case "2":
                            mm:
                                menu.xuatthongtinQuanlysinhvien();
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        hethong.listsinhvien();
                                        Console.WriteLine("Nếu bạn muốn quay lại thì nhấn: số 1");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        string quaylaidanhsachsinhvien = Console.ReadLine();
                                        if (quaylaidanhsachsinhvien == "1")
                                        {
                                            goto mm;
                                        }
                                        else
                                            break;
                                    case "2":
                                    pp:
                                        hethong.themsinhvien();
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("Nếu bạn muốn quay lại thì nhấn: số 1");
                                        Console.WriteLine("Nếu bạn muốn thêm tiếp một sinh viên nữa thì nhấn: số 2");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        string quaylaithemsinhvien = Console.ReadLine();
                                        if (quaylaithemsinhvien == "1")
                                        {
                                            goto mm;
                                        }
                                        else if (quaylaithemsinhvien == "2")
                                        {
                                            goto pp;
                                        }
                                        break;
                                    case "3":
                                    oo:
                                        Console.WriteLine("-------------------------------------------");
                                        Console.WriteLine("Nhập MSSV Của Sinh Viên Mà Bạn Muốn Xóa:");
                                        string MSSV = Console.ReadLine();
                                        hethong.xoasv(MSSV);
                                        hethong.listsinhvien();
                                        Console.WriteLine("Bạn đã xóa sinh viên thành công:");
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("Nếu bạn muốn quay lại thì nhấn: số 1");
                                        Console.WriteLine("Nếu bạn muốn xóa tiếp một sinh viên nữa thì nhấn: số 2");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");

                                        string quaylaixoasinhvien = Console.ReadLine();
                                        if (quaylaixoasinhvien == "1")
                                        {
                                            goto mm;
                                        }
                                        else if (quaylaixoasinhvien == "2")
                                        {
                                            goto oo;
                                        }
                                        else
                                            break;
                                    case "4":
                                        hethong.suathongtinsinhvien();
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("Nếu bạn muốn quay lại trang quản lý thì nhấn: số 1");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        string quaylaixuatquanlysinhvien = Console.ReadLine();
                                        if (quaylaixuatquanlysinhvien == "1")
                                        {
                                            goto mm;
                                        }
                                        else
                                            break;
                                    case "5":
                                    qlttsvv:
                                        hethong.thongtincanhansv();
                                        Console.WriteLine("----------------------------------------------------------");
                                        Console.WriteLine("bạn muốn xem thêm thông tin của sinh viên khác thì nhấn: số 1");
                                        Console.WriteLine("bạn muốn quay lại quan lý sinh viên thì nhấn: số 2");
                                        Console.WriteLine("Kết thúc: Kí tự bất kì");
                                        Console.WriteLine("----------------------------------------------------------");
                                        string quaylaixuatthongtinsinhvien = Console.ReadLine();
                                        if (quaylaixuatthongtinsinhvien == "1")
                                        {
                                            goto qlttsvv;
                                        }
                                        else if (quaylaixuatthongtinsinhvien == "2")
                                        {
                                            goto mm;
                                        }
                                        else
                                            break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("sai!.Mời bạn nhập lại");
                        goto b;
                    }
                    break;
                case "3":
                    c:
                    if(hethong.Loginsinhvien())
                    {
                        Console.WriteLine("Bạn đã đăng nhập thành công:");
                        huax:
                        menu.xuatthongtin();
                        Console.WriteLine("bạn hãy nhấn số bạn muốn thực hiện");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("nhập lại MSSV lần nữa");
                                string MSSV = Console.ReadLine();
                                hethong.suathongtinsinhviencuaminh(MSSV);
                                break;
                            case "2":
                                mmm:
                                hethong.lismonhoc();
                                hethong.DKHP();
                                
                                Console.WriteLine("nếu bạn muốn quay lại thì nhấn số 1:");
                                Console.WriteLine("nếu bạn muốn đăng kí thêm thì nhấn số 2:");
                                string quaylaidkhpsinhvien = Console.ReadLine();
                                if ( quaylaidkhpsinhvien == "1")
                                {
                                    goto huax;
                                }
                                else if (quaylaidkhpsinhvien == "2")
                                {
                                    goto mmm;
                                }
                                else
                                    break;
                            case "3":
                              
                                hethong.xuatTKB();
                                break;
                            default:
                                break;
                        }

                    }
                    else 
                    {
                        Console.WriteLine("sai!. Mời bạn nhập lại ");
                        goto c;
                    }
                    break;


            }
        }

    }
}
