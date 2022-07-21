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

            //Human human = new Human("Sahin", 20); xxxxxxxxxxxxxxx

            Man man = new Man("Elcan", 18, true);
            man.Eating();

            //Woman woman = new Woman();
            //woman.Name = "DCdsv";



        }
        abstract class Human //base class ana class
        {
            public string Name { get; set; }
            public byte Age { get; set; }
            public Human(string name, byte age)
            {
                Name = name;
                Age = age;
            }
            public Human(string name)
            {
                Name = name;
            }
            public virtual void Eating()
            {
                Console.WriteLine("Human yeyir");
            }
            public virtual void Eating(string x)
            {
                Console.WriteLine("Human yeyir");
            }

            public abstract void HairLong();

        }

        class Man : Human //derived class torenmis class
        {
            public bool Beard { get; set; }
            public string Test { get; set; }
            public Man(string nm, byte _age, bool beard) : base(nm, _age)
            {
                Beard = beard;
            }
            public Man(string name) : base(name) { }

            public override void Eating(string x)
            {
                Test = x;
                Console.WriteLine("Man yeyir");
            }

            public override void HairLong()
            {
                Console.WriteLine("Man hair qisa");
            }
        }
        //class Woman : Man
        //{

        //}
    }

}
