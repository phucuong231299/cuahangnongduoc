using System;
using System.Collections.Generic;
using System.Text;

namespace CuahangNongduoc.BusinessObject
{
    public class SoLuongTon
    {
        private SanPham  m_SanPham;

        public SanPham  SanPham
        {
            get { return m_SanPham; }
            set { m_SanPham = value; }
        }
        private int m_SoLuongTon;

        public int SoLuong
        {
            get { return m_SoLuongTon; }
            set { m_SoLuongTon = value; }
        }

	
    }
}
