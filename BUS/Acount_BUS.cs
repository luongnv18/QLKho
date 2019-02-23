using DAO;
using Quản_lí_kho___giao_dien_.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Acount_BUS
    {
       
            public static List<Account_DTO> Load_Account()
            {
                return Acount_DAO.loadList();
            }
            public static bool Add_ac(Account_DTO a)
            {
            return Acount_DAO.Add_USER(a);
            }
            public static bool Edit_ac(Account_DTO a)
            {
                return Acount_DAO.Edit_User(a);
            }

            public static bool Delete_ac(Account_DTO a)
            {
                return Acount_DAO.Delete_Account(a);
            }
            public static List<Account_DTO> Load_Acount_find(Account_DTO a)
            {
                return Acount_DAO.loadList_find(a)
    ;
            
        }
    }
}
