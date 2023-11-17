
namespace QLNV1
{
    partial class DiemSVForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiemSVGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.DiemSVGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // DiemSVGrid
            // 
            this.DiemSVGrid.Location = new System.Drawing.Point(1, 137);
            this.DiemSVGrid.MainView = this.gridView1;
            this.DiemSVGrid.Name = "DiemSVGrid";
            this.DiemSVGrid.Size = new System.Drawing.Size(1260, 632);
            this.DiemSVGrid.TabIndex = 0;
            this.DiemSVGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DiemSVGrid.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.DiemSVGrid;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gridColumn7.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn7.Caption = "Mã Môn";
            this.gridColumn7.FieldName = "MAMON";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.Caption = "Tên Môn";
            this.gridColumn1.FieldName = "TENMON";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 223;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.Caption = "Năm Học";
            this.gridColumn2.FieldName = "NAM";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 137;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.Caption = "Học Kỳ";
            this.gridColumn3.FieldName = "HOCKY";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 158;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.Caption = "Điểm CC";
            this.gridColumn4.FieldName = "DIEM_CC";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 197;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.Caption = "Điểm Giữa Kì";
            this.gridColumn5.FieldName = "DIEM_GK";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 197;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.gridColumn6.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.Caption = "Điểm Cuối Kì";
            this.gridColumn6.FieldName = "DIEM_CK";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 221;
            // 
            // MAMON
            // 
            this.MAMON.AppearanceHeader.BackColor = System.Drawing.Color.Red;
            this.MAMON.AppearanceHeader.Options.UseBackColor = true;
            this.MAMON.Caption = "Mã Môn";
            this.MAMON.MinWidth = 25;
            this.MAMON.Name = "MAMON";
            this.MAMON.OptionsColumn.AllowEdit = false;
            this.MAMON.Visible = true;
            this.MAMON.VisibleIndex = 0;
            this.MAMON.Width = 97;
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(1, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1263, 42);
            this.panelControl1.TabIndex = 1;
            // 
            // DiemSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 843);
            this.Controls.Add(this.DiemSVGrid);
            this.Controls.Add(this.panelControl1);
            this.Name = "DiemSVForm";
            this.Text = "DiemSVForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InitDiemSV);
            ((System.ComponentModel.ISupportInitialize)(this.DiemSVGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DiemSVGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn MAMON;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}