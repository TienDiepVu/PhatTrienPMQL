using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Person ps = new Person();
        ps.FullName = "Vu Tien Diep";
        ps.Age = 22;
        ps.Export();
    }
}
