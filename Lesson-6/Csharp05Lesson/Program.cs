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
            #region Methoda parametr olaraq array gondermek
            //int[] x = { 1, 2, 3, 6, 4, 8 ,98,36,45};
            //int[] x2 = { 205,55,87};
            //int y = 5;
            //int z = 5;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i]);
            ////}
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}

            //Total(x);
            //Total(x2);
            //Topla3(5);

            //int[] dynamicArr = new int[5];
            //dynamicArr[0] = 5;
            //dynamicArr[1] = 15;

            //foreach (var item in dynamicArr)
            //{
            //    if (item!=0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //for (int i = 0; i < dynamicArr.Length; i++)
            //{
            //    Console.WriteLine(i+1 +" elementi daxil edin");
            //    int eded = Convert.ToInt32(Console.ReadLine());
            //    dynamicArr[i] = eded;
            //}

            //Total(dynamicArr);
            //TotalResult(dynamicArr);

            //int z = TotalResult(dynamicArr) + 1000;
            //Console.WriteLine(z);
            #endregion

            //totala aid
            //int[] x = { 1, 2, 3, 6, 4, 8, 98, 36, 45 };
            //Total(x);
            //TotalParametrMulti(x, 100);

            ////params
            //TotalParamsIle(2, 9, 7, 5, 3, 6,8);



            TotalParamsIleMultiParametr(5, 418, 2, 3, 6, 9, 8, 7);

            TotalParamsIleMultiParametr(6,18, 2, 3, 6, 9, 8, 7);
        }
        public static void TotalParamsIle(params int[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                result += item;
            }
            Console.WriteLine(result + " cavab params");
        }
        public static void TotalParamsIleMultiParametr(int y,int x,params int[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                result += item;
            }
            Console.WriteLine(result+y + " cavab params multi parametr");
        }

        public static void Total(int[] array)
        {
            int result=0;
            foreach (var item in array)
            {
                result += item;
            }
            Console.WriteLine(result +" cavab");
        }

          public static void TotalParametrMulti(int[] array,int y)
        {
            int result=0;
            foreach (var item in array)
            {
                result += item;
            }
            Console.WriteLine(result+y +" cavab multi");
        }

        public static int TotalResult(int[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                result += item;
            }
            Console.WriteLine(result + " cavab");
            return result;
        }

        public static void Topla3(int number)
        {
            int x = 0;
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }


    }
}
