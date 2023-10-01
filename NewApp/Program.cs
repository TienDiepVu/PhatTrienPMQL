using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Person ps1 = new Person();
        Person ps2 = new Person();
        ps1.FullName = "Vu Tien Diep";
        ps1.Age = 22;
        ps1.Export();
        ps2.Export();
    }
}
