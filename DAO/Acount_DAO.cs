using Quản_lí_kho___giao_dien_.DAO;
using Quản_lí_kho___giao_dien_.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class Acount_DAO
    {
        public static List<Account_DTO> loadList()
        {
            //tạo chuỗi truy vấn
            string query = "select * from ACOUNT";
            using (SqlConnection connect = DataProvider.CONNECT())
            {
                DataTable dt = new DataTable();
                dt = DataProvider.Get_Data(query, connect);
                if (dt.Rows.Count == 0)
                    return null;
                else
                {
                    List<Account_DTO> USERS  = new List<Account_DTO>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Account_DTO user  = new Account_DTO();
                        user.Id = dt.Rows[i]["ID"].ToString();
                        user.Username = dt.Rows[i]["USERNAME"].ToString();
                        user.Right = dt.Rows[i]["RIGHTS"].ToString();
                        user.Password = dt.Rows[i]["PASS"].ToString();
                        user.Fullname =  dt.Rows[i]["FULLNAME"].ToString();

                        USERS.Add(user);
                    }
                    return USERS;
                }


            }
        }
        public static bool Add_USER(Account_DTO a)
        {

            String query = "insert into ACOUNT values(N'"+a.Id+"',N'"+a.Username+"',N'"+a.Fullname+"',N'"+a.Right+"',N'"+a.Password+"')";
            using (SqlConnection connect = DataProvider.CONNECT())
            {
                try
                {
                    DataProvider.Excute_Query(query, connect);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static bool Edit_User (Account_DTO a)
        {

            String query = " update ACOUNT set ID = N'"+a.Id+"', USERNAME = '"+a.Username+"',FULLNAME = '"+a.Fullname+" ',RIGHTS = '"+a.Right+"',PASS = '"+a.Password+"' WHERE ID = N'"+a.Id+"'";
            using (SqlConnection connect = DataProvider.CONNECT()) 
            {
                try
                {
                    DataProvider.Excute_Query(query,connect);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static bool Delete_Account(Account_DTO a)
        {

            String query = "delete from ACOUNT where ID=N'" +a.Id + "'";
            using (SqlConnection connect = DataProvider.CONNECT())
            {
                try
                {
                    DataProvider.Excute_Query(query, connect);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static List<Account_DTO> loadList_find(Account_DTO a)
        {
            //tạo chuỗi truy vấn
            string query = "select * from ACOUNT where ID='"+a.Id+"'";
            using (SqlConnection connect = DataProvider.CONNECT())
            {
                DataTable dt = new DataTable();
                dt = DataProvider.Get_Data(query, connect);
                if (dt.Rows.Count == 0)
                    return null;
                else
                {
                    List<Account_DTO> Accounts = new List<Account_DTO>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Account_DTO Account = new Account_DTO();
                        Account_DTO user = new Account_DTO();
                        user.Id = dt.Rows[i]["ID"].ToString();
                        user.Username = dt.Rows[i]["USERNAME"].ToString();
                        user.Right = dt.Rows[i]["RIGHTS"].ToString();
                        user.Password = dt.Rows[i]["PASS"].ToString();
                        user.Fullname = dt.Rows[i]["FULLNAME"].ToString();

                        Accounts.Add(user);

                        
                    }
                    return Accounts;
                }


            }
        }
    }
}
