using InventoryAccounting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using InventoryAccounting.ModelDB;

namespace InventoryAccounting.Logic
{
    public class Auth:IAuth
    {
        SportAccountingEntities db=new SportAccountingEntities();
        public bool Check(string login, string password)
        {
            var user = db.Users.Include(u => u.Roles).FirstOrDefault(u=>u.UserPassword==password && u.UserLogin==login);
            if (user != null)
            {
                new Profile(user).Show();
                return true;
            }
            return false;
        }
    }
}
