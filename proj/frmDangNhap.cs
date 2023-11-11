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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private bool isSinhVien = false;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.test.DataSource = dt;
            Program.bds_dspm.DataSource = dt;
            cbChiNhanh.DataSource = Program.bds_dspm;
            cbChiNhanh.DisplayMember = "TENKHOA";
            cbChiNhanh.ValueMember = "TENSERVER";
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publicsher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại tên Sever của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }




        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //    Console.WriteLine(txbTaiKhoan.Text);
            //    Console.WriteLine(txbMatKhau.Text);
            if (isSinhVien == false)
            {
                if (txbTaiKhoan.Text.Trim() == "" || txbMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    Program.mlogin = txbTaiKhoan.Text; Program.password = txbMatKhau.Text;
                    if (Program.KetNoi() == 0) return;

                    Program.mChinhanh = cbChiNhanh.SelectedIndex;
                    Program.mloginDN = Program.mlogin;
                    Program.passwordDN = Program.password;

                    string strLenh = "EXEC dbo.SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mlogin + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
                   
                    Program.mGroup = Program.myReader.GetString(2);
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.username = Program.myReader.GetString(0);
                    Program.myReader.Close();

                }
            }
            else
            {
                if (txbTaiKhoan.Text.Trim() == "" || txbMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    Console.WriteLine("eewqqw");
                    Program.mlogin = "SVKN";
                    Program.password = "123";
                    if (Program.KetNoi() == 0) return;


                    string strlenh1 = "EXEC [dbo].[SP_LayThongTinSV_DangNhap] '" + txbTaiKhoan.Text + "', '" + txbMatKhau.Text + "'";
                    Console.WriteLine("THIS IS " + strlenh1);
                    SqlDataReader reader = Program.ExecSqlDataReader(strlenh1);

                    if (reader.HasRows == false)
                    {
                        Console.WriteLine("true");
                        MessageBox.Show("Đăng nhập thất bại! \nXem Lại TK và PASSWORD");
                        return;
                    }

                    reader.Read();

                    if (Convert.IsDBNull(Program.username))
                    {
                        MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                        return;
                    }
                    Program.mGroup = "SV";
                    Program.mHoten = reader.GetString(1);
                    Program.username = reader.GetString(0);
                    reader.Close();


                }
            }
            Program.conn.Close();
            MessageBox.Show("Đăng nhập thành công !!!");
            Form f = new MainForm();
            f.ShowDialog();

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM V_DSPM");
            // cbChiNhanh.SelectedIndex = 1;
            cbChiNhanh.SelectedIndex = 0;
            Program.severname = cbChiNhanh.SelectedValue.ToString();
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //  Console.WriteLine(Program.severname);
                Program.severname = cbChiNhanh.SelectedValue.ToString();
                if (Program.severname == "M15R2\\SERVER_SITE4")
                {
                    checkBox1.Enabled = false;
                    checkBox1.Checked = false;
                    isSinhVien = false;
                    Console.WriteLine("this is " + isSinhVien);
                }
                else
                {
                    checkBox1.Enabled = true;

                }
                //     Console.WriteLine(Program.severname);
            }
            catch (Exception) { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Program.mainForm.Close();
        }

        private void rdoSinhvien_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isSinhVien = !isSinhVien;
        }
    }
}