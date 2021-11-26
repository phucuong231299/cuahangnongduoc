using System;
using System.Collections.Generic;
using System.Text;

namespace CuahangNongduoc.BusinessObject
{
    public class PhieuNhap
    {
        public PhieuNhap() { }
        public PhieuNhap(String id)
        {
            m_Id = id;
        }
        private String m_Id;

        public String Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }
        private DateTime m_NgayNhap;

        public DateTime NgayNhap
        {
            get { return m_NgayNhap; }
            set { m_NgayNhap = value; }
        }
        private long m_TongTien;

        public long TongTien
        {
            get { return m_TongTien; }
            set { m_TongTien = value; }
        }
        private long m_Datra;

        public long DaTra
        {
            get { return m_Datra; }
            set { m_Datra = value; }
        }

        private long m_ConNo;

        public long ConNo
        {
            get { return m_ConNo; }
            set { m_ConNo = value; }
        }

        private NhaCungCap m_NCC;

        public NhaCungCap NhaCungCap
        {
            get { return m_NCC; }
            set { m_NCC = value; }
        }

	

        private IList<MaSanPham> m_ChiTiet;

        public IList<MaSanPham> ChiTiet
        {
            get { return m_ChiTiet; }
            set { m_ChiTiet = value; }
        }

	
    }
}
