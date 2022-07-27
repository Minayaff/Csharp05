public class Program
    {
        static void Main(string[] args)
        {

            DataBase db = new DataBase();

            Book book = new Book("Zalikin Maceralari",25);

            var resat =  db.Books.Add(book);
            if(resat)
                Console.WriteLine(book.Name + " Success");

            User user = new User("Zalik", 27);

            db.Users.Add(user);

            Order order = new Order(user, book);
            Book book1 = new Book("Nedd", 85);
            db.Books.UpDate(book, book1);

        }

    }


    public class DataBase
    {

        public DbSet<User> Users;
        public DbSet<Book> Books;
        public DbSet<Order> Orders;

        public DataBase()
        {
            Users = new DbSet<User>();
            Books = new DbSet<Book>();
            Orders = new DbSet<Order>();
        }

    }


    public class DbSet<Type> where Type : class
    {

        private List<Type> _Data;
        public List<Type> Data
        {
            get
            {
                return _Data;
            }
        }
        public DbSet()
        {
            _Data = new List<Type>();
        }

        public bool Add(Type type)
        {
            if (type != null)
            {
                _Data.Add(type);
                return true;
            }

            return false;
        }

        public bool UpDate(Type oldType, Type newTtpe)
        {
            if (_Data.Contains(oldType) && oldType != null && oldType != null)
            {
                _Data.Remove(oldType);
                _Data.Add(newTtpe);
                return true;
            }
            return false;
        }

        public bool Delete(Type type)
        {
            if (_Data.Contains(type) && type != null)
            {
                Data.Remove(type);
                return true;
            }
            return false;
        }

    }

    public class User
    {
        public int Id;
        private static int No;
        public string FullName;
        public byte Age;
        public User(string fullName, byte age)
        {
            No++;
            Id = No;
            FullName = fullName;
            Age = age;
        }
    }

    public class Book
    {
        public int Id;
        private static int No;

        public string Name;
        public float Price;
        public Book(string name, float price)
        {
            No++;
            Id = No;
            Name = name;
        }

    }

    public class Order
    {
        private static int No;
        public int Id;
        public User User;
        public Book Book;
        public DateTime Date;
        public Order(User user, Book book)
        {
            No++;
            Id = No;
            User = user;
            Book = book;
            Date = DateTime.Now;
        }

    }
