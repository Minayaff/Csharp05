using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            int x1 = 5;
            int x2 = x1;
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            x1 = 100;

            Console.WriteLine(x1);
            Console.WriteLine(x2);


            int[] arr1 = { 1, 2, 3, 5, 46 };
            int[] arr2 = arr1;
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            arr1[0] = 96;
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            //Topla(6,5);
            //int x=Topla2(3, 5);
            //Console.WriteLine(x +" topla2den gelen");
            //Console.WriteLine(Topla2(3, 5));
            //int z1 = Topla2(6, 5) + 10;
            //Console.WriteLine(z1);


            //int z = Topla(6, 5) + 10;
            //Console.WriteLine(z);

            //object obj ="5";

            //if (obj is int)
            //{
            //    int j = (int)obj; //unboxing
            //}
        }
        #region Method overloading
        //public static void Toplama(int n1,int n2)
        //{
        //    Console.WriteLine(n1+n2);
        //}

        ////parametr sayina gore ferqlenen
        //public static void Toplama(int n1, int n2,int n3)
        //{
        //    Console.WriteLine(n1 + n2+n3);
        //}

        //methodun tipine gore
        public static int Toplama(int n1,int n2)
        {
            return n1 + n2;
        }
        public static double Toplama(double n1, double n2)
        {
            return n1 + n2;
        }

        public static decimal Toplama(decimal n1, decimal n2)
        {
            return n1 + n2;
        }
        #endregion

        public static void Topla(int n1,int n2)
        {
            int result = n1 + n2;
            Console.WriteLine(result);
            //return result; islemir
        }

        public static int Topla2(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
    }
}
