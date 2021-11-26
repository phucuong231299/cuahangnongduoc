using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuahangNongduoc
{
    public partial class frmInPhieuThanhToan : Form
    {
        CuahangNongduoc.BusinessObject.PhieuThanhToan m_PhieuThanhToan;
        public frmInPhieuThanhToan(CuahangNongduoc.BusinessObject.PhieuThanhToan ph)
        {
            InitializeComponent();
            m_PhieuThanhToan = ph;
        }

        private void frmPhieuThanhToan_Load(object sender, EventArgs e)
        {
            Num2Str num = new Num2Str();
            IList<Microsoft.Reporting.WinForms.ReportParameter> param = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            CuahangNongduoc.BusinessObject.CuaHang ch = ThamSo.LayCuaHang();
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("ten_cua_hang", ch.TenCuaHang));
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("dia_chi", ch.DiaChi));
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("dien_thoai", ch.DienThoai));

            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("bang_chu", num.NumberToString(m_PhieuThanhToan.TongTien.ToString())));

            this.reportViewer.LocalReport.SetParameters(param);
            this.PhieuThanhToanBindingSource.DataSource = m_PhieuThanhToan; 
            this.reportViewer.RefreshReport();
        }
    }
}