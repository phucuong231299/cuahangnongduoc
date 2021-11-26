using System;
using System.Collections.Generic;
using System.Text;

namespace CuahangNongduoc.BusinessObject
{
    public class CuaHang
    {
        private String m_TenCuaHang;

        public String TenCuaHang
        {
            get { return m_TenCuaHang; }
            set { m_TenCuaHang = value; }
        }

        private String m_DiaChi;

        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private String m_DienThoai;

        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }

    }
}
