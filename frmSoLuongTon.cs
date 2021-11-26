using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuahangNongduoc
{
    public partial class frmSoLuongTon : Form
    {
        public frmSoLuongTon()
        {
            InitializeComponent();
        }

        private void frmSoLuongTon_Load(object sender, EventArgs e)
        {
            IList<CuahangNongduoc.BusinessObject.SoLuongTon> data = CuahangNongduoc.Controller.SanPhamController.LaySoLuongTon();
            this.SoLuongTonBindingSource.DataSource = data;
            this.reportViewer.RefreshReport();
        }
    }
}