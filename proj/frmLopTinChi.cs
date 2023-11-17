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
        private string _flagOptionLopTinChi;
        private string _oldMaLTC;
        string a;
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

            if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
            this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

            this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);
            // TODO: This line of code loads data into the 'DS.GIANGVIEN' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'DS.DANGKY' table. You can move, or remove it, as needed.
            loadGVcombobox();
            DS.EnforceConstraints = false;

           


            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

            //macn = ((DataRowView)bdsLopTinChi[0])["MAKHOA"].ToString();
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
            //txbMaTGDK.Text = cbTenMonHoc.ValueMember.ToString();
           
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sPDanhSachLTCKoDKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

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
          /*      this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DANGKYTableAdapter.Fill(this.DS.DANGKY);*/
                if (bdsLopTinChi.Count > 0) 
                macn = ((DataRowView)bdsLopTinChi[0])["MAKHOA"].ToString();
                if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
                this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);
                Console.WriteLine(": " + a + " " + Program.severname);
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
            _flagOptionLopTinChi = "ADD";
            panelControl2.Enabled = true;
            sPDanhSachLTCKoDKBindingSource.AddNew();
            if (cbKhoa.SelectedIndex == 1) a = "CNTT"; else a = "VT";
            
            txbMaKhoa.Text = a;
            cbTenGiangVien.SelectedIndex = 0;
            cbTenMonHoc.SelectedIndex = 0;
            hUYLOPCheckEdit.Checked = false;
            hUYLOPCheckEdit.EditValue = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            lOPTINCHIGridControl.Enabled = false;

        }



        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maloptc = "";
            _flagOptionLopTinChi = "REMOVE";
            _oldMaLTC = textEdit1.Text.Trim();
            Console.WriteLine("SV DANG KY: " + textEdit2.Text);
            if (textEdit2.Text != "0")
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maloptc = ((DataRowView)sPDanhSachLTCKoDKBindingSource[sPDanhSachLTCKoDKBindingSource.Position])["MALTC"].ToString();
                    sPDanhSachLTCKoDKBindingSource.RemoveCurrent();
                    //this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                 //   this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp : " + ex.Message, "", MessageBoxButtons.OK);
                    if (cbKhoa.SelectedIndex == 1) a = "CNTT"; else a = "VT";
                    this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);


                    sPDanhSachLTCKoDKBindingSource.Position = sPDanhSachLTCKoDKBindingSource.Find("MALTC", maloptc);
                    return;
                }
            }
            if (sPDanhSachLTCKoDKBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = sPDanhSachLTCKoDKBindingSource.Position;
            _flagOptionLopTinChi = "UPDATE";
            _oldMaLTC = textEdit1.Text.Trim();
            
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = true;
            lOPTINCHIGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPhucHoi.Enabled = true;
            if (_flagOptionLopTinChi == "ADD" || _flagOptionLopTinChi == "UPDATE")
            {
                if (speHocKy.Value == 0)
                {
                    MessageBox.Show("Học kì không được thiếu!", "", MessageBoxButtons.OK);
                    speHocKy.Focus();
                    return;
                }
                if (speHocKy.Value < 0)
                {
                    MessageBox.Show("Học kì không thể là số âm!", "", MessageBoxButtons.OK);
                    speHocKy.Focus();
                    return;
                }
                if (speSoSVToiThieu.Value == 0)
                {
                    MessageBox.Show("Số sinh viên tối thiểu không được thiếu!", "", MessageBoxButtons.OK);
                    speSoSVToiThieu.Focus();
                    return;
                }
                if (speSoSVToiThieu.Value < 0)
                {
                    MessageBox.Show("Số sinh viên tối thiểu không thể là số âm!", "", MessageBoxButtons.OK);
                    speSoSVToiThieu.Focus();
                    return;
                }
                if (spinNHOM.Value == 0)
                {
                    MessageBox.Show("Nhóm không được thiếu!", "", MessageBoxButtons.OK);
                    spinNHOM.Focus();
                    return;
                }
                if (spinNHOM.Value < 0)
                {
                    MessageBox.Show("Số nhóm không thể là số âm!", "", MessageBoxButtons.OK);
                    spinNHOM.Focus();
                    return;
                }

                if (cbMATGDK.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn mã thời gian đăng ký", "", MessageBoxButtons.OK);
                    cbMATGDK.Focus();
                    return;
                }
                if (cbTenMonHoc.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn môn học cho lớp tín chỉ", "", MessageBoxButtons.OK);
                    cbTenMonHoc.Focus();
                    return;
                }
                if (cbTenGiangVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn giảng viên 1 cho lớp tín chỉ", "", MessageBoxButtons.OK);
                    cbTenGiangVien.Focus();
                    return;
                }
                if (cbTenGiangVien.SelectedValue == cbTenGiangVien2.SelectedValue)
                {
                    MessageBox.Show("Trùng lập dữ liệu 2 giảng viên lớp tín chỉ", "", MessageBoxButtons.OK);
                    cbTenGiangVien2.Focus();
                    return;
                }


                if (txbNienKhoa.Text.Trim() == "")
                {
                    MessageBox.Show("Niên khóa không được thiếu!", "", MessageBoxButtons.OK);
                    txbNienKhoa.Focus();
                    return;
                }

            }

            Console.WriteLine("MALTC: " + _oldMaLTC + ", SVTT: " + speSoSVToiThieu.Text + ", Nhom: " + spinNHOM.Text + ", NienKhoa: " + txbNienKhoa.Text + ", HocKy: " + speHocKy.Text + ", MAMON: " + cbTenMonHoc.SelectedValue + ", MaNV: " + Program.username + ", HuyLop: " + hUYLOPCheckEdit.EditValue + ", maKhoa: " + txbMaKhoa.Text + ", maTGDK: " + cbMATGDK.SelectedValue + ", maGV1: " + cbTenGiangVien.SelectedValue + ", maGV2: " + cbTenGiangVien2.SelectedValue);

            try
            {
                if (_flagOptionLopTinChi == "ADD")
                {
                    string query1;
                    if (cbTenGiangVien2.SelectedValue != null)
                        query1 = "EXEC [dbo].[SP_NewLTCvaGVDAY] " + speSoSVToiThieu.Text + "," + spinNHOM.Text + ",'" + txbNienKhoa.Text + "'," + speHocKy.Text + "," + cbTenMonHoc.SelectedValue + ",'" + Program.username + "'," + hUYLOPCheckEdit.EditValue + ",'" + txbMaKhoa.Text + "'," + cbMATGDK.SelectedValue + ",'" + cbTenGiangVien.SelectedValue + "','" + cbTenGiangVien2.SelectedValue + "'";
                    else 
                        query1 = "EXEC [dbo].[SP_NewLTCvaGVDAY] " + speSoSVToiThieu.Text + "," + spinNHOM.Text + ",'" + txbNienKhoa.Text + "'," + speHocKy.Text + "," + cbTenMonHoc.SelectedValue + ",'" + Program.username + "'," + hUYLOPCheckEdit.EditValue + ",'" + txbMaKhoa.Text + "'," + cbMATGDK.SelectedValue + ",'" + cbTenGiangVien.SelectedValue + "'";
                    if(Program.ExecSqlNonQuery(query1) == 0)
                    {
                        MessageBox.Show("Ghi dữ liệu lớp tín chỉ thành công!");
                        sPDanhSachLTCKoDKBindingSource.EndEdit();

                        sPDanhSachLTCKoDKBindingSource.ResetCurrentItem();


                        if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
                        this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

                        this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);

                    }
                    else
                    {
                        MessageBox.Show("Ghi dữ liệu lớp tín chỉ thất bại!");
                    }
                }
                if (_flagOptionLopTinChi == "UPDATE")
                {
                    string query1;
                    if (cbTenGiangVien2.SelectedValue != null)
                        query1 = "EXEC [dbo].[SP_UPDATELTCvaGVDAY] " + _oldMaLTC + "," + speSoSVToiThieu.Text + "," + spinNHOM.Text + ",'" + txbNienKhoa.Text + "'," + speHocKy.Text + "," + cbTenMonHoc.SelectedValue + ",'" + Program.username + "'," + hUYLOPCheckEdit.EditValue + ",'" + txbMaKhoa.Text + "'," + cbMATGDK.SelectedValue + ",'" + cbTenGiangVien.SelectedValue + "','" + cbTenGiangVien2.SelectedValue + "'";
                    else
                        query1 = "EXEC [dbo].[SP_UPDATELTCvaGVDAY] " + _oldMaLTC + "," + speSoSVToiThieu.Text + "," + spinNHOM.Text + ",'" + txbNienKhoa.Text + "'," + speHocKy.Text + "," + cbTenMonHoc.SelectedValue + ",'" + Program.username + "'," + hUYLOPCheckEdit.EditValue + ",'" + txbMaKhoa.Text + "'," + cbMATGDK.SelectedValue + ",'" + cbTenGiangVien.SelectedValue + "'";
                    if (Program.ExecSqlNonQuery(query1) == 0)
                    {
                        MessageBox.Show("Ghi dữ liệu lớp tín chỉ thành công!");
                        sPDanhSachLTCKoDKBindingSource.EndEdit();

                        sPDanhSachLTCKoDKBindingSource.ResetCurrentItem();


                        if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
                        this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

                        this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);

                    }
                    else
                    {
                        MessageBox.Show("Ghi dữ liệu lớp tín chỉ thất bại!");
                    }
                }
                if (_flagOptionLopTinChi == "REMOVE")
                {
                       string query1 = "EXEC [dbo].[SP_REMOVELTCvaGVDAY] " + _oldMaLTC;
                    if (Program.ExecSqlNonQuery(query1) == 0)
                    {
                        MessageBox.Show("Ghi dữ liệu lớp tín chỉ thành công!");
                        sPDanhSachLTCKoDKBindingSource.EndEdit();

                        sPDanhSachLTCKoDKBindingSource.ResetCurrentItem();

                        if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
                        this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

                        this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);

                    }
                    else
                    {
                        MessageBox.Show("Ghi dữ liệu lớp tín chỉ thất bại!");
                    }
                }

                if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
                this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

                this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);
                // this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                //this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
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
            if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
            this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

            this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
                this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

                this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);
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
               // txbMaGiangVien.Text = cbTenGiangVien.SelectedValue.ToString();
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

        private void cbTenMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTenMonHoc.SelectedValue != null)
            {
               // txbMaTGDK.Text = cbTenMonHoc.SelectedValue.ToString();
            }
        }

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
            if (bdsLopTinChi.Count > 0)
            {
                ///txbMaKhoa.Text = ((DataRowView)sPDanhSachLTCKoDKBindingSource[sPDanhSachLTCKoDKBindingSource.Position])["MAKHOA"].ToString();
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
                this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

                this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);
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
                if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
                this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

                this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);
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

                if (Program.severname == "20.255.58.0,1432") a = "VT"; else a = "CNTT";
                this.sP_DanhSachLTCKoDKTableAdapter.Connection.ConnectionString = Program.connstr;

                this.sP_DanhSachLTCKoDKTableAdapter.Fill(this.DS.SP_DanhSachLTCKoDK, a);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txbMaKhoa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txbNienKhoa_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}