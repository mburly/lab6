using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostmanDotNET.Models
{
    public class Book
    {
        public List<Item> Items { get; set; }
        public Book(List<Item> items)
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
