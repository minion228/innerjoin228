using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAccounting.Interfaces
{
    public interface IAuth
    {
        bool Check(string login, string password);
    }
}
