using System;
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
            //DateTime day = new DateTime();
            //DateTime date = DateTime.Now;
            //DateTime x = date.AddDays(5);
            //Console.WriteLine(x.Day +"/"+ x.Month +"/"+ x.Year);
            //Car masin = new Car();
            //masin.Model = "Sportage";
            //masin.Mator = 1.6;
            //masin.Name = "DfvD";


            //Car masin2 = new Car();
            //masin2.Mator = 1.8;
            //masin2.Model = "Sorento";


            //Car[] cars = { masin, masin2 };
            //Console.WriteLine(cars[1].Mator);
            //int[] x = new int[5];
            //x[0] = 6;
            //x[1] = 15;

            Car[] carList = new Car[3];
            for (int i = 0; i < carList.Length; i++)
            {
                Console.WriteLine($"{i+1} -ci masini sisteme elave et");
                Console.WriteLine("Adi");
                string name = Console.ReadLine();
                Console.WriteLine("Model");
                string model = Console.ReadLine();
                Console.WriteLine("Mator");
                double mator = Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("Ili");
                string year = Console.ReadLine();

                Car car = new Car(name,model,mator,year);
               
                carList[i] = car;

            }
            Console.WriteLine("butun masinlar");
            foreach (var item in carList)
            {
                Console.WriteLine(item.Name +" "+item.Model);
            }
        }

    }

    public class Car
    {
        //public string Name="kia";       
        public string Name;
        public string Model;
        public double Mator;
        public string Year;

        public Car(string nm,string mdl,double mtr,string yearr)
        {
            Name = nm;
            Model = mdl;
            Mator = mtr;
            Year = yearr;
        }

    }
  
}
