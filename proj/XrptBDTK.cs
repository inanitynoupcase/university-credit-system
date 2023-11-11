using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNV1
{
    public partial class XrptBDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptBDTK()
        {
            InitializeComponent();
        }
        public XrptBDTK(string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
        }
    }
}
