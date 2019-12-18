using System;
using System.Collections.Generic;
using System.Text;


namespace DKHP2711
{
    public class HeThong : Admin
    {
        Admin admin = new Admin() { ID_Admin = "1234", Pass_Admin = "1234" };

        Menu menu = new Menu();
        List<SinhVien> sinhviens;
        List<GiangVien> giangviens;
        List<MonHoc> monHocs;
        SinhVien sinh = new SinhVien(); 
        public HeThong()
        {
            sinhviens = new List<SinhVien>()
            {
                new SinhVien()
                {
                    Username = "Tổng",
                    Password="1111",
                    MSSV="19429861",
                    Id="19429861",
                    HoTen="Tăng Công Tổng",
                    GioiTinh="Nam",
                    QueQuan="Quang Nam",
                    khoa="Công Nghệ Thông Tin",

                },
                new SinhVien()
                {
                    Username = "A",
                    Password="1111",
                    MSSV="123",
                    Id="123",
                    HoTen="Nguyễn Văn A",
                    GioiTinh="Nam",
                    QueQuan="Quản Trị",
                    khoa="Công Nghệ Thông Tin"

                },
                new SinhVien()
                {
                    Username = "B",
                    Password="1111",
                    MSSV="456",
                    Id="456",
                    HoTen="Nguyễn Văn B",
                    GioiTinh="Nữ",
                    QueQuan="Huế",
                    khoa="Công Nghệ Thông Tin"

                },
                new SinhVien()
                {
                    Username = "C",
                    Password="1111",
                    MSSV="789",
                    Id="789",
                    HoTen="Nguyễn Văn C",
                    GioiTinh="Nam",
                    QueQuan="Đà Lạt",
                    khoa="Công Nghệ Thông Tin"
                },
                new SinhVien()
                {
                    Username = "D",
                    Password="1111",
                    MSSV="789789",
                    Id="789789",
                    HoTen="Nguyễn Văn D",
                    GioiTinh="Nam",
                    QueQuan="Đà Lạt",
                    khoa="Du Lịch Và Lữ Hành"
                },
                 new SinhVien()
                {
                    Username = "E",
                    Password="1111",
                    MSSV="456789",
                    Id="456789",
                    HoTen="Nguyễn Văn E",
                    GioiTinh="Nữ",
                    QueQuan="Phú Yên",
                    khoa="Kế Toán Kiểm Toán"
                },
                  new SinhVien()
                {
                    Username = "H",
                    Password="1111",
                    MSSV="123789789",
                    Id="123789789",
                    HoTen="Nguyễn Văn H",
                    GioiTinh="Nam",
                    QueQuan="Hải Phòng",
                    khoa="Du Lịch Và Lữ Hành"
                },
                   new SinhVien()
                {
                    Username = "G",
                    Password="1111",
                    MSSV="789456789",
                    Id="789456789",
                    HoTen="Nguyễn Văn G",
                    GioiTinh="Nam",
                    QueQuan="Long An",
                    khoa="Kế Toán Kiểm Toán"
                },
            };
            giangviens = new List<GiangVien>()
            {
                new GiangVien()
                {
                    Username = "Hà",
                    Password="2222",
                    MSGV="12345",
                    Id="12345",
                    HoTen="Tạ Hồng Hà",
                    GioiTinh="Nam",
                    QueQuan="Sài Gòn",
                    Khoa="AAA",
                    MonDay="Giáo Dục Thể Chất"
                },
                new GiangVien()
                {
                    Username = "Dung",
                    Password="2222",
                    MSGV="123456",
                    Id="123456",
                    HoTen="Nguyễn Ngọc Dung",
                    GioiTinh="NỮ",
                    QueQuan="Sài Gòn",
                    Khoa="BBB",
                    MonDay="Nhập Môn Tin Học"

                },
                new GiangVien()
                {
                    Username = "Anh",
                    Password="2222",
                    MSGV="1234567",
                    Id="1234567",
                    HoTen="Phạm Ngọc Anh",
                    GioiTinh="Nam",
                    QueQuan="Quảng Trị",
                    Khoa="AAA",
                    MonDay="Giáo Dục Quốc Phòng Và An Ninh"

                },
                new GiangVien()
                {
                    Username = "Hoàng",
                    Password="2222",
                    MSGV="123456789",
                    Id="123456789",
                    HoTen="Nguyễn Lâm Thanh Hoàng",
                    GioiTinh="Nam",
                    QueQuan="Hải Phòng",
                    Khoa="DDD",
                    MonDay="Những Nguyên Lý Cơ Bản Về Chủ Nghĩa Mác-LêNin"
                }
            };
            monHocs = new List<MonHoc>()
            {
                new MonHoc()
                {
                    TenMonHOC="Những Nguyên Lý Cơ Bản Về Chủ Nghĩa Mác-LêNin",
                    MaMonHoc="9999",
                    TietHoc="1-3",
                    NgayThu="thứ 5",
                    PhongHoc="v8.5",
                    GiangVien="Nguyễn Lâm Thanh Hoàng"

                },
                new MonHoc()
                {
                    TenMonHOC="Những Nguyên Lý Cơ Bản Về Chủ Nghĩa Mác-LêNin",
                    MaMonHoc="8888",
                    TietHoc="1-3",
                    NgayThu="thứ 6",
                    PhongHoc="v8.6",
                    GiangVien="Nguyễn Lâm Thanh Hoàng"

                },

                new MonHoc()
                {
                    TenMonHOC="Giáo Dục Quốc Phòng Và An Ninh",
                    MaMonHoc="7777",
                    TietHoc="1-5",
                    NgayThu="thứ 2",
                    PhongHoc="Nhà thiếu nhi quận gò gấp",
                    GiangVien="Phạm Ngọc Anh"

                },
                new MonHoc()
                {
                    TenMonHOC="Giáo Dục Quốc Phòng Và An Ninh",
                    MaMonHoc="6666",
                    TietHoc="1-5",
                    NgayThu="thứ 4",
                    PhongHoc="Nhà thiếu nhi quận gò gấp",
                    GiangVien="Phạm Ngọc Anh"

                },
                
                
            };
        }

