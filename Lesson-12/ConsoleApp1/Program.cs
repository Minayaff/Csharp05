using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student studenttt = new Student("Mina", 15, "Farzali");

            //Student.GetBirthdaYear(studenttt);

            //studenttt.GetFullname();

            //Student student2 = new Student("Eli", 20, "Eliyev");
            //student2.GetFullname();

            //Product product1 = new Product("Pervol",10);
            //product1.Discount = 2;
            //product1.GetTotalPrice();
            //Console.WriteLine(product1.Name);
            //Console.WriteLine(product1.TotalPrice);


            //Product product2 = new Product("Cay", 1.5);
            //Console.WriteLine(product2.Name);
            //Console.WriteLine(product2.TotalPrice);



            //Product product3 = new Product("Kofe", 1.5);
            //Console.WriteLine(product3.Name);
            //Console.WriteLine(product3.TotalPrice);

            ArrayList arrayList = new ArrayList();
            arrayList.Add(15);
            arrayList.Add("DSFSDF");
            arrayList.Add(25);
            //Console.WriteLine(arrayList[2]);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable numberNames = new Hashtable();
            //numberNames.Add(1, "One");
            //numberNames.Add("Ikinci", "Two");
            //numberNames.Add("Ucuncu", "Three");

            //Console.WriteLine(numberNames[1]);
            //foreach (DictionaryEntry item in numberNames)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //var cities = new Hashtable(){
            //    {"UK", "London, Manchester, Birmingham"},
            //    {"USA", "Chicago, New York, Washington"},
            //    {"India", "Mumbai, New Delhi, Pune"}
            //};
            //Console.WriteLine(cities["UK"]);


            //Stack st = new Stack(); //LIFO
            //st.Push("Mina");
            //st.Push("Elcan");
            //st.Push("Orxan");
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}
            //st.Pop();
            //Console.WriteLine("silinenden sonra");
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(st.Peek());

            Queue que = new Queue(); //FIFO
            que.Enqueue("Mina");
            que.Enqueue("Elcan");
            que.Enqueue("Orxan");
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
            que.Dequeue();
            Console.WriteLine("silindi");
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(que.Contains("Mina")); ;
        }


    }

}
