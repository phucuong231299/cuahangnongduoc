using System;
using System.Collections.Generic;
using System.Text;

namespace CuahangNongduoc.BusinessObject
{
    public class MaSanPham
    {
        public MaSanPham() { }
        public MaSanPham(String id, int so_luong) 
        {
            m_Id = id;
            m_SoLuong = so_luong;
        }

        private String m_Id;

        public String Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }
      
        private SanPham m_SanPham;

        public SanPham SanPham
        {
            get { return m_SanPham; }
            set { m_SanPham = value; }
        }
        private long m_GiaNhap;

        public long GiaNhap
        {
            get { return m_GiaNhap; }
            set { m_GiaNhap = value; }
        }
        private int m_SoLuong;

        public int SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }

        private long m_ThanhTien;

        public long ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        }


        private DateTime m_NgayNhap;

        public DateTime NgayNhap
        {
            get { return m_NgayNhap; }
            set { m_NgayNhap = value; }
        }
        private DateTime m_NgaySanXuat;

        public DateTime NgaySanXuat
        {
            get { return m_NgaySanXuat; }
            set { m_NgaySanXuat = value; }
        }
        private DateTime  m_NgayHetHan;

        public DateTime  NgayHetHan
        {
            get { return m_NgayHetHan; }
            set { m_NgayHetHan = value; }
        }
        private PhieuNhap m_PhieuNhap;

        public PhieuNhap PhieuNhap
        {
            get { return m_PhieuNhap; }
            set { m_PhieuNhap = value; }
        }

	
    }
}
