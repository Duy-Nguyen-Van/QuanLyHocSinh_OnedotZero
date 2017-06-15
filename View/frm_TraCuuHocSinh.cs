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
    public partial class frm_TraCuuHocSinh : Form
    {
        TraCuuOBJ objLop = new TraCuuOBJ();

        public frm_TraCuuHocSinh()
        {
            InitializeComponent();
        }
        DataTable tb = new DataTable();
        DataColumn TenHS = new DataColumn("TenHS");
        DataColumn TBKI = new DataColumn("TBKI");
        DataColumn TBKII = new DataColumn("TBKII");
        
        private void frm_TraCuuHocSinh_Load(object sender, EventArgs e)
        {
            cbo_Khoi.DataSource = objLop.GetKhoi();
            cbo_Khoi.ValueMember = "MAKHOI";
            cbo_Khoi.DisplayMember = "TENKHOI";

            tb.Columns.Add(TenHS);
            tb.Columns.Add(TBKI);
            tb.Columns.Add(TBKII);

        }

        private void cbo_Khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbo_Lop.Enabled = true;
            string MaKhoi = cbo_Khoi.SelectedValue.ToString();
            cbo_Lop.DataSource = objLop.GetLop(MaKhoi);
            cbo_Lop.ValueMember = "MALOP";
            cbo_Lop.DisplayMember = "TENLOP";
        }


        private void cbo_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaLop = cbo_Lop.SelectedValue.ToString();
            cbo_MaHS.DataSource = objLop.GetHS(MaLop);
            cbo_MaHS.ValueMember = "MAHS";
            cbo_MaHS.DisplayMember = "MAHS";
        }
        
        
        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable tb_id= objLop.GetHS_ID(cbo_MaHS.Text);

            DataRow d = tb.NewRow();
            d["TenHS"] = tb_id.Rows[0].ItemArray[0];
            d["TBKI"] = tb_id.Rows[0].ItemArray[1];
            d["TBKII"] = tb_id.Rows[0].ItemArray[2];
            tb.Rows.Add(d);

            gc_DanhSachHocSinhCanTraCuu.DataSource = tb;
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

   
        
    }
}
