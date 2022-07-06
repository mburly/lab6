using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPostman.Models
{
    public class BookBase
    {
        public Book Book { get; set; }

        public BookBase(Book book)
        {
            Book = book;
        }
    }
}
