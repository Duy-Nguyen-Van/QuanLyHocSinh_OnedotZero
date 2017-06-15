namespace QuanLyHocSinh_OnedotZero
{
    partial class frm_TraCuuHocSinh
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
            this.cbo_Khoi = new System.Windows.Forms.ComboBox();
            this.lbl_Khoi = new System.Windows.Forms.Label();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            this.grp_PhamViTimKiem = new System.Windows.Forms.GroupBox();
            this.lbl_MaHS = new System.Windows.Forms.Label();
            this.grp_ThongTinTimKiem = new System.Windows.Forms.GroupBox();
            this.cbo_MaHS = new System.Windows.Forms.ComboBox();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.grp_DanhSachHocSinhCanTraCuu = new System.Windows.Forms.GroupBox();
            this.gc_DanhSachHocSinhCanTraCuu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grp_PhamViTimKiem.SuspendLayout();
            this.grp_ThongTinTimKiem.SuspendLayout();
            this.grp_DanhSachHocSinhCanTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DanhSachHocSinhCanTraCuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Khoi
            // 
            this.cbo_Khoi.FormattingEnabled = true;
            this.cbo_Khoi.Location = new System.Drawing.Point(50, 26);
            this.cbo_Khoi.Name = "cbo_Khoi";
            this.cbo_Khoi.Size = new System.Drawing.Size(94, 21);
            this.cbo_Khoi.TabIndex = 0;
            this.cbo_Khoi.SelectedIndexChanged += new System.EventHandler(this.cbo_Khoi_SelectedIndexChanged);
            // 
            // lbl_Khoi
            // 
            this.lbl_Khoi.AutoSize = true;
            this.lbl_Khoi.Location = new System.Drawing.Point(16, 30);
            this.lbl_Khoi.Name = "lbl_Khoi";
            this.lbl_Khoi.Size = new System.Drawing.Size(28, 13);
            this.lbl_Khoi.TabIndex = 1;
            this.lbl_Khoi.Text = "Khối";
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Location = new System.Drawing.Point(16, 66);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(25, 13);
            this.lbl_Lop.TabIndex = 2;
            this.lbl_Lop.Text = "Lớp";
            // 
            // cbo_Lop
            // 
            this.cbo_Lop.FormattingEnabled = true;
            this.cbo_Lop.Location = new System.Drawing.Point(50, 63);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(94, 21);
            this.cbo_Lop.TabIndex = 3;
            this.cbo_Lop.SelectedIndexChanged += new System.EventHandler(this.cbo_Lop_SelectedIndexChanged);
            // 
            // grp_PhamViTimKiem
            // 
            this.grp_PhamViTimKiem.Controls.Add(this.cbo_Lop);
            this.grp_PhamViTimKiem.Controls.Add(this.lbl_Lop);
            this.grp_PhamViTimKiem.Controls.Add(this.lbl_Khoi);
            this.grp_PhamViTimKiem.Controls.Add(this.cbo_Khoi);
            this.grp_PhamViTimKiem.Location = new System.Drawing.Point(91, 12);
            this.grp_PhamViTimKiem.Name = "grp_PhamViTimKiem";
            this.grp_PhamViTimKiem.Size = new System.Drawing.Size(166, 100);
            this.grp_PhamViTimKiem.TabIndex = 4;
            this.grp_PhamViTimKiem.TabStop = false;
            this.grp_PhamViTimKiem.Text = "Phạm vi tìm kiếm";
            // 
            // lbl_MaHS
            // 
            this.lbl_MaHS.AutoSize = true;
            this.lbl_MaHS.Location = new System.Drawing.Point(12, 30);
            this.lbl_MaHS.Name = "lbl_MaHS";
            this.lbl_MaHS.Size = new System.Drawing.Size(40, 13);
            this.lbl_MaHS.TabIndex = 8;
            this.lbl_MaHS.Text = "Mã HS";
            // 
            // grp_ThongTinTimKiem
            // 
            this.grp_ThongTinTimKiem.Controls.Add(this.cbo_MaHS);
            this.grp_ThongTinTimKiem.Controls.Add(this.lbl_MaHS);
            this.grp_ThongTinTimKiem.Location = new System.Drawing.Point(293, 12);
            this.grp_ThongTinTimKiem.Name = "grp_ThongTinTimKiem";
            this.grp_ThongTinTimKiem.Size = new System.Drawing.Size(178, 59);
            this.grp_ThongTinTimKiem.TabIndex = 10;
            this.grp_ThongTinTimKiem.TabStop = false;
            this.grp_ThongTinTimKiem.Text = "Thông tin tìm kiếm";
            // 
            // cbo_MaHS
            // 
            this.cbo_MaHS.FormattingEnabled = true;
            this.cbo_MaHS.Location = new System.Drawing.Point(58, 26);
            this.cbo_MaHS.Name = "cbo_MaHS";
            this.cbo_MaHS.Size = new System.Drawing.Size(94, 21);
            this.cbo_MaHS.TabIndex = 4;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Location = new System.Drawing.Point(293, 89);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.bt_TimKiem.TabIndex = 11;
            this.bt_TimKiem.Text = "Tim kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(396, 89);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_Thoat.TabIndex = 12;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // grp_DanhSachHocSinhCanTraCuu
            // 
            this.grp_DanhSachHocSinhCanTraCuu.Controls.Add(this.gc_DanhSachHocSinhCanTraCuu);
            this.grp_DanhSachHocSinhCanTraCuu.Location = new System.Drawing.Point(5, 135);
            this.grp_DanhSachHocSinhCanTraCuu.Name = "grp_DanhSachHocSinhCanTraCuu";
            this.grp_DanhSachHocSinhCanTraCuu.Size = new System.Drawing.Size(560, 174);
            this.grp_DanhSachHocSinhCanTraCuu.TabIndex = 13;
            this.grp_DanhSachHocSinhCanTraCuu.TabStop = false;
            this.grp_DanhSachHocSinhCanTraCuu.Text = "Danh sách học sinh cần tra cứu";
            // 
            // gc_DanhSachHocSinhCanTraCuu
            // 
            this.gc_DanhSachHocSinhCanTraCuu.Location = new System.Drawing.Point(9, 20);
            this.gc_DanhSachHocSinhCanTraCuu.MainView = this.gridView1;
            this.gc_DanhSachHocSinhCanTraCuu.Name = "gc_DanhSachHocSinhCanTraCuu";
            this.gc_DanhSachHocSinhCanTraCuu.Size = new System.Drawing.Size(550, 146);
            this.gc_DanhSachHocSinhCanTraCuu.TabIndex = 0;
            this.gc_DanhSachHocSinhCanTraCuu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_DanhSachHocSinhCanTraCuu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frm_TraCuuHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 303);
            this.Controls.Add(this.grp_DanhSachHocSinhCanTraCuu);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.grp_ThongTinTimKiem);
            this.Controls.Add(this.grp_PhamViTimKiem);
            this.Name = "frm_TraCuuHocSinh";
            this.Text = "Tra cứu học sinh";
            this.Load += new System.EventHandler(this.frm_TraCuuHocSinh_Load);
            this.grp_PhamViTimKiem.ResumeLayout(false);
            this.grp_PhamViTimKiem.PerformLayout();
            this.grp_ThongTinTimKiem.ResumeLayout(false);
            this.grp_ThongTinTimKiem.PerformLayout();
            this.grp_DanhSachHocSinhCanTraCuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DanhSachHocSinhCanTraCuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Khoi;
        private System.Windows.Forms.Label lbl_Khoi;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private System.Windows.Forms.GroupBox grp_PhamViTimKiem;
        private System.Windows.Forms.Label lbl_MaHS;
        private System.Windows.Forms.GroupBox grp_ThongTinTimKiem;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.GroupBox grp_DanhSachHocSinhCanTraCuu;
        private DevExpress.XtraGrid.GridControl gc_DanhSachHocSinhCanTraCuu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbo_MaHS;

    }
}