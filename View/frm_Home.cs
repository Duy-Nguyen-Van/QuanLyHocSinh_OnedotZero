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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void btn_Tiepnhanhocsinh_Click(object sender, EventArgs e)
        {
            frm_TiepNhanHocSinh Tiepnhan = new frm_TiepNhanHocSinh();
            Tiepnhan.ShowDialog();
        }

        private void btn_Lapdanhsachlop_Click(object sender, EventArgs e)
        {
            frm_LapDanhSachLop Lapdanhsach = new frm_LapDanhSachLop();
            Lapdanhsach.ShowDialog();
        }

        private void btn_Tracuuhocsinh_Click(object sender, EventArgs e)
        {
            frm_TraCuuHocSinh Tracuu = new frm_TraCuuHocSinh();
            Tracuu.ShowDialog();
        }

        private void btn_Nhapbangdiem_Click(object sender, EventArgs e)
        {
            frm_NhapBangDiemMonHoc Nhapbangdiem = new frm_NhapBangDiemMonHoc();
            Nhapbangdiem.ShowDialog();
        }

        private void btn_Lapbaocao_Click(object sender, EventArgs e)
        {
            frm_LapBaoCaoTongKet Lapbaocao = new frm_LapBaoCaoTongKet();
            Lapbaocao.ShowDialog();
        }

        private void btn_Thaydoiquidinh_Click(object sender, EventArgs e)
        {
            frm_ThayDoiQuyDinh Thaydoi = new frm_ThayDoiQuyDinh();
            Thaydoi.ShowDialog();
        }




        

       

     
    }
}
