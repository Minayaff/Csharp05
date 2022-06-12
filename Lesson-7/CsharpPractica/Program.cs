using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            //string x = "salam";
            //string[] x = { "s","a","l","a","m"};
            //x[2]
            //Console.WriteLine(x[2]);
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}

            //CalculateArr(8, 9, 6, 4);
            //IsPalindrom("ana");

            #region String Methods

            //string x = "salam";
            //string sagol = "sagol";

            //Console.WriteLine(String.Compare(x, sagol));


            //string x2 = (String)x.Clone();


            string s1 = "       ";
            string s2 = "C#";
            string s3 = "C#";
            //Console.WriteLine(string.Concat(s1, s2));

            //Console.WriteLine(s1.Contains("boys"));
            //Console.WriteLine(s2.Equals(s3));
            //Console.WriteLine(s1.IndexOf("l"));
            //Console.WriteLine(s1.LastIndexOf("l"));
            //Console.WriteLine(string.IsNullOrEmpty(s1));
            //Console.WriteLine(string.IsNullOrWhiteSpace(s1));

            //string s11 = "Hel,lo,C#,guys";
            //string s22 = s11.Remove(2, 4);
            //Console.WriteLine(s22);

            //string[] array = s11.Split(',');

            //foreach (string item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //string pin = "AZE0091625";
            //string cutPin = pin.Substring(3);
            //if (cutPin == "AZE")
            //{
            //    Console.WriteLine("beraberdir");
            //}
            //else
            //{
            //    Console.WriteLine("deyil");
            //}


            //string c = "SALAM";
            //Console.WriteLine(c.ToLower());

            //string trimWord = "Hello C#     ";
            //string trim = trimWord.Trim();

            string soz = "Hello C#";
            char[] ch = soz.ToCharArray();
            #endregion

        }
        public static void IsPalindrom(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
                //result = result + word[i];
                //result = "" + "m";   ="m"
                //    result = "m" + "a";  " ma"
                //    result="ma"+"l"   "mal" 
                //    result="mal"+"a"
            }
            if (word == result)
            {
                Console.WriteLine("palindromdur");
            }
            else
            {
                Console.WriteLine("palindrom deyil");
            }
        }

        public static void CalculateArr(params int[] array)
        {
            int cem = 0;
            int hasil = 1;
            int ferq = 0;
            foreach (var item in array)
            {
                cem += item;  /*8+9+6+4*/
                hasil *= item; /*8*9*6*4*/
            }
            ferq = hasil - cem;
            Console.WriteLine($"{hasil}-{cem}=" + ferq);
        }
    }
}
