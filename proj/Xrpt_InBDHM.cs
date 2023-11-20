using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNV1
{
    public partial class Xrpt_InBDHM : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_InBDHM()
        {
            InitializeComponent();
        }
        public Xrpt_InBDHM(string nienkhoa,int hocky,int nhom, string monhoc)
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource2.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource2.Queries[0].Parameters[2].Value = nhom;
            this.sqlDataSource2.Queries[0].Parameters[3].Value = monhoc;
            this.sqlDataSource2.Fill();
        }
    }
}
