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

            #region Static ctor vs adi ctor , enum
            //Student student = new Student();
            //student.Firstname = "Dcdvdf";

            //Student student2 = new Student();
            //student.Firstname = "Dcdvdf222";

            //Student student3 = new Student();
            //student.Firstname = "Dcdvdf333";

            //List<string> week = new List<string> { "Monday", "Tuesday", "Wednesday" };

            //var x=week[0];
            //Console.WriteLine(x);
            //Console.WriteLine(WeekDays.Monday + " from enum");
            #endregion

            const int y= 5;

            PhoneBook bestFriend = new PhoneBook();
            bestFriend.AddPerson("Mina", "0559288755");
            bestFriend.AddPerson("Elcan", "0559288788");
            bestFriend.AddPerson("Mina", "0708889966");
            


            PhoneBook workFriend = new PhoneBook();

            //Dictionary<string, string> test = new Dictionary<string, string>();
            //test.Add("Mina", "0559288755");
            //test.Add("Eli", "0559415188755");
            //test.Add("Veli", "0559999999");

            //Console.WriteLine(test["Mina"]);
        }

        enum WeekDays
        {
            Monday=2,     // 0
            Tuesday=5,    // 1
            Wednesday=3,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday      // 6
        }
    }

}
