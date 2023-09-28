using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Employee fr = new Employee();
        fr.NameOfEmp = "Cam";
        fr.AgeOfEmp = 22;
        fr.EmpID = 110701;
        fr.Salary = 25000000;
        fr.ExportData();
    }
}
