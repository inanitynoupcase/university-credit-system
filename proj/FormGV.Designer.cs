
namespace QLNV1
{
    partial class FormGV
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.GvGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giangvienTableAdapter1 = new QLNV1.QLDSVHTCDataSetTableAdapters.GIANGVIENTableAdapter();
            this.GVtable = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLNV1.QLDSVHTCDataSet();
            this.Mabox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hobox = new System.Windows.Forms.TextBox();
            this.Tenbox = new System.Windows.Forms.TextBox();
            this.Hocvibox = new System.Windows.Forms.TextBox();
            this.Hochambox = new System.Windows.Forms.TextBox();
            this.Chuyenmonbox = new System.Windows.Forms.TextBox();
            this.Makhoabox = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.GvGrid);
            this.panelControl1.Location = new System.Drawing.Point(0, 250);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1298, 448);
            this.panelControl1.TabIndex = 0;
            // 
            // GvGrid
            // 
            this.GvGrid.Location = new System.Drawing.Point(-5, 5);
            this.GvGrid.MainView = this.gridView1;
            this.GvGrid.Name = "GvGrid";
            this.GvGrid.Size = new System.Drawing.Size(1298, 438);
            this.GvGrid.TabIndex = 0;
            this.GvGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GvGrid.Click += new System.EventHandler(this.GvGrid_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.GvGrid;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Giảng Viên";
            this.gridColumn1.FieldName = "MAGV";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ Giảng Viên";
            this.gridColumn2.FieldName = "HOGV";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Giảng Viên";
            this.gridColumn3.FieldName = "TENGV";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Học Vị";
            this.gridColumn4.FieldName = "HOCVI";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Học Hàm";
            this.gridColumn5.FieldName = "HOCHAM";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Chuyên Môn";
            this.gridColumn6.FieldName = "CHUYENMON";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã Khoa";
            this.gridColumn7.FieldName = "MAKHOA";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 94;
            // 
            // giangvienTableAdapter1
            // 
            this.giangvienTableAdapter1.ClearBeforeFill = true;
            // 
            // GVtable
            // 
            this.GVtable.DataMember = "GIANGVIEN";
            this.GVtable.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "QLDSVHTCDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Mabox
            // 
            this.Mabox.Location = new System.Drawing.Point(190, 127);
            this.Mabox.Name = "Mabox";
            this.Mabox.Size = new System.Drawing.Size(100, 23);
            this.Mabox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Hobox
            // 
            this.Hobox.Location = new System.Drawing.Point(321, 130);
            this.Hobox.Name = "Hobox";
            this.Hobox.Size = new System.Drawing.Size(100, 23);
            this.Hobox.TabIndex = 3;
            // 
            // Tenbox
            // 
            this.Tenbox.Location = new System.Drawing.Point(452, 130);
            this.Tenbox.Name = "Tenbox";
            this.Tenbox.Size = new System.Drawing.Size(100, 23);
            this.Tenbox.TabIndex = 4;
            // 
            // Hocvibox
            // 
            this.Hocvibox.Location = new System.Drawing.Point(575, 130);
            this.Hocvibox.Name = "Hocvibox";
            this.Hocvibox.Size = new System.Drawing.Size(100, 23);
            this.Hocvibox.TabIndex = 5;
            // 
            // Hochambox
            // 
            this.Hochambox.Location = new System.Drawing.Point(708, 130);
            this.Hochambox.Name = "Hochambox";
            this.Hochambox.Size = new System.Drawing.Size(100, 23);
            this.Hochambox.TabIndex = 6;
            // 
            // Chuyenmonbox
            // 
            this.Chuyenmonbox.Location = new System.Drawing.Point(832, 127);
            this.Chuyenmonbox.Name = "Chuyenmonbox";
            this.Chuyenmonbox.Size = new System.Drawing.Size(100, 23);
            this.Chuyenmonbox.TabIndex = 7;
            // 
            // Makhoabox
            // 
            this.Makhoabox.Location = new System.Drawing.Point(953, 127);
            this.Makhoabox.Name = "Makhoabox";
            this.Makhoabox.Size = new System.Drawing.Size(100, 23);
            this.Makhoabox.TabIndex = 8;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(200, 195);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 9;
            this.StartBtn.Text = "Bắt Đầu";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(321, 194);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Ghi";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // FormGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 698);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.Makhoabox);
            this.Controls.Add(this.Chuyenmonbox);
            this.Controls.Add(this.Hochambox);
            this.Controls.Add(this.Hocvibox);
            this.Controls.Add(this.Tenbox);
            this.Controls.Add(this.Hobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mabox);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormGV";
            this.Text = "FormGV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl GvGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private QLDSVHTCDataSetTableAdapters.GIANGVIENTableAdapter giangvienTableAdapter1;
        private System.Windows.Forms.BindingSource GVtable;
        private QLDSVHTCDataSet DS;
        private System.Windows.Forms.TextBox Mabox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Hobox;
        private System.Windows.Forms.TextBox Tenbox;
        private System.Windows.Forms.TextBox Hocvibox;
        private System.Windows.Forms.TextBox Hochambox;
        private System.Windows.Forms.TextBox Chuyenmonbox;
        private System.Windows.Forms.TextBox Makhoabox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button UpdateBtn;
    }
}