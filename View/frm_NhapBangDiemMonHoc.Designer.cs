namespace QuanLyHocSinh_OnedotZero
{
    partial class frm_NhapBangDiemMonHoc
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
            this.lbl_Hocky = new System.Windows.Forms.Label();
            this.cbo_Khoi = new System.Windows.Forms.ComboBox();
            this.cbo_HocKy = new System.Windows.Forms.ComboBox();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.grp_BangDiem = new System.Windows.Forms.GroupBox();
            this.gc_BangDiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grp_Chon = new System.Windows.Forms.GroupBox();
            this.lbl_TimKiem = new System.Windows.Forms.GroupBox();
            this.grp_BangDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_BangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grp_Chon.SuspendLayout();
            this.lbl_TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Khoi
            // 
            this.lbl_Khoi.AutoSize = true;
            this.lbl_Khoi.Location = new System.Drawing.Point(9, 21);
            this.lbl_Khoi.Name = "lbl_Khoi";
            this.lbl_Khoi.Size = new System.Drawing.Size(28, 13);
            this.lbl_Khoi.TabIndex = 0;
            this.lbl_Khoi.Text = "Khối";
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Location = new System.Drawing.Point(12, 51);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(25, 13);
            this.lbl_Lop.TabIndex = 1;
            this.lbl_Lop.Text = "Lớp";
            // 
            // lbl_Hocky
            // 
            this.lbl_Hocky.AutoSize = true;
            this.lbl_Hocky.Location = new System.Drawing.Point(12, 81);
            this.lbl_Hocky.Name = "lbl_Hocky";
            this.lbl_Hocky.Size = new System.Drawing.Size(41, 13);
            this.lbl_Hocky.TabIndex = 2;
            this.lbl_Hocky.Text = "Học kỳ";
            // 
            // cbo_Khoi
            // 
            this.cbo_Khoi.FormattingEnabled = true;
            this.cbo_Khoi.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cbo_Khoi.Location = new System.Drawing.Point(71, 18);
            this.cbo_Khoi.Name = "cbo_Khoi";
            this.cbo_Khoi.Size = new System.Drawing.Size(89, 21);
            this.cbo_Khoi.TabIndex = 3;
            // 
            // cbo_HocKy
            // 
            this.cbo_HocKy.FormattingEnabled = true;
            this.cbo_HocKy.Items.AddRange(new object[] {
            "HKI",
            "HKII"});
            this.cbo_HocKy.Location = new System.Drawing.Point(71, 78);
            this.cbo_HocKy.Name = "cbo_HocKy";
            this.cbo_HocKy.Size = new System.Drawing.Size(89, 21);
            this.cbo_HocKy.TabIndex = 4;
            // 
            // cbo_Lop
            // 
            this.cbo_Lop.FormattingEnabled = true;
            this.cbo_Lop.Location = new System.Drawing.Point(71, 48);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(89, 21);
            this.cbo_Lop.TabIndex = 5;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(31, 25);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(203, 20);
            this.txt_TimKiem.TabIndex = 12;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Location = new System.Drawing.Point(287, 25);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.bt_TimKiem.TabIndex = 13;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(281, 76);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(75, 23);
            this.bt_Sua.TabIndex = 14;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            // 
            // bt_Luu
            // 
            this.bt_Luu.Location = new System.Drawing.Point(409, 76);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 23);
            this.bt_Luu.TabIndex = 15;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(537, 76);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_Thoat.TabIndex = 16;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            // 
            // grp_BangDiem
            // 
            this.grp_BangDiem.Controls.Add(this.gc_BangDiem);
            this.grp_BangDiem.Location = new System.Drawing.Point(4, 143);
            this.grp_BangDiem.Name = "grp_BangDiem";
            this.grp_BangDiem.Size = new System.Drawing.Size(633, 205);
            this.grp_BangDiem.TabIndex = 17;
            this.grp_BangDiem.TabStop = false;
            this.grp_BangDiem.Text = "Bảng điểm";
            // 
            // gc_BangDiem
            // 
            this.gc_BangDiem.Location = new System.Drawing.Point(0, 22);
            this.gc_BangDiem.MainView = this.gridView1;
            this.gc_BangDiem.Name = "gc_BangDiem";
            this.gc_BangDiem.Size = new System.Drawing.Size(632, 182);
            this.gc_BangDiem.TabIndex = 0;
            this.gc_BangDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_BangDiem;
            this.gridView1.Name = "gridView1";
            // 
            // grp_Chon
            // 
            this.grp_Chon.Controls.Add(this.cbo_Lop);
            this.grp_Chon.Controls.Add(this.cbo_HocKy);
            this.grp_Chon.Controls.Add(this.cbo_Khoi);
            this.grp_Chon.Controls.Add(this.lbl_Hocky);
            this.grp_Chon.Controls.Add(this.lbl_Lop);
            this.grp_Chon.Controls.Add(this.lbl_Khoi);
            this.grp_Chon.Location = new System.Drawing.Point(20, 8);
            this.grp_Chon.Name = "grp_Chon";
            this.grp_Chon.Size = new System.Drawing.Size(174, 118);
            this.grp_Chon.TabIndex = 18;
            this.grp_Chon.TabStop = false;
            this.grp_Chon.Text = "Chọn";
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.Controls.Add(this.txt_TimKiem);
            this.lbl_TimKiem.Controls.Add(this.bt_TimKiem);
            this.lbl_TimKiem.Location = new System.Drawing.Point(250, 12);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(378, 58);
            this.lbl_TimKiem.TabIndex = 19;
            this.lbl_TimKiem.TabStop = false;
            this.lbl_TimKiem.Text = "Nhập họ tên hoặc mã HS để tìm kiếm: ";
            // 
            // frm_NhapBangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 349);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.grp_Chon);
            this.Controls.Add(this.grp_BangDiem);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.bt_Sua);
            this.Name = "frm_NhapBangDiemMonHoc";
            this.Text = "Nhập bảng điểm môn học";
            this.grp_BangDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_BangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grp_Chon.ResumeLayout(false);
            this.grp_Chon.PerformLayout();
            this.lbl_TimKiem.ResumeLayout(false);
            this.lbl_TimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Khoi;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.Label lbl_Hocky;
        private System.Windows.Forms.ComboBox cbo_Khoi;
        private System.Windows.Forms.ComboBox cbo_HocKy;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.GroupBox grp_BangDiem;
        private DevExpress.XtraGrid.GridControl gc_BangDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox grp_Chon;
        private System.Windows.Forms.GroupBox lbl_TimKiem;
    }
}