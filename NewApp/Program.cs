using NewApp.Models;
Employee[] stdArr = new  Employee[3];
for(int i = 0; i < 3; i++)
{
Console.WriteLine("Nhap phan tu thu {0}: ", i);
Employee std = new Employee ();
std.Import();
stdArr[i] = std;
}
foreach(Employee std in stdArr)
{
string fName = std.FullName;
string PID = std.PersonID;
int a = std.Age;
int slr = std.Salary;
Console.WriteLine("{0} – {1} - {3} - {2} USD", fName, PID, slr , a);
}




