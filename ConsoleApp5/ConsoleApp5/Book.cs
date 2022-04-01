using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Book : Object
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public Book(string Name, string Author)
        {
            this.Name = Name;
            this.Author = Author;
        }

        public override string ToString()
        {
            return $"{Name} - {Author}";
        }
    }
}
