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

        private void btndn_Click(object sender, EventArgs e)
        {
          ctrl.dangnhap(txttendn.Text, txtmk.Text);
            
        }
    }
}
