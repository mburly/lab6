using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostman.Models
{
    public class Volume
    {
        public List<Item> Items { get; set; }
        public Volume(List<Item> items)
        {
            Items = items;
        }
        public override string ToString()
        {
            string ret = String.Empty;
            foreach (Item item in Items)
            {
                ret += item.ToString();
            }
            return ret;
        }
    }
}
