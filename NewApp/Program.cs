using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Person ps = new Person();
        string str = "VuTienDiep";
        int a = 22;
        ps.Export2(str,a);
    }
}
