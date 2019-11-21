namespace _08_Bai8
{
    partial class FormLopHoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaHSRL = new System.Windows.Forms.Button();
            this.lvwDSHVTL = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.lvwDSLH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwDSHV = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemHSVL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaHSRL);
            this.groupBox1.Controls.Add(this.lvwDSHVTL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lvwDSLH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtKhoa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học ";
            // 
            // btnXoaHSRL
            // 
            this.btnXoaHSRL.Location = new System.Drawing.Point(160, 480);
            this.btnXoaHSRL.Name = "btnXoaHSRL";
            this.btnXoaHSRL.Size = new System.Drawing.Size(143, 23);
            this.btnXoaHSRL.TabIndex = 14;
            this.btnXoaHSRL.Text = "Xóa học viên ra khỏi lớp";
            this.btnXoaHSRL.UseVisualStyleBackColor = true;
            this.btnXoaHSRL.Click += new System.EventHandler(this.btnXoaHSRL_Click);
            // 
            // lvwDSHVTL
            // 
            this.lvwDSHVTL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwDSHVTL.FullRowSelect = true;
            this.lvwDSHVTL.GridLines = true;
            this.lvwDSHVTL.HideSelection = false;
            this.lvwDSHVTL.Location = new System.Drawing.Point(20, 315);
            this.lvwDSHVTL.MultiSelect = false;
            this.lvwDSHVTL.Name = "lvwDSHVTL";
            this.lvwDSHVTL.Size = new System.Drawing.Size(357, 157);
            this.lvwDSHVTL.TabIndex = 13;
            this.lvwDSHVTL.UseCompatibleStateImageBehavior = false;
            this.lvwDSHVTL.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã học viên";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên học viên ";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày sinh ";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giới tính";
            this.columnHeader7.Width = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Danh sách học viên trong lớp";
            // 
            // lvwDSLH
            // 
            this.lvwDSLH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwDSLH.FullRowSelect = true;
            this.lvwDSLH.GridLines = true;
            this.lvwDSLH.HideSelection = false;
            this.lvwDSLH.Location = new System.Drawing.Point(20, 134);
            this.lvwDSLH.MultiSelect = false;
            this.lvwDSLH.Name = "lvwDSLH";
            this.lvwDSLH.Size = new System.Drawing.Size(357, 157);
            this.lvwDSLH.TabIndex = 11;
            this.lvwDSLH.UseCompatibleStateImageBehavior = false;
            this.lvwDSLH.View = System.Windows.Forms.View.Details;
            this.lvwDSLH.SelectedIndexChanged += new System.EventHandler(this.lvwDSLH_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã lớp";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khoa";
            this.columnHeader2.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hệ đào tạo";
            this.columnHeader3.Width = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Danh sách lớp học";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(302, 87);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(302, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa lớp";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(302, 63);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa lớp";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(302, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm lớp";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(101, 41);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(195, 20);
            this.txtKhoa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hệ đào tạo";
            // 
            // txtHDT
            // 
            this.txtHDT.Location = new System.Drawing.Point(101, 65);
            this.txtHDT.Name = "txtHDT";
            this.txtHDT.Size = new System.Drawing.Size(195, 20);
            this.txtHDT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khoa";
            // 
            // txtMaL
            // 
            this.txtMaL.Location = new System.Drawing.Point(101, 17);
            this.txtMaL.Name = "txtMaL";
            this.txtMaL.Size = new System.Drawing.Size(195, 20);
            this.txtMaL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học";
            // 
            // lvwDSHV
            // 
            this.lvwDSHV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvwDSHV.FullRowSelect = true;
            this.lvwDSHV.GridLines = true;
            this.lvwDSHV.HideSelection = false;
            this.lvwDSHV.Location = new System.Drawing.Point(412, 38);
            this.lvwDSHV.MultiSelect = false;
            this.lvwDSHV.Name = "lvwDSHV";
            this.lvwDSHV.Size = new System.Drawing.Size(374, 441);
            this.lvwDSHV.TabIndex = 15;
            this.lvwDSHV.UseCompatibleStateImageBehavior = false;
            this.lvwDSHV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã học viên";
            this.columnHeader8.Width = 77;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên học viên";
            this.columnHeader9.Width = 124;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ngày sinh";
            this.columnHeader10.Width = 106;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách học viên";
            // 
            // btnThemHSVL
            // 
            this.btnThemHSVL.Location = new System.Drawing.Point(432, 485);
            this.btnThemHSVL.Name = "btnThemHSVL";
            this.btnThemHSVL.Size = new System.Drawing.Size(143, 23);
            this.btnThemHSVL.TabIndex = 16;
            this.btnThemHSVL.Text = "Thêm học viên vào lớp";
            this.btnThemHSVL.UseVisualStyleBackColor = true;
            this.btnThemHSVL.Click += new System.EventHandler(this.btnThemHSVL_Click);
            // 
            // FormLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 524);
            this.Controls.Add(this.btnThemHSVL);
            this.Controls.Add(this.lvwDSHV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLopHoc";
            this.Text = "frmLophoc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaHSRL;
        private System.Windows.Forms.ListView lvwDSHVTL;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvwDSLH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwDSHV;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemHSVL;
    }
}