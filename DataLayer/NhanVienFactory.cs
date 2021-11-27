using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;



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
        public Boolean dangnhap(string tdn,string mk)
        {
            

            Boolean tam;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=cuahang.dll;");
            string sql = "select *from NHAN_VIEN where TEN_DANG_NHAP='" + tdn + "' AND MAT_KHAU='" + mk + "'";
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText= "select * from NHAN_VIEN where TEN_DANG_NHAP = '" + tdn + "' AND MAT_KHAU = '" + mk + "'";
            OleDbDataReader rd= cmd.ExecuteReader();
            int c = 0;
            while (rd.Read())
            {
                c += 1;
                c++;
            }
            if (c > 0)
            {
                return tam = true;
            }
            else
            {
                return tam = false;
            }
            return tam;



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
