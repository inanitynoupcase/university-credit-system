
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
            this.label3 = new System.Windows.Forms.Label();
            this.Khoabox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV";
            // 
            // LopLabel
            // 
            this.LopLabel.AutoSize = true;
            this.LopLabel.Location = new System.Drawing.Point(646, 84);
            this.LopLabel.Name = "LopLabel";
            this.LopLabel.Size = new System.Drawing.Size(26, 17);
            this.LopLabel.TabIndex = 2;
            this.LopLabel.Text = "lớp";
            // 
            // TensvBox
            // 
            this.TensvBox.Enabled = false;
            this.TensvBox.Location = new System.Drawing.Point(186, 81);
            this.TensvBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TensvBox.Name = "TensvBox";
            this.TensvBox.Size = new System.Drawing.Size(245, 23);
            this.TensvBox.TabIndex = 3;
            // 
            // MasvBox
            // 
            this.MasvBox.Enabled = false;
            this.MasvBox.Location = new System.Drawing.Point(506, 84);
            this.MasvBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MasvBox.Name = "MasvBox";
            this.MasvBox.Size = new System.Drawing.Size(116, 23);
            this.MasvBox.TabIndex = 4;
            // 
            // LopBox
            // 
            this.LopBox.Enabled = false;
            this.LopBox.Location = new System.Drawing.Point(678, 84);
            this.LopBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LopBox.Name = "LopBox";
            this.LopBox.Size = new System.Drawing.Size(116, 23);
            this.LopBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã SV";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 270);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Lớp";
            // 
            // CheckInfo
            // 
            this.CheckInfo.Location = new System.Drawing.Point(715, 270);
            this.CheckInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckInfo.Name = "CheckInfo";
            this.CheckInfo.Size = new System.Drawing.Size(123, 28);
            this.CheckInfo.TabIndex = 10;
            this.CheckInfo.Text = "Check Thông TIn";
            this.CheckInfo.UseVisualStyleBackColor = true;
            this.CheckInfo.Click += new System.EventHandler(this.CheckInfo_Click);
            // 
            // SwitchClassbtn
            // 
            this.SwitchClassbtn.Location = new System.Drawing.Point(579, 396);
            this.SwitchClassbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SwitchClassbtn.Name = "SwitchClassbtn";
            this.SwitchClassbtn.Size = new System.Drawing.Size(119, 28);
            this.SwitchClassbtn.TabIndex = 11;
            this.SwitchClassbtn.Text = "Chuyển Lớp";
            this.SwitchClassbtn.UseVisualStyleBackColor = true;
            this.SwitchClassbtn.Click += new System.EventHandler(this.SwitchClassbtn_Click);
            // 
            // ComboboxLopHoc
            // 
            this.ComboboxLopHoc.Enabled = false;
            this.ComboboxLopHoc.FormattingEnabled = true;
            this.ComboboxLopHoc.Location = new System.Drawing.Point(458, 335);
            this.ComboboxLopHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboboxLopHoc.Name = "ComboboxLopHoc";
            this.ComboboxLopHoc.Size = new System.Drawing.Size(238, 24);
            this.ComboboxLopHoc.TabIndex = 12;
            this.ComboboxLopHoc.SelectedIndexChanged += new System.EventHandler(this.ComboboxLopHoc_SelectedIndexChanged);
            // 
            // NamLabel
            // 
            this.NamLabel.AutoSize = true;
            this.NamLabel.Location = new System.Drawing.Point(826, 84);
            this.NamLabel.Name = "NamLabel";
            this.NamLabel.Size = new System.Drawing.Size(64, 17);
            this.NamLabel.TabIndex = 13;
            this.NamLabel.Text = "Năm Học";
            // 
            // NamHocBox
            // 
            this.NamHocBox.Enabled = false;
            this.NamHocBox.Location = new System.Drawing.Point(896, 84);
            this.NamHocBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NamHocBox.Name = "NamHocBox";
            this.NamHocBox.Size = new System.Drawing.Size(116, 23);
            this.NamHocBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1039, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Khoa";
            // 
            // Khoabox
            // 
            this.Khoabox.Enabled = false;
            this.Khoabox.Location = new System.Drawing.Point(1084, 84);
            this.Khoabox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Khoabox.Name = "Khoabox";
            this.Khoabox.Size = new System.Drawing.Size(129, 23);
            this.Khoabox.TabIndex = 16;
            // 
            // FormChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 843);
            this.Controls.Add(this.Khoabox);
            this.Controls.Add(this.label3);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Khoabox;
    }
}