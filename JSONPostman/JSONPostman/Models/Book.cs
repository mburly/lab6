using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostman.Models
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
            Console.WriteLine("HERRO?");
            string ret = String.Empty;
            if(Items != null)
            {
                Console.WriteLine("Ok...");
            }
            else
            {
                Console.WriteLine("???");
            }
            foreach (Item item in Items)
            {
                Console.WriteLine("???");
                ret += item.ToString();
            }
            return ret;
        }
    }
}
