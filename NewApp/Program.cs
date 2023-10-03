using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        string name = "VTD";
        int age = 22;
        emp.ExportData2(name, age);
    }
}
