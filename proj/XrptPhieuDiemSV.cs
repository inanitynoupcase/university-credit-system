using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNV1
{
    public partial class XrptPhieuDiemSV : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptPhieuDiemSV()
        {
            InitializeComponent();
        }
        public XrptPhieuDiemSV(string msv,int type)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = msv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = type;
        }
    }
}
