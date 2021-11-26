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
    public partial class frmDanhsachPhieuNhap : Form
    {
        public frmDanhsachPhieuNhap()
        {
            InitializeComponent();
        }

        PhieuNhapController ctrl = new PhieuNhapController();
        NhaCungCapController ctrlNCC = new NhaCungCapController();

        private void frmDanhsachPhieuNhap_Load(object sender, EventArgs e)
        {
            ctrlNCC.HienthiDataGridviewComboBox(colNhaCungCap);
            ctrl.HienthiPhieuNhap(bindingNavigator, dataGridView);
        }
        frmNhapHang NhapHang = null;
        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (NhapHang == null || NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang(ctrl);
                NhapHang.Show();
            }
            else
                NhapHang.Activate();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (NhapHang == null || NhapHang.IsDisposed)
            {
                NhapHang = new frmNhapHang();
                NhapHang.Show();
            }
            else
                NhapHang.Activate();
        }

        private void toolIn_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigator.BindingSource.Current;
            if (row != null)
            {
                PhieuNhapController ctrlPN = new PhieuNhapController();
                String ma_phieu = row["ID"].ToString();
                CuahangNongduoc.BusinessObject.PhieuNhap ph =  ctrlPN.LayPhieuNhap(ma_phieu);
                frmInPhieuNhap PhieuNhap = new frmInPhieuNhap(ph);
                PhieuNhap.Show();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Phieu Nhap", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator.BindingSource.RemoveCurrent();
                ctrl.Save();
            }
        }

        private void toolTimKiem_Click(object sender, EventArgs e)
        {
            
            frmTimPhieuNhap TimPhieu = new frmTimPhieuNhap();
            Point p = PointToScreen(toolTimKiem.Bounds.Location);
            p.X += toolTimKiem.Width;
            p.Y += toolTimKiem.Height;
            TimPhieu.Location = p;
            TimPhieu.ShowDialog();
            if (TimPhieu.DialogResult == DialogResult.OK)
            {
                ctrl.TimPhieuNhap(TimPhieu.cmbNCC.SelectedValue.ToString(), TimPhieu.dtNgayNhap.Value.Date);
            }
        }
    }
}