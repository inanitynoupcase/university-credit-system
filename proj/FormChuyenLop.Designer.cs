
namespace QLNV1
{
    partial class FormChuyenLop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LopLabel = new System.Windows.Forms.Label();
            this.TensvBox = new System.Windows.Forms.TextBox();
            this.MasvBox = new System.Windows.Forms.TextBox();
            this.LopBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckInfo = new System.Windows.Forms.Button();
            this.SwitchClassbtn = new System.Windows.Forms.Button();
            this.ComboboxLopHoc = new System.Windows.Forms.ComboBox();
            this.NamLabel = new System.Windows.Forms.Label();
            this.NamHocBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV";
            // 
            // LopLabel
            // 
            this.LopLabel.AutoSize = true;
            this.LopLabel.Location = new System.Drawing.Point(554, 68);
            this.LopLabel.Name = "LopLabel";
            this.LopLabel.Size = new System.Drawing.Size(21, 13);
            this.LopLabel.TabIndex = 2;
            this.LopLabel.Text = "lớp";
            // 
            // TensvBox
            // 
            this.TensvBox.Enabled = false;
            this.TensvBox.Location = new System.Drawing.Point(154, 60);
            this.TensvBox.Name = "TensvBox";
            this.TensvBox.Size = new System.Drawing.Size(211, 21);
            this.TensvBox.TabIndex = 3;
            // 
            // MasvBox
            // 
            this.MasvBox.Enabled = false;
            this.MasvBox.Location = new System.Drawing.Point(432, 60);
            this.MasvBox.Name = "MasvBox";
            this.MasvBox.Size = new System.Drawing.Size(100, 21);
            this.MasvBox.TabIndex = 4;
            // 
            // LopBox
            // 
            this.LopBox.Enabled = false;
            this.LopBox.Location = new System.Drawing.Point(581, 60);
            this.LopBox.Name = "LopBox";
            this.LopBox.Size = new System.Drawing.Size(100, 21);
            this.LopBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã SV";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Lớp";
            // 
            // CheckInfo
            // 
            this.CheckInfo.Location = new System.Drawing.Point(613, 219);
            this.CheckInfo.Name = "CheckInfo";
            this.CheckInfo.Size = new System.Drawing.Size(102, 23);
            this.CheckInfo.TabIndex = 10;
            this.CheckInfo.Text = "Check Thông TIn";
            this.CheckInfo.UseVisualStyleBackColor = true;
            this.CheckInfo.Click += new System.EventHandler(this.CheckInfo_Click);
            // 
            // SwitchClassbtn
            // 
            this.SwitchClassbtn.Location = new System.Drawing.Point(496, 322);
            this.SwitchClassbtn.Name = "SwitchClassbtn";
            this.SwitchClassbtn.Size = new System.Drawing.Size(102, 23);
            this.SwitchClassbtn.TabIndex = 11;
            this.SwitchClassbtn.Text = "Chuyển Lớp";
            this.SwitchClassbtn.UseVisualStyleBackColor = true;
            // 
            // ComboboxLopHoc
            // 
            this.ComboboxLopHoc.Enabled = false;
            this.ComboboxLopHoc.FormattingEnabled = true;
            this.ComboboxLopHoc.Location = new System.Drawing.Point(393, 267);
            this.ComboboxLopHoc.Name = "ComboboxLopHoc";
            this.ComboboxLopHoc.Size = new System.Drawing.Size(205, 21);
            this.ComboboxLopHoc.TabIndex = 12;
            this.ComboboxLopHoc.SelectedIndexChanged += new System.EventHandler(this.ComboboxLopHoc_SelectedIndexChanged);
            // 
            // NamLabel
            // 
            this.NamLabel.AutoSize = true;
            this.NamLabel.Location = new System.Drawing.Point(708, 68);
            this.NamLabel.Name = "NamLabel";
            this.NamLabel.Size = new System.Drawing.Size(49, 13);
            this.NamLabel.TabIndex = 13;
            this.NamLabel.Text = "Năm Học";
            // 
            // NamHocBox
            // 
            this.NamHocBox.Enabled = false;
            this.NamHocBox.Location = new System.Drawing.Point(763, 60);
            this.NamHocBox.Name = "NamHocBox";
            this.NamHocBox.Size = new System.Drawing.Size(100, 21);
            this.NamHocBox.TabIndex = 14;
            // 
            // FormChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 685);
            this.Controls.Add(this.NamHocBox);
            this.Controls.Add(this.NamLabel);
            this.Controls.Add(this.ComboboxLopHoc);
            this.Controls.Add(this.SwitchClassbtn);
            this.Controls.Add(this.CheckInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LopBox);
            this.Controls.Add(this.MasvBox);
            this.Controls.Add(this.TensvBox);
            this.Controls.Add(this.LopLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChuyenLop";
            this.Text = "FormChuyenLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LopLabel;
        private System.Windows.Forms.TextBox TensvBox;
        private System.Windows.Forms.TextBox LopBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CheckInfo;
        private System.Windows.Forms.Button SwitchClassbtn;
        private System.Windows.Forms.ComboBox ComboboxLopHoc;
        private System.Windows.Forms.TextBox MasvBox;
        private System.Windows.Forms.Label NamLabel;
        private System.Windows.Forms.TextBox NamHocBox;
    }
}