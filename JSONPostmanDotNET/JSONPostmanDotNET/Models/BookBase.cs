using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostmanDotNET.Models
{
    public class BookBase
    {
        public Book Volume { get; set; }

        public BookBase(Book volume)
        {
            Volume = volume;
        }
    }
}
