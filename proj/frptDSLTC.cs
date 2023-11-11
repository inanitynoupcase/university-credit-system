using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV1
{
    public partial class frptDSLTC : DevExpress.XtraEditors.XtraForm
    {
        public frptDSLTC()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frptDSLTC_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
            loadcbNienkhoa();
            cbNienKhoa.SelectedIndex = 0;
        }
        void loadcbNienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNienKhoa = new BindingSource();
            bdsNienKhoa.DataSource = dt;
            cbNienKhoa.DataSource = bdsNienKhoa;
            cbNienKhoa.DisplayMember = "NIENKHOA";
            cbNienKhoa.ValueMember = "NIENKHOA";
        }
        void loadcbHocKi(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllHocKy '" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;
            cbHocKi.DataSource = bdsHocKi;
            cbHocKi.DisplayMember = "HOCKY";
            cbHocKi.ValueMember = "HOCKY";
        }
        
        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.severname = cbKhoa.SelectedValue.ToString();
            if (cbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadcbNienkhoa();
                cbNienKhoa.SelectedIndex = 0;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
           
            string nienkhoa = cbNienKhoa.Text;
            int hocky = Int32.Parse(cbHocKi.Text);
            string khoa = cbKhoa.Text;
            Xtrp_InDanhSachLopTinChi_Report rpt = new Xtrp_InDanhSachLopTinChi_Report(nienkhoa,hocky);
            rpt.lbKhoa.Text = khoa;
            rpt.lbHocKy.Text = hocky.ToString();
            rpt.lbNienKhoa.Text = nienkhoa;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cbNienKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;*/
            loadcbHocKi(cbNienKhoa.Text);
          //  cbHocKi.SelectedIndex = 0;
        }
    }
}