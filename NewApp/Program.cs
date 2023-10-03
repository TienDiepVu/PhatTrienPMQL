using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        string n = "VTD";
        int a = 22;
        int s = 2000;
        Console.WriteLine("{0} - {1} tuoi - muc luong {} USD", n ,a, emp.TinhLuong(s));
    }
}
