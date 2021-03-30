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
        string ItemCategory { get; }
        int ItemPrice { get; set; }
    }
}
