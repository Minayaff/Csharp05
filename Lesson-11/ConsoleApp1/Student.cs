using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string Fullname;
        public byte Age;
        public string GroupNumber;
        public string MiddleName { get; set; }


        public Student(string fn, byte age, string grNum)
        {
            Fullname = fn;
            Age = age;
            GroupNumber = grNum;
        }
        public Student(string fn,string grNum)
        {
            Fullname = fn;
            GroupNumber = grNum;
        }
        //public Student()
        //{

        //}

        public static void GetBirthdaYear(Student student)
        {
            Console.WriteLine(DateTime.Now.Year - student.Age + " dogum ili");
        }

        public static void CheckGroupNumberByStName(string fullname, Student[] stds)
        {
            foreach (var item in stds)
            {
                if (item.Fullname == fullname)
                {
                    Console.WriteLine(item.GroupNumber + " bu qrupda oxuyur");
                }
            }
        }
        public static void CheckGroupNumber(string groupNum, Student[] stds)
        {
            int count = 0;
            foreach (var item in stds)
            {
                if (item.GroupNumber == groupNum)
                {
                    count++;
                    Console.WriteLine(item.Fullname);
                }
            }

            Console.WriteLine(groupNum + $" qrupda {count} oxuyur");
        }

    }
}
