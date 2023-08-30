// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        Console.Write("Nhập vào số thứ nhất: a= ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập vào số thứ hai: b= ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} - {1} = {2} ", a,b,a-b);
        Console.WriteLine("{0} * {1} = {2} ", a,b,a*b);
        Console.WriteLine("{0} / {1} = {2} ", a,b,a/b);
        Console.WriteLine("{0} % {1} = {2} ", a,b,a%b);
        if (a == b) 
        {
            Console.Write(a + " bằng " + b);
        }
        else 
        {
            if (a > b){ 
            Console.WriteLine(a + " lớn hơn " + b);
            }
            else {
            Console.WriteLine(a + " nhỏ hơn " + b);
            }
        }       
    }
}
