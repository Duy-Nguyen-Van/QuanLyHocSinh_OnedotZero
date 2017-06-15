using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh_OnedotZero
{
    public partial class frm_TiepNhanHocSinh : Form
    {
        HocSinhOJB objHS = new HocSinhOJB();
        public frm_TiepNhanHocSinh()
        {
            InitializeComponent();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TiepNhanHocSinh_Load(object sender, EventArgs e)
        {
           // gCDanhSachHS.DataSource = objHS.GetTT_HS();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            DataTable DanhSachHS = new DataTable();
            DataColumn HoTen = new DataColumn("Họ Tên");
            DataColumn DiaChi = new DataColumn("Địa Chỉ");
            DataColumn GioiTinh = new DataColumn("Giới Tính");
            DataColumn Email = new DataColumn("Email");
            DataColumn NgaySinh = new DataColumn("Ngày Sinh");
            DanhSachHS.Columns.Add(HoTen);
            DanhSachHS.Columns.Add(DiaChi);
            DanhSachHS.Columns.Add(Email);
            DanhSachHS.Columns.Add(GioiTinh);
            DanhSachHS.Columns.Add(NgaySinh);
            DataRow d;
            d = DanhSachHS.NewRow();
            d["Họ Tên"] = txt_HoTen.Text;
            d["Địa Chỉ"] = txt_DiaChi.Text;
            d["Giới Tính"] = cbo_GioiTinh.Text;
            d["Email"] = txt_Email.Text;
            d["Ngày Sinh"] = dtm_NgaySinh.Value;
            DanhSachHS.Rows.Add(d);

            /* foreach (DataRow d in DanhSachHS.Rows)
             {
                 d["HoTen"]= "edg";
                 d["DiaChi"] = txt_HoTen.Text;
                 d["GioiTinh"] = cbo_GioiTinh.Text;
                 d["Email"] = txt_Email.Text;
                 d["NgaySinh"] = dtm_NgaySinh.Value;
             }*/
            gc_DanhSachHS.DataSource = DanhSachHS;

        }
       
    }
}
