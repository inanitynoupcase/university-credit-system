using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV1
{
    public partial class frptBDTK : DevExpress.XtraEditors.XtraForm
    {
        public frptBDTK()
        {
            InitializeComponent();
        }

        private void frptBDTK_Load(object sender, EventArgs e)
        {

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            cbLop.DataSource = bdsLop;
            cbLop.DisplayMember = "MALOP";
            cbLop.ValueMember = "TENLOP";


            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
           
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
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
            }
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string malop = cbLop.Text;
            string cmd = "SELECT TENKHOA,KHOAHOC FROM dbo.LOP,dbo.KHOA WHERE MALOP = '" + malop + "' AND KHOA.MAKHOA = LOP.MAKHOA";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            reader.Read();
            string tenkhoa = reader.GetString(0);
            string khoahoc = reader.GetString(1);
            reader.Close();
            XrptBDTK rpt = new XrptBDTK(malop);
            rpt.lbKhoa.Text = tenkhoa;
            rpt.lbKhoaHoc.Text = khoahoc;
            rpt.lbLop.Text = malop;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}