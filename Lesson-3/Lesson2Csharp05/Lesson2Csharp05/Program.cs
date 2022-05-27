using System;

namespace Lesson2Csharp05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Hello_World();
            //Console.WriteLine(Topla());
            //long c = Topla() + 100;
            //Console.WriteLine(c);
            //Topla2();
            //int x = Topla2() + 1000;

            Console.WriteLine(Topla3(5));
            HiPerson("Nofel");
            HiPerson("Mina");

        }
        public static void Topla2()
        {
            int x = 0;
            for (int i = 1; i < 10; i++)
            {
                x += i;
            }
            Console.WriteLine(x);
        }

        public static int Topla()
        {
            byte x = 0;
            for (int i = 1; i < 10; i++)
            {
                //x += i;
            }
           
            return x;
        }


        public static int Topla3(int number)
        {
            int x = 0;
            for (int i = 1; i < number; i++)
            {
                x += i;
            }

            return x;
        }

        public static void HiPerson(string name)
        {
            Console.WriteLine($"Salamm {name}");

        }

    }
}
