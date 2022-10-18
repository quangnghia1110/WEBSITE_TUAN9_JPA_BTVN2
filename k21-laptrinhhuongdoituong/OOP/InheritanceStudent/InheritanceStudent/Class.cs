using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudent
{
    class Class
    {
        private string tenLop;
        private string khoaHoc;
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public Class()
        {
            tenLop = "";
            khoaHoc = "";
        }
        public Class(string tenLop, string khoaHoc)
        {
            TenLop = tenLop;
            KhoaHoc = khoaHoc;
        }
        public string toString()
        {
            string kq = $", Lớp: {TenLop}, Khóa: {KhoaHoc}";
            return kq;
        }
    }
}
