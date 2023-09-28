public  class Program 
{
    public static void Main(string[] args)
    {
        /* Khai bao bien
        string name = "Vu Tien Diep";
        int age = 22;
        Console.WriteLine("Thong tin sinh vien: {0} - {1}", name, age);
        */
        
        // Khai bao hang 
        // const string employee = "Vu Tien Diep";
        // const int born = 2001;
        // const string company = " Cong ty Co phan Cong nghe va Truyen thong RT";
        // const float exp = 0.5f;
        // Console.WriteLine(" Ho va ten :{0} \n Nam sinh: {1} \n Don vi cong tac: {2}\n Tham nien: {3} nam ", employee , born , company , exp  );

        //Toan tu so hoc
        int a,b;
        Console.Write("a = ");
        a = Convert.ToInt16(Console.ReadLine());
        System.Console.Write("b = ");
        b = Convert.ToInt16(Console.ReadLine());
        // Console.WriteLine("{0} - {1} = {2}", a , b , a-b);
        // Console.WriteLine("{0} x {1} = {2}", a , b , a*b);
        // Console.WriteLine("{0} / {1} = {2} ", a, b, a / b);
        // Console.WriteLine("{0} % {1} = {2} ", a, b, a % b);
        
        //toan tu so sanh
        if (a < b)
        {
            Console.WriteLine(a + " nho hơn " + b);
        }
        else if (a > b)
        {
            Console.WriteLine(a + " lon hơn " + b);
        }
        else
        {
            Console.WriteLine(a + " bang " + b);
        }

    }
}
