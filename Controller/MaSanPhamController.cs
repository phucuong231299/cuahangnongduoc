using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using CuahangNongduoc.DataLayer;
using CuahangNongduoc.BusinessObject;

namespace CuahangNongduoc.Controller
{
    public class MaSanPhamController
    {
        MaSanPhanFactory factory = new MaSanPhanFactory();

        public DataRow NewRow()
        {
            return factory.NewRow();
        }
        public void Add(DataRow row)
        {
            factory.Add(row);
        }
        public bool Save()
        {
            return factory.Save();
        }

        public SanPham LaySanPham(String idMaSanPham)
        {
            MaSanPhanFactory f = new MaSanPhanFactory();
            DataTable tbl = f.LaySanPham(idMaSanPham);
            SanPham sp = null;
            DonViTinhController ctrlDVT = new DonViTinhController();
            if (tbl.Rows.Count > 0)
            {
                sp =  new  SanPham();
                sp.Id = Convert.ToString(tbl.Rows[0]["ID"]);
                sp.TenSanPham = Convert.ToString(tbl.Rows[0]["TEN_SAN_PHAM"]);
                sp.SoLuong = Convert.ToInt32(tbl.Rows[0]["SO_LUONG"]);
                sp.DonGiaNhap = Convert.ToInt64(tbl.Rows[0]["DON_GIA_NHAP"]);
                sp.GiaBanLe = Convert.ToInt64(tbl.Rows[0]["GIA_BAN_LE"]);
                sp.GiaBanSi = Convert.ToInt64(tbl.Rows[0]["GIA_BAN_SI"]);
                sp.DonViTinh = ctrlDVT.LayDVT(Convert.ToInt32(tbl.Rows[0]["ID_DON_VI_TINH"]));
            }
            return sp;

        }


        public MaSanPham LayMaSanPham(String idMaSanPham)
        {
            MaSanPhanFactory f = new MaSanPhanFactory();
            DataTable tbl = f.LayMaSanPham(idMaSanPham);
            MaSanPham sp = null;
            SanPhamController ctrlSanPham = new SanPhamController();
            if (tbl.Rows.Count > 0)
            {
                sp = new MaSanPham();
                sp.Id = Convert.ToString(tbl.Rows[0]["ID"]);
                sp.SoLuong = Convert.ToInt32(tbl.Rows[0]["SO_LUONG"]);
                sp.GiaNhap = Convert.ToInt64(tbl.Rows[0]["DON_GIA_NHAP"]);
                sp.NgayNhap = Convert.ToDateTime(tbl.Rows[0]["NGAY_NHAP"]);
                sp.NgaySanXuat = Convert.ToDateTime(tbl.Rows[0]["NGAY_SAN_XUAT"]);
                sp.NgayHetHan = Convert.ToDateTime(tbl.Rows[0]["NGAY_HET_HAN"]);
                sp.SanPham = ctrlSanPham.LaySanPham(tbl.Rows[0]["ID_SAN_PHAM"].ToString());
                
            }
            return sp;

        }

        public static IList<MaSanPham> LayMaSanPhamHetHan(DateTime dt)
        {
            IList<MaSanPham> ds = new List<MaSanPham>();
            MaSanPhanFactory f = new MaSanPhanFactory();
            DataTable tbl = f.DanhsachMaSanPhamHetHan(dt);

            MaSanPham sp = null;
            SanPhamController ctrlSanPham = new SanPhamController();
            foreach  ( DataRow row in tbl.Rows)
            {
                sp = new MaSanPham();
                sp.Id = Convert.ToString(row["ID"]);
                sp.SoLuong = Convert.ToInt32(row["SO_LUONG"]);
                sp.GiaNhap = Convert.ToInt64(row["DON_GIA_NHAP"]);
                sp.NgayNhap = Convert.ToDateTime(row["NGAY_NHAP"]);
                sp.NgaySanXuat = Convert.ToDateTime(row["NGAY_SAN_XUAT"]);
                sp.NgayHetHan = Convert.ToDateTime(row["NGAY_HET_HAN"]);
                sp.SanPham = ctrlSanPham.LaySanPham(row["ID_SAN_PHAM"].ToString());
                ds.Add(sp);
            }
            return ds;

        }

        public void HienThiAutoComboBox(String sp, ComboBox cmb)
        {
            cmb.DataSource = factory.DanhsachMaSanPham(sp);
            cmb.DisplayMember = "ID";
            cmb.ValueMember = "ID";
        }

        public void HienThiDataGridViewComboBox(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = factory.DanhsachMaSanPham();
            cmb.DisplayMember = "ID";
            cmb.ValueMember = "ID";
            cmb.DataPropertyName = "ID_MA_SAN_PHAM";
            cmb.HeaderText = "Mã sản phẩm";
        }

        public void HienThiChiTietPhieuNhap(String id, DataGridView dg)
        {
            
            dg.DataSource = factory.DanhsachChiTiet(id);
        }
        public IList<MaSanPham> ChiTietPhieuNhap(String id)
        {
            SanPhamController ctrlSanPham = new SanPhamController();
            IList<MaSanPham> ds = new List<MaSanPham>();
            DataTable tbl = factory.DanhsachChiTiet(id);
            foreach (DataRow row in tbl.Rows)
            {
                MaSanPham sp = new MaSanPham();
                sp = new MaSanPham();
                sp.Id = Convert.ToString(row["ID"]);
                sp.SoLuong = Convert.ToInt32(row["SO_LUONG"]);
                sp.GiaNhap = Convert.ToInt64(row["DON_GIA_NHAP"]);
                sp.ThanhTien = sp.SoLuong * sp.GiaNhap;
                sp.NgayNhap = Convert.ToDateTime(row["NGAY_NHAP"]);
                sp.NgaySanXuat = Convert.ToDateTime(row["NGAY_SAN_XUAT"]);
                sp.NgayHetHan = Convert.ToDateTime(row["NGAY_HET_HAN"]);
                sp.SanPham = ctrlSanPham.LaySanPham(row["ID_SAN_PHAM"].ToString());
                ds.Add(sp);
            }
            return ds;
        }

    }
}
