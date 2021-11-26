using System;
using System.Collections.Generic;
using System.Text;
using CuahangNongduoc.DataLayer;
using CuahangNongduoc.BusinessObject;
using System.Windows.Forms;
using System.Data;

namespace CuahangNongduoc.Controller
{
    
    public class ChiTietPhieuNhapController
    {
        ChiTietPhieuNhapFactory factory = new ChiTietPhieuNhapFactory();


        public void ThemChiTietPhieuNhap(String idPhieuNhap, String idMaSP)
        {
            factory.LoadSchema();
            DataRow row = factory.NewRow();
            row["ID_PHIEU_NHAP"] = idPhieuNhap;
            row["ID_MA_SAN_PHAM"] = idMaSP;
             
            factory.Add(row);
            factory.Save();
        }
        public int XoaChiTietPhieuNhap(String idPhieuNhap)
        {
            return factory.XoaChiTietPhieuNhap(idPhieuNhap);
        }

        public void HienThiChiTietPhieuNhap(String id, ListView lvw)
        {
            MaSanPhamController ctrlMSP = new MaSanPhamController();
            PhieuNhapController ctrlPN = new PhieuNhapController();
            DataTable tbl = factory.LayChiTietPhieuNhap(id);

            lvw.Items.Clear();
            foreach (DataRow row in tbl.Rows)
            {
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
                ct.MaSanPham = ctrlMSP.LayMaSanPham(Convert.ToString(row["ID_MA_SAN_PHAM"]));
                ct.PhieuNhap = ctrlPN.LayPhieuNhap(Convert.ToString((row["ID_PHIEU_NHAP"])));

                ListViewItem item = new ListViewItem(Convert.ToString(lvw.Items.Count + 1));
                item.SubItems.Add(ct.MaSanPham.SanPham.TenSanPham);
                item.SubItems.Add(ct.MaSanPham.Id);
                item.SubItems.Add(ct.MaSanPham.GiaNhap.ToString("#,###0"));
                item.SubItems.Add(ct.MaSanPham.SoLuong.ToString("#,###0"));
                long thanhtien = (ct.MaSanPham.SoLuong + ct.MaSanPham.GiaNhap);
                item.SubItems.Add(thanhtien.ToString("#,###0"));
                item.SubItems.Add(ct.MaSanPham.NgaySanXuat.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ct.MaSanPham.NgayHetHan.ToString("dd/MM/yyyy"));
                
                item.Tag = ct;
                lvw.Items.Add(item);
            }
        }
    }
}
