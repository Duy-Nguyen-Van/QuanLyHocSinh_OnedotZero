using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyHocSinh_OnedotZero
{
    class HocSinhOJB
    {
        HocSinhMOD objHS = new HocSinhMOD();

        public DataTable GetTT_HS()
        {
            string str = "SELECT * FROM HOCSINH";
            return objHS.GetAll(str);
        }

        public DataTable GetHS_ID(string ID)
        {
            string str = "SELECT * FROM HOCSINH WHERE MAHS= '" + ID + "'";
            return objHS.GetAll(str);

        }

        

    }
}
