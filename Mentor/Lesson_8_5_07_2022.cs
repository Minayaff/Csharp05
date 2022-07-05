
    internal class Program
    {
        

        static void Main(string[] args)
        {

            // Stdudent Array Create(Yaradırıq)
            Student[] students = new Student[3];


            // Student Arrayinin Length qədər loop edirk = (Yaddaş Tutumu qədər dövür edirik)
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"--------- Studen Create {i+1} -------------"); 

                Console.Write("Id :");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name :");
                string name = Console.ReadLine();

                Console.Write("Group Name :");
                string groupName = Console.ReadLine();

                Console.Write("Age :");
                byte age = Convert.ToByte(Console.ReadLine());
                
                // Student Create (Datalara uyğun Studenti yaratdıq)
                Student student = new Student(id, name, groupName, age);

                // Student Arrayə Save Edirik.
                students[i] = student;
            }


            // Search (Axtarış)
            Console.WriteLine("----------- Search Student -------------");
            Console.Write("Id : ");
            int searchId = Convert.ToInt32(Console.ReadLine());
           
            foreach (var item in students)
            {
                if(searchId == item.Id) // Search Cadition
                {
                    // Show All Data
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.FullName);
                    Console.WriteLine(item.Age);
                    Console.WriteLine(item.GroupName);
                    item.BrithDate();
                    break;
                }
            }
            
        }
    }

    class Student
    {

        // Class Create Olunan anda Fildlərə uyğun dataları qəbul edirik
        public Student(int id,string fullName,string groupName,byte age)
        {
            Id = id;
            FullName = fullName;
            GroupName = groupName;
            Age = age;
        }

        // Doğum ilini göstərən method
        public void BrithDate()
        {
            Console.WriteLine(DateTime.Now.Year - Age);
        }

        public int Id;
        public string FullName;
        public string GroupName;
        public byte Age;
    }
