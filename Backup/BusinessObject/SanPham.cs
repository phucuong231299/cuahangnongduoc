using System;
using System.Collections.Generic;
using System.Text;

namespace CuahangNongduoc.BusinessObject
{
    public class SanPham
    {
        public SanPham() { }
        public SanPham(String id, String tensp)
        {
            m_Id = id;
            m_TenSP = tensp;
        }
        private String m_Id;

        public String Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }
        private String m_TenSP;

        public String TenSanPham
        {
            get { return m_TenSP; }
            set { m_TenSP = value; }
        }
        private int m_SoLuong;

        public int SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }
        private long m_DonGiaNhap;

        public long DonGiaNhap
        {
            get { return m_DonGiaNhap; }
            set { m_DonGiaNhap = value; }
        }
        private long m_GiaBanSi;

        public long GiaBanSi
        {
            get { return m_GiaBanSi; }
            set { m_GiaBanSi = value; }
        }
        private long m_GiaBanLe;

        public long GiaBanLe
        {
            get { return m_GiaBanLe; }
            set { m_GiaBanLe = value; }
        }
        private DonViTinh m_DonViTinh;

        public DonViTinh DonViTinh
        {
            get { return m_DonViTinh; }
            set { m_DonViTinh = value; }
        }

	
	
    }
}
