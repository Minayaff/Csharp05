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

            #region Kecen ders
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

            //Car[] carList = new Car[3];
            //for (int i = 0; i < carList.Length; i++)
            //{
            //    Console.WriteLine($"{i+1} -ci masini sisteme elave et");
            //    Console.WriteLine("Adi");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Model");
            //    string model = Console.ReadLine();
            //    Console.WriteLine("Mator");
            //    double mator = Convert.ToDouble( Console.ReadLine());
            //    Console.WriteLine("Ili");
            //    string year = Console.ReadLine();

            //    Car car = new Car(name,model,mator,year);

            //    carList[i] = car;

            //}
            //Console.WriteLine("butun masinlar");
            //foreach (var item in carList)
            //{
            //    Console.WriteLine(item.Name +" "+item.Model);
            //}
            #endregion

            #region Ev tapsirigi teze ders

            //Student student = new Student();
            //student.MiddleName = "sdfsdfsd";

            //int[] dvdvdf = { 5,6,7};
            //dvdvdf[0] = 51;

            //Student[] students = new Student[3];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} -ci telebeni sisteme elave et");
            //    Console.WriteLine("Fullname");
            //    string fullname = Console.ReadLine();
            //    Console.WriteLine("Qrupu");
            //    string qrupNum = Console.ReadLine();
            //    Console.WriteLine("Yas");
            //    byte age = Convert.ToByte(Console.ReadLine());

            //    Student student = new Student(fullname, age, qrupNum);
            //    Student.GetBirthdaYear(student);

            //    students[i] = student;
            //}
            //Console.WriteLine("1. Qrup nomresini oyren \n 2.Qrupda nece telebe oxudugunu oyren ");
            //int secim = Convert.ToInt32(Console.ReadLine());

            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine("Axtardigin telebenin adini daxil et");
            //        string telebeAdi = Console.ReadLine();
            //        Student.CheckGroupNumberByStName(telebeAdi, students);
            //        break;
            //    case 2:
            //        Console.WriteLine("Qrup nomresini daxil etmekle telebe sayi");
            //        string qrupAdi = Console.ReadLine();
            //        Student.CheckGroupNumber(qrupAdi, students);
            //        break;
            //    default:
            //        Console.WriteLine("bele secim yoxdur");
            //        break;
            //}


            #endregion


            #region Izah
            //non-genericslerde olcu problemi yoxdur ama tipi de yoxdur
            int[] testArray = new int[5];
            testArray[0] = 15;
            testArray[1] = 25;
            testArray[2] = 35;

            ArrayList list = new ArrayList();
            list.Add(15);
            list.Add("SDfsdfds");
            Student st = new Student("Mina", "P105");
            list.Add(st);

            //list.Remove(15);

            //if (list[1] is int)
            //{
            //    int test = (int)list[0];
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            list.Insert(0, "eli");
            list.Insert(3, "eli");

            list.AddRange(testArray);
            Console.WriteLine(list.IndexOf("eli"));
            Console.WriteLine(list.LastIndexOf("eli"));
            list.RemoveRange(2,3);
            //list.RemoveAt(2);
            //list.Remove("eli");
           
            #endregion


        }


    }

    #region kecen ders
    public class Car
    {
        //public string Name="kia";       
        public string Name;
        public string Model;
        public double Mator;
        public string Year;

        public Car(string nm, string mdl, double mtr, string yearr)
        {
            Name = nm;
            Model = mdl;
            Mator = mtr;
            Year = yearr;
        }

    }

    #endregion

}
