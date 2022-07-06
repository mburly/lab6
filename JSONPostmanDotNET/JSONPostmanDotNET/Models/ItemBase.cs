using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostmanDotNET.Models
{
    public class ItemBase
    {
        public Item Item { get; set; }
        public ItemBase(Item item)
        {
            Item = item;
        }
    }
}
