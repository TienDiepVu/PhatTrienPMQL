using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Person ps = new Person();
        string str = "VuTienDiep";
        int a = 22;
        string c = "11111111";
        ps.Export(str,a);
        ps.Export(str,c);

    }
}
