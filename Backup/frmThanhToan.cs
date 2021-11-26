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
    public partial class frmThanhToan : Form
    {
        KhachHangController ctrlKH = new KhachHangController();
        PhieuThanhToanController ctrl = new PhieuThanhToanController();
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            ctrlKH.HienthiChungAutoComboBox(cmbKhachHang);
            ctrlKH.HienthiKhachHangChungDataGridviewComboBox(colKhachHang);
            ctrl.HienthiPhieuThanhToan(bindingNavigator, dataGridView, cmbKhachHang, txtMaPhieu, dtNgayThanhToan, numTongTien, txtGhiChu);
            bindingNavigator.BindingSource.AddingNew += new AddingNewEventHandler(BindingSource_AddingNew);
        }

        void BindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            long maphieu = ThamSo.LayMaPhieuThanhToan();;
            ThamSo.GanMaPhieuThanhToan(maphieu+1);

            DataRow row = ctrl.NewRow();
            row["ID"] = maphieu;
            row["NGAY_THANH_TOAN"] = DateTime.Now.Date;
            row["TONG_TIEN"] = numTongTien.Value;
            ctrl.Add(row);
            bindingNavigator.BindingSource.MoveLast();
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa phiếu thanh toán này không?", "Phieu Thanh Toan",   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa phiếu thanh toán này không?", "Phieu Thanh Toan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator.BindingSource.RemoveCurrent();
                ctrl.Save();
            }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Focus();
            bindingNavigator.BindingSource.MoveNext();
            ctrl.Save();
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void toolIn_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)bindingNavigator.BindingSource.Current;
            if (row != null)
            {
                PhieuThanhToanController ctrlTT = new PhieuThanhToanController();
                String ma_phieu = row["ID"].ToString();
                CuahangNongduoc.BusinessObject.PhieuThanhToan ph = ctrlTT.LayPhieuThanhToan(ma_phieu);
                frmInPhieuThanhToan PhieuThanhToan = new frmInPhieuThanhToan(ph);
                PhieuThanhToan.Show();
            }
        }

        private void toolTimKiem_Click(object sender, EventArgs e)
        {
            frmTimPhieuThu Tim = new frmTimPhieuThu();
            Point p = PointToScreen(toolTimKiem.Bounds.Location);
            p.X += toolTimKiem.Width;
            p.Y += toolTimKiem.Height;
            Tim.Location = p;
            Tim.ShowDialog();
            if (Tim.DialogResult == DialogResult.OK)
            {
                ctrl.TimPhieuThanhToan(bindingNavigator, dataGridView, cmbKhachHang, txtMaPhieu, dtNgayThanhToan, numTongTien, txtGhiChu,
                    Tim.cmbKhachHang.SelectedValue.ToString(), Tim.dtNgayThu.Value.Date);
            }
        }

    }
}