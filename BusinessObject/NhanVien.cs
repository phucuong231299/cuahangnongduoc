using System;
using System.Collections.Generic;
using System.Text;

namespace CuahangNongduoc.BusinessObject
{
    class NhanVien
    {
        private int id;
        private string hovaten;
        private string tendangnhap;
        private string matkhau;
        

        public int Id { get => id; set => id = value; }
        public string Hovaten { get => hovaten; set => hovaten = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
       
    }
}
