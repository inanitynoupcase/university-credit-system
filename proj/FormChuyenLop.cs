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
    public partial class FormChuyenLop : DevExpress.XtraEditors.XtraForm
    {
        string MAsv;
        public FormChuyenLop()
        {
            InitializeComponent();
            SwitchClassbtn.Enabled = false;
        }

        private void CheckInfo_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("mã sinh viên không được trống");
            }
            else
            {
                string cmd = "EXEC [dbo].[SP_LayThongTinSV] '" + textBox1.Text + "'";
                DataTable dt = Program.ExecSqlDataTable(cmd);
                if(dt.Rows.Count > 0)
                {
                    
                    TensvBox.Text = dt.Rows[0].ItemArray[0].ToString();
                    MasvBox.Text = dt.Rows[0].ItemArray[1].ToString();
                    LopBox.Text = dt.Rows[0].ItemArray[2].ToString();
                    NamHocBox.Text = dt.Rows[0].ItemArray[3].ToString();
                    string cmd2 = "EXEC [dbo].[SP_LayLopTheoNam] " + NamHocBox.Text;
                    DataTable dtLop = Program.ExecSqlDataTable(cmd2);
                    if (dt.Rows.Count > 0)
                    {
                        ComboboxLopHoc.DataSource = dtLop;
                        ComboboxLopHoc.DisplayMember = "MALOP";
                        ComboboxLopHoc.Enabled = true;

                        foreach (var item in ComboboxLopHoc.Items)
                        {
                            DataRowView dataRowView = (DataRowView)item;
                            string malop = dataRowView["MALOP"].ToString();

                            Console.WriteLine(malop + " " + LopBox.Text);

                            if (malop == LopBox.Text)
                            {
                                ComboboxLopHoc.SelectedItem = item;
                                Console.WriteLine("FOUND ITEM");
                                break; // Exit the loop once the item is found
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("sinh viên chưa có lớp");

                    }

                }
                else
                {
                    MessageBox.Show("sinh viên không tồn tại hoặc đã nghỉ học");
                }

            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MAsv = textBox1.Text;
        }

        private void ComboboxLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}