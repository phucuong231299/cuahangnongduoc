using System;
using System.Collections.Generic;
using System.Text;

namespace CuahangNongduoc.BusinessObject
{
    public class LyDoChi
    {
        private long m_Id;

        public long Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }
        private String m_LyDo;

        public String LyDo
        {
            get { return m_LyDo; }
            set { m_LyDo = value; }
        }
	
    }
}
