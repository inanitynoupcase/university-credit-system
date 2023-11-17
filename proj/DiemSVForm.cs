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
    public partial class DiemSVForm : DevExpress.XtraEditors.XtraForm
    {
        float SumDiem;

        public DiemSVForm()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void InitDiemSV(object sender, EventArgs e)
        {
            string cmd = "EXEC SP_LayDiemTheoSV '" + Program.username + "'";
            DataTable tableDiem = Program.ExecSqlDataTable(cmd);
            foreach (DataColumn column in tableDiem.Columns)
            {
                Console.Write(column.ColumnName.PadRight(15) + "\t");
            }
            BindingSource TableSource = new BindingSource();
            TableSource.DataSource = tableDiem;
            this.DiemSVGrid.DataSource = TableSource;
            foreach (DataRow row in tableDiem.Rows)
            {
                // Replace "DIEM_TK" with the actual column name
                if (row["DIEM_TK"] != DBNull.Value)
                {
                    float diemTkValue = Convert.ToSingle(row["DIEM_TK"]);
                    SumDiem += diemTkValue;
                }
            }
            SumDiem = SumDiem / tableDiem.Rows.Count;
            diemtbbox.Text = SumDiem.ToString("F2");



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void diemtbbox_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}