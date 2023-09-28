namespace NewApp.Models
{
    public class Person
    {
        public string FullName{ get; set; }
        public int Age { get; set;}
        public void Import()
        {
            Console.Write("Ho va Ten: ");
            FullName = Console.ReadLine();
            Console.Write("Tuoi: ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Export()
        {
            Console.WriteLine("{0} - {1} Tuoi", FullName , Age);
        }
    }
}
