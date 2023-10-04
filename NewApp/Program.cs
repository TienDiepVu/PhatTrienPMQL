using NewApp.Models;
Student[] stdArr = new  Student[3];
for(int i = 0; i < 3; i++)
{
Console.WriteLine("Nhap phan tu thu {0}: ", i);
Student std = new Student ();
std.Import();
stdArr[i] = std;
}





