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
    public partial class frmTimPhieuBanLe : Form
    {
        public frmTimPhieuBanLe()
        {
            InitializeComponent();
        }
        public frmTimPhieuBanLe(bool loai):this()
        {
            KhachHangController ctrlKH = new KhachHangController();
            ctrlKH.HienthiAutoComboBox(cmbNCC, loai);
        }

    }
}