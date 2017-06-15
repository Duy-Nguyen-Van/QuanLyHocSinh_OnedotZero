using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHocSinh_OnedotZero
{
	public partial class frm_LapDanhSachLop : Form
	{

		SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B9QJAOE\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True");
		DataSet ds;
		SqlDataAdapter da;
		DanhSachLopOBJ objLop = new DanhSachLopOBJ();
		public frm_LapDanhSachLop()
		{
			InitializeComponent();
		}

		private void bt_Thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frm_LapDanhSachLop_Load(object sender, EventArgs e)
		{
			/*cbo_Khoi.DataSource = objLop.GetKhoi();
			cbo_Khoi.ValueMember = "MAKHOI";
			cbo_Khoi.DisplayMember = "TENKHOI";
			cbo_HoTen.DataSource = objLop.GetHS();
			cbo_HoTen.ValueMember = "MAHS";
			cbo_HoTen.DisplayMember = "HOTEN";*/
			LoadData();
		}
		private void LoadData()
		{
			DataLopDataContext db = new DataLopDataContext();
			//var dsLop = db.HOCSINHs.ToList();
			cbo_Khoi.DataSource = objLop.GetKhoi();
			cbo_Khoi.ValueMember = "MAKHOI";
			cbo_Khoi.DisplayMember = "TENKHOI";
			cbo_HoTen.DataSource = objLop.GetHS();
			cbo_HoTen.ValueMember = "MAHS";
			cbo_HoTen.DisplayMember = "HOTEN";
			//gc_DanhSachHocSinhLop.DataSource = dsLop;
		}
		private void cbo_Khoi_SelectedIndexChanged(object sender, EventArgs e)
		{
			string MaKhoi = cbo_Khoi.SelectedValue.ToString();
			cbo_Lop.DataSource = objLop.GetLop(MaKhoi);
			cbo_Lop.ValueMember = "MALOP";
			cbo_Lop.DisplayMember = "TENLOP";
		}

		private void cbo_Lop_SelectedIndexChanged(object sender, EventArgs e)
		{
			string MaLop = cbo_Lop.SelectedValue.ToString();
			cbo_HoTen.DataSource = objLop.GetHS();
			cbo_HoTen.ValueMember = "MAHS";
			cbo_HoTen.DisplayMember = "HOTEN";
		}

		private void bt_Them_Click(object sender, EventArgs e)
		{
			if (objLop.UpDateMaLop_HS(cbo_Lop.SelectedValue.ToString(), cbo_HoTen.SelectedValue.ToString()))
				gc_DanhSachHocSinhLop.DataSource = objLop.GetHS_ID(cbo_HoTen.SelectedValue.ToString());

			else
				MessageBox.Show("CÓ LỖI TRONG QUÁ TRÌNH THÊM!");
		}

		private void gc_DanhSachHocSinhLop_Click(object sender, EventArgs e)
		{

		}

		private void bt_LopMoi_Click(object sender, EventArgs e)
		{
			frm_LapDanhSachLop f1 = new frm_LapDanhSachLop();
			f1.ShowDialog();
			this.Close();
		}
		/*private bool Save()
		{
			
			//string _Code = "";
			string _Name = "";
			_Name = txt_Lop.Text;
			return false;
			DataLopDataContext db = new DataLopDataContext();
			LOP _lop = null;
			_lop = new LOP();

		}*/
		private void bt_Luu_Click(object sender, EventArgs e)
		{
			conn.Open();
			for (int i = 0; i < gridView1.RowCount; i++)
			{
				string hoten = gridView1.GetRowCellValue(i, gridView1.Columns["HOTEN"]).ToString();
				string gioitinh = gridView1.GetRowCellValue(i, gridView1.Columns["GIOITINH"]).ToString();
				string ngaysinh = gridView1.GetRowCellValue(i, gridView1.Columns["NGAYSINH"]).ToString();
				string diachi = gridView1.GetRowCellValue(i, gridView1.Columns["DIACHI"]).ToString();
				string lop = "INSERT INTO tblHOCSINH (MALOP) VALUES('"+ cbo_Lop.Text +"')";
			}
			MessageBox.Show("Bạn đã lưu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			conn.Close();
		}

		private void bt_Xoa_Click(object sender, EventArgs e)
		{
			/*SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B9QJAOE\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True");
			conn.Open();
			string delete = "Delete from LapDanhSachLop where Họ Tên= " + cbo_HoTen.Text + "'";
			if (MessageBox.Show("Bạn có chắc chắn xóa học sinh " + cbo_HoTen.Text + " không? Nếu có ấn nút Yes, không thì ấn nút No", "Xóa sản phẩm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)== DialogResult.Yes)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandText = delete;
				//cmd.ExecuteNonQuery();
				MessageBox.Show("Xóa thành công");
				conn.Dispose();
				cmd.Dispose();*/
			if (MessageBox.Show("Bạn có chắc chắn xóa học sinh " + cbo_HoTen.Text + " không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				/*string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
				string delete = "delete from HOCSINH where HOTEN = 'N"+ id +"'";
				conn.Open();
				SqlCommand cmd = new SqlCommand(delete, conn);
				cmd.ExecuteNonQuery();
				conn.Close();
				frm_LapDanhSachLop_Load(null, null);*/
				int row_index = gridView1.FocusedRowHandle;
				string cul_name = "HOTEN";
				object value = gridView1.GetRowCellValue(row_index, cul_name);
				if (value != null)
				{
					DataLopDataContext db = new DataLopDataContext();
					var _Lop = db.LOPs.Where(s => s.MALOP == (string)value).SingleOrDefault();
					if (_Lop != null)
					{
						db.LOPs.DeleteOnSubmit(_Lop);
						db.SubmitChanges();
						MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
						LoadData();
					}
					//MessageBox.Show("Bạn đang chọn có giá trị: " + value.ToString());
				}
				else
				{
					MessageBox.Show("Bạn chưa chọn đối tượng cần xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				
			}


		}
	}
}