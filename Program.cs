using Do_an_nhom;
using System.Collections;
using System.Diagnostics.Contracts;
using System.Text.Json;
using System.Xml.Serialization;
internal class Program
{
    public static string filePath_BoPhan = @"D:\C#\BoPhan.txt";
    public static string filePath_NhanSu_GD = @"D:\C#\NhanSu_GD.txt";
    public static string filePath_NhanSu_TP = @"D:\C#\NhanSu_TP.txt";
    public static string filePath_NhanSu_PGD = @"D:\C#\NhanSu_PGD.txt";
    public static string filePath_NhanSu_NVF = @"D:\C#\NhanSu_NVF.txt";
    public static string filePath_NhanSu_NVP = @"D:\C#\NhanSu_NVP.txt";
    public static string filePath_NhanSu_TT = @"D:\C#\NhanSu_TT.txt";
    private static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        BoPhan_List boPhan_List = new BoPhan_List();
        boPhan_List.Add(new BoPhan() { MaBP = 1, TenBP = "Kế toán", HeSoLuong = 2 });
        boPhan_List.Add(new BoPhan() { MaBP = 2, TenBP = "Nhân sự", HeSoLuong = 2 });
        boPhan_List.Add(new BoPhan() { MaBP = 3, TenBP = "Kỹ thuật", HeSoLuong = 3 });
        boPhan_List.Add(new BoPhan() { MaBP = 4, TenBP = "Tuyển Dụng", HeSoLuong = 2 });
        boPhan_List.Add(new BoPhan() { MaBP = 5, TenBP = "Dịch vụ", HeSoLuong = 2 });
        //
        //
        //
        SerializationHelper.Serialize(boPhan_List.BoPhans, filePath_BoPhan);
        SerializationHelper.Deserialize(boPhan_List.BoPhans, filePath_BoPhan);
        //
        //
        //
        NhanSu_List<GiamDoc> giamDocList = new NhanSu_List<GiamDoc>();
        giamDocList.Add(new GiamDoc()
        {
            MaNV = 1,
            HoLot = "Nguyen",
            Ten = "Van A",
            CMND = "123456789",
            GioiTinh = true,
            NgaySinh = new DateTime(1980, 5, 15),
            DiaChi = "123 Đường ABC, Quận XYZ, Thành phố HCM",
            DienThoai = "0123456789",
            MaBP = 1, // Giả sử GiamDoc thuộc bộ phận có mã là 1
            HeSoLuong = 2.5, // Giả sử hệ số lương của GiamDoc là 2.5})
            LoaiNhanVien = 5,
            LuongCoBan = 170
        });
        NhanSu_List<PhoGiamDoc> pgdList = new NhanSu_List<PhoGiamDoc>();
        pgdList.Add(new PhoGiamDoc()
        {
            MaNV = 2,
            HoLot = "Nguyen",
            Ten = "Van D",
            CMND = "0909999999",
            GioiTinh = false,
            NgaySinh = new DateTime(1999, 12, 10),
            DiaChi = "456 Đường ABC, Quận XYZ, Thành phố HCM",
            DienThoai = "0934746717",
            MaBP = 1, // Giả sử PhoGiamDoc thuộc bộ phận có mã là 1
            HeSoLuong = 2.0, // Giả sử hệ số lương của PhoGiamDoc là 2.5})
            LoaiNhanVien = 4,
            LuongCoBan = 150
        });
        NhanSu_List<TruongPhong> truongPhongList = new NhanSu_List<TruongPhong>();
        truongPhongList.Add(new TruongPhong()
        {
            MaNV = 3,
            HoLot = "Nguyen",
            Ten = "Van B",
            CMND = "012345678",
            GioiTinh = true,
            NgaySinh = new DateTime(1988, 12, 26),
            DiaChi = "456 Đường ABC, Quận XYZ, Thành phố HCM",
            DienThoai = "0787700820", // tạo khéo léo để không bị trùng, thêm hàm kiểm tra sau.
            MaBP = 1, // Giả sử TruongPhong thuộc bộ phận có mã là 1
            HeSoLuong = 1.5, // Giả sử hệ số lương của TruongPhong là 1.5})
            LoaiNhanVien = 3,
            LuongCoBan = 100
        });
        NhanSu_List<NhanVienFullTime> nvfList = new NhanSu_List<NhanVienFullTime>();
        nvfList.Add(new NhanVienFullTime()
        {
            MaNV = 4,
            HoLot = "Nguyen",
            Ten = "Van E",
            CMND = "888888888",
            GioiTinh = true,
            NgaySinh = new DateTime(1988, 12, 26),
            DiaChi = "456 Đường ABC, Quận ABC, Thành phố HCM",
            DienThoai = "01111111", // tạo khéo léo để không bị trùng, thêm hàm kiểm tra sau.
            MaBP = 1, // Giả sử NV thuộc bộ phận có mã là 1
            HeSoLuong = 1.2, // Giả sử hệ số lương của NV là 1.2})
            LoaiNhanVien = 2,
            LuongCoBan = 80
        });
        NhanSu_List<NhanVienPartTime> nvpList = new NhanSu_List<NhanVienPartTime>();
        nvpList.Add(new NhanVienPartTime()
        {
            MaNV = 5,
            HoLot = "Nguyen",
            Ten = "Van F",
            CMND = "888888828",
            GioiTinh = true,
            NgaySinh = new DateTime(1988, 12, 26),
            DiaChi = "456 Đường ABC, Quận XYZ, Thành phố HCM",
            DienThoai = "0987654321", // tạo khéo léo để không bị trùng, thêm hàm kiểm tra sau.
            MaBP = 1, // Giả sử TruongPhong thuộc bộ phận có mã là 1
            HeSoLuong = 1.0, // Giả sử hệ số lương của TruongPhong là 1.0})
            LoaiNhanVien = 1,
            LuongCoBan = 100
        });
        NhanSu_List<ThucTapSinh> ttList = new NhanSu_List<ThucTapSinh>();
        ttList.Add(new ThucTapSinh()
        {
            MaNV = 6,
            HoLot = "Nguyen",
            Ten = "Van G",
            CMND = "012345678",
            GioiTinh = true,
            NgaySinh = new DateTime(1988, 12, 26),
            DiaChi = "456 Đường ABC, Quận XYZ, Thành phố HCM",
            DienThoai = "00000000", // tạo khéo léo để không bị trùng, thêm hàm kiểm tra sau.
            MaBP = 1, // Giả sử TTS thuộc bộ phận có mã là 1
            HeSoLuong = 1.0, // Giả sử hệ số lương của TTS là 1.0})
            LoaiNhanVien = 0,
            LuongCoBan = 50
        });
        //
        //
        //
        SerializationHelper.Serialize(giamDocList.NhanSus, filePath_NhanSu_GD);
        SerializationHelper.Deserialize(giamDocList.NhanSus, filePath_NhanSu_GD);
        SerializationHelper.Serialize(truongPhongList.NhanSus, filePath_NhanSu_TP);
        SerializationHelper.Deserialize(truongPhongList.NhanSus, filePath_NhanSu_TP);
        SerializationHelper.Serialize(pgdList.NhanSus, filePath_NhanSu_PGD);
        SerializationHelper.Deserialize(pgdList.NhanSus, filePath_NhanSu_PGD);
        SerializationHelper.Serialize(nvfList.NhanSus, filePath_NhanSu_NVF);
        SerializationHelper.Deserialize(nvfList.NhanSus, filePath_NhanSu_NVF);
        SerializationHelper.Serialize(nvpList.NhanSus, filePath_NhanSu_NVP);
        SerializationHelper.Deserialize(nvpList.NhanSus, filePath_NhanSu_NVP);
        SerializationHelper.Serialize(ttList.NhanSus, filePath_NhanSu_TT);
        SerializationHelper.Deserialize(ttList.NhanSus, filePath_NhanSu_TT);
        //
        //
        //
        while (true)
        {
            Console.WriteLine(@"--- CHƯƠNG TRÌNH CHẤM CÔNG --- " +
                                "\n1. Check-In"+
                                "\n2. Check-Out"+
                                "\n3. Tính lương nhân sự"+
                                "\n4. Thoát");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                {
                    Console.Write("Nhập số điện thoại: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("Nhập loại nhân viên (5: GiamDoc, 4: PhoGiamDoc, 3: TruongPhong, 2: NhanVienFullTime, 1: NhanVienParttime, 0: Thuc Tap Sinh): ");
                    int loaiNV = int.Parse(Console.ReadLine());
                    DateTime checkIn = DateTime.Now;
                        if (loaiNV == giamDocList.NhanSus[0].LoaiNhanVien)
                        {
                            giamDocList.CheckIn(phoneNumber, loaiNV, checkIn);
                        }
                        else if (loaiNV == truongPhongList.NhanSus[0].LoaiNhanVien)
                        {
                            truongPhongList.CheckIn(phoneNumber, loaiNV, checkIn);
                        } // thêm nhiều loại nhân viên khác
                        else if (loaiNV == pgdList.NhanSus[0].LoaiNhanVien)
                        {
                            pgdList.CheckIn(phoneNumber, loaiNV, checkIn);
                        }
                        else if (loaiNV == nvfList.NhanSus[0].LoaiNhanVien)
                        {
                            nvfList.CheckIn(phoneNumber, loaiNV, checkIn);
                        }
                        else if (loaiNV == nvpList.NhanSus[0].LoaiNhanVien)
                        {
                            nvpList.CheckIn(phoneNumber, loaiNV, checkIn);
                        }
                        else if (loaiNV == ttList.NhanSus[0].LoaiNhanVien)
                        {
                            ttList.CheckIn(phoneNumber, loaiNV, checkIn);
                        }
                    break;
                }
                case "2":
                {
                    Console.Write("Nhập số điện thoại: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("Nhập loại nhân viên (5: GiamDoc, 4: PhoGiamDoc, 3: TruongPhong, 2: NhanVienFullTime, 1: NhanVienParttime, 0: Thuc Tap Sinh): ");
                    int loaiNV = int.Parse(Console.ReadLine());
                    DateTime checkOut = DateTime.Now;
                        if (loaiNV == giamDocList.NhanSus[0].LoaiNhanVien)
                        {
                            giamDocList.CheckOut(phoneNumber, checkOut);
                        }
                        else if (loaiNV == truongPhongList.NhanSus[0].LoaiNhanVien)
                        {
                            truongPhongList.CheckOut(phoneNumber, checkOut);
                        } // thêm nhiều loại nhân viên khác
                        else if (loaiNV == pgdList.NhanSus[0].LoaiNhanVien)
                        {
                            pgdList.CheckOut(phoneNumber, checkOut);
                        }
                        else if (loaiNV == nvfList.NhanSus[0].LoaiNhanVien)
                        {
                            nvfList.CheckOut(phoneNumber, checkOut);
                        }
                        else if (loaiNV == nvpList.NhanSus[0].LoaiNhanVien)
                        {
                            nvpList.CheckOut(phoneNumber, checkOut);
                        }
                        else if (loaiNV == ttList.NhanSus[0].LoaiNhanVien)
                        {
                            ttList.CheckOut(phoneNumber, checkOut);
                        }
                        break;
                }
                case "3":
                {
                    Console.Write("Nhập số điện thoại: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("Nhập loại nhân viên (5: GiamDoc, 4: PhoGiamDoc, 3: TruongPhong, 2: NhanVienFullTime, 1: NhanVienParttime, 0: Thuc Tap Sinh): ");
                    int loaiNV = int.Parse(Console.ReadLine());
                        if (loaiNV == giamDocList.NhanSus[0].LoaiNhanVien)
                        {
                            giamDocList.TinhLuong(phoneNumber, loaiNV);
                        }
                        else if (loaiNV == truongPhongList.NhanSus[0].LoaiNhanVien)
                        {
                            truongPhongList.TinhLuong(phoneNumber, loaiNV);
                        } // thêm nhiều loại nhân viên khác
                        else if (loaiNV == pgdList.NhanSus[0].LoaiNhanVien)
                        {
                            pgdList.TinhLuong(phoneNumber, loaiNV);
                        }
                        else if (loaiNV == nvfList.NhanSus[0].LoaiNhanVien)
                        {
                            nvfList.TinhLuong(phoneNumber, loaiNV);
                        }
                        else if (loaiNV == nvpList.NhanSus[0].LoaiNhanVien)
                        {
                            nvpList.TinhLuong(phoneNumber, loaiNV);
                        }
                        else if (loaiNV == ttList.NhanSus[0].LoaiNhanVien)
                        {
                            ttList.TinhLuong(phoneNumber, loaiNV);
                        }
                        break;
                }
                case "4":
                {
                    return;
                }
                default:
                {
                    Console.WriteLine("Đây không phải là một lựa chọn !");
                    break;
                }
            }
        }
    }
}