//Khai bao bien
string name = "Vu Tien Diep";
int age = 22;
Console.WriteLine("Sinh Vien : {0} - {1} tuoi ", name, age);

//khai bao hang 
const string hoTen = "Vu Tien Diep";
const int tuoi = 22;
Console.WriteLine("Sinh Vien : {0} - {1} tuoi ", hoTen, tuoi);

// Toan tu so hoc
int a, b;
Console.Write("Nhap vao so thu nhat: a = ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap vao so thu hai: b = ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0} - {1} = {2} ", a, b, a - b);
Console.WriteLine("{0} * {1} = {2} ", a, b, a * b);
Console.WriteLine("{0} / {1} = {2} ", a, b, a / b);
Console.WriteLine("{0} % {1} = {2} ", a, b, a % b);

//Toan tu so sanh
if (a == b)
{
    Console.Write(a + " bang " + b);
}
else
{
    if (a > b)
    {
        Console.WriteLine(a + " lon hon " + b);
    }
    else
    {
        Console.WriteLine(a + " nho hon " + b);
    }
}
