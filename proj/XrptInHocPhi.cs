using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNV1
{
    public partial class XrptInHocPhi : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptInHocPhi()
        {
            InitializeComponent();
        }
        public XrptInHocPhi(string malop,string nienkhoa,int hocky,string connstr)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocky;
        }
    }
}
