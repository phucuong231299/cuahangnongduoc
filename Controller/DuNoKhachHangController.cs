using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using CuahangNongduoc.BusinessObject;
using CuahangNongduoc.DataLayer;

namespace CuahangNongduoc.Controller
{
    public class DuNoKhachHangController
    {
        DuNoKhachHangFactory factory = new DuNoKhachHangFactory();

        public void Tonghop(int thang, int nam, 
            ToolStripProgressBar bar, DataGridView dg, BindingNavigator bn)
        {

            int ThangTruoc=0, NamTruoc=0;
            ThamSo.PreMonth(ref ThangTruoc, ref NamTruoc, thang, nam);
            factory.Clear(thang, nam);


            BindingSource bs = new BindingSource();
            bs.DataSource = factory.LayDuNoKhachHang("-1", 0, 0);
            bn.BindingSource = bs;
            dg.DataSource = bs;
            
            KhachHangFactory factoryKH = new KhachHangFactory();
            DataTable tbl = factoryKH.DanhsachKhachHang();
            long dauky = 0, phatsinh = 0, datra = 0, cuoiky = 0;

            bar.Minimum = 0;
            bar.Value = 0;
            bar.Maximum = tbl.Rows.Count;

            foreach(DataRow row in tbl.Rows)
            {
                DataRow r = factory.NewRow();
                String kh = Convert.ToString(row["ID"]);
                

                dauky = DuNoKhachHangFactory.LayDuNo(kh, ThangTruoc, NamTruoc);
                phatsinh = PhieuBanFactory.LayConNo(kh, thang, nam);
                datra = PhieuThanhToanFactory.LayTongTien(kh, thang, nam);
                cuoiky = (dauky + phatsinh - datra);

                r["ID_KHACH_HANG"] = kh;
                r["THANG"] = thang;
                r["NAM"] = nam;
                r["DAU_KY"] = dauky;
                r["PHAT_SINH"] = phatsinh;
                r["DA_TRA"] = datra;
                r["CUOI_KY"] = cuoiky;

           
                factory.Add(r);

                bar.Value++;
            }

            
        }
        public bool Save()
        {
            return factory.Save();
        }
    }
}
