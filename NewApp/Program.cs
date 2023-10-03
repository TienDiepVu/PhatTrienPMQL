using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee();
        Employee emp2 = new Employee();
        emp1.NameOfEmp = "Tien Diep Vu";
        emp1.AgeOfEmp = 22;
        emp1.EmpID = 2001;
        emp1.Salary = 2500;
        emp1.ExportData();
        emp2.ExportData();
    }
}
