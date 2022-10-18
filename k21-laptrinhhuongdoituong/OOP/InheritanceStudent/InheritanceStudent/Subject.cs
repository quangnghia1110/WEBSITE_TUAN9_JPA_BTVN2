using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudent
{
    class Subject
    {
       
        private string tenMon;
        private int soTinChi;
        private double diemThi;
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public double DiemThi { get => diemThi; set => diemThi = value; }
        
        public Subject(string tenMon, int soTinChi, double diemThi)
        {
            TenMon = tenMon;
            SoTinChi = soTinChi;
            DiemThi = diemThi;
        }
        public string toString()
        {
            string strDiem = $"{DiemThi}";
            string strTC = $"{SoTinChi}";
            string kq = $"| {TenMon}{new string(' ', 26 - 2 - TenMon.Length)}| {SoTinChi}{new string(' ', 26 - 2 - strTC.Length)}| {DiemThi:0.00}{new string(' ', 26 - 5 - strDiem.Length)}|";
            return kq;
        }

        
    }

}
