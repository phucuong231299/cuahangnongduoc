using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace CuahangNongduoc
{
    public enum Controll
    {
        Normal,
        AddNew,
        Edit
    }
    public class ThamSo
    {
        public static void PreMonth(ref int thangtruoc, ref int namtruoc, int thang, int nam)
        {
            thangtruoc = thang - 1;
            namtruoc = nam;
            if (thangtruoc == 0)
            {
                thangtruoc = 12;
                namtruoc= nam - 1;
            }
        }

        public static bool LaSoNguyen(String so)
        {
            try
            {
                Convert.ToInt64(so);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static long LayMaPhieuNhap()
        {
            DataService ds = new DataService();
            object obj = ds.ExecuteScalar(new OleDbCommand("SELECT PHIEU_NHAP FROM THAM_SO"));
            return Convert.ToInt64(obj);
        }
        public static void GanMaPhieuNhap(long id)
        {
            DataService ds = new DataService();
            ds.ExecuteNoneQuery(new OleDbCommand("UPDATE THAM_SO SET PHIEU_NHAP = " + id));
            
        }

        public static long LayMaPhieuBan()
        {
            DataService ds = new DataService();
            object obj = ds.ExecuteScalar(new OleDbCommand("SELECT PHIEU_BAN FROM THAM_SO"));
            return Convert.ToInt64(obj);
        }
        public static void GanMaPhieuBan(long id)
        {
            DataService ds = new DataService();
            ds.ExecuteNoneQuery(new OleDbCommand("UPDATE THAM_SO SET PHIEU_BAN = " + id));

        }

        public static long LayMaPhieuThanhToan()
        {
            DataService ds = new DataService();
            object obj = ds.ExecuteScalar(new OleDbCommand("SELECT PHIEU_THANH_TOAN FROM THAM_SO"));
            return Convert.ToInt64(obj);
        }
        public static void GanMaPhieuThanhToan(long id)
        {
            DataService ds = new DataService();
            ds.ExecuteNoneQuery(new OleDbCommand("UPDATE THAM_SO SET PHIEU_THANH_TOAN = " + id));

        }



        public static long SanPham
        {
            get 
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT SAN_PHAM FROM THAM_SO"));
                return Convert.ToInt64(obj);
            }
            set 
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE THAM_SO SET SAN_PHAM = " + value));
            }
        }
	
        
        public static CuahangNongduoc.BusinessObject.CuaHang LayCuaHang()
        {
            CuahangNongduoc.BusinessObject.CuaHang ch = new CuahangNongduoc.BusinessObject.CuaHang();
            DataService ds = new DataService();
            ds.Load(new OleDbCommand("SELECT TEN_CUA_HANG, DIA_CHI, DIEN_THOAI FROM THAM_SO"));
            if (ds.Rows.Count > 0)
            {
                ch.TenCuaHang = ds.Rows[0]["TEN_CUA_HANG"].ToString();
                ch.DiaChi = ds.Rows[0]["DIA_CHI"].ToString();
                ch.DienThoai = ds.Rows[0]["DIEN_THOAI"].ToString();
            }
            return ch;
        }
        public static void GanCuaHang(String ten_cua_hang, String dia_chi , String dien_thoai)
        {
            DataService ds = new DataService();
            OleDbCommand cmd = new OleDbCommand("UPDATE THAM_SO SET TEN_CUA_HANG = @ten_cua_hang, DIA_CHI = @dia_chi, DIEN_THOAI = @dien_thoai ");
            cmd.Parameters.Add("@ten_cua_hang", OleDbType.VarChar).Value = ten_cua_hang;
            cmd.Parameters.Add("@dia_chi", OleDbType.VarChar).Value = dia_chi;
            cmd.Parameters.Add("@dien_thoai", OleDbType.VarChar).Value = dien_thoai;

            ds.ExecuteNoneQuery(cmd);
        }

        

        public static long NhaCungCap
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT NHA_CUNG_CAP FROM THAM_SO"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE THAM_SO SET NHA_CUNG_CAP = " + value));
            }
        }

        public static long KhachHang
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT KHACH_HANG FROM THAM_SO"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE THAM_SO SET KHACH_HANG = " + value));
            }
        }

        public static long PhieuChi
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT PHIEU_CHI FROM THAM_SO"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE THAM_SO SET PHIEU_CHI = " + value));
            }
        }

       
    }
}
