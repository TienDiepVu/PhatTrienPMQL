using NewApp.Models;
Person[] stdArr = new  Person[3];
for(int i = 0; i < 3; i++)
{
Console.WriteLine("Nhap phan tu thu {0}: ", i);
Person std = new Person ();
std.Import();
stdArr[i] = std;
}
foreach(Person std in stdArr)
{
string fName = std.FullName;
string PID = std.PersonID;
Console.WriteLine("{0} – {1}", fName, PID);
}




