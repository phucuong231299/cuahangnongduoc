using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuahangNongduoc
{
    public partial class frmDaiLy : Form
    {
        CuahangNongduoc.Controller.KhachHangController ctrl = new CuahangNongduoc.Controller.KhachHangController();
        public frmDaiLy()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

            ctrl.HienthiDaiLyDataGridview(dataGridView, bindingNavigator);
        }

        private void toolLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            ctrl.Save();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            long maso = ThamSo.KhachHang;
            ThamSo.KhachHang = maso + 1;

            DataRowView row = (DataRowView)bindingNavigator.BindingSource.AddNew();
            row["ID"] = maso;
        }

        private void toolThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Dai Ly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator.BindingSource.RemoveCurrent();
            }
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Dai Ly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolTimHoTen_Click(object sender, EventArgs e)
        {
            toolTimDiaChi.Checked = !toolTimDiaChi.Checked;
            toolTimHoTen.Checked = !toolTimDiaChi.Checked;
            toolTimKhachHang.Text = "Tìm theo Họ tên";
            bindingNavigator.Focus();
        }

        private void toolTimDiaChi_Click(object sender, EventArgs e)
        {
            toolTimHoTen.Checked = !toolTimHoTen.Checked;
            toolTimDiaChi.Checked = !toolTimHoTen.Checked;
            toolTimKhachHang.Text = "Tìm theo Địa chỉ";
            bindingNavigator.Focus();
        }

        private void toolTimKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (toolTimHoTen.Checked)
                    ctrl.TimHoTen(toolTimKhachHang.Text, true);
                else
                    ctrl.TimDiaChi(toolTimKhachHang.Text, true);
            }
        }

        private void toolTimKhachHang_Leave(object sender, EventArgs e)
        {
            if (toolTimHoTen.Checked == true)
                toolTimKhachHang.Text = "Tìm theo Họ tên";
            else
                toolTimKhachHang.Text = "Tìm theo Địa chỉ";

            toolTimKhachHang.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void toolTimKhachHang_Enter(object sender, EventArgs e)
        {
            toolTimKhachHang.Text = "";
            toolTimKhachHang.ForeColor = Color.Black;
        }
    }
}