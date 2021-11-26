using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuahangNongduoc
{
    public partial class frmSanphamHethan : Form
    {
        public frmSanphamHethan()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<CuahangNongduoc.BusinessObject.MaSanPham> data = CuahangNongduoc.Controller.MaSanPhamController.LayMaSanPhamHetHan(dt.Value.Date);
            IList<Microsoft.Reporting.WinForms.ReportParameter> param = new List<Microsoft.Reporting.WinForms.ReportParameter>();

            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("ngay_tinh", dt.Value.Date.ToString("dd/MM/yyyy")));
            this.MaSanPhamBindingSource.DataSource = data;
            this.reportViewer.LocalReport.SetParameters(param);
            this.reportViewer.RefreshReport();
        }

        private void frmSanphamHethan_Load(object sender, EventArgs e)
        {

        }
    }
}