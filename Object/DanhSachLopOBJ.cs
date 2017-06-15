using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace QuanLyHocSinh_OnedotZero
{
    class DanhSachLopOBJ
    {
        DanhSachLopMOD objLop = new DanhSachLopMOD();

        public DataTable GetKhoi()
        {
            string str = "SELECT * FROM KHOI";
            return objLop.GetAll(str);
        }
        public DataTable GetLop(string MaKhoi)
        {
            string str = "SELECT * FROM LOP WHERE MAKHOI = '" + MaKhoi + "'";
            return objLop.GetAll(str);

        }
        public DataTable GetHS()
        {
            string str = "SELECT * FROM HOCSINH";
            return objLop.GetAll(str);

        }
        public DataTable GetHS_ID(string ID)
        {
            string str = "SELECT * FROM HOCSINH WHERE MAHS= '"+ ID + "'";
            return objLop.GetAll(str);

        }
        /*public DataTable GetHS_ID(string MaHS)
        {
            string str = "SELECT HOTEN,TBHKI, TBHKII  FROM HOCSINH h JOIN DANHSACHLOP d ON h.MAHS=d.MAHS WHERE d.MAHS = '" + MaHS + "'";
            return objLop.GetAll(str);

        }*/
        public bool UpDateMaLop_HS(string MaLop, string MaHS)
        {
            string SQLstr = "UPDATE HOCSINH SET MALOP= '"+ MaLop+"' WHERE MAHS = '"+ MaHS+ "'";
            if(objLop.ChangeData(SQLstr))
            {
                return true;
            }
            return false;
        }
    }
}
