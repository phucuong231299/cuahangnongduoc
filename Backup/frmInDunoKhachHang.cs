using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuahangNongduoc
{
    public partial class frmInDunoKhachHang : Form
    {
        CuahangNongduoc.BusinessObject.DuNoKhachHang m_DuNo;
        public frmInDunoKhachHang(CuahangNongduoc.BusinessObject.DuNoKhachHang  dn)
        {
            InitializeComponent();
            m_DuNo = dn;
        }

        private void frmInDunoKhachHang_Load(object sender, EventArgs e)
        {
            Num2Str num = new Num2Str();
            IList<Microsoft.Reporting.WinForms.ReportParameter> param = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            CuahangNongduoc.BusinessObject.CuaHang ch = ThamSo.LayCuaHang();
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("ten_cua_hang", ch.TenCuaHang));
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("dia_chi", ch.DiaChi));
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("dien_thoai", ch.DienThoai));

            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("bang_chu", num.NumberToString(m_DuNo.CuoiKy.ToString())));

            this.reportViewer.LocalReport.SetParameters(param);
            this.DuNoKhachHangBindingSource.DataSource = m_DuNo;
            this.reportViewer.RefreshReport();
        }
    }
}