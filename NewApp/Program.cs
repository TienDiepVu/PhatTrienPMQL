    // Vũ Tiến Điệp 
    // 2021050192

using NewApp.Models;
using System.Collections;
ArrayList arrList = new ArrayList();
for(int i = 0; i < 2; i++)
{
Student std = new Student (); 
std.Import(); 
arrList.Add(std); 
}
for(int i = 0; i < 2; i++)
{
Student std = (Student) arrList[i];
std.Export(); 
}






