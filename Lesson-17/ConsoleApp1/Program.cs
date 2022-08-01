
ConsoleLog consoleLog = new ConsoleLog();
consoleLog.Write("program start");

FileLog fileLog = new FileLog();
fileLog.Write("program start");

#region Encapsulation
//using System.Net.Mail;

//Student Student = new Student
//{
//    Email = "dsvcdsfds@gmail.com"
//};
//Console.WriteLine(Student.Email);


//CalculateSquare calculateSquare = new CalculateSquare(5, 10);
//Console.WriteLine(calculateSquare.sahe);

//class Student
//{
//    private string _email;
//    public string Email
//    {
//        get { return _email; }
//        set
//        {
//            try
//            {
//                MailAddress mailAddress = new MailAddress(value);
//                _email = value;
//            }
//            catch (Exception)
//            {

//                throw new Exception();
//            }
//        }
//    }

//}


//public class CalculateSquare
//{

//    public int x { get; set; }
//    public int y { get; set; }
//    private int _sahe;
//    public int sahe
//    {
//        get
//        {
//            return _sahe;
//        }
//    }
//    public CalculateSquare(int x1, int y1)
//    {
//        x = x1;
//        y = y1;
//        Calculate();
//    }

//    public void Calculate()
//    {
//        this._sahe = x * y;

//    }
//}

#endregion
#region Interface
//class Mother
//{

//}

//class Father
//{

//}

//class Child : Father
//{

//}

interface IDDL
{
    void Add(string table, string data);
    void Update(string table, string data);

}
interface IDMl
{
    void Select(string table, string data);
}
class X:Mssql
{

}
class Mssql :IDMl
{
    public void Select(string table, string data)
    {
        throw new NotImplementedException();
    }

}

class Mysql : IDDL, IDMl
{
    public void Add(string table, string data)
    {
        throw new NotImplementedException();
    }

    public void Select(string table, string data)
    {
        throw new NotImplementedException();
    }

    public void Update(string table, string data)
    {
        throw new NotImplementedException();
    }
}

class Oracle : IDDL
{
    public void Add(string table, string data)
    {
        throw new NotImplementedException();
    }

    public void Update(string table, string data)
    {
        throw new NotImplementedException();
    }
}

#endregion

 
interface ILog
{
    void Write(string message);
}
class ConsoleLog : ILog
{
    public void Write(string message)
    {
        Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm")+ " "+message);
    }
}

class FileLog : ILog
{
    public void Write(string message)
    {
        string text = DateTime.Now.ToString("dd.MM.yyyy HH:mm")+ " "+message;
        using (StreamWriter word = File.AppendText(@"C:\Users\Minaye.Ferzeliyeva\source\repos\ConsoleApp1\ConsoleApp1\logTxt.txt"))
        {
            word.WriteLine(text);
        }
    }
}