using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin228.Classes
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public Role(int id)
        {
            Id = id;
            
        }
    }
}
