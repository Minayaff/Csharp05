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
        public string MiddleName;
        public int Id;
        public static List<Student> Students = new List<Student>();

        //constructor-yalniz 1 defe isleyir
        static Student()
        {
            Console.WriteLine("Static constructor");
        }
        //adi ctor
        public Student()
        {
            Console.WriteLine("Adi constructor");
        }

        //public Student(string name)
        //{
        //    Firstname = name;
        //    Nomre++; //1 //2
        //    Id = Nomre; //1 //2
        //}
        //public static void AddStudent(string name,string surname)
        //{

        //}

        //public void GetFullName(Student student)
        //{

        //}



    }
}
