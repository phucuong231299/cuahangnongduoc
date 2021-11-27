using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace CuahangNongduoc.DataLayer
{
    class NhanVienFactory
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachNhanVien()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NHAN_VIEN");
            m_Ds.Load(cmd);
            return m_Ds;
        }
        public void dangnhap(string tdn,string mk)
        {
            SqlParameter[] arr = new SqlParameter[2];
            arr[0] = new SqlParameter("@TEN_DANG_NHAP", tdn);
            arr[1] = new SqlParameter("@MAT_KHAU", mk);
           // SqlDataReader rd=sqlh



            //OleDbCommand cmd = new OleDbCommand("SELECT * FROM NHAN_VIEN WHERE TEN_DANG_NHAP = @tdn and MAT_KHAU=@mk");
            //cmd.Parameters.Add("tdn", OleDbType.VarChar, 50).Value = tdn;
            //cmd.Parameters.Add("mk", OleDbType.VarChar, 50).Value = mk;
            //m_Ds.Load(cmd).


        }

        public DataTable TimMaNhanVien(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NHAN_VIEN WHERE HO_VA_TEN LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;
            m_Ds.Load(cmd);
            return m_Ds;
        }
        public DataTable TimTenNhanVien(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM SAN_PHAM WHERE TEN_SAN_PHAM LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarChar).Value = ten;
            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable LaySanPham(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM SAN_PHAM WHERE ID = @id");
            cmd.Parameters.Add("id", OleDbType.VarChar, 50).Value = id;
            m_Ds.Load(cmd);
            return m_Ds;
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
