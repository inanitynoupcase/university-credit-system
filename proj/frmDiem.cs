using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV1
{
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string macn = "";
        int MALTC = 0;
        String DiemCC;
        String DiemGK;
        String DiemCK;
        float DIEMCC = 0;
        float DIEMGK = 0;
        float DIEMCK = 0;
        string formattedDIEMCC = "";
        string formattedDIEMGK = "";
        string formattedDIEMCK = "";
        private BindingSource bdsDiem = new BindingSource();
        public frmDiem()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        void enableComponent(bool value)
        {
            textBoxMaSV.Enabled = value;
            textBoxTenSV.Enabled = value;
            textBoxDiemCC.Enabled = value;
            textBoxDiemGK.Enabled = value;
            textBoxDiemCK.Enabled = value;
            btnCapNhat.Enabled = value;
        }
        private void frmDiem_Load(object sender, EventArgs e)
        {
            enableComponent(false);
            DS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            Console.WriteLine("coonection str " + Program.connstr);
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;

            cbMonHoc.DataSource = bdsMonHoc;
            cbMonHoc.DisplayMember = "TENMON";
            cbMonHoc.ValueMember = "TENMON";

            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
            loadcbNienkhoa();
           // cbNienKhoa.SelectedIndex = 0;
            //cbNienKhoa.Text = cbNienKhoa.Items[cbNienKhoa.SelectedIndex].ToString();
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
        void loadNhom(string nienkhoa,string hocki)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllNhom '"+nienkhoa+"', "+hocki;
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsNhom = new BindingSource();
            bdsNhom.DataSource = dt;
            cbNhom.DataSource = bdsNhom;
            cbNhom.DisplayMember = "NHOM";
            cbNhom.ValueMember = "NHOM";
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
        void loadBDMH()
        {
            string cmd = "EXEC [dbo].[SP_BDMH] '" + cbNienKhoa.Text + "', " + cbHocKi.Text + ", " + cbNhom.Text + ", N'" + cbMonHoc.SelectedValue.ToString() + "','" + Program.username + "'" ;
            DataTable diemTable = Program.ExecSqlDataTable(cmd);
            this.bdsDiem.DataSource = diemTable;
            this.DiemGridControl.DataSource = this.bdsDiem;
        }
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            loadBDMH();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (DiemCC == "")
            {
                DIEMCC = -1;

            }
            else
            {
                DIEMCC = float.Parse(DiemCC);
                formattedDIEMCC = DIEMCC.ToString("F2", CultureInfo.InvariantCulture);
            }
            if (DiemGK == "")
            {
                DIEMGK = -1;

            }
            else
            {
                DIEMGK = float.Parse(DiemGK);
                formattedDIEMGK = DIEMGK.ToString("F2", CultureInfo.InvariantCulture);
            }
            if (DiemCK == "")
            {
                DIEMCK = -1;

            }
            else
            {

                DIEMCK = float.Parse(DiemCK);
                formattedDIEMCK = DIEMCK.ToString("F2", CultureInfo.InvariantCulture);

            }

            string cmd = "Exec [dbo].[SP_XULY_DIEM] '" + textBoxMaSV.Text + "', " + MALTC + "," + formattedDIEMCC + "," + formattedDIEMGK + "," + formattedDIEMCK;
            if (Program.ExecSqlNonQuery(cmd) == 0)
            {
                BindingSource gridDataSource = (BindingSource)DiemGridControl.DataSource;

                // Assuming your underlying data source is a DataTable
                DataTable dataSource = (DataTable)gridDataSource.DataSource;
                foreach (DataRow row in dataSource.Rows)
                {
                    // Assuming "MASV" is the column name
                    if (row["MASV"].ToString() == textBoxMaSV.Text)
                    {
                        row["DIEM_CC"] = formattedDIEMCC;
                        row["DIEM_GK"] = formattedDIEMGK;
                        row["DIEM_CK"] = formattedDIEMCK;
                        string diemtk = (DIEMCC * 0.1 + DIEMGK * 0.3 + DIEMCK * 0.6).ToString("F2", CultureInfo.InvariantCulture);
                        row["DIEM_TK"] = diemtk;

                        break;
                    }
                }

            }

        }
          

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Handled = true;
            SolidBrush brush = new SolidBrush(Color.FromArgb(0xC6, 0x64, 0xFF));
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height));
            Size size = ImageCollection.GetImageListSize(e.Info.ImageCollection);
            Rectangle r = e.Bounds;
            ImageCollection.DrawImageListImage(e.Cache, e.Info.ImageCollection, e.Info.ImageIndex,
                    new Rectangle(r.X + (r.Width - size.Width) / 2, r.Y + (r.Height - size.Height) / 2, size.Width, size.Height));
            brush.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {

             if(cbHocKi.Text != "System.Data.DataRowView")
            {
                Console.WriteLine("this is cbHocKi" + cbNienKhoa.Text + " " + cbHocKi.Text);
                loadNhom(cbNienKhoa.Text, cbHocKi.Text);

            }
            // cbNhom.SelectedIndex = 0;
        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNienKhoa.Text != "System.Data.DataRowView")
            {
                Console.WriteLine("this is " + cbNienKhoa.Text);
                loadcbHocKi(cbNienKhoa.Text);
            }
