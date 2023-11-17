using DevExpress.XtraEditors;
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
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

    

       

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            loadGVcombobox();
           

            if (Program.mGroup.Equals("KHOA"))
            {
                rdoKhoa.Checked = true;
                rdoPGV.Enabled = rdoKhoa.Enabled = false;
            }
            if (Program.mGroup.Equals("PGV"))
            {
                rdoPGV.Checked = true;
                rdoPGV.Enabled = rdoKhoa.Enabled = false;

            }

        }

        void loadGVcombobox()
        {
            if (Program.mGroup.Equals("KHOA")){
                    DataTable dt = new DataTable();
                    string cmd = "EXEC dbo.SP_LayDSGV";
                    dt = Program.ExecSqlDataTable(cmd);

                    BindingSource bdsgv = new BindingSource();
                    bdsgv.DataSource = dt;
                    cbGiangVien.DataSource = bdsgv;
                    cbGiangVien.DisplayMember = "MAGV";
                    cbGiangVien.ValueMember = "MAGV";
                }
            if (Program.mGroup.Equals("PGV"))
                {
                DataTable dt = new DataTable();
                string cmd = "EXEC dbo.SP_LayDSNV";
                dt = Program.ExecSqlDataTable(cmd);

                BindingSource bdsgv = new BindingSource();
                bdsgv.DataSource = dt;
                cbGiangVien.DataSource = bdsgv;
                cbGiangVien.DisplayMember = "MANV";
                cbGiangVien.ValueMember = "MANV";
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txbTenLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được thiếu!", "", MessageBoxButtons.OK);
                txbTenLogin.Focus();
                return;
            }
            if (txbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txbMatKhau.Focus();
                return;
            }
            if (txbXacNhanMK.Text.Trim() == "")
            {
                MessageBox.Show("Xác nhận mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txbXacNhanMK.Focus();
                return;
            }
            if(txbXacNhanMK.Text != txbMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng!", "", MessageBoxButtons.OK);
                txbXacNhanMK.Focus();
                return;
            }
            if (rdoKhoa.Checked == false && rdoPGV.Checked == false)
            {
                MessageBox.Show("Nhóm quyền không được thiếu!", "", MessageBoxButtons.OK);
                rdoKhoa.Focus();
                return;
            }
            string login = txbTenLogin.Text;
            string matkhau = txbMatKhau.Text;
            string user = cbGiangVien.SelectedValue.ToString();
            string role = "";
            if (rdoKhoa.Checked) role = "KHOA";
            if (rdoPGV.Checked) role = "PGV";

            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                           " @LGNAME = N'" + login + "', " +
                           " @PASS = N'" + matkhau + "', " +
                           " @USERNAME = N'" + user + "', " +
                           " @ROLE = N'" + role + "' ";

           /* if (role == "PKT" && Program.severname == ((DataRowView)Program.bds_dspm[0])["TENSERVER"].ToString())
            {
                // site 1 ---> sử dụng LINK2
                subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + matkhau + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";
            }
            else if (role == "PKT" && Program.severname == ((DataRowView)Program.bds_dspm[1])["TENSERVER"].ToString())

            {
                subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +

                           " @LGNAME = N'" + login + "', " +
                           " @PASS = N'" + matkhau + "', " +
                           " @USERNAME = N'" + user + "', " +
                           " @ROLE = N'" + role + "' ";
            }*/
            string strLenh = " DECLARE @return_value int " + subLenh +
                    " SELECT  'Return Value' = @return_value ";

            int resultCheckLogin = Program.CheckDataHelper(strLenh);

            if (resultCheckLogin == -1)
            {
                XtraMessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                XtraMessageBox.Show("Login bị trùng . Mời bạn nhập login khác !", "", MessageBoxButtons.OK);
                
            }
            else if (resultCheckLogin == 2)
            {
                XtraMessageBox.Show("Người này đã có tài khoản rồi !", "", MessageBoxButtons.OK);
               

            }
            else if (resultCheckLogin == 3)
            {
                XtraMessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 0)
            {
                XtraMessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }

            return;
        }

        private void txbXacNhanMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txbTenLogin.Text = "";
            txbMatKhau.Text = "";
            txbXacNhanMK.Text = "";
        }
    }
}