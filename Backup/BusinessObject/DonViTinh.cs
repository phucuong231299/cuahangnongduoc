using System;
using System.Collections.Generic;
using System.Text;

namespace CuahangNongduoc.BusinessObject
{
    public class DonViTinh
    {
        public DonViTinh() { }
        public DonViTinh(int id, String ten)
        {
            m_ID = id;
            m_Ten = ten;
        }

        private int m_ID;

        public int Id
        {
            get { return m_ID; }
            set { m_ID = value; }
        }
        private String m_Ten;

        public String Ten
        {
            get { return m_Ten; }
            set { m_Ten = value; }
        }
	
	
    }
}
