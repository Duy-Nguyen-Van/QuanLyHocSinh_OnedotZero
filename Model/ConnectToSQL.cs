using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh_OnedotZero
{
	class ConnectToSQL
	{
		public static SqlConnection conn;
		public ConnectToSQL()
		{
			try
			{
				conn = new SqlConnection(@"Data Source=DESKTOP-B9QJAOE\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True");

			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}

