using InnerJoin228.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using InnerJoin228.Classes;
using System.Threading.Tasks;
using InnerJoin228.Interfaces;

namespace InnerJoin228.Logic
{
    public class Auth:IAuth
    {
        InnerJoin228Entities db=new InnerJoin228Entities();
        public bool Check(string login, string password)
        {
            var user = db.Users.Include(u=>u.Roles).FirstOrDefault(u=>u.UserLogin==login && u.UserPassword==password);
            if (user!=null)
            {
                
                new Profile(user).Show();
                return true;
            }
            return false;
        }
    }
}
