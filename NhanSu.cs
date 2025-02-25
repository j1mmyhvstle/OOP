﻿using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Do_an_nhom
{
    public abstract class NhanSu : ISerializable
    {
        public int MaNV { get; set; }
        public int SoGioCong { get; set; }
        public int? MaBP { get; set; }
        public int LoaiNhanVien { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string CMND { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        //public double Luong { get; set; }
        public double LuongCoBan { get; set; } // được phép ghi đè
        public double HeSoLuong { get; set; } // được phép ghi đè
        public NhanSu() { }

        protected NhanSu(SerializationInfo info, StreamingContext context)
        {
            MaNV = info.GetInt32("MaNV");
            HoLot = info.GetString("HoLot");
            Ten = info.GetString("Ten");
            CMND = info.GetString("CMND");
            GioiTinh = info.GetBoolean("GioiTinh");
            NgaySinh = info.GetDateTime("NgaySinh");
            DiaChi = info.GetString("DiaChi");
            DienThoai = info.GetString("DienThoai");
            MaBP = info.GetInt32("MaBP");
            SoGioCong = info.GetInt32("SoGioCong");
        }
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaNV", MaNV);
            info.AddValue("HoLot", HoLot);
            info.AddValue("Ten", Ten);
            info.AddValue("CMND", CMND);
            info.AddValue("GioiTinh", GioiTinh);
            info.AddValue("NgaySinh", NgaySinh);
            info.AddValue("DiaChi", DiaChi);
            info.AddValue("DienThoai", DienThoai);
            info.AddValue("MaBP", MaBP);
            info.AddValue("SoGioCong", SoGioCong);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    public class GiamDoc : NhanSu
    {
        //public double LuongCoBan = 170000; // Lương cơ bản * 1000
        //public double HeSoLuong { get; set; }
        //public int LoaiNhanVien = 5;
        public GiamDoc() { }

        public GiamDoc(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            LuongCoBan = info.GetDouble("LuongCoBan");
            HeSoLuong = info.GetDouble("HeSoLuong");
            LoaiNhanVien = info.GetInt32("LoaiNhanVien");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("LuongCoBan", LuongCoBan);
            info.AddValue("HeSoLuong", HeSoLuong);
            info.AddValue("LoaiNhanVien", LoaiNhanVien);
        }
        public override string ToString()
        {
            return $"MaNV = {MaNV}, HoLot = \"{HoLot}\", Ten = \"{Ten}\", CMND = \"{CMND}\", GioiTinh = {GioiTinh}, NgaySinh = {NgaySinh}, DiaChi = \"{DiaChi}\", DienThoai = \"{DienThoai}\", MaBP = {MaBP}, LuongCoBan = {LuongCoBan}, HeSoLuong = {HeSoLuong}";
        }
    }
    public class PhoGiamDoc : NhanSu
    {
        //public double LuongCoBan = 130000; // Lương cơ bản * 1000
        //public double HeSoLuong { get; set; }
        //public int LoaiNhanVien = 4;
        public PhoGiamDoc() { }

        public PhoGiamDoc(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            LuongCoBan = info.GetDouble("LuongCoBan");
            HeSoLuong = info.GetDouble("HeSoLuong");
            LoaiNhanVien = info.GetInt32("LoaiNhanVien");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("LuongCoBan", LuongCoBan);
            info.AddValue("HeSoLuong", HeSoLuong);
            info.AddValue("LoaiNhanVien", LoaiNhanVien);
        }
        public override string ToString()
        {
            return $"MaNV = {MaNV}, HoLot = \"{HoLot}\", Ten = \"{Ten}\", CMND = \"{CMND}\", GioiTinh = {GioiTinh}, NgaySinh = {NgaySinh}, DiaChi = \"{DiaChi}\", DienThoai = \"{DienThoai}\", MaBP = {MaBP}, LuongCoBan = {LuongCoBan}, HeSoLuong = {HeSoLuong}";
        }
    }
    public class TruongPhong : NhanSu
    {
        //public double LuongCoBan = 100000; // Lương cơ bản * 1000
        //public double HeSoLuong { get; set; }
        //public int LoaiNhanVien = 3;
        public TruongPhong() { }

        public TruongPhong(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            LuongCoBan = info.GetDouble("LuongCoBan");
            HeSoLuong = info.GetDouble("HeSoLuong");
            LoaiNhanVien = info.GetInt32("LoaiNhanVien");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("LuongCoBan", LuongCoBan);
            info.AddValue("HeSoLuong", HeSoLuong);
            info.AddValue("LoaiNhanVien", LoaiNhanVien);
        }
        public override string ToString()
        {
            return $"MaNV = {MaNV}, HoLot = \"{HoLot}\", Ten = \"{Ten}\", CMND = \"{CMND}\", GioiTinh = {GioiTinh}, NgaySinh = {NgaySinh}, DiaChi = \"{DiaChi}\", DienThoai = \"{DienThoai}\", MaBP = {MaBP}, LuongCoBan = {LuongCoBan}, HeSoLuong = {HeSoLuong}";
        }
    }
    public class NhanVienFullTime : NhanSu
    {
        //public double LuongCoBan = 60000; // Lương cơ bản * 1000
        //public double HeSoLuong { get; set; }
        //public int LoaiNhanVien = 2;
        public NhanVienFullTime() { }

        public NhanVienFullTime(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            LuongCoBan = info.GetDouble("LuongCoBan");
            HeSoLuong = info.GetDouble("HeSoLuong");
            LoaiNhanVien = info.GetInt32("LoaiNhanVien");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("LuongCoBan", LuongCoBan);
            info.AddValue("HeSoLuong", HeSoLuong);
            info.AddValue("LoaiNhanVien", LoaiNhanVien);
        }
        public override string ToString()
        {
            return $"MaNV = {MaNV}, HoLot = \"{HoLot}\", Ten = \"{Ten}\", CMND = \"{CMND}\", GioiTinh = {GioiTinh}, NgaySinh = {NgaySinh}, DiaChi = \"{DiaChi}\", DienThoai = \"{DienThoai}\", MaBP = {MaBP}, LuongCoBan = {LuongCoBan}, HeSoLuong = {HeSoLuong}";
        }
    }
    public class NhanVienPartTime : NhanSu
    {
        //public double LuongCoBan = 30000; // Lương cơ bản * 1000
        //public int LoaiNhanVien = 1;
        public NhanVienPartTime() { }

        public NhanVienPartTime(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            LuongCoBan = info.GetDouble("LuongCoBan");
            LoaiNhanVien = info.GetInt32("LoaiNhanVien");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("LuongCoBan", LuongCoBan);
            info.AddValue("LoaiNhanVien", LoaiNhanVien);
        }
        public override string ToString()
        {
            return $"MaNV = {MaNV}, HoLot = \"{HoLot}\", Ten = \"{Ten}\", CMND = \"{CMND}\", GioiTinh = {GioiTinh}, NgaySinh = {NgaySinh}, DiaChi = \"{DiaChi}\", DienThoai = \"{DienThoai}\", MaBP = {MaBP}, LuongCoBan = {LuongCoBan}";
        }
    }
    public class ThucTapSinh : NhanSu
    {
        //public double LuongCoBan = 0;
        //public int LoaiNhanVien = 0;
        public ThucTapSinh() { }

        public ThucTapSinh(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            LuongCoBan = info.GetDouble("LuongCoBan");
            LoaiNhanVien = info.GetInt32("LoaiNhanVien");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("LuongCoBan", LuongCoBan);
            info.AddValue("LoaiNhanVien", LoaiNhanVien);
        }
        public override string ToString()
        {
            return $"MaNV = {MaNV}, HoLot = \"{HoLot}\", Ten = \"{Ten}\", CMND = \"{CMND}\", GioiTinh = {GioiTinh}, NgaySinh = {NgaySinh}, DiaChi = \"{DiaChi}\", DienThoai = \"{DienThoai}\", MaBP = {MaBP}, LuongCoBan = {LuongCoBan}";
        }
    }
    public class NhanSu_List<T> where T : NhanSu
    {
        private List<T> nhanSus = new List<T>();

        public List<T> NhanSus { get { return nhanSus; } set { nhanSus = value; } }

        public NhanSu_List() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("NhanSus", NhanSus);
        }
        public NhanSu_List(SerializationInfo info, StreamingContext context)
        {
            NhanSus = (List<T>)info.GetValue("NhanSus", typeof(List<T>));
        }
        public void Add(T item)
        {
            NhanSus.Add(item);
        }


        // Chấm công tính lương - engine
        public void CheckIn(string phoneNumber, int loaiNV, DateTime checkIn)
        {
            string filePath = $"D:\\C#\\ChamCong_{DateTime.Now:yyyyMMdd}.json";
            Dictionary<string, Dictionary<string, string>> chamCongList;
            if (File.Exists(filePath))
            {
                string data = File.ReadAllText(filePath);
                chamCongList = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(data);
            }
            else
            {
                chamCongList = new Dictionary<string, Dictionary<string, string>>();
            }

            if (!chamCongList.ContainsKey(phoneNumber))
            {
                chamCongList[phoneNumber] = new Dictionary<string, string>
                {
                    { "checkIn", checkIn.ToString() },
                    { "loaiNV", loaiNV.ToString() }
                };
            }
            string newData = JsonSerializer.Serialize(chamCongList);
            File.WriteAllText(filePath, newData);
            Console.WriteLine($"Đã check-in cho {phoneNumber}.");
        }
        public void CheckOut(string phoneNumber, DateTime checkOut)
        {
            string filePath = $"D:\\C#\\ChamCong_{DateTime.Now:yyyyMMdd}.json";
            string data = File.ReadAllText(filePath);
            Dictionary<string, Dictionary<string, string>> chamCongList = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(data);

            if (chamCongList.ContainsKey(phoneNumber))
            {
                chamCongList[phoneNumber]["checkOut"] = checkOut.ToString();
                DateTime checkIn = DateTime.Parse(chamCongList[phoneNumber]["checkIn"]);
                int soGioCong = (checkOut - checkIn).Hours;
                chamCongList[phoneNumber]["soGioCong"] = soGioCong.ToString();

                string newData = JsonSerializer.Serialize(chamCongList);
                File.WriteAllText(filePath, newData);
                Console.WriteLine($"Đã check-out cho {phoneNumber}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy bản ghi check-in cho số điện thoại {phoneNumber}");
            }
        }
        public void TinhLuong(string phoneNumber, int loaiNV)
        {
            T nhanSu = FindByPhoneNumber(phoneNumber);
            if (nhanSu != null)
            {
                int tongSoGioCong = 0;
                string[] filePaths = Directory.GetFiles("D:\\C#", "ChamCong_*.json"); // lấy tất cả các file
                foreach (string filePath in filePaths)
                {
                    string data = File.ReadAllText(filePath);
                    JsonDocument jsonDocument = JsonDocument.Parse(data);
                    // kiểm tra tính mảng []
                    if (jsonDocument.RootElement.TryGetProperty(phoneNumber, out JsonElement phoneNumberElement))
                    {
                        if (phoneNumberElement.TryGetProperty("checkIns", out JsonElement checkInsElement))
                        {
                            if (checkInsElement.ValueKind == JsonValueKind.Array)
                            {
                                Dictionary<string, Dictionary<string, List<string>>> chamCongList = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, List<string>>>>(data); // không sài cái của Khánh được
                                if (chamCongList.ContainsKey(phoneNumber))
                                {
                                    List<string> checkIns = chamCongList[phoneNumber]["checkIns"];
                                    List<string> checkOuts = chamCongList[phoneNumber]["checkOuts"];
                                    if (loaiNV != 1) // Nếu là nhân viên chính thức
                                    {
                                        DateTime checkIn = DateTime.Parse(checkIns[0]);
                                        DateTime checkOut = DateTime.Parse(checkOuts[checkOuts.Count - 1]);
                                        tongSoGioCong += (checkOut - checkIn).Hours;
                                    }
                                    else // Nếu là nhân viên thời vụ
                                    {
                                        for (int i = 0; i < checkIns.Count && i < checkOuts.Count; i++)
                                        {
                                            DateTime checkIn = DateTime.Parse(checkIns[i]);
                                            DateTime checkOut = DateTime.Parse(checkOuts[i]);
                                            tongSoGioCong += (checkOut - checkIn).Hours;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                // nếu không phải mảng
                                Console.WriteLine($"Error: \"checkIn\" không phải một mảng mà là {checkInsElement.ValueKind}.");
                            }
                        }
                    }
                }
                double luong = tongSoGioCong * nhanSu.HeSoLuong * nhanSu.LuongCoBan;
                if (tongSoGioCong > 250)
                {
                    luong += 500000;
                }
                Console.WriteLine($"Số giờ công: {tongSoGioCong}");
                Console.WriteLine($"Hệ số lương: {nhanSu.HeSoLuong}");
                Console.WriteLine($"Lương cơ bản: {nhanSu.LuongCoBan}");
                Console.WriteLine($"Lương của nhân sự có số điện thoại {phoneNumber} và loại nhân viên {loaiNV} là: {luong}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy nhân sự nào có số điện thoại {phoneNumber} và loại nhân viên {loaiNV}");
            }
        }
        public T FindByPhoneNumber(string phoneNumber)
        {
            foreach (T nhanSu in NhanSus)
            {
                if (nhanSu.DienThoai == phoneNumber)
                {
                    return nhanSu;
                }
            }
            return null;
        }
    }
}
