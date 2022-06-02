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
            #region Method overloading
            //Toplama(2.5, 3.3);

            //float f1 = 5F / 3;
            //double db1 = 5D / 3;
            //decimal dec1 = 5M / 3;

            //Console.WriteLine($"float {f1}");
            //Console.WriteLine($"double {db1}");
            //Console.WriteLine($"decimal {dec1}");
            #endregion

            #region Casting
            //casting ---value typelar arasinda gedir
            //1.up-cast 2.downcast
            byte a = 255;
            int b = a; //upcast
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            int c = 255;
            sbyte d = (sbyte)c; //downcasting -data itkisi mutleqdir
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            int yas = 5;
            byte yass = 5;


            #endregion

            #region Array
            //Array-fixed size, reference type
            //1
            int[] arr1 = new int[5];
            arr1[0] = 3;
            arr1[1] = 35;
            arr1[4] = 80;
            arr1[2] = 60;
            arr1[3] = 90;

            //Console.WriteLine(arr1[4] +" arrayin 4cu indeksinde data");
            //2
            int[] arr2 = new int[5] { 20, 30, 40, 50, 60 };

            //3 en coox istifade edilen
            int[] arr3 = { 7, 8, 9, 4, 5, 6 };
            //arr3[6] = 5; //error verecek

            //4
            string[] ms = { "Eli", "Veli", "Mina" };

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}

            #endregion


            #region Boxing vs unboxing -value type--reference(object) type

            int[] array = { 7, 8, 9, 4, 5, 6 };
            //Console.WriteLine(array[3]);
            int x = 5;
            //Console.WriteLine(x +" =x");
            //string z = "SDVDFG";
            object fx = x; //boxing
            //fx = z;
            Console.WriteLine(fx);

            object obj = "5";

            if (obj is int)
            {
                int j = (int)obj; //unboxing
            }

            #endregion
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
    }
}
