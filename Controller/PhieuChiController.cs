using System;
using System.Collections.Generic;
using System.Text;
using CuahangNongduoc.DataLayer;
using CuahangNongduoc.BusinessObject;
using System.Windows.Forms;
using System.Data;

namespace CuahangNongduoc.Controller
{
    
    public class PhieuChiController
    {
        PhieuChiFactory factory = new PhieuChiFactory();


        public DataRow NewRow()
        {
            return factory.NewRow();
        }
        public void Add(DataRow row)
        {
            factory.Add(row);
        }
        public void Save()
        {
            factory.Save();
        }

        public PhieuChi LayPhieuChi(String id)
        {
            PhieuChi ph = null;
            DataTable tbl = factory.LayPhieuChi(id);
            if (tbl.Rows.Count > 0 )
            {
                ph = new PhieuChi();
                ph.Id = Convert.ToString(tbl.Rows[0]["ID"]);
                LyDoChiController ctrlLyDo = new LyDoChiController();
                ph.LyDoChi = ctrlLyDo.LayLyDoChi(Convert.ToInt64(tbl.Rows[0]["ID_LY_DO_CHI"]));
                ph.NgayChi = Convert.ToDateTime(tbl.Rows[0]["NGAY_CHI"]);
                ph.TongTien = Convert.ToInt64(tbl.Rows[0]["TONG_TIEN"]);
                ph.GhiChu = Convert.ToString(tbl.Rows[0]["GHI_CHU"]);
            }
            return ph;
        }
        
        public void HienthiPhieuChi(BindingNavigator bn, DataGridView dg,ComboBox cmb, TextBox txt, DateTimePicker dt, NumericUpDown numTongTien, TextBox txtGhichu)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = factory.DanhsachPhieuChi();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            
            txt.DataBindings.Clear();
            txt.DataBindings.Add("Text", bs, "ID");

            cmb.DataBindings.Clear();
            cmb.DataBindings.Add("SelectedValue", bs, "ID_LY_DO_CHI");

            dt.DataBindings.Clear();
            dt.DataBindings.Add("Value", bs, "NGAY_CHI");

            numTongTien.DataBindings.Clear();
            numTongTien.DataBindings.Add("Value", bs, "TONG_TIEN");

            txtGhichu.DataBindings.Clear();
            txtGhichu.DataBindings.Add("Text", bs, "GHI_CHU");


        }

        public void TimPhieuChi(BindingNavigator bn, DataGridView dg, ComboBox cmb, TextBox txt, DateTimePicker dt, NumericUpDown numTongTien, TextBox txtGhichu,
            int lydo, DateTime ngay)
        {
            
            BindingSource bs = new BindingSource();
            bs.DataSource = factory.TimPhieuChi(lydo, ngay);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txt.DataBindings.Clear();
            txt.DataBindings.Add("Text", bs, "ID");

            cmb.DataBindings.Clear();
            cmb.DataBindings.Add("SelectedValue", bs, "ID_LY_DO_CHI");

            dt.DataBindings.Clear();
            dt.DataBindings.Add("Value", bs, "NGAY_CHI");

            numTongTien.DataBindings.Clear();
            numTongTien.DataBindings.Add("Value", bs, "TONG_TIEN");

            txtGhichu.DataBindings.Clear();
            txtGhichu.DataBindings.Add("Text", bs, "GHI_CHU");
        }
    }
}
