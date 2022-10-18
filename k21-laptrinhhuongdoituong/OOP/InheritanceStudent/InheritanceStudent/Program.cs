using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> students = new List<Student>();
            bool temp = true;
            while (temp)
            {
                Console.Clear();
                Console.WriteLine("1. Nhập thông tin cho sinh viên.");
                Console.WriteLine("2. In danh sách sinh viên.");
                Console.WriteLine("3. In ra phiếu điểm cho các sinh viên.");
                Console.WriteLine("4. Thoát.\n");
                Console.Write("Nhập lựa chọn từ 1->4: ");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Write("***Nhập số lượng sinh viên: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("**Sinh viên thứ {0}", i + 1);
                            students.Add(NhapThongTinSinhVien());
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        if (students.Count == 0)
                            Console.WriteLine("Chưa có sinh viên");
                        else
                        {
                            foreach (Student i in students)
                            {
                                Console.WriteLine(i.toString());
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Phiếu điểm của sinh viên");
                        if (students.Count == 0)
                            Console.WriteLine("Chưa có sinh viên");
                        else
                        {
                            foreach (Student i in students)
                            {
                                i.InPhieuBaoDiem();
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        temp = false;
                        break;
                    default:
                        Console.WriteLine("Phương án không hợp lệ. Vui lòng nhập lại!");
                        Console.ReadKey();
                        break;
                }
            }
        }
        
        private static Student NhapThongTinSinhVien()
        {
            Console.Write("Nhập họ tên sinh viên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập mã số sinh viên: ");
            string maSinhVien = Console.ReadLine();
            Console.Write("Nhập tên lớp học: ");
            string tenLop = Console.ReadLine();
            Console.Write("Nhập khóa học: ");
            string khoaHoc = Console.ReadLine();
            Student student = new Student(hoTen, maSinhVien, tenLop, khoaHoc);
            Console.Write("Nhập số lượng môn học: ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("*Môn thứ {0}", i + 1);
                student.ThemMonHoc();
            }
            return student;
        }
    }
}