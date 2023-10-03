using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Employee std = new Employee();
        std.Import();
        std.Export();
    }
}
