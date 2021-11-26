using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace CuahangNongduoc.DataLayer
{
    public class LyDoChiFactory
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachLyDo()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM LY_DO_CHI");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayLyDoChi(long id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM LY_DO_CHI WHERE ID = " + id);
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public bool Save()
        {
            return m_Ds.ExecuteNoneQuery() > 0;
        }
    }
}
