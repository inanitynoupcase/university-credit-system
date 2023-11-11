using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNV1
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            DangKibarButton2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            HienThiMenu();
            PhanQuyen();
            this.MANV.Text = "MA " + Program.username;
            this.HOTEN.Text = "HOTEN " + Program.mHoten;
            this.NHOM.Text = "NHOM " + Program.mGroup;
            Console.WriteLine(this.NHOM.Text);
        }
        public void MainForm_Closing(object sender, EventArgs e)
        {
          //  cbKhoa.DataSource = Program.bds_dspm;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void HienThiMenu()
        {
           rpQuanTri.Visible = rpBaoCao.Visible =rpCauHinh.Visible =  true;
        }

        #region EVENT


        private void NhanVienbarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        #endregion

       
        void PhanQuyen()
        {
            if (Program.mGroup.Equals("SV"))
            {
               
                DangKibarButton2.Enabled = true;
                DiemButtonItem.Enabled = HocPhibarButton.Enabled = LopHocbarButton.Enabled = LopTinChibarButton.Enabled = MonHocButtonItem.Enabled = btnSinhVien.Enabled = btnTaoTK.Enabled= false;
                rpBaoCao.Visible = false;
                DIEMSVBTN.Enabled = true;
            }
            if (Program.mGroup.Equals("PKT"))
            {
                HocPhibarButton.Enabled = true;
                DiemButtonItem.Enabled = LopHocbarButton.Enabled = LopTinChibarButton.Enabled = MonHocButtonItem.Enabled = btnSinhVien.Enabled = DangKibarButton2.Enabled= false;
                rpBaoCao.Visible = false;
            }
            if(Program.mGroup.Equals("PGV")|| Program.mGroup.Equals("KHOA"))
            {
                DangKibarButton2.Enabled= HocPhibarButton.Enabled= false;
            }
        }
        private void LopHocbarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmLopHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmLopHoc f = new frmLopHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void MonHocButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void LopTinChibarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frmLopTinChi f = new frmLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void DangKibarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKi));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKi f = new frmDangKi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void DiemButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmDiem f = new frmDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void HocPhibarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLapPhieuNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptInDSSVLTC));
            if (frm != null) frm.Activate();
            else
            {
                frptInDSSVLTC f = new frptInDSSVLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptDSLTC));
            if (frm != null) frm.Activate();
            else
            {
                frptDSLTC f = new frptDSLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptBDHM));
            if (frm != null) frm.Activate();
            else
            {
                frptBDHM f = new frptBDHM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptPhieuDiemSV));
            if (frm != null) frm.Activate();
            else
            {
                frptPhieuDiemSV f = new frptPhieuDiemSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frptHocPhi f = new frptHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Form frmDangNhap = new frmDangNhap();

            this.Close();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptBDTK));
            if (frm != null) frm.Activate();
            else
            {
                frptBDTK f = new frptBDTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(DiemSVForm));
            if (frm != null) frm.Activate();
            else
            {
                DiemSVForm f = new DiemSVForm();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
