using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public interface IItem
    {
        string ItemName { get; }
        int ItemPrice { get; }
    }
}
