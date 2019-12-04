namespace baikt
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bổSungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.svVan = new System.Windows.Forms.ToolStripMenuItem();
            this.svVatLy = new System.Windows.Forms.ToolStripMenuItem();
            this.SvCNTT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.tcDiem = new System.Windows.Forms.TabControl();
            this.tpVan = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpVatLy = new System.Windows.Forms.TabPage();
            this.txtVLHN = new System.Windows.Forms.TextBox();
            this.txtDien = new System.Windows.Forms.TextBox();
            this.txtQuangHoc = new System.Windows.Forms.TextBox();
            this.txtCoHoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpCNTT = new System.Windows.Forms.TabPage();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.txtCSharp = new System.Windows.Forms.TextBox();
            this.txtPascal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxNam = new System.Windows.Forms.CheckBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_DanhSach = new System.Windows.Forms.ListView();
            this.txtVHCD = new System.Windows.Forms.TextBox();
            this.txtVHHD = new System.Windows.Forms.TextBox();
            this.mnLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tcDiem.SuspendLayout();
            this.tpVan.SuspendLayout();
            this.tpVatLy.SuspendLayout();
            this.tpCNTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bổSungToolStripMenuItem,
            this.mnLuu,
            this.mnXoa,
            this.mnSua});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bổSungToolStripMenuItem
            // 
            this.bổSungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.svVan,
            this.svVatLy,
            this.SvCNTT});
            this.bổSungToolStripMenuItem.Name = "bổSungToolStripMenuItem";
            this.bổSungToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.bổSungToolStripMenuItem.Text = "Bổ sung";
            // 
            // svVan
            // 
            this.svVan.CheckOnClick = true;
            this.svVan.Name = "svVan";
            this.svVan.Size = new System.Drawing.Size(152, 22);
            this.svVan.Text = "Sv Văn";
            this.svVan.Click += new System.EventHandler(this.svVan_Click);
            // 
            // svVatLy
            // 
            this.svVatLy.Name = "svVatLy";
            this.svVatLy.Size = new System.Drawing.Size(152, 22);
            this.svVatLy.Text = "Sv Vật lý";
            this.svVatLy.Click += new System.EventHandler(this.svVatLy_Click);
            // 
            // SvCNTT
            // 
            this.SvCNTT.Name = "SvCNTT";
            this.SvCNTT.Size = new System.Drawing.Size(152, 22);
            this.SvCNTT.Text = "Sv Cntt";
            this.SvCNTT.Click += new System.EventHandler(this.SvCNTT_Click);
            // 
            // mnXoa
            // 
            this.mnXoa.Name = "mnXoa";
            this.mnXoa.Size = new System.Drawing.Size(39, 20);
            this.mnXoa.Text = "Xóa";
            this.mnXoa.Click += new System.EventHandler(this.mnXoa_Click);
            // 
            // mnSua
            // 
            this.mnSua.Name = "mnSua";
            this.mnSua.Size = new System.Drawing.Size(67, 20);
            this.mnSua.Text = "Cập nhật";
            this.mnSua.Click += new System.EventHandler(this.mnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDTB);
            this.groupBox1.Controls.Add(this.tcDiem);
            this.groupBox1.Controls.Add(this.checkBoxNam);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(397, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 368);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(52, 342);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(211, 20);
            this.txtDTB.TabIndex = 6;
            // 
            // tcDiem
            // 
            this.tcDiem.Controls.Add(this.tpVan);
            this.tcDiem.Controls.Add(this.tpVatLy);
            this.tcDiem.Controls.Add(this.tpCNTT);
            this.tcDiem.Location = new System.Drawing.Point(9, 144);
            this.tcDiem.Name = "tcDiem";
            this.tcDiem.SelectedIndex = 0;
            this.tcDiem.Size = new System.Drawing.Size(264, 189);
            this.tcDiem.TabIndex = 5;
            // 
            // tpVan
            // 
            this.tpVan.Controls.Add(this.txtVHHD);
            this.tpVan.Controls.Add(this.txtVHCD);
            this.tpVan.Controls.Add(this.label4);
            this.tpVan.Controls.Add(this.label3);
            this.tpVan.Location = new System.Drawing.Point(4, 22);
            this.tpVan.Name = "tpVan";
            this.tpVan.Padding = new System.Windows.Forms.Padding(3);
            this.tpVan.Size = new System.Drawing.Size(256, 163);
            this.tpVan.TabIndex = 0;
            this.tpVan.Text = "Văn";
            this.tpVan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Văn học HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Văn học CĐ";
            // 
            // tpVatLy
            // 
            this.tpVatLy.Controls.Add(this.txtVLHN);
            this.tpVatLy.Controls.Add(this.txtDien);
            this.tpVatLy.Controls.Add(this.txtQuangHoc);
            this.tpVatLy.Controls.Add(this.txtCoHoc);
            this.tpVatLy.Controls.Add(this.label8);
            this.tpVatLy.Controls.Add(this.label7);
            this.tpVatLy.Controls.Add(this.label6);
            this.tpVatLy.Controls.Add(this.label5);
            this.tpVatLy.Location = new System.Drawing.Point(4, 22);
            this.tpVatLy.Name = "tpVatLy";
            this.tpVatLy.Padding = new System.Windows.Forms.Padding(3);
            this.tpVatLy.Size = new System.Drawing.Size(256, 163);
            this.tpVatLy.TabIndex = 1;
            this.tpVatLy.Text = "Vật lý";
            this.tpVatLy.UseVisualStyleBackColor = true;
            // 
            // txtVLHN
            // 
            this.txtVLHN.Location = new System.Drawing.Point(102, 129);
            this.txtVLHN.Name = "txtVLHN";
            this.txtVLHN.Size = new System.Drawing.Size(148, 20);
            this.txtVLHN.TabIndex = 7;
            // 
            // txtDien
            // 
            this.txtDien.Location = new System.Drawing.Point(102, 87);
            this.txtDien.Name = "txtDien";
            this.txtDien.Size = new System.Drawing.Size(148, 20);
            this.txtDien.TabIndex = 6;
            // 
            // txtQuangHoc
            // 
            this.txtQuangHoc.Location = new System.Drawing.Point(102, 50);
            this.txtQuangHoc.Name = "txtQuangHoc";
            this.txtQuangHoc.Size = new System.Drawing.Size(148, 20);
            this.txtQuangHoc.TabIndex = 5;
            // 
            // txtCoHoc
            // 
            this.txtCoHoc.Location = new System.Drawing.Point(102, 15);
            this.txtCoHoc.Name = "txtCoHoc";
            this.txtCoHoc.Size = new System.Drawing.Size(148, 20);
            this.txtCoHoc.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "VL Hạt nhân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Điện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quang học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cơ học";
            // 
            // tpCNTT
            // 
            this.tpCNTT.Controls.Add(this.txtSQL);
            this.tpCNTT.Controls.Add(this.txtCSharp);
            this.tpCNTT.Controls.Add(this.txtPascal);
            this.tpCNTT.Controls.Add(this.label11);
            this.tpCNTT.Controls.Add(this.label10);
            this.tpCNTT.Controls.Add(this.label9);
            this.tpCNTT.Location = new System.Drawing.Point(4, 22);
            this.tpCNTT.Name = "tpCNTT";
            this.tpCNTT.Size = new System.Drawing.Size(256, 163);
            this.tpCNTT.TabIndex = 2;
            this.tpCNTT.Text = "CNTT";
            this.tpCNTT.UseVisualStyleBackColor = true;
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(107, 109);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(146, 20);
            this.txtSQL.TabIndex = 5;
            // 
            // txtCSharp
            // 
            this.txtCSharp.Location = new System.Drawing.Point(107, 63);
            this.txtCSharp.Name = "txtCSharp";
            this.txtCSharp.Size = new System.Drawing.Size(146, 20);
            this.txtCSharp.TabIndex = 4;
            // 
            // txtPascal
            // 
            this.txtPascal.Location = new System.Drawing.Point(107, 21);
            this.txtPascal.Name = "txtPascal";
            this.txtPascal.Size = new System.Drawing.Size(146, 20);
            this.txtPascal.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "SQL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "C Sharp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pascal";
            // 
            // checkBoxNam
            // 
            this.checkBoxNam.AutoSize = true;
            this.checkBoxNam.Location = new System.Drawing.Point(95, 57);
            this.checkBoxNam.Name = "checkBoxNam";
            this.checkBoxNam.Size = new System.Drawing.Size(48, 17);
            this.checkBoxNam.TabIndex = 4;
            this.checkBoxNam.Text = "Nam";
            this.checkBoxNam.UseVisualStyleBackColor = true;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(95, 96);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(178, 20);
            this.txtNgaySinh.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(95, 31);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(178, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // lv_DanhSach
            // 
            this.lv_DanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_DanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.lv_DanhSach.FullRowSelect = true;
            this.lv_DanhSach.GridLines = true;
            this.lv_DanhSach.Location = new System.Drawing.Point(0, 24);
            this.lv_DanhSach.Name = "lv_DanhSach";
            this.lv_DanhSach.Size = new System.Drawing.Size(391, 368);
            this.lv_DanhSach.TabIndex = 2;
            this.lv_DanhSach.UseCompatibleStateImageBehavior = false;
            this.lv_DanhSach.View = System.Windows.Forms.View.Details;
            this.lv_DanhSach.SelectedIndexChanged += new System.EventHandler(this.lv_DanhSach_SelectedIndexChanged);
            // 
            // txtVHCD
            // 
            this.txtVHCD.Location = new System.Drawing.Point(134, 23);
            this.txtVHCD.Name = "txtVHCD";
            this.txtVHCD.Size = new System.Drawing.Size(100, 20);
            this.txtVHCD.TabIndex = 2;
            // 
            // txtVHHD
            // 
            this.txtVHHD.Location = new System.Drawing.Point(134, 66);
            this.txtVHHD.Name = "txtVHHD";
            this.txtVHHD.Size = new System.Drawing.Size(100, 20);
            this.txtVHHD.TabIndex = 3;
            // 
            // mnLuu
            // 
            this.mnLuu.Name = "mnLuu";
            this.mnLuu.Size = new System.Drawing.Size(39, 20);
            this.mnLuu.Text = "Lưu";
            this.mnLuu.Click += new System.EventHandler(this.mnLuu_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MaSV";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TenSV";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khoa";
            this.columnHeader3.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 392);
            this.Controls.Add(this.lv_DanhSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcDiem.ResumeLayout(false);
            this.tpVan.ResumeLayout(false);
            this.tpVan.PerformLayout();
            this.tpVatLy.ResumeLayout(false);
            this.tpVatLy.PerformLayout();
            this.tpCNTT.ResumeLayout(false);
            this.tpCNTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bổSungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem svVan;
        private System.Windows.Forms.ToolStripMenuItem svVatLy;
        private System.Windows.Forms.ToolStripMenuItem SvCNTT;
        private System.Windows.Forms.ToolStripMenuItem mnXoa;
        private System.Windows.Forms.ToolStripMenuItem mnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tcDiem;
        private System.Windows.Forms.TabPage tpVan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpVatLy;
        private System.Windows.Forms.TextBox txtVLHN;
        private System.Windows.Forms.TextBox txtDien;
        private System.Windows.Forms.TextBox txtQuangHoc;
        private System.Windows.Forms.TextBox txtCoHoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpCNTT;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.TextBox txtCSharp;
        private System.Windows.Forms.TextBox txtPascal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxNam;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_DanhSach;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtVHHD;
        private System.Windows.Forms.TextBox txtVHCD;
        private System.Windows.Forms.ToolStripMenuItem mnLuu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

