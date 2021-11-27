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
            if (ctrl.dangnhap(txttendn.Text, txtmk.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
               
                if (m == null || m.IsDisposed)
                {
                    this.Hide();
                    m = new frmMain();
                    m.Show();
                }
                else
                    m.Activate();


            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            }
            
        }
    }
}
