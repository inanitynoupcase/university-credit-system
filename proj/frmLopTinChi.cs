using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
using ComboBox = System.Windows.Forms.ComboBox;

namespace QLNV1
{
    public partial class frmLopTinChi : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        int vitri = 0;
        string macn = "";
        public frmLopTinChi()
        {
            InitializeComponent();
            panelControl2.Enabled = false;
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.THOIGIANDANGKY' table. You can move, or remove it, as needed.
            this.tHOIGIANDANGKYTableAdapter.Fill(this.DS.THOIGIANDANGKY);
            // TODO: This line of code loads data into the 'DS.SP_LayDSGV' table. You can move, or remove it, as needed.
            this.sP_LayDSGVTableAdapter.Fill(this.DS.SP_LayDSGV);
            // TODO: This line of code loads data into the 'DS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
            // TODO: This line of code loads data into the 'DS.SP_DanhSachLTCKoDK' table. You can move, or remove it, as needed.
            this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, Program.MaKhoa);
            // TODO: This line of code loads data into the 'DS.GIANGVIEN' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'DS.DANGKY' table. You can move, or remove it, as needed.
            loadGVcombobox();
            DS.EnforceConstraints = false;

            //this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
           // this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.DS.DANGKY);


            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

            macn = ((DataRowView)bdsLopTinChi[0])["MAKHOA"].ToString();
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;



            cbTenMonHoc.DataSource = bdsMonHoc;
            cbTenMonHoc.DisplayMember = "TENMON";
            cbTenMonHoc.ValueMember = "MAMON";

            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
            txbMaGiangVien.Text = cbTenGiangVien.ValueMember.ToString();
         
        }

       /* private void lOPTINCHIBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLopTinChi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }*/

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        void loadGVcombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.SP_LayDSGV";
            dt = Program.ExecSqlDataTable(cmd);
            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            
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
            else if (cbKhoa.SelectedIndex != 2)
            {
                loadGVcombobox();
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DANGKYTableAdapter.Fill(this.DS.DANGKY);
                macn = ((DataRowView)bdsLopTinChi[0])["MAKHOA"].ToString();
            }

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sPDanhSachLTCKoDKBindingSource.CancelEdit();
            if (btnThem.Enabled == false) sPDanhSachLTCKoDKBindingSource.Position = vitri;
            lOPTINCHIGridControl.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            frmLopTinChi_Load(sender, e);

            // load lại cả form...


            if (vitri > 0)
            {
                sPDanhSachLTCKoDKBindingSource.Position = vitri;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = sPDanhSachLTCKoDKBindingSource.Position;
            panelControl2.Enabled = true;
            sPDanhSachLTCKoDKBindingSource.AddNew();
            txbMaKhoa.Text = macn;
            cbTenGiangVien.SelectedIndex = 0;
            cbTenMonHoc.SelectedIndex = 0;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            lOPTINCHIGridControl.Enabled = false;

        }



        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maloptc = "";
          
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maloptc = ((DataRowView)sPDanhSachLTCKoDKBindingSource[sPDanhSachLTCKoDKBindingSource.Position])["MALTC"].ToString();
                    sPDanhSachLTCKoDKBindingSource.RemoveCurrent();
                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "", MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
                    sPDanhSachLTCKoDKBindingSource.Position = sPDanhSachLTCKoDKBindingSource.Find("IDLTC", maloptc);
               
                    return;
                }
            }
            if (sPDanhSachLTCKoDKBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = sPDanhSachLTCKoDKBindingSource.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = true;
            lOPTINCHIGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPhucHoi.Enabled = true;

            if (speHocKy.Value == 0)
            {
                MessageBox.Show("Học kì không được thiếu!", "", MessageBoxButtons.OK);
                speHocKy.Focus();
                return;
            }
            if (speSoSVToiThieu.Value == 0)
            {
                MessageBox.Show("Số sinh viên tối thiểu không được thiếu!", "", MessageBoxButtons.OK);
                speSoSVToiThieu.Focus();
                return;
            }
           /* if (speNhom.Value == 0)
            {
                MessageBox.Show("Nhóm không được thiếu!", "", MessageBoxButtons.OK);
                speSoSVToiThieu.Focus();
                return;
            }*/
            if (txbMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txbMaKhoa.Focus();
                return;
            }
           /* if (txbMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                txbMaKhoa.Focus();
                return;
            }*/
            if (txbMaGiangVien.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaKhoa.Focus();
                return;
            }
            if (txbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được thiếu!", "", MessageBoxButtons.OK);
                txbMaKhoa.Focus();
                return;
            }
            try
            {
                sPDanhSachLTCKoDKBindingSource.EndEdit();
                sPDanhSachLTCKoDKBindingSource.ResetCurrentItem();
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp tín chỉ: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            lOPTINCHIGridControl.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }



        private void cbTenGiangVien_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTenGiangVien.SelectedValue != null)
            {
                txbMaGiangVien.Text = cbTenGiangVien.SelectedValue.ToString();
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

      /*  private void cbTenMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTenMonHoc.SelectedValue != null)
            {
                txbMaMonHoc.Text = cbTenMonHoc.SelectedValue.ToString();
            }
        }*/

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl2.Enabled = false;
            lOPTINCHIGridControl.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = true;
        }

        private void cbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbMaMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            // cbTenMonHoc.SelectedValue = txbMaMonHoc.Text;
        }

        private void txbMaGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            //  cbTenGiangVien.SelectedValue = txbMaGiangVien.Text;
        }

        private void cbTenGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lOPTINCHIGridControl_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, Program.MaKhoa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
                    }

        private void sPDanhSachLTCKoDKBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, Program.MaKhoa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, Program.MaKhoa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}