using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CuahangNongduoc.Controller;

namespace CuahangNongduoc
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        NhanVienController ctrl = new NhanVienController();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {


            ctrl.HienthiDataGridview(dataGridView1, bindingNavigator,
            txtmanv, txttennv, txttendn, txtmk);
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataRow row = ctrl.NewRow();
            long maso = ThamSo.NhanVien;
            ThamSo.NhanVien = maso+1;
            row["ID"] = maso;
            row["HO_VA_TEN"] = "";
            row["TEN_DANG_NHAP"] = "";
            row["MAT_KHAU"] = "";
            
            
            ctrl.Add(row);
            bindingNavigator.BindingSource.MoveLast();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            ctrl.Save();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator.BindingSource.RemoveCurrent();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