        public bool Loginadadmin()
        {
            Console.WriteLine("Mời bạn nhập tài khoản admin: ");
            string TK = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập mật khẩu admin: ");
            string MK = Console.ReadLine();
            if (login(admin.ID_Admin, admin.Pass_Admin, TK, MK))
            {
                return true;
            }
            return false;
        }
        public bool Loginsinhvien()
        {
            Console.WriteLine("Mời bạn nhập tài khoản sinh viên: ");
            string TK = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập mật khẩu sinh viên: ");
            string MK = Console.ReadLine();
            foreach (var item in sinhviens)
            {
                if (login(item.MSSV, item.Password, TK, MK))
                    return true;
            }
            return false;

        }

        public bool Logingiangvien()
        {
            Console.WriteLine("Mời bạn nhập tài khoản giảng viên ");
            string TK = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập mật khẩu giảng viên ");
            string Mk = Console.ReadLine();
            foreach (var gv in giangviens)
            {
                if (login(gv.MSGV, gv.Password, TK, Mk))
                    return true;
            }
            return false;
        }
        public void listgiangvien()
        {
            for (int i = 0; i < giangviens.Count; i++)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Username: {giangviens[i].Username}");
                Console.WriteLine($"Họ và Tên: {giangviens[i].HoTen}");
                Console.WriteLine($"MSGV: {giangviens[i].MSGV}");
                Console.WriteLine($"Id: {giangviens[i].Id}");
                Console.WriteLine($"Password: {giangviens[i].Password}");
                Console.WriteLine($"Giới Tính: {giangviens[i].GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {giangviens[i].Khoa}");
                Console.WriteLine($"Quê Quán: {giangviens[i].QueQuan}");
                Console.WriteLine($"Môn Dạy:{giangviens[i].MonDay}");
            }
        }
        public void listsinhvien()
        {
            for (int i = 0; i < sinhviens.Count; i++)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Username: {sinhviens[i].Username}");
                Console.WriteLine($"Họ và Tên: {sinhviens[i].HoTen}");
                Console.WriteLine($"MSSV: {sinhviens[i].MSSV}");
                Console.WriteLine($"Id: {sinhviens[i].Id}");
                Console.WriteLine($"Password: {sinhviens[i].Password}");
                Console.WriteLine($"Giới Tính: {sinhviens[i].GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {sinhviens[i].khoa}");
                Console.WriteLine($"Quê Quán: {sinhviens[i].QueQuan}");
            }
        }
        public void themgiangvien()
        {
        themgv:
            GiangVien themgiangvien = new GiangVien();
            Console.Write("Nhập Username: ");
            themgiangvien.Username = Console.ReadLine();
            Console.WriteLine("Nhập Họ và Tên: ");
            themgiangvien.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập MSGV: ");
            themgiangvien.MSGV = Console.ReadLine();
            Console.WriteLine("NHập Id: ");
            themgiangvien.Id = Console.ReadLine();
            Console.WriteLine("Nhập password: ");
            themgiangvien.Password = Console.ReadLine();
            Console.WriteLine("Nhập Giới Tính: ");
            themgiangvien.GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập KHoa: ");
            themgiangvien.Khoa = Console.ReadLine();
            Console.WriteLine("Nhập Quê Quán: ");
            themgiangvien.QueQuan = Console.ReadLine();
            Console.WriteLine("nhập môn dạy: ");
            themgiangvien.MonDay = Console.ReadLine();
            if (this.giangviens.Find(gv => gv.MSGV == themgiangvien.MSGV) != null)
            {
                Console.WriteLine("Giảng Viên Này Đã Tồn Tại!");
                Console.WriteLine("Bạn Hãy Nhập Lại Thông Tin Sinh Viên Mà Bạn Cần Thêm:");
                goto themgv;
            }
            else
            {
                this.giangviens.Add(themgiangvien);
                Console.WriteLine("Bạn Đã Thêm Giảng Viên Thành Công!");
                Console.WriteLine("----Danh Sách Giảng Viên Sau khi Thêm----");
                this.listgiangvien();
            }
        }
        public void themsinhvien()
        {
        themsv:
            SinhVien themsinhvien = new SinhVien();
            Console.Write("Nhập Username: ");
            themsinhvien.Username = Console.ReadLine();
            Console.WriteLine("Nhập Họ và Tên: ");
            themsinhvien.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập MSGV: ");
            themsinhvien.MSSV = Console.ReadLine();
            Console.WriteLine("NHập Id: ");
            themsinhvien.Id = Console.ReadLine();
            Console.WriteLine("Nhập password: ");
            themsinhvien.Password = Console.ReadLine();
            Console.WriteLine("Nhập Giới Tính: ");
            themsinhvien.GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập KHoa: ");
            themsinhvien.khoa = Console.ReadLine();
            Console.WriteLine("Nhập Quê Quán: ");
            themsinhvien.QueQuan = Console.ReadLine();
            if (this.sinhviens.Find(sv => sv.MSSV == themsinhvien.MSSV) != null)
            {
                Console.WriteLine("Sinh Viên Này Đã Tồn Tại!");
                Console.WriteLine("Bạn Hãy Nhập Lại Sinh Viên Mà Bạn Cần Thêm:");
                goto themsv;
            }
            else
            {
                this.sinhviens.Add(themsinhvien);
                Console.WriteLine("Bạn Đã Thêm Sinh Viên Thành Công!");
                Console.WriteLine("----Danh Sách Sau Khi Thêm----");
                this.listsinhvien();
            }
        }
        public void xoasv(string MSSV)
        {
        j:
            if (kiemTraTonTaiSV(MSSV))
            {

                foreach (var item in sinhviens)
                    if (item.MSSV.Equals(MSSV))
                    {
                        sinhviens.Remove(item);
                        break;
                    }
            }
            else
            {
                Console.WriteLine("Không tồn tại sinh viên này!");
                Console.WriteLine("bạn nhập lại MSSV");
                MSSV = Console.ReadLine();
                goto j;
            }
        }
        private bool kiemTraTonTaiSV(string MSSV)
        {
            foreach (var item in sinhviens)
                if (item.MSSV.Equals(MSSV))
                    return true;
            return false;
        }



        public void xoagv(string MSGV)
        {
        jh:
            if (kiemTraTonTaiGV(MSGV))
            {

                foreach (var item in giangviens)
                    if (item.MSGV.Equals(MSGV))
                    {
                        giangviens.Remove(item);
                        break;
                    }
            }
            else
            {
                Console.WriteLine("Không tồn tại giảng viên này!");
                Console.WriteLine("bạn nhập lại MSGV");
                MSGV = Console.ReadLine();
                goto jh;
            }

        }

        private bool kiemTraTonTaiGV(string MSGV)
        {
            foreach (var item in giangviens)
                if (item.MSGV.Equals(MSGV))
                    return true;
            return false;
        }



        public void suathongtingiangvien()
        {
        themgvkhac:
        quaylaisaiMSGV:
            Console.WriteLine("Bạn hãy nhập MSGV của giảng viên mà bạn muốn sữa thông tin!");
            string MSGV = Console.ReadLine();
            //Console.WriteLine(MSGV);
            GiangVien giangVien = new GiangVien();

            foreach (var item in giangviens)
            {

                if (item.MSGV == MSGV)
                {

                    giangVien = item;
                }
            }

            if (giangVien.MSGV != null)
            {
                //Console.WriteLine(item.MSGV == MSGV);
                //Console.WriteLine("Vao if");
                Console.WriteLine($"Username: {giangVien.Username}");
                Console.WriteLine($"Họ và Tên: {giangVien.HoTen}");
                Console.WriteLine($"MSGV: {giangVien.MSGV}");
                Console.WriteLine($"Id: {giangVien.Id}");
                Console.WriteLine($"Password: {giangVien.Password}");
                Console.WriteLine($"Giới Tính: {giangVien.GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {giangVien.Khoa}");
                Console.WriteLine($"Quê Quán: {giangVien.QueQuan}");
                Console.WriteLine($"môn dạy: {giangVien.MonDay}");
                Console.WriteLine("--------------------------------------------");
            tgv:
                menu.SuaThongTin();
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("nhập Username cần chỉnh sửa");
                        giangVien.Username = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien1 = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien1 == "1")
                        {
                            goto tgv;
                        }
                        else
                            break;
                    case "2":
                        Console.WriteLine("nhập họ và tên cần chỉnh sửa");
                        giangVien.HoTen = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien2 = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien2 == "1")
                        {
                            goto tgv;
                        }
                        else
                            break;
                    case "3":
                        Console.WriteLine("nhập MSGV cần chỉnh sửa");
                        giangVien.MSGV = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien3 = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien3 == "1")
                        {
                            goto tgv;
                        }
                        else
                            break;
                    case "4":
                        Console.WriteLine("nhập ID cần chỉnh sửa");
                        giangVien.Id = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien4 = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien4 == "1")
                        {
                            goto tgv;
                        }
                        else
                            break;
                    case "5":
                        Console.WriteLine("nhập Password cần chỉnh sửa");
                        giangVien.Password = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien5 = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien5 == "1")
                        {
                            goto tgv;
                        }
                        else
                            break;
                    case "6":
                        Console.WriteLine("nhập giới tính cần chỉnh sửa");
                        giangVien.GioiTinh = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien6 = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien6 == "1")
                        {
                            goto tgv;
                        }
                        else
                            break;
                    case "7":
                        Console.WriteLine("nhập thuộc khoa cần chỉnh sửa");
                        giangVien.Khoa = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien7 = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien7 == "1")
                        {
                            goto tgv;
                        }
                        else
                            break;
                    case "8":
                        Console.WriteLine("nhập quê quán cần chỉnh sửa");
                        giangVien.QueQuan = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa lại thông đã nhập không:");
                        Console.WriteLine("sửa lại nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien8 = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien8 == "1")
                        {
                            goto tgv;
                        }
                        else
                            break;
                    case "9":
                        Console.WriteLine("nhập môn cần chỉnh sửa");
                        giangVien.MonDay = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa lại thông đã nhập không:");
                        Console.WriteLine("sửa lại nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien9 = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien9 == "1")
                        {
                            goto tgv;
                        }
                        else
                            break;
                    default:
                        break;

                }
                Console.WriteLine("bạn đã sửa thông tin của giảng viên đã thành công");
                Console.WriteLine($"Username: {giangVien.Username}");
                Console.WriteLine($"Họ và Tên: {giangVien.HoTen}");
                Console.WriteLine($"MSGV: {giangVien.MSGV}");
                Console.WriteLine($"Id: {giangVien.Id}");
                Console.WriteLine($"Password: {giangVien.Password}");
                Console.WriteLine($"Giới Tính: {giangVien.GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {giangVien.Khoa}");
                Console.WriteLine($"Quê Quán: {giangVien.QueQuan}");
                Console.WriteLine($"môn dạy: {giangVien.MonDay}");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("bạn muốn sửa thông tin của giảng viên nào nữa không?");
                Console.WriteLine("còn thì nhấp số 1");
                Console.WriteLine("không thì nhấn phím còn lại");
                string quaylaisuathemgvkhac = Console.ReadLine();
                if (quaylaisuathemgvkhac == "1")
                {
                    goto themgvkhac;
                }
            }

            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("bạn đã nhập sai MSGV");
                Console.WriteLine("bạn có muốn nhập lại MSGV không");
                Console.WriteLine("còn thì nhấn số 1");
                Console.WriteLine("không thì nhấn một phím bất kì");
                Console.WriteLine("--------------------------------------");
                string quaylainhapMSGV = Console.ReadLine();
                if (quaylainhapMSGV == "1")
                {
                    goto quaylaisaiMSGV;
                }
                else
                {
                    return;
                }
            }
        }



        public void suathongtinsinhvien()
        {
        themsvkhac:
        quaylaisaiMSSV:
            Console.WriteLine("Bạn hãy nhập MSGV của sinh viên mà bạn muốn sữa thông tin!");
            string MSSV = Console.ReadLine();
            //Console.WriteLine(MSSV);
            SinhVien sinhVien = new SinhVien();

            foreach (var item in sinhviens)
            {

                if (item.MSSV == MSSV)
                {

                    sinhVien = item;
                }
            }

            if (sinhVien.MSSV != null)
            {
                //Console.WriteLine(item.MSGV == MSGV);
                //Console.WriteLine("Vao if");
                Console.WriteLine($"Username: {sinhVien.Username}");
                Console.WriteLine($"Họ và Tên: {sinhVien.HoTen}");
                Console.WriteLine($"MSSV: {sinhVien.MSSV}");
                Console.WriteLine($"Id: {sinhVien.Id}");
                Console.WriteLine($"Password: {sinhVien.Password}");
                Console.WriteLine($"Giới Tính: {sinhVien.GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {sinhVien.khoa}");
                Console.WriteLine($"Quê Quán: {sinhVien.QueQuan}");
                Console.WriteLine("--------------------------------------------");
            tsv:
                menu.SuaThongTin();
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("nhập Username cần chỉnh sửa");
                        sinhVien.Username = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien1 = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien1 == "1")
                        {
                            goto tsv;
                        }
                        else
                            break;
                    case "2":
                        Console.WriteLine("nhập họ và tên cần chỉnh sửa");
                        sinhVien.HoTen = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien2 = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien2 == "1")
                        {
                            goto tsv;
                        }
                        else
                            break;
                    case "3":
                        Console.WriteLine("nhập MSSV cần chỉnh sửa");
                        sinhVien.MSSV = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien3 = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien3 == "1")
                        {
                            goto tsv;
                        }
                        else
                            break;
                    case "4":
                        Console.WriteLine("nhập ID cần chỉnh sửa");
                        sinhVien.Id = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien4 = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien4 == "1")
                        {
                            goto tsv;
                        }
                        else
                            break;
                    case "5":
                        Console.WriteLine("nhập Password cần chỉnh sửa");
                        sinhVien.Password = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien5 = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien5 == "1")
                        {
                            goto tsv;
                        }
                        else
                            break;
                    case "6":
                        Console.WriteLine("nhập giới tính cần chỉnh sửa");
                        sinhVien.GioiTinh = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien6 = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien6 == "1")
                        {
                            goto tsv;
                        }
                        else
                            break;
                    case "7":
                        Console.WriteLine("nhập thuộc khoa cần chỉnh sửa");
                        sinhVien.khoa = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien7 = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien7 == "1")
                        {
                            goto tsv;
                        }
                        else
                            break;
                    case "8":
                        Console.WriteLine("nhập quê quán cần chỉnh sửa");
                        sinhVien.QueQuan = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa lại thông đã nhập không:");
                        Console.WriteLine("sửa lại nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien8 = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien8 == "1")
                        {
                            goto tsv;
                        }
                        else
                            break;
                    default:
                        break;

                }
                Console.WriteLine("bạn đã sửa thông tin của sinh viên đã thành công");
                Console.WriteLine($"Username: {sinhVien.Username}");
                Console.WriteLine($"Họ và Tên: {sinhVien.HoTen}");
                Console.WriteLine($"MSGV: {sinhVien.MSSV}");
                Console.WriteLine($"Id: {sinhVien.Id}");
                Console.WriteLine($"Password: {sinhVien.Password}");
                Console.WriteLine($"Giới Tính: {sinhVien.GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {sinhVien.khoa}");
                Console.WriteLine($"Quê Quán: {sinhVien.QueQuan}");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("bạn muốn sửa thông tin của sinh viên nào nữa không?");
                Console.WriteLine("còn thì nhấp số 1");
                Console.WriteLine("không thì nhấn phím còn lại");
                string quaylaisuathemsvkhac = Console.ReadLine();
                if (quaylaisuathemsvkhac == "1")
                {
                    goto themsvkhac;
                }
            }

            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("bạn đã nhập sai MSSV");
                Console.WriteLine("bạn có muốn nhập lại MSSV không");
                Console.WriteLine("còn thì nhấn số 1");
                Console.WriteLine("không thì nhấn một phím bất kì");
                Console.WriteLine("--------------------------------------");
                string quaylainhapMSSV = Console.ReadLine();
                if (quaylainhapMSSV == "1")
                {
                    goto quaylaisaiMSSV;
                }
                else
                {
                    return;
                }
            }
        }
        public void thongtincanhangv()
        {
        jk:
            Console.WriteLine("Bạn hãy nhập MSGV !");
            string MSGV = Console.ReadLine();

            if (kiemTraTonTaiGV(MSGV))
            {

                foreach (var item in giangviens)
                    if (item.MSGV.Equals(MSGV))
                    {
                        Console.WriteLine($"Username: {item.Username}");
                        Console.WriteLine($"Họ và Tên: {item.HoTen}");
                        Console.WriteLine($"MSGV: {item.MSGV}");
                        Console.WriteLine($"Id: {item.Id}");
                        Console.WriteLine($"Password: {item.Password}");
                        Console.WriteLine($"Giới Tính: {item.GioiTinh}");
                        Console.WriteLine($"Thuộc Khoa: {item.Khoa}");
                        Console.WriteLine($"Quê Quán: {item.QueQuan}");
                        Console.WriteLine($"môn dạy: {item.MonDay}");
                        Console.WriteLine("--------------------------------------------");
                        break;
                    }
            }
            else
            {
                Console.WriteLine("Không tồn tại giảng viên này!");

                goto jk;
            }
        }
        public void thongtincanhansv()
        {
        jkh:
            Console.WriteLine("Bạn hãy nhập MSSV !");
            string MSSV = Console.ReadLine();

            if (kiemTraTonTaiSV(MSSV))
            {

                foreach (var item in sinhviens)
                    if (item.MSSV.Equals(MSSV))
                    {
                        Console.WriteLine($"Username: {item.Username}");
                        Console.WriteLine($"Họ và Tên: {item.HoTen}");
                        Console.WriteLine($"MSGV: {item.MSSV}");
                        Console.WriteLine($"Id: {item.Id}");
                        Console.WriteLine($"Password: {item.Password}");
                        Console.WriteLine($"Giới Tính: {item.GioiTinh}");
                        Console.WriteLine($"Thuộc Khoa: {item.khoa}");
                        Console.WriteLine($"Quê Quán: {item.QueQuan}");
                        Console.WriteLine("--------------------------------------------");
                        break;
                    }
            }
            else
            {
                Console.WriteLine("Không tồn tại sinh viên này!");

                goto jkh;
            }
        }
        public void suathongtingiangviencuaminh(string MSGV)
        {
            GiangVien giangVien = new GiangVien();

            foreach (var item in giangviens)
            {

                if (item.MSGV == MSGV)
                {

                    giangVien = item;
                }
            }

            if (giangVien.MSGV != null)
            {
                //Console.WriteLine(item.MSGV == MSGV);
                //Console.WriteLine("Vao if");
                Console.WriteLine($"Username: {giangVien.Username}");
                Console.WriteLine($"Họ và Tên: {giangVien.HoTen}");
                Console.WriteLine($"MSGV: {giangVien.MSGV}");
                Console.WriteLine($"Id: {giangVien.Id}");
                Console.WriteLine($"Password: {giangVien.Password}");
                Console.WriteLine($"Giới Tính: {giangVien.GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {giangVien.Khoa}");
                Console.WriteLine($"Quê Quán: {giangVien.QueQuan}");
                Console.WriteLine($"môn dạy: (không được sửa:) {giangVien.MonDay}");
                Console.WriteLine("--------------------------------------------");
            tgvcm:
                menu.SuaThongTin();
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("nhập Username cần chỉnh sửa");
                        giangVien.Username = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien1cm = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien1cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "2":
                        Console.WriteLine("nhập họ và tên cần chỉnh sửa");
                        giangVien.HoTen = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien2cm = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien2cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "3":
                        Console.WriteLine("nhập MSGV cần chỉnh sửa");
                        giangVien.MSGV = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien3cm = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien3cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "4":
                        Console.WriteLine("nhập ID cần chỉnh sửa");
                        giangVien.Id = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien4cm = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien4cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "5":
                        Console.WriteLine("nhập Password cần chỉnh sửa");
                        giangVien.Password = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien5cm = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien5cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "6":
                        Console.WriteLine("nhập giới tính cần chỉnh sửa");
                        giangVien.GioiTinh = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien6cm = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien6cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "7":
                        Console.WriteLine("nhập thuộc khoa cần chỉnh sửa");
                        giangVien.Khoa = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien7cm = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien7cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "8":
                        Console.WriteLine("nhập quê quán cần chỉnh sửa");
                        giangVien.QueQuan = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa lại thông đã nhập không:");
                        Console.WriteLine("sửa lại nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtingiangvien8cm = Console.ReadLine();
                        if (quaylaisuatiepthongtingiangvien8cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    //case "9":
                    //    console.writeline("nhập môn cần chỉnh sửa");
                    //    giangvien.monday = console.readline();
                    //    console.writeline("bạn còn muốn sửa lại thông đã nhập không:");
                    //    console.writeline("sửa lại nhấp số 1:");
                    //    console.writeline("không thì nhấn các phím còn lại:");
                    //    string quaylaisuatiepthongtingiangvien9cm = console.readline();
                    //    if (quaylaisuatiepthongtingiangvien9cm == "1")
                    //    {
                    //        goto tgvcm;
                    //    }
                    //    else
                    //        break;
                    default:
                        break;

                }
                Console.WriteLine("bạn đã sửa thông tin của giảng viên đã thành công");
                Console.WriteLine($"Username: {giangVien.Username}");
                Console.WriteLine($"Họ và Tên: {giangVien.HoTen}");
                Console.WriteLine($"MSGV: {giangVien.MSGV}");
                Console.WriteLine($"Id: {giangVien.Id}");
                Console.WriteLine($"Password: {giangVien.Password}");
                Console.WriteLine($"Giới Tính: {giangVien.GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {giangVien.Khoa}");
                Console.WriteLine($"Quê Quán: {giangVien.QueQuan}");
                Console.WriteLine($"môn dạy: {giangVien.MonDay}");
                Console.WriteLine("--------------------------------------------");
            }


        }

        public void thongtincanhangvcuaminh()
        {

            Console.WriteLine("Mời bạn nhập lại tài khoản giảng viên ");
            string TK = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập lại mật khẩu giảng viên ");
            string Mk = Console.ReadLine();
            foreach (var gv in giangviens)
            {
                if (login(gv.MSGV, gv.Password, TK, Mk))
                {
                    Console.WriteLine($"Username: {gv.Username}");
                    Console.WriteLine($"Họ và Tên: {gv.HoTen}");
                    Console.WriteLine($"MSGV: {gv.MSGV}");
                    Console.WriteLine($"Id: {gv.Id}");
                    Console.WriteLine($"Password: {gv.Password}");
                    Console.WriteLine($"Giới Tính: {gv.GioiTinh}");
                    Console.WriteLine($"Thuộc Khoa: {gv.Khoa}");
                    Console.WriteLine($"Quê Quán: {gv.QueQuan}");
                    Console.WriteLine($"môn dạy: {gv.MonDay}");
                    Console.WriteLine("--------------------------------------------");
                    break;
                }

            }

        }
        public void suathongtinsinhviencuaminh(string MSSV)
        {
            SinhVien sinhVien = new SinhVien();

            foreach (var item in sinhviens)
            {

                if (item.MSSV == MSSV)
                {

                    sinhVien = item;
                }
            }

            if (sinhVien.MSSV != null)
            {
                //Console.WriteLine(item.MSGV == MSGV);
                //Console.WriteLine("Vao if");
                Console.WriteLine($"Username: {sinhVien.Username}");
                Console.WriteLine($"Họ và Tên: {sinhVien.HoTen}");
                Console.WriteLine($"MSGV: {sinhVien.MSSV}");
                Console.WriteLine($"Id: {sinhVien.Id}");
                Console.WriteLine($"Password: {sinhVien.Password}");
                Console.WriteLine($"Giới Tính: {sinhVien.GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {sinhVien.khoa}");
                Console.WriteLine($"Quê Quán: {sinhVien.QueQuan}");

                Console.WriteLine("--------------------------------------------");
            tgvcm:
                menu.SuaThongTin();
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("nhập Username cần chỉnh sửa");
                        sinhVien.Username = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien1cm = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien1cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "2":
                        Console.WriteLine("nhập họ và tên cần chỉnh sửa");
                        sinhVien.HoTen = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien2cm = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien2cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "3":
                        Console.WriteLine("nhập MSSV cần chỉnh sửa");
                        sinhVien.MSSV = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien3cm = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien3cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "4":
                        Console.WriteLine("nhập ID cần chỉnh sửa");
                        sinhVien.Id = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien4cm = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien4cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "5":
                        Console.WriteLine("nhập Password cần chỉnh sửa");
                        sinhVien.Password = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien5cm = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien5cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "6":
                        Console.WriteLine("nhập giới tính cần chỉnh sửa");
                        sinhVien.GioiTinh = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien6cm = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien6cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "7":
                        Console.WriteLine("nhập thuộc khoa cần chỉnh sửa");
                        sinhVien.khoa = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa thêm nữa không:");
                        Console.WriteLine("sửa tiếp nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien7cm = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien7cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    case "8":
                        Console.WriteLine("nhập quê quán cần chỉnh sửa");
                        sinhVien.QueQuan = Console.ReadLine();
                        Console.WriteLine("bạn còn muốn sửa lại thông đã nhập không:");
                        Console.WriteLine("sửa lại nhấp số 1:");
                        Console.WriteLine("không thì nhấn các phím còn lại:");
                        string quaylaisuatiepthongtinsinhvien8cm = Console.ReadLine();
                        if (quaylaisuatiepthongtinsinhvien8cm == "1")
                        {
                            goto tgvcm;
                        }
                        else
                            break;
                    //case "9":
                    //    console.writeline("nhập môn cần chỉnh sửa");
                    //    giangvien.monday = console.readline();
                    //    console.writeline("bạn còn muốn sửa lại thông đã nhập không:");
                    //    console.writeline("sửa lại nhấp số 1:");
                    //    console.writeline("không thì nhấn các phím còn lại:");
                    //    string quaylaisuatiepthongtingiangvien9cm = console.readline();
                    //    if (quaylaisuatiepthongtingiangvien9cm == "1")
                    //    {
                    //        goto tgvcm;
                    //    }
                    //    else
                    //        break;
                    default:
                        break;

                }
                Console.WriteLine("bạn đã sửa thông tin của giảng viên đã thành công");
                Console.WriteLine($"Username: {sinhVien.Username}");
                Console.WriteLine($"Họ và Tên: {sinhVien.HoTen}");
                Console.WriteLine($"MSGV: {sinhVien.MSSV}");
                Console.WriteLine($"Id: {sinhVien.Id}");
                Console.WriteLine($"Password: {sinhVien.Password}");
                Console.WriteLine($"Giới Tính: {sinhVien.GioiTinh}");
                Console.WriteLine($"Thuộc Khoa: {sinhVien.khoa}");
                Console.WriteLine($"Quê Quán: {sinhVien.QueQuan}");
                Console.WriteLine("--------------------------------------------");
            }


        }
        public void DKHP()
        {

            Console.WriteLine("Mời bạn nhập mã môn học");
            string MaMonHoc = Console.ReadLine();
            Console.WriteLine("Bạn hãy nhập lại MSSV");
            string MSSV = Console.ReadLine();

            foreach (MonHoc item in monHocs)
            {
                if (item.MaMonHoc == MaMonHoc)
                {
                    foreach (SinhVien item1 in sinhviens)
                    {

                        if (item1.MSSV == MSSV)
                        {
                            item1.monhoccc = item;
                            //this.monHocs.Add(monhoccc);
                            
                        }


                    }
                }

            }



        }
        public void lismonhoc()
        {
            for (int i = 0; i < monHocs.Count; i++)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Tên Môn Học:{monHocs[i].TenMonHOC}");
                Console.WriteLine($"Mã Môn Học: {monHocs[i].MaMonHoc}");
                Console.WriteLine($"tiết học: {monHocs[i].TietHoc}");
                Console.WriteLine($"ngày : {monHocs[i].NgayThu}");
                Console.WriteLine($"phong học: {monHocs[i].PhongHoc}");
                Console.WriteLine($"giảng viên: {monHocs[i].GiangVien}");

            }
        }
        public void xuatTKB()
        {
            Console.WriteLine("bạn hãy nhập MSSV cần in thời khóa biểu:");
            string MSSV = Console.ReadLine();
            foreach (var item in sinhviens)
            {

                if (item.MSSV == MSSV)
                {
                    // Console.WriteLine($"MSSV: {item.MSSV}");
                    //Console.WriteLine($"MaMon: {item.monhoccc.MaMonHoc}");
                    //Console.WriteLine($"TenMon: {item.monhoccc.TenMonHOC}");
                     
                    Console.WriteLine("thứ 2 |");

                    if (item.monhoccc.NgayThu == "thứ 2")
                    {
                        Console.WriteLine("Môn: {0},Tiet: {1},Phong: {2}, {3}", item.monhoccc.TenMonHOC, item.monhoccc.TietHoc, item.monhoccc.PhongHoc, item.monhoccc.GiangVien);
                    }
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("thứ 3 | ");

                    if (item.monhoccc.NgayThu == "thứ 3")
                    {
                        Console.WriteLine("Môn: {0},Tiet: {1},Phong: {2}, {3}", item.monhoccc.TenMonHOC, item.monhoccc.TietHoc, item.monhoccc.PhongHoc, item.monhoccc.GiangVien);
                    }

                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("thứ 4 | ");

                    if (item.monhoccc.NgayThu == "thứ 4")
                    {
                        Console.WriteLine("Môn: {0},Tiet: {1},Phong: {2}, {3}", item.monhoccc.TenMonHOC, item.monhoccc.TietHoc, item.monhoccc.PhongHoc, item.monhoccc.GiangVien); ;
                    }

                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("thứ 5 | ");

                    if (item.monhoccc.NgayThu == "thứ 5")
                    {
                        Console.WriteLine("Môn: {0},Tiet: {1},Phong: {2}, {3}", item.monhoccc.TenMonHOC, item.monhoccc.TietHoc, item.monhoccc.PhongHoc, item.monhoccc.GiangVien);
                    }

                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("thứ 6 | ");

                    if (item.monhoccc.NgayThu == "thứ 6")
                    {
                        Console.WriteLine("Môn: {0},Tiet: {1},Phong: {2}, {3}", item.monhoccc.TenMonHOC, item.monhoccc.TietHoc, item.monhoccc.PhongHoc, item.monhoccc.GiangVien);
                    }


                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("thứ 7 | ");

                    if (item.monhoccc.NgayThu == "thứ 7")
                    {
                        Console.WriteLine("Môn: {0},Tiet: {1},Phong: {2}, {3}", item.monhoccc.TenMonHOC, item.monhoccc.TietHoc, item.monhoccc.PhongHoc, item.monhoccc.GiangVien);
                    }

                    Console.WriteLine("---------------------------------------------------------------------");
                }
            }
        
        }

    }
            
     
}

