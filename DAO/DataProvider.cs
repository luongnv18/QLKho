using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lí_kho___giao_dien_.DAO
{
   public  class DataProvider
    {
            //tạo hàm kết nối
            public static SqlConnection CONNECT()
            {
                string str_connect= @"Data Source=SKY_COMPUTER\SQLEXPRESS02;Initial Catalog = QLKHO; Integrated Security = True";
            SqlConnection connect = new SqlConnection(str_connect);
                connect.Open();
                return connect;
            }
            public static void Close_Connect(SqlConnection connect)
            {
                connect.Close();
            }
            public static DataTable Get_Data(string query, SqlConnection connect)
            {
                //dùng DatAdapter để lấy dữ liệu từ CSDL
                SqlDataAdapter da = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            public static bool Excute_Query(string query, SqlConnection connect)
            {
                try
                {
                    SqlCommand com = new SqlCommand(query, connect);
                    com.ExecuteNonQuery();
                    return true;

                }
                catch (Exception ex)
                { return false; }
            }
        
    }
}
