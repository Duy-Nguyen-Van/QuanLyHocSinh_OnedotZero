namespace QuanLyHocSinh_OnedotZero
{
    partial class frm_LapBaoCaoTongKet
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
            this.lbl_BaoCaoTongKetMon = new System.Windows.Forms.Label();
            this.lbl_BaoCaoTongKetHocKy = new System.Windows.Forms.Label();
            this.dgv_BaoCaoTongKetMon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BaoCaoTongKetHocKy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_HocKyBCTKM = new System.Windows.Forms.Label();
            this.lbl_HocKyBCTKHK = new System.Windows.Forms.Label();
            this.lbl_MonBCTKM = new System.Windows.Forms.Label();
            this.lbl_Mon_BCTKHK = new System.Windows.Forms.Label();
            this.cbo_HocKyBCTKM = new System.Windows.Forms.ComboBox();
            this.cbo_MonBCTKM = new System.Windows.Forms.ComboBox();
            this.cbo_HocKyBCTKHK = new System.Windows.Forms.ComboBox();
            this.cbo_MonBCTKHK = new System.Windows.Forms.ComboBox();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_XuatFileMon = new System.Windows.Forms.Button();
            this.bt_LapBaoCaoMon = new System.Windows.Forms.Button();
            this.bt_XuatFileHK = new System.Windows.Forms.Button();
            this.bt_LapBaoCaoHK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCaoTongKetMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCaoTongKetHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BaoCaoTongKetMon
            // 
            this.lbl_BaoCaoTongKetMon.AutoSize = true;
            this.lbl_BaoCaoTongKetMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaoCaoTongKetMon.Location = new System.Drawing.Point(146, 9);
            this.lbl_BaoCaoTongKetMon.Name = "lbl_BaoCaoTongKetMon";
            this.lbl_BaoCaoTongKetMon.Size = new System.Drawing.Size(221, 25);
            this.lbl_BaoCaoTongKetMon.TabIndex = 0;
            this.lbl_BaoCaoTongKetMon.Text = "Báo cáo tổng kết môn";
            // 
            // lbl_BaoCaoTongKetHocKy
            // 
            this.lbl_BaoCaoTongKetHocKy.AutoSize = true;
            this.lbl_BaoCaoTongKetHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaoCaoTongKetHocKy.Location = new System.Drawing.Point(146, 246);
            this.lbl_BaoCaoTongKetHocKy.Name = "lbl_BaoCaoTongKetHocKy";
            this.lbl_BaoCaoTongKetHocKy.Size = new System.Drawing.Size(243, 25);
            this.lbl_BaoCaoTongKetHocKy.TabIndex = 1;
            this.lbl_BaoCaoTongKetHocKy.Text = "Báo cáo tổng kết học kỳ";
            // 
            // dgv_BaoCaoTongKetMon
            // 
            this.dgv_BaoCaoTongKetMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BaoCaoTongKetMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Lop,
            this.SiSo,
            this.SoLuongDat,
            this.TyLe});
            this.dgv_BaoCaoTongKetMon.Location = new System.Drawing.Point(-2, 71);
            this.dgv_BaoCaoTongKetMon.Name = "dgv_BaoCaoTongKetMon";
            this.dgv_BaoCaoTongKetMon.Size = new System.Drawing.Size(546, 138);
            this.dgv_BaoCaoTongKetMon.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            // 
            // SiSo
            // 
            this.SiSo.HeaderText = "Sĩ số";
            this.SiSo.Name = "SiSo";
            // 
            // SoLuongDat
            // 
            this.SoLuongDat.HeaderText = "Số lượng đạt";
            this.SoLuongDat.Name = "SoLuongDat";
            // 
            // TyLe
            // 
            this.TyLe.HeaderText = "Tỷ lệ";
            this.TyLe.Name = "TyLe";
            // 
            // dgv_BaoCaoTongKetHocKy
            // 
            this.dgv_BaoCaoTongKetHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BaoCaoTongKetHocKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_BaoCaoTongKetHocKy.Location = new System.Drawing.Point(-2, 304);
            this.dgv_BaoCaoTongKetHocKy.Name = "dgv_BaoCaoTongKetHocKy";
            this.dgv_BaoCaoTongKetHocKy.Size = new System.Drawing.Size(546, 138);
            this.dgv_BaoCaoTongKetHocKy.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Lớp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Sĩ số";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng đạt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tỷ lệ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // lbl_HocKyBCTKM
            // 
            this.lbl_HocKyBCTKM.AutoSize = true;
            this.lbl_HocKyBCTKM.Location = new System.Drawing.Point(59, 43);
            this.lbl_HocKyBCTKM.Name = "lbl_HocKyBCTKM";
            this.lbl_HocKyBCTKM.Size = new System.Drawing.Size(41, 13);
            this.lbl_HocKyBCTKM.TabIndex = 4;
            this.lbl_HocKyBCTKM.Text = "Học kỳ";
            // 
            // lbl_HocKyBCTKHK
            // 
            this.lbl_HocKyBCTKHK.AutoSize = true;
            this.lbl_HocKyBCTKHK.Location = new System.Drawing.Point(59, 277);
            this.lbl_HocKyBCTKHK.Name = "lbl_HocKyBCTKHK";
            this.lbl_HocKyBCTKHK.Size = new System.Drawing.Size(41, 13);
            this.lbl_HocKyBCTKHK.TabIndex = 5;
            this.lbl_HocKyBCTKHK.Text = "Học kỳ";
            // 
            // lbl_MonBCTKM
            // 
            this.lbl_MonBCTKM.AutoSize = true;
            this.lbl_MonBCTKM.Location = new System.Drawing.Point(238, 43);
            this.lbl_MonBCTKM.Name = "lbl_MonBCTKM";
            this.lbl_MonBCTKM.Size = new System.Drawing.Size(28, 13);
            this.lbl_MonBCTKM.TabIndex = 6;
            this.lbl_MonBCTKM.Text = "Môn";
            // 
            // lbl_Mon_BCTKHK
            // 
            this.lbl_Mon_BCTKHK.AutoSize = true;
            this.lbl_Mon_BCTKHK.Location = new System.Drawing.Point(238, 277);
            this.lbl_Mon_BCTKHK.Name = "lbl_Mon_BCTKHK";
            this.lbl_Mon_BCTKHK.Size = new System.Drawing.Size(28, 13);
            this.lbl_Mon_BCTKHK.TabIndex = 7;
            this.lbl_Mon_BCTKHK.Text = "Môn";
            // 
            // cbo_HocKyBCTKM
            // 
            this.cbo_HocKyBCTKM.FormattingEnabled = true;
            this.cbo_HocKyBCTKM.Location = new System.Drawing.Point(106, 40);
            this.cbo_HocKyBCTKM.Name = "cbo_HocKyBCTKM";
            this.cbo_HocKyBCTKM.Size = new System.Drawing.Size(99, 21);
            this.cbo_HocKyBCTKM.TabIndex = 8;
            // 
            // cbo_MonBCTKM
            // 
            this.cbo_MonBCTKM.FormattingEnabled = true;
            this.cbo_MonBCTKM.Location = new System.Drawing.Point(272, 40);
            this.cbo_MonBCTKM.Name = "cbo_MonBCTKM";
            this.cbo_MonBCTKM.Size = new System.Drawing.Size(99, 21);
            this.cbo_MonBCTKM.TabIndex = 9;
            // 
            // cbo_HocKyBCTKHK
            // 
            this.cbo_HocKyBCTKHK.FormattingEnabled = true;
            this.cbo_HocKyBCTKHK.Location = new System.Drawing.Point(106, 277);
            this.cbo_HocKyBCTKHK.Name = "cbo_HocKyBCTKHK";
            this.cbo_HocKyBCTKHK.Size = new System.Drawing.Size(99, 21);
            this.cbo_HocKyBCTKHK.TabIndex = 10;
            // 
            // cbo_MonBCTKHK
            // 
            this.cbo_MonBCTKHK.FormattingEnabled = true;
            this.cbo_MonBCTKHK.Location = new System.Drawing.Point(272, 274);
            this.cbo_MonBCTKHK.Name = "cbo_MonBCTKHK";
            this.cbo_MonBCTKHK.Size = new System.Drawing.Size(99, 21);
            this.cbo_MonBCTKHK.TabIndex = 11;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(438, 38);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_Thoat.TabIndex = 12;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            // 
            // bt_XuatFileMon
            // 
            this.bt_XuatFileMon.Location = new System.Drawing.Point(106, 220);
            this.bt_XuatFileMon.Name = "bt_XuatFileMon";
            this.bt_XuatFileMon.Size = new System.Drawing.Size(99, 23);
            this.bt_XuatFileMon.TabIndex = 13;
            this.bt_XuatFileMon.Text = "Xuất file";
            this.bt_XuatFileMon.UseVisualStyleBackColor = true;
            // 
            // bt_LapBaoCaoMon
            // 
            this.bt_LapBaoCaoMon.Location = new System.Drawing.Point(272, 220);
            this.bt_LapBaoCaoMon.Name = "bt_LapBaoCaoMon";
            this.bt_LapBaoCaoMon.Size = new System.Drawing.Size(99, 23);
            this.bt_LapBaoCaoMon.TabIndex = 14;
            this.bt_LapBaoCaoMon.Text = "Lập báo cáo";
            this.bt_LapBaoCaoMon.UseVisualStyleBackColor = true;
            // 
            // bt_XuatFileHK
            // 
            this.bt_XuatFileHK.Location = new System.Drawing.Point(106, 451);
            this.bt_XuatFileHK.Name = "bt_XuatFileHK";
            this.bt_XuatFileHK.Size = new System.Drawing.Size(99, 23);
            this.bt_XuatFileHK.TabIndex = 15;
            this.bt_XuatFileHK.Text = "Xuất file";
            this.bt_XuatFileHK.UseVisualStyleBackColor = true;
            // 
            // bt_LapBaoCaoHK
            // 
            this.bt_LapBaoCaoHK.Location = new System.Drawing.Point(272, 451);
            this.bt_LapBaoCaoHK.Name = "bt_LapBaoCaoHK";
            this.bt_LapBaoCaoHK.Size = new System.Drawing.Size(99, 23);
            this.bt_LapBaoCaoHK.TabIndex = 16;
            this.bt_LapBaoCaoHK.Text = "Lập báo cáo";
            this.bt_LapBaoCaoHK.UseVisualStyleBackColor = true;
            // 
            // frm_LapBaoCaoTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 483);
            this.Controls.Add(this.bt_LapBaoCaoHK);
            this.Controls.Add(this.bt_XuatFileHK);
            this.Controls.Add(this.bt_LapBaoCaoMon);
            this.Controls.Add(this.bt_XuatFileMon);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.cbo_MonBCTKHK);
            this.Controls.Add(this.cbo_HocKyBCTKHK);
            this.Controls.Add(this.cbo_MonBCTKM);
            this.Controls.Add(this.cbo_HocKyBCTKM);
            this.Controls.Add(this.lbl_Mon_BCTKHK);
            this.Controls.Add(this.lbl_MonBCTKM);
            this.Controls.Add(this.lbl_HocKyBCTKHK);
            this.Controls.Add(this.lbl_HocKyBCTKM);
            this.Controls.Add(this.dgv_BaoCaoTongKetHocKy);
            this.Controls.Add(this.dgv_BaoCaoTongKetMon);
            this.Controls.Add(this.lbl_BaoCaoTongKetHocKy);
            this.Controls.Add(this.lbl_BaoCaoTongKetMon);
            this.Name = "frm_LapBaoCaoTongKet";
            this.Text = "Lập báo cáo tổng kết";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCaoTongKetMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCaoTongKetHocKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BaoCaoTongKetMon;
        private System.Windows.Forms.Label lbl_BaoCaoTongKetHocKy;
        private System.Windows.Forms.DataGridView dgv_BaoCaoTongKetMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLe;
        private System.Windows.Forms.DataGridView dgv_BaoCaoTongKetHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lbl_HocKyBCTKM;
        private System.Windows.Forms.Label lbl_HocKyBCTKHK;
        private System.Windows.Forms.Label lbl_MonBCTKM;
        private System.Windows.Forms.Label lbl_Mon_BCTKHK;
        private System.Windows.Forms.ComboBox cbo_HocKyBCTKM;
        private System.Windows.Forms.ComboBox cbo_MonBCTKM;
        private System.Windows.Forms.ComboBox cbo_HocKyBCTKHK;
        private System.Windows.Forms.ComboBox cbo_MonBCTKHK;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_XuatFileMon;
        private System.Windows.Forms.Button bt_LapBaoCaoMon;
        private System.Windows.Forms.Button bt_XuatFileHK;
        private System.Windows.Forms.Button bt_LapBaoCaoHK;
    }
}