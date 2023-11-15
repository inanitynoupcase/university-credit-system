using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNV1
{
    public partial class XrptInDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptInDSSV()
        {
            InitializeComponent();
        }
        public XrptInDSSV(string malop, string connstr)
        {
            InitializeComponent();
            this.sqlDataSource4.Connection.ConnectionString = connstr;
            this.sqlDataSource4.Queries[0].Parameters[0].Value = malop;
    
        }
    }
}
