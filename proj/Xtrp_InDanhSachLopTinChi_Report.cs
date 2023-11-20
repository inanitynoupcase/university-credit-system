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
        public Xtrp_InDanhSachLopTinChi_Report(string nienkhoa, int hocky, string khoa)
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource2.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource2.Queries[0].Parameters[2].Value = khoa;
            this.sqlDataSource2.Fill();
        }
    }
}
