using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudent
{
    class Student:Class
    {
        private List<Subject> list = new List<Subject>();
        private string hoTen;
        private string maSinhVien;
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public Student()
        {
            hoTen = "";
            maSinhVien = "";
        }
        public Student(string hoTen, string maSinhVien, string tenLop, string khoaHoc) : base (tenLop, khoaHoc)  
        {
            HoTen = hoTen;
            MaSinhVien = maSinhVien;
        }
        public void ThemMonHoc()
        {
            Console.Write("Nhập tên môn học: ");
            string tenMon = Console.ReadLine();
            Console.Write("Nhập số tín chỉ: ");
            int soTinChi = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm thi: ");
            double diemThi = double.Parse(Console.ReadLine());
            Subject temp = new Subject(tenMon, soTinChi, diemThi);
            list.Add(temp);
        }
        public void InPhieuBaoDiem()
        {
            int spaceMS = 36 - maSinhVien.Length - 18;
            int spaceTen = 42 - hoTen.Length - 15;
            int spaceLop = 36 - TenLop.Length - 6;
            int spaceKhoa = 42 - KhoaHoc.Length - 6;
            string sinhVien="|Mã số sinh viên: "+maSinhVien+ new string(' ',spaceMS) + "Tên sinh viên: " + hoTen + new string(' ', spaceTen) + "|";
            string lopHoc = "|Lớp: " + TenLop + new string(' ', spaceLop) + "Khóa: " + KhoaHoc + new string(' ', spaceKhoa) + "|";
            Console.WriteLine(" " + new string('_', 77));
            Console.WriteLine("|Phiếu Báo Điểm" + new string(' ', 78 - 15) + "|");
            Console.WriteLine(sinhVien);
            Console.WriteLine(lopHoc);
            Console.WriteLine("|" + new string('_', 77) + "|");
            Console.WriteLine("|" + new string(' ', 77) + "|");
            Console.WriteLine("|" + new string(' ', 39 - 4) + "BẢNG ĐIỂM" + new string(' ', 39 - 6) + "|");
            Console.WriteLine("|" + new string('_', 77) + "|");
            int space = 26;
            Console.WriteLine("|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|");
            Console.WriteLine("| Tên môn" + new string(' ', space - 9) + "| Số tín chỉ" + new string(' ', space - 12) + "| Điểm" + new string(' ', space - 6) + "|");
            Console.WriteLine("|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|");
            if (list.Count == 0)
            {
                Console.WriteLine("|" + new string(' ', 77) + "|");
                Console.WriteLine("| Chưa có môn học" + new string(' ', 78 - 17) + "|");
                Console.WriteLine("|" + new string('_', 77) + "|");
            }
            else
            {
                foreach(Subject i in list)
                {
                    Console.WriteLine("|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|" + new string(' ', space - 1) + "|");
                    Console.WriteLine(i.toString());
                    Console.WriteLine("|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|" + new string('_', space - 1) + "|");

                }
            }
            
        }
        public string toString()
        {
            string kq = $"Họ và tên: {hoTen}, Mã số sinh viên: {maSinhVien}"+base.toString();
            return kq;
        }
    }
}
