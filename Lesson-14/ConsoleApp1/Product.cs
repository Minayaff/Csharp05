using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string Name;
        public double Price;
        public double Discount;
        public string Code;
        public static int No = 1000;
        public int Id;
        public double TotalPrice;


        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            No++;
            Id = No;
            string x = name.Substring(0, 3);
            Code = x + No;
            if (Discount == 0)
            {
                TotalPrice = price;
            }
        }

        public void GetTotalPrice()
        {

            double faizinTapilmasi = (Price * Discount) / 100;
            TotalPrice = Price - faizinTapilmasi;
            Console.WriteLine("endirim tetbiq edildi");
        }
    }
}
