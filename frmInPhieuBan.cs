using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuahangNongduoc
{
    public partial class frmInPhieuBan : Form
    {
        CuahangNongduoc.BusinessObject.PhieuBan m_PhieuBan;
        public frmInPhieuBan(CuahangNongduoc.BusinessObject.PhieuBan ph)
        {
            InitializeComponent();
            reportViewer.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);
            this.reportViewer.LocalReport.SubreportProcessing += new Microsoft.Reporting.WinForms.SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            m_PhieuBan = ph;
        }

        void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            e.DataSources.Clear();
            e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("CuahangNongduoc_BusinessObject_ChiTietPhieuBan", m_PhieuBan.ChiTiet));
        }

        private void frmInPhieuBan_Load(object sender, EventArgs e)
        {
            Num2Str num = new Num2Str();
            IList<Microsoft.Reporting.WinForms.ReportParameter> param = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            CuahangNongduoc.BusinessObject.CuaHang ch = ThamSo.LayCuaHang();
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("ten_cua_hang", ch.TenCuaHang));
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("dia_chi", ch.DiaChi));
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("dien_thoai", ch.DienThoai));
            param.Add(new Microsoft.Reporting.WinForms.ReportParameter("bang_chu", num.NumberToString(m_PhieuBan.TongTien.ToString())));

            this.reportViewer.LocalReport.SetParameters(param);
            this.PhieuBanBindingSource.DataSource = m_PhieuBan;
            this.reportViewer.RefreshReport();
        }
    }
}