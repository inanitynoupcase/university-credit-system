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
    public partial class FormGV : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt;
        public FormGV()
        {
            InitializeComponent();
        }

        private void FormGV_Load(object sender, EventArgs e)
        {
            giangvienTableAdapter1.Fill(this.DS.GIANGVIEN);
            GvGrid.DataSource = GVtable;
            GvGrid.Enabled = false;
            disableComponent();


        }
        private void disableComponent()
        {
            Mabox.Enabled = Hobox.Enabled = Tenbox.Enabled = Hocvibox.Enabled = Hochambox.Enabled = Chuyenmonbox.Enabled = Makhoabox.Enabled =  false;
        }
        private void enableComponent()
        {
            Mabox.Enabled = Hobox.Enabled = Tenbox.Enabled = Hocvibox.Enabled = Hochambox.Enabled = Chuyenmonbox.Enabled = Makhoabox.Enabled = true;

        }
        private void GvGrid_Click(object sender, EventArgs e)
        {
            if (GVtable.Count > 0)
            {
                //  enableComponent(true);
                enableComponent();

                Mabox.Text = ((DataRowView)GVtable[GVtable.Position])["MAGV"].ToString();
                Hobox.Text = ((DataRowView)GVtable[GVtable.Position])["HOGV"].ToString();
                Tenbox.Text = ((DataRowView)GVtable[GVtable.Position])["TENGV"].ToString();
                Hocvibox.Text = ((DataRowView)GVtable[GVtable.Position])["HOCVI"].ToString();
                Hochambox.Text = ((DataRowView)GVtable[GVtable.Position])["HOCHAM"].ToString();
                Chuyenmonbox.Text = ((DataRowView)GVtable[GVtable.Position])["CHUYENMON"].ToString();
                Makhoabox.Text = ((DataRowView)GVtable[GVtable.Position])["MAKHOA"].ToString();

            }


        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            GvGrid.Enabled = true;
        }
    }
}