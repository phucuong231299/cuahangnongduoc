using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace CuahangNongduoc.DataLayer
{
    public class ChiTietPhieuNhapFactory
    {
        DataService m_Ds = new DataService();

        public void LoadSchema()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM CHI_TIET_PHIEU_NHAP WHERE ID_PHIEU_NHAP = '-1'");
            m_Ds.Load(cmd);
        }

        public DataTable LayChiTietPhieuNhap(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM CHI_TIET_PHIEU_NHAP WHERE ID_PHIEU_NHAP = @id");
            cmd.Parameters.Add("id", OleDbType.VarChar,50).Value = id;
            m_Ds.Load(cmd);
            return m_Ds;
        }

        public int XoaChiTietPhieuNhap(String id)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM CHI_TIET_PHIEU_NHAP WHERE ID_PHIEU_NHAP = @id");
            cmd.Parameters.Add("id", OleDbType.VarChar, 50).Value = id;
            return m_Ds.ExecuteNoneQuery(cmd);
        }
        
        
        public DataRow NewRow()
        {
            return m_Ds.NewRow();
        }
        public void Add(DataRow row)
        {
            m_Ds.Rows.Add(row);
        }
        public bool Save()
        {
               
           return m_Ds.ExecuteNoneQuery() > 0;
        }
    }
}
