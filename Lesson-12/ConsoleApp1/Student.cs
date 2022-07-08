using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string Firstname;
        public string Lastname;
        public byte Age;
        public string GroupNumber;
        public string MiddleName { get; set; }


        public Student(string fname, byte age, string lname)
        {
            Firstname = fname;
            Age = age;
            Lastname = lname ;
        }
        public Student(string fn,string grNum)
        {
            Firstname = fn;
            GroupNumber = grNum;
        }

        public static void GetBirthdaYear(Student student)
        {
            Console.WriteLine(DateTime.Now.Year - student.Age + " dogum ili");
        }

        public void GetFullname()
        {
            Console.WriteLine(Firstname +" " + Lastname);
        }
        
    }
}
