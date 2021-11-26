using System;
using System.Collections.Generic;
using System.Text;
using CuahangNongduoc.DataLayer;
using CuahangNongduoc.BusinessObject;
using System.Windows.Forms;
using System.Data;

namespace CuahangNongduoc.Controller
{

    public class ChiTietPhieuBanController
    {
        ChiTietPhieuBanFactory factory = new ChiTietPhieuBanFactory();



        public void HienThiChiTiet(DataGridView dgv, String idPhieuBan)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = factory.LayChiTietPhieuBan(idPhieuBan);
            dgv.DataSource = bs;
        }
        public DataRow NewRow()
        {
            return factory.NewRow();
        }
        public void Add(DataRow row)
        {
            factory.Add(row);
        }
        public void Save()
        {
            factory.Save();
        }


        public IList<ChiTietPhieuBan> ChiTietPhieuBan(String idPhieuBan)
        {
            IList<ChiTietPhieuBan> ds = new List<ChiTietPhieuBan>();

            DataTable tbl = factory.LayChiTietPhieuBan(idPhieuBan);
            foreach (DataRow row in tbl.Rows)
            {
                MaSanPhamController ctrl = new MaSanPhamController();
                ChiTietPhieuBan ct = new ChiTietPhieuBan();
                ct.DonGia = Convert.ToInt64(row["DON_GIA"]);
                ct.SoLuong = Convert.ToInt32(row["SO_LUONG"]);
                ct.ThanhTien = Convert.ToInt64(row["THANH_TIEN"]);
                ct.MaSanPham = ctrl.LayMaSanPham(Convert.ToString(row["ID_MA_SAN_PHAM"]));

                ds.Add(ct);
            }
            return ds;
        }

        public IList<ChiTietPhieuBan> ChiTietPhieuBan(DateTime dtNgayBan)
        {
            IList<ChiTietPhieuBan> ds = new List<ChiTietPhieuBan>();

            DataTable tbl = factory.LayChiTietPhieuBan(dtNgayBan);
            foreach (DataRow row in tbl.Rows)
            {
                MaSanPhamController ctrl = new MaSanPhamController();
                ChiTietPhieuBan ct = new ChiTietPhieuBan();
                ct.DonGia = Convert.ToInt64(row["DON_GIA"]);
                ct.SoLuong = Convert.ToInt32(row["SO_LUONG"]);
                ct.ThanhTien = Convert.ToInt64(row["THANH_TIEN"]);
                ct.MaSanPham = ctrl.LayMaSanPham(Convert.ToString(row["ID_MA_SAN_PHAM"]));

                ds.Add(ct);
            }
            return ds;
        }
        public IList<ChiTietPhieuBan> ChiTietPhieuBan(int thang, int nam)
        {
            IList<ChiTietPhieuBan> ds = new List<ChiTietPhieuBan>();

            DataTable tbl = factory.LayChiTietPhieuBan(thang, nam);
            foreach (DataRow row in tbl.Rows)
            {
                MaSanPhamController ctrl = new MaSanPhamController();
                ChiTietPhieuBan ct = new ChiTietPhieuBan();
                ct.DonGia = Convert.ToInt64(row["DON_GIA"]);
                ct.SoLuong = Convert.ToInt32(row["SO_LUONG"]);
                ct.ThanhTien = Convert.ToInt64(row["THANH_TIEN"]);
                ct.MaSanPham = ctrl.LayMaSanPham(Convert.ToString(row["ID_MA_SAN_PHAM"]));

                ds.Add(ct);
            }
            return ds;
        }

    }
}
