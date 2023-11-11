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

namespace QLNV1
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bdsHocPhi = new BindingSource();
        BindingSource bdsCTHP = new BindingSource();
        int vitri = 0;
        int vitri1 = 0;
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadHP()
        {
            string cmd1 = "EXEC [dbo].[SP_GetInfoSV_HP] '" + txbMaSV.Text + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd1);
            if (reader.HasRows == false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại");
                reader.Close();
                return;
            }
            reader.Read();
            txbTenSinhVien.Text = reader.GetString(0);
            txbMaLop.Text = reader.GetString(1);
            reader.Close();
            Program.conn.Close();


            string cmd2 = "EXEC dbo.SP_GetDSHP_SV '" + txbMaSV.Text + "'";
            DataTable tableHocPhi = Program.ExecSqlDataTable(cmd2);
            this.bdsHocPhi.DataSource = tableHocPhi;
            this.HOCPHIGRIDCONTROL.DataSource = this.bdsHocPhi;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txbMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống");
                txbMaSV.Focus();
                return;
            }
            loadHP();
        }

        private void HOCPHIGRIDCONTROL_MouseClick(object sender, MouseEventArgs e)
        {
            if (bdsHocPhi.Count > 0)
            {
                string nienkhoa = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString();
                string hocki = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString();
                string msv = txbMaSV.Text;

                string cmd = "EXEC dbo.SP_GetCTHP_SV '" + msv + "', '" + nienkhoa + "', '" + hocki + "'";
                DataTable tableCTHP = Program.ExecSqlDataTable(cmd);
                this.bdsCTHP.DataSource = tableCTHP;
                this.CT_HOCPHIGRIDCONTROL.DataSource = this.bdsCTHP;
            }
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri1 = bdsHocPhi.Position;
            bdsHocPhi.AddNew();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txbMaSV.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã sinh viên");
                    txbMaSV.Focus();
                    return;
                }
                if (float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCPHI"].ToString()) <= 0)
                {
                    MessageBox.Show("Số tiền không được nhỏ hơn 0đ");
                    return;
                }
                if (((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString() == "")
                {
                    MessageBox.Show("Niên khóa chưa nhập!");
                    return;
                }
                if (((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString() == "")
                {
                    MessageBox.Show("Học kỳ chưa nhập!");
                    return;
                }
                if (((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCPHI"].ToString() == "")
                {
                    MessageBox.Show("Học phí chưa nhập!");
                    return;
                }
                if (float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString()) <= 0)
                {
                    MessageBox.Show("Học kì không được nhỏ hơn 1");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
           
            string msv = txbMaSV.Text;
            string nienkhoa = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString();
            string hocki = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString();
            string hocphi = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCPHI"].ToString();
            bdsHocPhi.EndEdit();
            bdsHocPhi.ResetCurrentItem();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;

            conn.Open();
            tran = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("TAO_THONGTINHOCPHI", conn);
                cmd.Connection = conn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MASV", msv));
                cmd.Parameters.Add(new SqlParameter("@NienKhoa", nienkhoa));
                cmd.Parameters.Add(new SqlParameter("@HocKy", hocki));
                cmd.Parameters.Add(new SqlParameter("@HocPhi", hocphi));
                cmd.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Thêm học phí thành công!");
                loadHP();


            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    XtraMessageBox.Show("Lỗi ghi học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                conn.Close();
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitri = bdsCTHP.Position;
            bdsCTHP.AddNew();
        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString() == "")
                {
                    MessageBox.Show("Số tiền không được bỏ trống");
                    return;
                }
                if (float.Parse(((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString()) <= 0)
                {
                    MessageBox.Show("Số tiền không được nhỏ hơn 0đ");
                    return;
                }

                if (float.Parse(((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString()) > float.Parse(((DataRowView)bdsHocPhi[bdsHocPhi.Position])["SOTIENCANDONG"].ToString()))
                {
                    MessageBox.Show("Số tiền đóng không được lớn hơn số tiền cần đóng!");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string nienkhoa = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["NIENKHOA"].ToString();
            string hocki = ((DataRowView)bdsHocPhi[bdsHocPhi.Position])["HOCKY"].ToString();
            string msv = txbMaSV.Text;
            string sotiendong = ((DataRowView)bdsCTHP[bdsCTHP.Position])["SOTIENDONG"].ToString();
            bdsCTHP.EndEdit();
            bdsCTHP.ResetCurrentItem();
            SqlConnection conn = new SqlConnection(Program.connstr);
            // bắt đầu transaction
            SqlTransaction tran;

            conn.Open();
            tran = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("SV_DONGTIEN", conn);
                cmd.Connection = conn;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MASV", msv));
                cmd.Parameters.Add(new SqlParameter("@NienKhoa", nienkhoa));
                cmd.Parameters.Add(new SqlParameter("@HocKy", hocki));
                cmd.Parameters.Add(new SqlParameter("@SoTienDong", sotiendong));
                cmd.ExecuteNonQuery();





                tran.Commit();
                MessageBox.Show("Thêm chi tiết học phí thành công!");
                loadHP();


            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    XtraMessageBox.Show("Lỗi ghi chit tiết học phí vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                conn.Close();
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsCTHP.CancelEdit();
            frmHocPhi_Load(sender, e);
            if (vitri > 0)
            {
                bdsCTHP.Position = vitri;
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

        private void gridView2_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadHP();
        }

        private void btnPhucHoi1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHocPhi.CancelEdit();
            frmHocPhi_Load(sender, e);
            if (vitri > 0)
            {
                bdsHocPhi.Position = vitri1;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}