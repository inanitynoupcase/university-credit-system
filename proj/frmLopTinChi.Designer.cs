
namespace QLNV1
{
    partial class frmLopTinChi
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label hUYLOPLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopTinChi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLNV1.QLDSVHTCDataSet();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsLopTinChi = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTINCHITableAdapter = new QLNV1.QLDSVHTCDataSetTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLNV1.QLDSVHTCDataSetTableAdapters.TableAdapterManager();
            this.MONHOCTableAdapter = new QLNV1.QLDSVHTCDataSetTableAdapters.MONHOCTableAdapter();
            this.lOPTINCHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.speNhom = new DevExpress.XtraEditors.SpinEdit();
            this.hUYLOPCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.speSoSVToiThieu = new DevExpress.XtraEditors.SpinEdit();
            this.txbMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.cbTenGiangVien = new System.Windows.Forms.ComboBox();
            this.txbMaGiangVien = new DevExpress.XtraEditors.TextEdit();
            this.txbMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.speHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.txbNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDangKi = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYTableAdapter = new QLNV1.QLDSVHTCDataSetTableAdapters.DANGKYTableAdapter();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUYLOPCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoSVToiThieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaGiangVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKi)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(424, 28);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(54, 13);
            nIENKHOALabel.TabIndex = 2;
            nIENKHOALabel.Text = "Niên khóa";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(150, 59);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(39, 13);
            hOCKYLabel.TabIndex = 4;
            hOCKYLabel.Text = "Học kỳ";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(424, 93);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(64, 13);
            mAMHLabel.TabIndex = 6;
            mAMHLabel.Text = "Mã môn học";
            mAMHLabel.Click += new System.EventHandler(this.mAMHLabel_Click);
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(150, 90);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(68, 13);
            tENMHLabel.TabIndex = 8;
            tENMHLabel.Text = "Tên môn học";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(424, 130);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(71, 13);
            mAGVLabel.TabIndex = 10;
            mAGVLabel.Text = "Mã nhân viên";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(150, 126);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(77, 13);
            tENLabel.TabIndex = 12;
            tENLabel.Text = "Tên giảng viên";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(151, 28);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(47, 13);
            mAKHOALabel.TabIndex = 14;
            mAKHOALabel.Text = "Mã khoa";
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(150, 164);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(75, 13);
            sOSVTOITHIEULabel.TabIndex = 16;
            sOSVTOITHIEULabel.Text = "Số sv tối thiểu";
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(423, 163);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(43, 13);
            hUYLOPLabel.TabIndex = 18;
            hUYLOPLabel.Text = "Hủy lớp";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(426, 58);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(34, 13);
            nHOMLabel.TabIndex = 20;
            nHOMLabel.Text = "Nhóm";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnPhucHoi,
            this.btnGhi,
            this.btnHuy,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1083, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 563);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1083, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 518);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1083, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 518);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 45);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1083, 51);
            this.panelControl1.TabIndex = 5;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(439, 15);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(233, 21);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // bdsLopTinChi
            // 
            this.bdsLopTinChi.DataMember = "LOPTINCHI";
            this.bdsLopTinChi.DataSource = this.DS;
            // 
            // LOPTINCHITableAdapter
            // 
            this.LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BUOITHUTableAdapter = null;
            this.tableAdapterManager.CHUYENNGANHTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.DAYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KEHOACHGIANGTableAdapter = null;
            this.tableAdapterManager.KHANANGGIANGDAYTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.LOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THOIGIANDANGKYTableAdapter = null;
            this.tableAdapterManager.THOIGIANHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLNV1.QLDSVHTCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTINCHIGridControl
            // 
            this.lOPTINCHIGridControl.DataSource = this.bdsLopTinChi;
            this.lOPTINCHIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOPTINCHIGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lOPTINCHIGridControl.Location = new System.Drawing.Point(0, 96);
            this.lOPTINCHIGridControl.MainView = this.gridView1;
            this.lOPTINCHIGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lOPTINCHIGridControl.MenuManager = this.barManager1;
            this.lOPTINCHIGridControl.Name = "lOPTINCHIGridControl";
            this.lOPTINCHIGridControl.Size = new System.Drawing.Size(1083, 225);
            this.lOPTINCHIGridControl.TabIndex = 6;
            this.lOPTINCHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.lOPTINCHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colMALTC
            // 
            this.colMALTC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMALTC.AppearanceHeader.Options.UseBackColor = true;
            this.colMALTC.Caption = "Mã lớp tín chi";
            this.colMALTC.FieldName = "IDLTC";
            this.colMALTC.MinWidth = 21;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 81;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colNIENKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 21;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            this.colNIENKHOA.Width = 81;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colHOCKY.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 21;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            this.colHOCKY.Width = 81;
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMAMH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMON";
            this.colMAMH.MinWidth = 21;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            this.colMAMH.Width = 81;
            // 
            // colNHOM
            // 
            this.colNHOM.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colNHOM.AppearanceHeader.Options.UseBackColor = true;
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 21;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 81;
            // 
            // colMAGV
            // 
            this.colMAGV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMAGV.AppearanceHeader.Options.UseBackColor = true;
            this.colMAGV.Caption = "Nhân viên mở lớp";
            this.colMAGV.FieldName = "MANV";
            this.colMAGV.MinWidth = 21;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            this.colMAGV.Width = 81;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colMAKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHOA.Caption = "Mã khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 21;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            this.colMAKHOA.Width = 81;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseBackColor = true;
            this.colSOSVTOITHIEU.Caption = "Số SV tối thiểu";
            this.colSOSVTOITHIEU.FieldName = "SOSINHVIEN_TOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 21;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 7;
            this.colSOSVTOITHIEU.Width = 81;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colHUYLOP.AppearanceHeader.Options.UseBackColor = true;
            this.colHUYLOP.Caption = "Hủy lớp";
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 21;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 8;
            this.colHUYLOP.Width = 81;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cbTenMonHoc);
            this.panelControl2.Controls.Add(nHOMLabel);
            this.panelControl2.Controls.Add(this.speNhom);
            this.panelControl2.Controls.Add(hUYLOPLabel);
            this.panelControl2.Controls.Add(this.hUYLOPCheckEdit);
            this.panelControl2.Controls.Add(sOSVTOITHIEULabel);
            this.panelControl2.Controls.Add(this.speSoSVToiThieu);
            this.panelControl2.Controls.Add(mAKHOALabel);
            this.panelControl2.Controls.Add(this.txbMaKhoa);
            this.panelControl2.Controls.Add(tENLabel);
            this.panelControl2.Controls.Add(this.cbTenGiangVien);
            this.panelControl2.Controls.Add(mAGVLabel);
            this.panelControl2.Controls.Add(this.txbMaGiangVien);
            this.panelControl2.Controls.Add(tENMHLabel);
            this.panelControl2.Controls.Add(mAMHLabel);
            this.panelControl2.Controls.Add(this.txbMaMonHoc);
            this.panelControl2.Controls.Add(hOCKYLabel);
            this.panelControl2.Controls.Add(this.speHocKy);
            this.panelControl2.Controls.Add(nIENKHOALabel);
            this.panelControl2.Controls.Add(this.txbNienKhoa);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 321);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1083, 242);
            this.panelControl2.TabIndex = 7;
            // 
            // cbTenMonHoc
            // 
            this.cbTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenMonHoc.FormattingEnabled = true;
            this.cbTenMonHoc.Location = new System.Drawing.Point(238, 93);
            this.cbTenMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenMonHoc.Name = "cbTenMonHoc";
            this.cbTenMonHoc.Size = new System.Drawing.Size(151, 21);
            this.cbTenMonHoc.TabIndex = 22;
            this.cbTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbTenMonHoc_SelectedIndexChanged);
            this.cbTenMonHoc.SelectedValueChanged += new System.EventHandler(this.cbTenMonHoc_SelectedValueChanged);
            // 
            // speNhom
            // 
            this.speNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "NHOM", true));
            this.speNhom.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speNhom.Location = new System.Drawing.Point(525, 56);
            this.speNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speNhom.MenuManager = this.barManager1;
            this.speNhom.Name = "speNhom";
            this.speNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speNhom.Size = new System.Drawing.Size(169, 20);
            this.speNhom.TabIndex = 21;
            // 
            // hUYLOPCheckEdit
            // 
            this.hUYLOPCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "HUYLOP", true));
            this.hUYLOPCheckEdit.Location = new System.Drawing.Point(483, 161);
            this.hUYLOPCheckEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hUYLOPCheckEdit.MenuManager = this.barManager1;
            this.hUYLOPCheckEdit.Name = "hUYLOPCheckEdit";
            this.hUYLOPCheckEdit.Properties.Caption = "";
            this.hUYLOPCheckEdit.Size = new System.Drawing.Size(81, 20);
            this.hUYLOPCheckEdit.TabIndex = 19;
            // 
            // speSoSVToiThieu
            // 
            this.speSoSVToiThieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "SOSINHVIEN_TOITHIEU", true));
            this.speSoSVToiThieu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speSoSVToiThieu.Location = new System.Drawing.Point(238, 161);
            this.speSoSVToiThieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speSoSVToiThieu.MenuManager = this.barManager1;
            this.speSoSVToiThieu.Name = "speSoSVToiThieu";
            this.speSoSVToiThieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speSoSVToiThieu.Size = new System.Drawing.Size(151, 20);
            this.speSoSVToiThieu.TabIndex = 17;
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "MAKHOA", true));
            this.txbMaKhoa.Location = new System.Drawing.Point(238, 26);
            this.txbMaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaKhoa.MenuManager = this.barManager1;
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Properties.ReadOnly = true;
            this.txbMaKhoa.Size = new System.Drawing.Size(151, 20);
            this.txbMaKhoa.TabIndex = 15;
            // 
            // cbTenGiangVien
            // 
            this.cbTenGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenGiangVien.FormattingEnabled = true;
            this.cbTenGiangVien.Location = new System.Drawing.Point(238, 126);
            this.cbTenGiangVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenGiangVien.Name = "cbTenGiangVien";
            this.cbTenGiangVien.Size = new System.Drawing.Size(151, 21);
            this.cbTenGiangVien.TabIndex = 13;
            this.cbTenGiangVien.SelectedIndexChanged += new System.EventHandler(this.cbTenGiangVien_SelectedIndexChanged);
            this.cbTenGiangVien.SelectedValueChanged += new System.EventHandler(this.cbTenGiangVien_SelectedValueChanged);
            // 
            // txbMaGiangVien
            // 
            this.txbMaGiangVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "MANV", true));
            this.txbMaGiangVien.Location = new System.Drawing.Point(525, 128);
            this.txbMaGiangVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaGiangVien.MenuManager = this.barManager1;
            this.txbMaGiangVien.Name = "txbMaGiangVien";
            this.txbMaGiangVien.Properties.ReadOnly = true;
            this.txbMaGiangVien.Size = new System.Drawing.Size(169, 20);
            this.txbMaGiangVien.TabIndex = 11;
            this.txbMaGiangVien.EditValueChanged += new System.EventHandler(this.txbMaGiangVien_EditValueChanged);
            // 
            // txbMaMonHoc
            // 
            this.txbMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "MAMON", true));
            this.txbMaMonHoc.Location = new System.Drawing.Point(525, 90);
            this.txbMaMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaMonHoc.MenuManager = this.barManager1;
            this.txbMaMonHoc.Name = "txbMaMonHoc";
            this.txbMaMonHoc.Properties.ReadOnly = true;
            this.txbMaMonHoc.Size = new System.Drawing.Size(169, 20);
            this.txbMaMonHoc.TabIndex = 7;
            this.txbMaMonHoc.EditValueChanged += new System.EventHandler(this.txbMaMonHoc_EditValueChanged);
            // 
            // speHocKy
            // 
            this.speHocKy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "HOCKY", true));
            this.speHocKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speHocKy.Location = new System.Drawing.Point(238, 56);
            this.speHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speHocKy.MenuManager = this.barManager1;
            this.speHocKy.Name = "speHocKy";
            this.speHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speHocKy.Size = new System.Drawing.Size(151, 20);
            this.speHocKy.TabIndex = 5;
            // 
            // txbNienKhoa
            // 
            this.txbNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "NIENKHOA", true));
            this.txbNienKhoa.Location = new System.Drawing.Point(525, 24);
            this.txbNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNienKhoa.MenuManager = this.barManager1;
            this.txbNienKhoa.Name = "txbNienKhoa";
            this.txbNienKhoa.Size = new System.Drawing.Size(170, 20);
            this.txbNienKhoa.TabIndex = 3;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DS;
            // 
            // bdsDangKi
            // 
            this.bdsDangKi.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDangKi.DataSource = this.bdsLopTinChi;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // frmLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 583);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.lOPTINCHIGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLopTinChi";
            this.Text = "Lớp tín chỉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUYLOPCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoSVToiThieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaGiangVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLDSVHTCDataSet DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsLopTinChi;
        private QLDSVHTCDataSetTableAdapters.LOPTINCHITableAdapter LOPTINCHITableAdapter;
        private QLDSVHTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPTINCHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txbMaMonHoc;
        private DevExpress.XtraEditors.SpinEdit speHocKy;
        private DevExpress.XtraEditors.TextEdit txbNienKhoa;
        private QLDSVHTCDataSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DevExpress.XtraEditors.TextEdit txbMaGiangVien;
        private System.Windows.Forms.ComboBox cbTenGiangVien;
        private DevExpress.XtraEditors.CheckEdit hUYLOPCheckEdit;
        private DevExpress.XtraEditors.SpinEdit speSoSVToiThieu;
        private DevExpress.XtraEditors.TextEdit txbMaKhoa;
        private System.Windows.Forms.BindingSource bdsDangKi;
        private QLDSVHTCDataSetTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private DevExpress.XtraEditors.SpinEdit speNhom;
        private System.Windows.Forms.ComboBox cbTenMonHoc;
    }
}