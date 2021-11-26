using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CuahangNongduoc.BusinessObject;
using CuahangNongduoc.DataLayer;


namespace CuahangNongduoc.Controller
{
    public class DonViTinhController
    {
        DonViTinhFactory factory = new DonViTinhFactory();

        public void HienthiAutoComboBox(System.Windows.Forms.ComboBox cmb)
        {
            DataTable tbl = factory.DanhsachDVT();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TEN_DON_VI";
            cmb.ValueMember = "ID";
        }
        public System.Windows.Forms.DataGridViewComboBoxColumn HienthiDataGridViewComboBoxColumn()
        {
            System.Windows.Forms.DataGridViewComboBoxColumn cmb = new System.Windows.Forms.DataGridViewComboBoxColumn();
            DataTable tbl = factory.DanhsachDVT();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TEN_DON_VI";
            cmb.ValueMember = "ID";
            cmb.DataPropertyName = "ID_DON_VI_TINH";
            cmb.HeaderText = "Đơn vị tính";
            return cmb;
        }
        public void HienthiDataGridview(System.Windows.Forms.DataGridView dg, System.Windows.Forms.BindingNavigator bn)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            bs.DataSource = factory.DanhsachDVT();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            
        }
        
        public DonViTinh LayDVT(int id)
        {
            DataTable tbl = factory.LayDVT(id);
            DonViTinh dvt = null;
            if (tbl.Rows.Count > 0)
            {
                dvt = new DonViTinh(Convert.ToInt32(tbl.Rows[0]["ID"]), Convert.ToString(tbl.Rows[0]["TEN_DON_VI"]));
            }
            return dvt;
        }

        public bool Save()
        {
            return factory.Save();
        }
    }
}
