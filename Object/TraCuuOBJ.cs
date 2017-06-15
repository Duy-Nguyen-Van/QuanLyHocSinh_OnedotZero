using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyHocSinh_OnedotZero
{
    class TraCuuOBJ
    {
        TraCuuMOD objLop = new TraCuuMOD();

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
        public DataTable GetHS(string MaLop)
        {
            string str = "SELECT * FROM HOCSINH WHERE MALOP = '" + MaLop + "'";
            return objLop.GetAll(str);

        }
        public DataTable GetHS_ID(string MaHS)
        {
            string str = "SELECT HOTEN,TBHKI, TBHKII  FROM HOCSINH h JOIN DANHSACHLOP d ON h.MAHS=d.MAHS WHERE d.MAHS = '" + MaHS + "'";
            return objLop.GetAll(str);

        }
    }
}
