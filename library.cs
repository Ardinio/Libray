using System;
using System.Collections.Generic;

namespace Biblioteket
{
    class library
    {
        private List<Book> books = new List<Book>();

        public bool AddBook(Book newbook)
        {
            return true;
        }
        public bool AddBooks(List<string> morebooks)
        {
            return true;
        }
        public string ShowAllBooks(List<Book> showbooks)
        {
            throw new NotImplementedException();
        }

        public List<Book> ShowBooks()
        {
            throw new NotImplementedException();
        }
        public string SearchBook(string searchbook)
        {
            throw new NotImplementedException();
        }
    }
}