/*            cbHocKi.SelectedIndex = 0; */
        }

        private void DiemGridControl_Click(object sender, EventArgs e)
        {
            if(bdsDiem.Count > 0)
            {
                enableComponent(true);

                textBoxMaSV.Text = ((DataRowView)bdsDiem[bdsDiem.Position])["MASV"].ToString();
                textBoxTenSV.Text = ((DataRowView)bdsDiem[bdsDiem.Position])["HOTEN"].ToString();
                textBoxDiemCC.Text = ((DataRowView)bdsDiem[bdsDiem.Position])["DIEM_CC"].ToString();
                textBoxDiemGK.Text = ((DataRowView)bdsDiem[bdsDiem.Position])["DIEM_GK"].ToString();
                textBoxDiemCK.Text = ((DataRowView)bdsDiem[bdsDiem.Position])["DIEM_CK"].ToString();
              //  Console.WriteLine("bao ngu: " + textBoxMaSV + DIEMCC + DIEMGK + DIEMCK);
                MALTC = Int32.Parse(((DataRowView)bdsDiem[bdsDiem.Position])["MALTC"].ToString());
                if(textBoxDiemCC.Text == "")
                {
                    DIEMCC = -1;
 
                }
                else
                {
                    DIEMCC = float.Parse(((DataRowView)bdsDiem[bdsDiem.Position])["DIEM_CC"].ToString());
                    formattedDIEMCC = DIEMCC.ToString("F2", CultureInfo.InvariantCulture);
                }
                if (textBoxDiemGK.Text == "")
                {
                    DIEMGK = -1;

                }
                else
                {
                    DIEMGK = float.Parse(((DataRowView)bdsDiem[bdsDiem.Position])["DIEM_GK"].ToString());
                    formattedDIEMGK = DIEMGK.ToString("F2", CultureInfo.InvariantCulture);
                }
                if (textBoxDiemCK.Text == "")
                {
                    DIEMCK = -1;

                }
                else
                {
                  
                    DIEMCK = float.Parse(((DataRowView)bdsDiem[bdsDiem.Position])["DIEM_CK"].ToString());
                    formattedDIEMCK = DIEMCK.ToString("F2", CultureInfo.InvariantCulture);

                }


            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DiemCC = textBoxDiemCC.Text;
        }

        private void bdsMonHoc_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDiemCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxDiemCC_Leave(object sender, EventArgs e)
        {
            string a = textBoxDiemCC.Text;
            string pattern = @"^(?:[0-9]|10)(\.\d)?$";
            if (Regex.IsMatch(a, pattern))
            {
                Console.WriteLine("chay: " + a );
            }
            else { textBoxDiemCC.Text = ""; MessageBox.Show(":  SAI FORMAT ĐIỂM CHUYÊN CẦN "); } 
            
       
        }

        private void textBoxDiemGK_TextChanged(object sender, EventArgs e)
        {
            DiemGK = textBoxDiemGK.Text;

        }

        private void textBoxDiemCK_TextChanged(object sender, EventArgs e)
        {
            DiemCK = textBoxDiemCK.Text;
        }

        private void textBoxDiemGK_Leave(object sender, EventArgs e)
        {
            string a=  textBoxDiemGK.Text;
            string pattern = @"^(?:[0-9]|10)(\.\d)?$";
            if (Regex.IsMatch(a, pattern))
            {
                Console.WriteLine("chay: " + a);
            }
            else { textBoxDiemGK.Text = ""; MessageBox.Show(": SAI FORMAT ĐIỂM GIƯA KÌ  "); }


        }

        private void textBoxDiemGK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxDiemCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxDiemCK_Leave(object sender, EventArgs e)
        {
            string a = textBoxDiemCK.Text;
            string pattern = @"^(?:[0-9]|10)(\.\d)?$";
            if (Regex.IsMatch(a, pattern))
            {
                Console.WriteLine("chay: " + a);
            }
            else { textBoxDiemCK.Text = ""; MessageBox.Show(":  SAI FORMAT ĐIỂM CUỐI KÌ "); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}