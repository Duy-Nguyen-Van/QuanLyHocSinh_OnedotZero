namespace QuanLyHocSinh_OnedotZero
{
    partial class frm_LapDanhSachLop
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
			this.lbl_Khoi = new System.Windows.Forms.Label();
			this.lbl_Lop = new System.Windows.Forms.Label();
			this.lbl_SiSo = new System.Windows.Forms.Label();
			this.cbo_Khoi = new System.Windows.Forms.ComboBox();
			this.cbo_Lop = new System.Windows.Forms.ComboBox();
			this.cbo_SiSo = new System.Windows.Forms.ComboBox();
			this.bt_Luu = new System.Windows.Forms.Button();
			this.bt_Xoa = new System.Windows.Forms.Button();
			this.bt_Them = new System.Windows.Forms.Button();
			this.bt_LopMoi = new System.Windows.Forms.Button();
			this.bt_Thoat = new System.Windows.Forms.Button();
			this.lb_HoTen = new System.Windows.Forms.Label();
			this.grp_ThongTinHocSinh = new System.Windows.Forms.GroupBox();
			this.cbo_HoTen = new System.Windows.Forms.ComboBox();
			this.gc_DanhSachHocSinhLop = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grp_DanhSachHocSinh = new System.Windows.Forms.GroupBox();
			this.txt_Lop = new System.Windows.Forms.TextBox();
			this.grp_ThongTinHocSinh.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gc_DanhSachHocSinhLop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.grp_DanhSachHocSinh.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_Khoi
			// 
			this.lbl_Khoi.AutoSize = true;
			this.lbl_Khoi.BackColor = System.Drawing.SystemColors.Control;
			this.lbl_Khoi.Location = new System.Drawing.Point(16, 32);
			this.lbl_Khoi.Name = "lbl_Khoi";
			this.lbl_Khoi.Size = new System.Drawing.Size(28, 13);
			this.lbl_Khoi.TabIndex = 0;
			this.lbl_Khoi.Text = "Khối";
			// 
			// lbl_Lop
			// 
			this.lbl_Lop.AutoSize = true;
			this.lbl_Lop.Location = new System.Drawing.Point(16, 62);
			this.lbl_Lop.Name = "lbl_Lop";
			this.lbl_Lop.Size = new System.Drawing.Size(25, 13);
			this.lbl_Lop.TabIndex = 1;
			this.lbl_Lop.Text = "Lớp";
			// 
			// lbl_SiSo
			// 
			this.lbl_SiSo.AutoSize = true;
			this.lbl_SiSo.Location = new System.Drawing.Point(338, 35);
			this.lbl_SiSo.Name = "lbl_SiSo";
			this.lbl_SiSo.Size = new System.Drawing.Size(33, 13);
			this.lbl_SiSo.TabIndex = 2;
			this.lbl_SiSo.Text = "Sĩ số";
			// 
			// cbo_Khoi
			// 
			this.cbo_Khoi.FormattingEnabled = true;
			this.cbo_Khoi.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
			this.cbo_Khoi.Location = new System.Drawing.Point(62, 25);
			this.cbo_Khoi.Name = "cbo_Khoi";
			this.cbo_Khoi.Size = new System.Drawing.Size(140, 21);
			this.cbo_Khoi.TabIndex = 3;
			this.cbo_Khoi.SelectedIndexChanged += new System.EventHandler(this.cbo_Khoi_SelectedIndexChanged);
			// 
			// cbo_Lop
			// 
			this.cbo_Lop.FormattingEnabled = true;
			this.cbo_Lop.Location = new System.Drawing.Point(62, 59);
			this.cbo_Lop.Name = "cbo_Lop";
			this.cbo_Lop.Size = new System.Drawing.Size(140, 21);
			this.cbo_Lop.TabIndex = 4;
			this.cbo_Lop.SelectedIndexChanged += new System.EventHandler(this.cbo_Lop_SelectedIndexChanged);
			// 
			// cbo_SiSo
			// 
			this.cbo_SiSo.FormattingEnabled = true;
			this.cbo_SiSo.Location = new System.Drawing.Point(377, 32);
			this.cbo_SiSo.Name = "cbo_SiSo";
			this.cbo_SiSo.Size = new System.Drawing.Size(74, 21);
			this.cbo_SiSo.TabIndex = 5;
			// 
			// bt_Luu
			// 
			this.bt_Luu.Location = new System.Drawing.Point(150, 156);
			this.bt_Luu.Name = "bt_Luu";
			this.bt_Luu.Size = new System.Drawing.Size(75, 23);
			this.bt_Luu.TabIndex = 7;
			this.bt_Luu.Text = "Lưu";
			this.bt_Luu.UseVisualStyleBackColor = true;
			this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
			// 
			// bt_Xoa
			// 
			this.bt_Xoa.Location = new System.Drawing.Point(260, 156);
			this.bt_Xoa.Name = "bt_Xoa";
			this.bt_Xoa.Size = new System.Drawing.Size(75, 23);
			this.bt_Xoa.TabIndex = 8;
			this.bt_Xoa.Text = "Xóa";
			this.bt_Xoa.UseVisualStyleBackColor = true;
			this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
			// 
			// bt_Them
			// 
			this.bt_Them.Location = new System.Drawing.Point(36, 156);
			this.bt_Them.Name = "bt_Them";
			this.bt_Them.Size = new System.Drawing.Size(75, 23);
			this.bt_Them.TabIndex = 9;
			this.bt_Them.Text = "Thêm";
			this.bt_Them.UseVisualStyleBackColor = true;
			this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
			// 
			// bt_LopMoi
			// 
			this.bt_LopMoi.Location = new System.Drawing.Point(376, 156);
			this.bt_LopMoi.Name = "bt_LopMoi";
			this.bt_LopMoi.Size = new System.Drawing.Size(75, 23);
			this.bt_LopMoi.TabIndex = 10;
			this.bt_LopMoi.Text = "Lớp Mới";
			this.bt_LopMoi.UseVisualStyleBackColor = true;
			this.bt_LopMoi.Click += new System.EventHandler(this.bt_LopMoi_Click);
			// 
			// bt_Thoat
			// 
			this.bt_Thoat.Location = new System.Drawing.Point(481, 156);
			this.bt_Thoat.Name = "bt_Thoat";
			this.bt_Thoat.Size = new System.Drawing.Size(75, 23);
			this.bt_Thoat.TabIndex = 11;
			this.bt_Thoat.Text = "Thoát";
			this.bt_Thoat.UseVisualStyleBackColor = true;
			this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
			// 
			// lb_HoTen
			// 
			this.lb_HoTen.AutoSize = true;
			this.lb_HoTen.Location = new System.Drawing.Point(16, 95);
			this.lb_HoTen.Name = "lb_HoTen";
			this.lb_HoTen.Size = new System.Drawing.Size(39, 13);
			this.lb_HoTen.TabIndex = 12;
			this.lb_HoTen.Text = "Họ tên";
			// 
			// grp_ThongTinHocSinh
			// 
			this.grp_ThongTinHocSinh.Controls.Add(this.cbo_HoTen);
			this.grp_ThongTinHocSinh.Controls.Add(this.cbo_Lop);
			this.grp_ThongTinHocSinh.Controls.Add(this.cbo_Khoi);
			this.grp_ThongTinHocSinh.Controls.Add(this.lbl_Lop);
			this.grp_ThongTinHocSinh.Controls.Add(this.lb_HoTen);
			this.grp_ThongTinHocSinh.Controls.Add(this.lbl_Khoi);
			this.grp_ThongTinHocSinh.Location = new System.Drawing.Point(17, 8);
			this.grp_ThongTinHocSinh.Name = "grp_ThongTinHocSinh";
			this.grp_ThongTinHocSinh.Size = new System.Drawing.Size(232, 124);
			this.grp_ThongTinHocSinh.TabIndex = 14;
			this.grp_ThongTinHocSinh.TabStop = false;
			this.grp_ThongTinHocSinh.Text = "Thông tin học sinh";
			// 
			// cbo_HoTen
			// 
			this.cbo_HoTen.FormattingEnabled = true;
			this.cbo_HoTen.Location = new System.Drawing.Point(62, 92);
			this.cbo_HoTen.Name = "cbo_HoTen";
			this.cbo_HoTen.Size = new System.Drawing.Size(140, 21);
			this.cbo_HoTen.TabIndex = 13;
			// 
			// gc_DanhSachHocSinhLop
			// 
			this.gc_DanhSachHocSinhLop.Location = new System.Drawing.Point(5, 19);
			this.gc_DanhSachHocSinhLop.MainView = this.gridView1;
			this.gc_DanhSachHocSinhLop.Name = "gc_DanhSachHocSinhLop";
			this.gc_DanhSachHocSinhLop.Size = new System.Drawing.Size(556, 190);
			this.gc_DanhSachHocSinhLop.TabIndex = 15;
			this.gc_DanhSachHocSinhLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			this.gc_DanhSachHocSinhLop.Click += new System.EventHandler(this.gc_DanhSachHocSinhLop_Click);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
			this.gridView1.GridControl = this.gc_DanhSachHocSinhLop;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Họ Tên";
			this.gridColumn1.FieldName = "HOTEN";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Giới Tính";
			this.gridColumn2.FieldName = "GIOITINH";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Ngày Sinh";
			this.gridColumn3.FieldName = "NGAYSINH";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Địa Chỉ";
			this.gridColumn4.FieldName = "DIACHI";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			// 
			// grp_DanhSachHocSinh
			// 
			this.grp_DanhSachHocSinh.Controls.Add(this.txt_Lop);
			this.grp_DanhSachHocSinh.Controls.Add(this.gc_DanhSachHocSinhLop);
			this.grp_DanhSachHocSinh.Location = new System.Drawing.Point(17, 203);
			this.grp_DanhSachHocSinh.Name = "grp_DanhSachHocSinh";
			this.grp_DanhSachHocSinh.Size = new System.Drawing.Size(561, 217);
			this.grp_DanhSachHocSinh.TabIndex = 16;
			this.grp_DanhSachHocSinh.TabStop = false;
			this.grp_DanhSachHocSinh.Text = "Danh sách học sinh lớp: ";
			// 
			// txt_Lop
			// 
			this.txt_Lop.Location = new System.Drawing.Point(133, 0);
			this.txt_Lop.Name = "txt_Lop";
			this.txt_Lop.Size = new System.Drawing.Size(75, 20);
			this.txt_Lop.TabIndex = 16;
			// 
			// frm_LapDanhSachLop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 416);
			this.Controls.Add(this.grp_DanhSachHocSinh);
			this.Controls.Add(this.grp_ThongTinHocSinh);
			this.Controls.Add(this.bt_Thoat);
			this.Controls.Add(this.bt_LopMoi);
			this.Controls.Add(this.bt_Them);
			this.Controls.Add(this.bt_Xoa);
			this.Controls.Add(this.bt_Luu);
			this.Controls.Add(this.cbo_SiSo);
			this.Controls.Add(this.lbl_SiSo);
			this.Name = "frm_LapDanhSachLop";
			this.Text = "Lập danh sách lớp";
			this.Load += new System.EventHandler(this.frm_LapDanhSachLop_Load);
			this.grp_ThongTinHocSinh.ResumeLayout(false);
			this.grp_ThongTinHocSinh.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gc_DanhSachHocSinhLop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.grp_DanhSachHocSinh.ResumeLayout(false);
			this.grp_DanhSachHocSinh.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Khoi;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.Label lbl_SiSo;
        private System.Windows.Forms.ComboBox cbo_Khoi;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private System.Windows.Forms.ComboBox cbo_SiSo;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_LopMoi;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.GroupBox grp_ThongTinHocSinh;
        private DevExpress.XtraGrid.GridControl gc_DanhSachHocSinhLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox grp_DanhSachHocSinh;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.ComboBox cbo_HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}