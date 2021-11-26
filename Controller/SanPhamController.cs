using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using CuahangNongduoc.BusinessObject;
using CuahangNongduoc.DataLayer;


namespace CuahangNongduoc.Controller
{
    public class SanPhamController
    {
        SanPhamFactory factory = new SanPhamFactory();

        public void HienthiAutoComboBox(System.Windows.Forms.ComboBox cmb)
        {
            DataTable tbl = factory.DanhsachSanPham(); 
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TEN_SAN_PHAM";
            cmb.ValueMember = "ID";
            cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }
        public void HienthiDataGridViewComboBoxColumn(System.Windows.Forms.DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = factory.DanhsachSanPham();
            cmb.DisplayMember = "TEN_SAN_PHAM";
            cmb.ValueMember = "ID";
            cmb.AutoComplete = true;
        }
        public void TimMaSanPham(String ma)
        {
            factory.TimMaSanPham(ma);
        }
        public void TimTenSanPham(String ten)
        {
            factory.TimTenSanPham(ten);
        }

        public void HienthiDataGridview(System.Windows.Forms.DataGridView dg, System.Windows.Forms.BindingNavigator bn,
            TextBox txtMaSp, TextBox txtTenSp, ComboBox cmbDVT, NumericUpDown numSL, NumericUpDown numDonGiaNhap, NumericUpDown numGiaBanSi, NumericUpDown numGiaBanLe)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            bs.DataSource = factory.DanhsachSanPham();
            
            txtMaSp.DataBindings.Clear();
            txtMaSp.DataBindings.Add("Text", bs, "ID");

            txtTenSp.DataBindings.Clear();
            txtTenSp.DataBindings.Add("Text", bs, "TEN_SAN_PHAM");

            cmbDVT.DataBindings.Clear();
            cmbDVT.DataBindings.Add("SelectedValue", bs, "ID_DON_VI_TINH");

            numSL.DataBindings.Clear();
            numSL.DataBindings.Add("Value", bs, "SO_LUONG");

            numDonGiaNhap.DataBindings.Clear();
            numDonGiaNhap.DataBindings.Add("Value", bs, "DON_GIA_NHAP");

            numGiaBanSi.DataBindings.Clear();
            numGiaBanSi.DataBindings.Add("Value", bs, "GIA_BAN_SI");

            numGiaBanLe.DataBindings.Clear();
            numGiaBanLe.DataBindings.Add("Value", bs, "GIA_BAN_LE");
            bn.BindingSource = bs;
            dg.DataSource = bs;

            
        }
        public void CapNhatGiaNhap(String id, long gia_moi ,long so_luong)
        {
            DataTable tbl = factory.LaySanPham(id);
            if (tbl.Rows.Count > 0)
            {
                long tong_so = Convert.ToInt32(tbl.Rows[0]["SO_LUONG"]);
                long tong_gia = Convert.ToInt64(tbl.Rows[0]["DON_GIA_NHAP"]);
                if (tong_gia != gia_moi)
                {
                    long thanh_tien = gia_moi * so_luong + tong_gia * tong_so;
                    tong_so += so_luong;
                    tbl.Rows[0]["DON_GIA_NHAP"] = thanh_tien / tong_so;
                    tbl.Rows[0]["SO_LUONG"] = tong_so;
                }
                factory.Save();
            }

        }
    
        public SanPham LaySanPham(String id)
        {
            DataTable tbl = factory.LaySanPham(id);
            SanPham sp = new SanPham();
            DonViTinhController ctrlDVT = new DonViTinhController();
            if (tbl.Rows.Count > 0)
            {
                sp.Id = Convert.ToString(tbl.Rows[0]["ID"]);
                sp.TenSanPham =  Convert.ToString(tbl.Rows[0]["TEN_SAN_PHAM"]);
                sp.SoLuong = Convert.ToInt32(tbl.Rows[0]["SO_LUONG"]);
                sp.DonGiaNhap = Convert.ToInt64(tbl.Rows[0]["DON_GIA_NHAP"]);
                sp.GiaBanLe = Convert.ToInt64(tbl.Rows[0]["GIA_BAN_LE"]);
                sp.GiaBanSi = Convert.ToInt64(tbl.Rows[0]["GIA_BAN_SI"]);
                sp.DonViTinh = ctrlDVT.LayDVT(Convert.ToInt32(tbl.Rows[0]["ID_DON_VI_TINH"]));
            }
            return sp;

        }

        public static IList<SoLuongTon> LaySoLuongTon()
        {
            SanPhamFactory f = new SanPhamFactory();
            DataTable tbl = f.LaySoLuongTon();

            IList<SoLuongTon> ds = new List<SoLuongTon>();
            

            DonViTinhController ctrlDVT = new DonViTinhController();
            foreach(DataRow row in tbl.Rows)
            {
                SoLuongTon slt = new SoLuongTon();
                SanPham sp = new SanPham();
                sp.Id = Convert.ToString(row["ID"]);
                sp.TenSanPham = Convert.ToString(row["TEN_SAN_PHAM"]);
                sp.SoLuong = Convert.ToInt32(row["SO_LUONG"]);
                sp.DonGiaNhap = Convert.ToInt64(row["DON_GIA_NHAP"]);
                sp.GiaBanLe = Convert.ToInt64(row["GIA_BAN_LE"]);
                sp.GiaBanSi = Convert.ToInt64(row["GIA_BAN_SI"]);
                sp.DonViTinh = ctrlDVT.LayDVT(Convert.ToInt32(row["ID_DON_VI_TINH"]));
                slt.SanPham = sp;
                slt.SoLuong = Convert.ToInt32(row["SO_LUONG_TON"]);
                ds.Add(slt);
            }
            return ds;

        }

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
    }
}
