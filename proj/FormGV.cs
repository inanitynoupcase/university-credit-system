using DevExpress.XtraEditors;
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
    public partial class FormGV : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        DataTable dt;
        int vitri = 0;
        public FormGV()
        {
            InitializeComponent();
        }

        private void FormGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
            gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
            GvGrid.DataSource = gIANGVIENBindingSource;
            GvGrid.Enabled = true;
            panelControl1.Enabled = false;
           // disableComponent();


        }
        private void disableComponent()
        {
            //Mabox.Enabled = Hobox.Enabled = Tenbox.Enabled = Hocvibox.Enabled = Hochambox.Enabled = Chuyenmonbox.Enabled = Makhoabox.Enabled =  false;
        }
        private void enableComponent()
        {
          //  Mabox.Enabled = Hobox.Enabled = Tenbox.Enabled = Hocvibox.Enabled = Hochambox.Enabled = Chuyenmonbox.Enabled = Makhoabox.Enabled = true;

        }
        private void GvGrid_Click(object sender, EventArgs e)
        {
            if (gIANGVIENBindingSource.Count > 0)
            {
                //  enableComponent(true);
               // enableComponent();

             //   Mabox.Text = ((DataRowView)gIANGVIENBindingSource[gIANGVIENBindingSource.Position])["MAGV"].ToString();
               // Hobox.Text = ((DataRowView)gIANGVIENBindingSource[gIANGVIENBindingSource.Position])["HOGV"].ToString();
              //  Tenbox.Text = ((DataRowView)gIANGVIENBindingSource[gIANGVIENBindingSource.Position])["TENGV"].ToString();
               // Hocvibox.Text = ((DataRowView)gIANGVIENBindingSource[gIANGVIENBindingSource.Position])["HOCVI"].ToString();
              //  Hochambox.Text = ((DataRowView)gIANGVIENBindingSource[gIANGVIENBindingSource.Position])["HOCHAM"].ToString();
               // Chuyenmonbox.Text = ((DataRowView)gIANGVIENBindingSource[gIANGVIENBindingSource.Position])["CHUYENMON"].ToString();
                //Makhoabox.Text = ((DataRowView)gIANGVIENBindingSource[gIANGVIENBindingSource.Position])["MAKHOA"].ToString();

            }


        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            GvGrid.Enabled = true;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = gIANGVIENBindingSource.Position;
            panelControl1.Enabled = true;

            gIANGVIENBindingSource.AddNew();
            txbMaGV.Text = ((DataRowView)gIANGVIENBindingSource[gIANGVIENBindingSource.Position])["MAGV"].ToString();
            txbMaKhoa.Text = Program.MaKhoa;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            GvGrid.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = gIANGVIENBindingSource.Position;
            txbMaGV.Enabled = false;
            panelControl1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = true;
            GvGrid.Enabled = false;
        }

         private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
            if (txbMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã GV không được thiếu!", "", MessageBoxButtons.OK);
                txbMaGV.Focus();
                return;
            }
            if (txbHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ GV không được thiếu!", "", MessageBoxButtons.OK);
                txbHo.Focus();
                return;
            }
            if (txbTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên GV không được thiếu!", "", MessageBoxButtons.OK);
                txbTen.Focus();
                return;
            }
            if (txbHocVi.Text.Trim() == "")
            {
                MessageBox.Show("Học vị không được thiếu!", "", MessageBoxButtons.OK);
                txbHocVi.Focus();
                return;
            }
            if (txbHocHam.Text.Trim() == "")
            {
                MessageBox.Show("Học hàm không được thiếu!", "", MessageBoxButtons.OK);
                txbHocHam.Focus();
                return;
            }
            if (txbChuyenMon.Text.Trim() == "")
            {
                MessageBox.Show("Chuyên môn không được thiếu!", "", MessageBoxButtons.OK);
                txbChuyenMon.Focus();
                return;
            }
            if (txbMaKhoa.Text.Trim() != Program.MaKhoa)
            {
                MessageBox.Show("Vui lòng chọn đúng khoa của giảng viên này!", "", MessageBoxButtons.OK);
                txbChuyenMon.Focus();
                return;
            }


            try
            {
               
                 Console.WriteLine(txbMaGV.Text + " " + txbHo.Text + " " + txbTen.Text + " " + txbHocVi.Text + " " + txbHocHam.Text + " " + txbChuyenMon.Text + " " + txbMaKhoa.Text);
                 // Lưu giá trị từ TextBox vào biến
                  string maKhoa = txbMaKhoa.Text;
                    gIANGVIENBindingSource.EndEdit();
                    gIANGVIENBindingSource.ResetCurrentItem();
                // Cập nhật dữ liệu vào bảng GIANGVIEN
                string cmd = "Exec [dbo].[AddOrUpdateGiangVien] '" + txbMaGV.Text + "',N'" + txbHo.Text + "',N'" + txbTen.Text + "',N'" + txbHocVi.Text + "',N'" + txbHocHam.Text + "',N'" + txbChuyenMon.Text + "','"+ Program.MaKhoa + "'";
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    // Hiển thị thông báo thành công
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gIANGVIENBindingSource.EndEdit();
                    gIANGVIENBindingSource.ResetCurrentItem();
                    this.gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);

                }
                else
                {
                    MessageBox.Show("Ghi dữ liệu lớp tín chỉ thất bại!");
                }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Lỗi ghi giảng viên: " + ex.Message, "", MessageBoxButtons.OK);
                     return;
                 }
                 GvGrid.Enabled = true;
                 btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                 btnGhi.Enabled = btnPhucHoi.Enabled = false;
                 panelControl1.Enabled = false;
           //  }
           //  else
         //    {
                // return;
        //     }
         }
       
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = false;
            GvGrid.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = true;

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mabox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbMaGV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txbHo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}