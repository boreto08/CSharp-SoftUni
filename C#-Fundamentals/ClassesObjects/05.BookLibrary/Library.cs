using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> ListOfBooks { get; set; }

        public Library(string name)
        {
            this.Name = name;
            this.ListOfBooks = new List<Book>();
        }
    }
}
