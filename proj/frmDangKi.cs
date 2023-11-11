using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmDangKi : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource bdsSinhVien = new BindingSource();
        private BindingSource bdsLopTinchi = new BindingSource();
        private BindingSource bdsDSLTC_HUY = new BindingSource();
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            txbMaSV.Visible = false;
            btnSearchSinhVien.Visible = false;
            loadcbNienkhoa();
            LoadSinhVienInfo();
            Console.WriteLine("this is load " + cbNienKhoa.Text);
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
            Console.WriteLine("this is load func " + cbNienKhoa.Text);
        }
        void loadcbHocKi(string nienkhoa)
        {
            Console.WriteLine(cbNienKhoa.Text);
            Console.WriteLine(nienkhoa);
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.GetAllHocKy '" + nienkhoa + "'";
            Console.WriteLine(cmd);
            dt = Program.ExecSqlDataTable(cmd);

            BindingSource bdsHocKi = new BindingSource();
            bdsHocKi.DataSource = dt;

            cbHocKi.DataSource = bdsHocKi;
            cbHocKi.DisplayMember = "HOCKY";
            cbHocKi.ValueMember = "HOCKY";
            // cbHocKi.SelectedIndex = 0;
        }
        private void btnSearchLopTinChi_Click(object sender, EventArgs e)
        {

            Console.WriteLine("progarm" + Program.MaKhoa);
            string cmd = "EXEC [dbo].[SP_InDanhSachLopTinChi] '" + cbNienKhoa.Text + "', '" + cbHocKi.Text + "','" + Program.MaKhoa + "'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.LOPTINCHIgridControl.DataSource = this.bdsLopTinchi;
        }

        private void LOPTINCHIgridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (bdsLopTinchi.Count > 0)
            {
                txbMaLopTinChi.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
            }

        }
        private void LoadSinhVienInfo()
        {
            txbMaSV.Text = Program.username;
            txbMaSVDK.Text = Program.username;
            string cmd = "EXEC dbo.SP_getInfoSVDKI '" + txbMaSV.Text + "'";
            DataTable tableSV = Program.ExecSqlDataTable(cmd);
            this.bdsSinhVien.DataSource = tableSV;
            this.SINHVIENgridControl.DataSource = this.bdsSinhVien;

            string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
            DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);
            this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
            this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;


        }
        private void btnSearchSinhVien_Click(object sender, EventArgs e)
        {
            if (txbMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaSV.Focus();
                return;
            }
            if (txbMaSV.Text != Program.username)
            {
                MessageBox.Show("Bạn không phải là tài khoản sinh viên này!", "", MessageBoxButtons.OK);
                txbMaSV.Focus();
                return;
            }
            txbMaSVDK.Text = txbMaSV.Text;
            //     string cmd = "EXEC dbo.SP_getInfoSVDKI '" + txbMaSV.Text + "'";
            string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
            //   DataTable tableSV = Program.ExecSqlDataTable(cmd);
            DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);

            //   this.bdsSinhVien.DataSource = tableSV;
            this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
            //    this.SINHVIENgridControl.DataSource = this.bdsSinhVien;
            this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;
        }

        private void SINHVIENgridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (bdsSinhVien.Count > 0)
            {
                txbMaSVDK.Text = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {

            if (txbMaSVDK.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaSVDK.Focus();
                return;
            }
            if (txbMaLopTinChi.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp tín chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txbMaLopTinChi.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC [dbo].[SP_XULY_LTC] '" + txbMaSVDK.Text + "' , '" + txbMaLopTinChi.Text + "', " + 1;
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Đăng kí thành công!");
                    string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
                    DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);
                    this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
                    this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;
                }
                else
                {
                    MessageBox.Show("Đăng kí thất bại");
                }
            }
            else
            {
                return;
            }
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            // row
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

        private void gridView3_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            // row
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridView3_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbMaSVDK.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaSVDK.Focus();
                return;
            }
            if (bdsDSLTC_HUY.Position < 0)
            {
                MessageBox.Show("Bạn chưa chọn lớp tín chỉ để hủy");
                DSLTC_HUYgridControl.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maltc = "";
                if (((DataRowView)bdsDSLTC_HUY[bdsDSLTC_HUY.Position])["MALTC"] != null)
                {
                    maltc = ((DataRowView)bdsDSLTC_HUY[bdsDSLTC_HUY.Position])["MALTC"].ToString();
                }

                string cmd = "EXEC [dbo].[SP_XULY_LTC] '" + txbMaSVDK.Text + "' , '" + maltc + "', " + 2;
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Hủy đăng kí thành công!");
                    string cmd1 = "EXEC dbo.SP_LIST_SVHUYDANGKY '" + txbMaSV.Text + "'";
                    DataTable tableDSLTC_HUY = Program.ExecSqlDataTable(cmd1);
                    this.bdsDSLTC_HUY.DataSource = tableDSLTC_HUY;
                    this.DSLTC_HUYgridControl.DataSource = this.bdsDSLTC_HUY;
                }
                else
                {
                    MessageBox.Show("Hủy đăng kí thất bại");
                }
            }
            else
            {
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*    loadcbNienkhoa();   
              cbNienKhoa.SelectedIndex = 0;

          
                cbHocKi.Items[1]= */
            loadcbHocKi(cbNienKhoa.Text);
            Console.WriteLine("this is indexchange " + cbNienKhoa.Text);
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void SINHVIENgridControl_Click(object sender, EventArgs e)
        {

        }

        private void DSLTC_HUYgridControl_Click(object sender, EventArgs e)
        {

        }
    }
}