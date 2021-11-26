using System;
using System.Collections.Generic;
using System.Text;

namespace CuahangNongduoc.BusinessObject
{
    public class DuNoKhachHang
    {
        private KhachHang m_KH;

        public KhachHang KhachHang
        {
            get { return m_KH; }
            set { m_KH = value; }
        }
        private int m_Thang;

        public int Thang
        {
            get { return m_Thang; }
            set { m_Thang = value; }
        }
        private int m_Nam;

        public int Nam
        {
            get { return m_Nam; }
            set { m_Nam = value; }
        }
        private long m_DauKy;

        public long DauKy
        {
            get { return m_DauKy; }
            set { m_DauKy = value; }
        }
        private long m_PhatSinh;

        public long PhatSinh
        {
            get { return m_PhatSinh; }
            set { m_PhatSinh = value; }
        }

        private long m_DaTra;

        public long DaTra
        {
            get { return m_DaTra; }
            set { m_DaTra = value; }
        }
        private long m_CuoiKy;

        public long CuoiKy
        {
            get { return m_CuoiKy; }
            set { m_CuoiKy = value; }
        }


    }
}
