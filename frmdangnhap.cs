using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CuahangNongduoc.Controller;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace CuahangNongduoc
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        NhanVienController ctrl = new NhanVienController();

        private void button2_Click(object sender, EventArgs e)
        {

        }

        frmMain m = null;
        private void btndn_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=cuahang.dll;");
            OleDbDataAdapter da = new OleDbDataAdapter("select * from NHAN_VIEN where TEN_DANG_NHAP='" + txttendn.Text + "' and MAT_KHAU ='" + txtmk.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                frmMain FM = new frmMain();
                frmDanhsachPhieuBanLe bl = new frmDanhsachPhieuBanLe();
                MessageBox.Show("Chào mừng bạn đến với shop");
                this.Hide();
                FM = new frmMain(dt.Rows[0][1].ToString(), dt.Rows[0][4].ToString());
                bl = new frmDanhsachPhieuBanLe(dt.Rows[0][4].ToString());
                // hd = new frm_dmChiTietHoaDon(dt.Rows[0][4].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][0].ToString());
                FM.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                return;
            }
            //if (ctrl.dangnhap(txttendn.Text, txtmk.Text))
            //{



            //    MessageBox.Show("Đăng nhập thành công");

            //    if (m == null || m.IsDisposed)
            //    {
            //        this.Hide();
            //        m = new frmMain();
            //        m.Show();
            //    }
            //    else
            //        m.Activate();


            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            //}

        }
    }
}
