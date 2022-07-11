using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05
{
    public class Library
    {
        public List<Book> books =new List<Book>();

        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> findedBooks = new List<Book>();

            foreach (var item in books)
            {
                if (item.Title.ToLower().Contains(name.ToLower()))
                    //if (item.Title.ToLower() == name.ToLower())
                {
                    findedBooks.Add(item);
                    Console.WriteLine(item.Title + " " + item.AuthorName);
                }
            }

            return findedBooks;
        }
    }
}
