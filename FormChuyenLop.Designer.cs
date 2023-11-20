
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
            this.label3 = new System.Windows.Forms.Label();
            this.TensvBox = new System.Windows.Forms.TextBox();
            this.MasvBox = new System.Windows.Forms.TextBox();
            this.LopBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CheckInfo = new System.Windows.Forms.Button();
            this.SwitchClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "lớp";
            // 
            // TensvBox
            // 
            this.TensvBox.Location = new System.Drawing.Point(240, 60);
            this.TensvBox.Name = "TensvBox";
            this.TensvBox.ReadOnly = true;
            this.TensvBox.Size = new System.Drawing.Size(100, 21);
            this.TensvBox.TabIndex = 3;
            // 
            // MasvBox
            // 
            this.MasvBox.Location = new System.Drawing.Point(464, 60);
            this.MasvBox.Name = "MasvBox";
            this.MasvBox.ReadOnly = true;
            this.MasvBox.Size = new System.Drawing.Size(100, 21);
            this.MasvBox.TabIndex = 4;
            // 
            // LopBox
            // 
            this.LopBox.Location = new System.Drawing.Point(695, 60);
            this.LopBox.Name = "LopBox";
            this.LopBox.ReadOnly = true;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(393, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 21);
            this.textBox2.TabIndex = 9;
            // 
            // CheckInfo
            // 
            this.CheckInfo.Location = new System.Drawing.Point(631, 267);
            this.CheckInfo.Name = "CheckInfo";
            this.CheckInfo.Size = new System.Drawing.Size(102, 23);
            this.CheckInfo.TabIndex = 10;
            this.CheckInfo.Text = "Check Thông TIn";
            this.CheckInfo.UseVisualStyleBackColor = true;
            this.CheckInfo.Click += new System.EventHandler(this.CheckInfo_Click);
            // 
            // SwitchClass
            // 
            this.SwitchClass.Location = new System.Drawing.Point(496, 318);
            this.SwitchClass.Name = "SwitchClass";
            this.SwitchClass.Size = new System.Drawing.Size(102, 23);
            this.SwitchClass.TabIndex = 11;
            this.SwitchClass.Text = "Chuyển Lớp";
            this.SwitchClass.UseVisualStyleBackColor = true;
            // 
            // FormChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 685);
            this.Controls.Add(this.SwitchClass);
            this.Controls.Add(this.CheckInfo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LopBox);
            this.Controls.Add(this.MasvBox);
            this.Controls.Add(this.TensvBox);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TensvBox;
        private System.Windows.Forms.TextBox MasvBox;
        private System.Windows.Forms.TextBox LopBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CheckInfo;
        private System.Windows.Forms.Button SwitchClass;
    }
}