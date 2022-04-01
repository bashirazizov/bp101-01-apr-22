using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Library
    {
        private Book[] Books;
        public Library(int size)
        {
            Books = new Book[size];
        }


        public Book this[int index]
        {
            get
            {
                return Books[index];
            }
            set
            {
                Books[index] = value;
            }
        }
    
    }
}
