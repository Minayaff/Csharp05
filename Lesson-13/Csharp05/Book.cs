using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05
{
    public class Book
    {
        public string Title;
        public string AuthorName;
        public string Code;
        public static int Nomre = 100;
        public int Id;

        public Book(string name, string author)
        {
            Title = name;
            AuthorName = author;
            Nomre++;
            Id = Nomre;
            Code = Title.Substring(0, 2) + Id;

        }


    }
}
