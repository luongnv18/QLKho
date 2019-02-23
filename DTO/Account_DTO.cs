using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lí_kho___giao_dien_.DTO
{
  public  class Account_DTO
    {
        private string id;
        private string username;
        private string fullname;
        private string right;
        private string password;
public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Right { get => right; set => right = value; }
        public string Password { get => password; set => password = value; }
    }
}
