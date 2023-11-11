using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNV1
{
    public partial class Xtrp_InDanhSachLopTinChi_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_InDanhSachLopTinChi_Report()
        {
            InitializeComponent();
        }
        public Xtrp_InDanhSachLopTinChi_Report(string nienkhoa, int hocky)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Fill();
        }
    }
}
