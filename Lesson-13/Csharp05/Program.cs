using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lesson
            //ArrayList array =new ArrayList();
            //array.Add("Gdrgd");
            //array.Add("fgfDbf");

            //if (array[0] is int)
            //{
            //    int x = (int)array[0];
            //}

            //List<int> vs = new List<int>();
            //vs.Add(5); //1
            //vs.Add(15); //2
            //vs.Add(15); //2
            //vs.Add(15); //2
            //vs.Add(15); //2

            //vs.Insert(0, 50); //0

            //vs.RemoveAt(1);
            //vs.Remove(15);
            //vs.RemoveAll(x=>x==15);
            //select * from xtable where isactive=true
            //xtable.where(x=>x.isactive==true)

            //foreach (var item in vs)
            //{
            //    if (item==15)
            //    {
            //        vs.Remove(15);
            //    }
            //}
            //Stack<int> stack = new Stack<int>();
            //stack.Push(5);

            //Queue<int> queue = new Queue<int>();    
            //queue.Enqueue(5);   
            //queue.Enqueue(15);  

            //Dictionary<int,string> pairs = new Dictionary<int,string>();
            //pairs.Add(1, "Sahin");
            //pairs.Add(2, "Zalik");
            //pairs.Add(3, "Orxan");
            //pairs.Add(4, "Nofel");

            //if (pairs.ContainsKey(1))
            //{
            //    pairs.Remove(1);
            //}

            //foreach (var item in pairs)
            //{
            //    Console.WriteLine(item.Key + " " +item.Value);
            //}

            //SortedList<string, string> cities = new SortedList<string, string>()
            //                        {
            //                            {"London", "UK"},
            //                            {"New York", "USA"},
            //                            { "Mumbai", "India"},
            //                            {"Johannesburg", "South Africa"}
            //                        };
            //Console.WriteLine("---Cities---");
            //foreach (var kvp in cities)
            //{
            //    Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
            //    Console.WriteLine($"{kvp.Key} , {kvp.Value}");
            //    Console.WriteLine(kvp.Key +","+ kvp.Value);
            //}
            #endregion

            Book book1 = new Book("Csharp", "XXX");
            Book book4 = new Book("Html", "ZZZ");
            Book book2 = new Book("Csharp", "YYY");
            Book book3 = new Book("Csharp", "ZZZ");
            Book book5 = new Book("AspNet", "uuu");

            Library programmingLibrary = new Library();
            programmingLibrary.books =new List<Book>{ book1, book2, book3, book4, book5};

           programmingLibrary.FindAllBooksByName("Csharp");


            Library childLibrary = new Library();

            Book nagil1 = new Book("Nagillar1", "XXX");
            Book nagil2 = new Book("Nagillar2", "XZzzXX");
            Book nagil3 = new Book("Nagillar3", "yyyy");
            Book nagil4 = new Book("Nagillar4", "PPP");

            childLibrary.books=new List<Book> { nagil1,nagil2, nagil3, nagil4};

            childLibrary.FindAllBooksByName("nagil");



        }
    }
}
