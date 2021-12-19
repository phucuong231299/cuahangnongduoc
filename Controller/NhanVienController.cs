using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using CuahangNongduoc.BusinessObject;
using CuahangNongduoc.DataLayer;

namespace CuahangNongduoc.Controller
{
    class NhanVienController
    {
        NhanVienFactory factory = new NhanVienFactory();
        public void HienthiAutoComboBox(System.Windows.Forms.ComboBox cmb)
        {
            DataTable tbl = factory.DanhsachNhanVien();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TEN_SAN_PHAM";
            cmb.ValueMember = "ID";
            cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }
        public void HienthiDataGridViewComboBoxColumn(System.Windows.Forms.DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = factory.DanhsachNhanVien();
            cmb.DisplayMember = "HO_VA_TEN";
            cmb.ValueMember = "ID";
            cmb.AutoComplete = true;
        }
        public void TimMaNhanVien(String ma)
        {
            factory.TimMaNhanVien(ma);
        }
       
        public Boolean dangnhap(String tdn,string mk)
        {
           return factory.dangnhap(tdn,mk);
        }
        public void TimTenNhanVien(String ten)
        {
            factory.TimTenNhanVien(ten);
        }

        public void HienthiDataGridview(System.Windows.Forms.DataGridView dg, System.Windows.Forms.BindingNavigator bn,
            TextBox txtmanv, TextBox txttennv, TextBox txttendanhnhap, TextBox matkhau)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            bs.DataSource = factory.DanhsachNhanVien();

            txtmanv.DataBindings.Clear();
            txtmanv.DataBindings.Add("text", bs, "ID");

            txttennv.DataBindings.Clear();
            txttennv.DataBindings.Add("Text", bs, "HO_VA_TEN");

            txttendanhnhap.DataBindings.Clear();
            txttendanhnhap.DataBindings.Add("TEXT", bs, "TEN_DANG_NHAP");

            matkhau.DataBindings.Clear();
            matkhau.DataBindings.Add("TEXT", bs, "MAT_KHAU");

            


            bn.BindingSource = bs;
            dg.DataSource = bs;


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
