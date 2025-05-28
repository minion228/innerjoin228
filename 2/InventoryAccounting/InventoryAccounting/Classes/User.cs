using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAccounting.Classes
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int UserRole { get; set; }
        public User(string login, string password)
        {
            Login=login;
            Password=password;
        }
    }
}
