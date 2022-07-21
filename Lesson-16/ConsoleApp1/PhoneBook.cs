using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PhoneBook
    {
        private readonly Dictionary<string, string> _phoneBook;


        public PhoneBook()
        {
            _phoneBook = new Dictionary<string, string>();

        }


        public void AddPerson(string name, string number)
        {
            if (_phoneBook.ContainsKey(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(name + " is exist");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Select one of the option \n 1.Keep the number \n 2.Update the number");
                string option = Console.ReadLine();
                while (option != "1" && option != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please select valid option");
                    option = Console.ReadLine();
                }
                if (option == "2")
                {
                    var a = _phoneBook[name];
                    _phoneBook[name] = number;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{name} was successfuly update number {number} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                _phoneBook.Add(name, number);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name } with {number} added");
            }
        }


        public void GetNumberByName(string name)
        {
            if (_phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"{name} ve nomresi {_phoneBook[name]}");
            }
            else
            {
                Console.WriteLine("Nobody exist");
            }
        }

        public void GetNameByNumber(string number)
        {
            if (_phoneBook.ContainsValue(number))
            {
                foreach (var item in _phoneBook.Keys)
                {
                    var x = _phoneBook[item];
                    if (_phoneBook[item] == number)
                    {
                        Console.WriteLine($"{item} -a mexsusdur");
                    }
                }
            }
        }

        public void RemoveByNumber(string number)
        {
            if (_phoneBook.ContainsValue(number))
            {
                foreach (var item in _phoneBook.Keys)
                {
                    var x = _phoneBook[item];
                    if (_phoneBook[item] == number)
                    {
                        _phoneBook.Remove(item);
                    }
                }
            }
        }
    }
}
