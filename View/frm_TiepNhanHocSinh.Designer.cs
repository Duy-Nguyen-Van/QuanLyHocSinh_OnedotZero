namespace QuanLyHocSinh_OnedotZero
{
    partial class frm_TiepNhanHocSinh
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
            this.lbl_NgayTiepNhan = new System.Windows.Forms.Label();
            this.dtm_NgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.dtm_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.grp_ThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.gc_DanhSachHS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grp_ThongTinHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DanhSachHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NgayTiepNhan
            // 
            this.lbl_NgayTiepNhan.AutoSize = true;
            this.lbl_NgayTiepNhan.Location = new System.Drawing.Point(342, 111);
            this.lbl_NgayTiepNhan.Name = "lbl_NgayTiepNhan";
            this.lbl_NgayTiepNhan.Size = new System.Drawing.Size(79, 13);
            this.lbl_NgayTiepNhan.TabIndex = 0;
            this.lbl_NgayTiepNhan.Text = "Ngày tiếp nhận";
            // 
            // dtm_NgayTiepNhan
            // 
            this.dtm_NgayTiepNhan.Location = new System.Drawing.Point(427, 105);
            this.dtm_NgayTiepNhan.Name = "dtm_NgayTiepNhan";
            this.dtm_NgayTiepNhan.Size = new System.Drawing.Size(200, 20);
            this.dtm_NgayTiepNhan.TabIndex = 1;
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(24, 193);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(90, 23);
            this.bt_Them.TabIndex = 3;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(147, 193);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(90, 23);
            this.bt_Sua.TabIndex = 4;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(282, 193);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(90, 23);
            this.bt_Xoa.TabIndex = 5;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(535, 193);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(90, 23);
            this.bt_Thoat.TabIndex = 6;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(9, 25);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(39, 13);
            this.lb_HoTen.TabIndex = 7;
            this.lb_HoTen.Text = "Họ tên";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(9, 111);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lb_NgaySinh.TabIndex = 8;
            this.lb_NgaySinh.Text = "Ngày sinh";
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Location = new System.Drawing.Point(9, 65);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lb_GioiTinh.TabIndex = 9;
            this.lb_GioiTinh.Text = "Giới tính";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(342, 25);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(41, 13);
            this.lb_DiaChi.TabIndex = 10;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(342, 65);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(32, 13);
            this.lb_Email.TabIndex = 11;
            this.lb_Email.Text = "Email";
            // 
            // dtm_NgaySinh
            // 
            this.dtm_NgaySinh.Location = new System.Drawing.Point(109, 105);
            this.dtm_NgaySinh.Name = "dtm_NgaySinh";
            this.dtm_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtm_NgaySinh.TabIndex = 12;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(109, 22);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(200, 20);
            this.txt_HoTen.TabIndex = 13;
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_GioiTinh.Location = new System.Drawing.Point(109, 62);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(200, 21);
            this.cbo_GioiTinh.TabIndex = 17;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(427, 22);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(200, 20);
            this.txt_DiaChi.TabIndex = 18;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(427, 62);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(200, 20);
            this.txt_Email.TabIndex = 19;
            // 
            // grp_ThongTinHocSinh
            // 
            this.grp_ThongTinHocSinh.Controls.Add(this.txt_Email);
            this.grp_ThongTinHocSinh.Controls.Add(this.txt_DiaChi);
            this.grp_ThongTinHocSinh.Controls.Add(this.cbo_GioiTinh);
            this.grp_ThongTinHocSinh.Controls.Add(this.txt_HoTen);
            this.grp_ThongTinHocSinh.Controls.Add(this.dtm_NgaySinh);
            this.grp_ThongTinHocSinh.Controls.Add(this.lb_Email);
            this.grp_ThongTinHocSinh.Controls.Add(this.lb_DiaChi);
            this.grp_ThongTinHocSinh.Controls.Add(this.dtm_NgayTiepNhan);
            this.grp_ThongTinHocSinh.Controls.Add(this.lb_GioiTinh);
            this.grp_ThongTinHocSinh.Controls.Add(this.lbl_NgayTiepNhan);
            this.grp_ThongTinHocSinh.Controls.Add(this.lb_NgaySinh);
            this.grp_ThongTinHocSinh.Controls.Add(this.lb_HoTen);
            this.grp_ThongTinHocSinh.Location = new System.Drawing.Point(12, 12);
            this.grp_ThongTinHocSinh.Name = "grp_ThongTinHocSinh";
            this.grp_ThongTinHocSinh.Size = new System.Drawing.Size(643, 150);
            this.grp_ThongTinHocSinh.TabIndex = 20;
            this.grp_ThongTinHocSinh.TabStop = false;
            this.grp_ThongTinHocSinh.Text = "Thông tin học sinh";
            // 
            // bt_Luu
            // 
            this.bt_Luu.Location = new System.Drawing.Point(409, 193);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(90, 23);
            this.bt_Luu.TabIndex = 21;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = true;
            // 
            // gc_DanhSachHS
            // 
            this.gc_DanhSachHS.Location = new System.Drawing.Point(3, 241);
            this.gc_DanhSachHS.MainView = this.gridView1;
            this.gc_DanhSachHS.Name = "gc_DanhSachHS";
            this.gc_DanhSachHS.Size = new System.Drawing.Size(649, 185);
            this.gc_DanhSachHS.TabIndex = 22;
            this.gc_DanhSachHS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_DanhSachHS;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frm_TiepNhanHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 428);
            this.Controls.Add(this.gc_DanhSachHS);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.grp_ThongTinHocSinh);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.MaximizeBox = false;
            this.Name = "frm_TiepNhanHocSinh";
            this.Text = "Tiếp nhận học sinh";
            this.Load += new System.EventHandler(this.frm_TiepNhanHocSinh_Load);
            this.grp_ThongTinHocSinh.ResumeLayout(false);
            this.grp_ThongTinHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DanhSachHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_NgayTiepNhan;
        private System.Windows.Forms.DateTimePicker dtm_NgayTiepNhan;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.DateTimePicker dtm_NgaySinh;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.GroupBox grp_ThongTinHocSinh;
        private System.Windows.Forms.Button bt_Luu;
        private DevExpress.XtraGrid.GridControl gc_DanhSachHS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}