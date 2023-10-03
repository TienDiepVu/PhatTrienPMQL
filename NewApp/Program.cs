using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Student std = new Student();
        std.Import();
        std.Export();
    }
}
