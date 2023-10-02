using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Person ps = new Person();
        string str = "VuTienDiep";
        int a = 22;
        System.Console.WriteLine( "{0} sinh nam {1} ", str , ps.GetYearOfBirth(a));
    }
}
