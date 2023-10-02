namespace NewApp.Models
{
    public class Person
    {
        public string FullName{ get; set; }
        public int Age { get; set;}
        public string PersonID{ get; set; }
        public void Import()
        {
            Console.Write("Ho va Ten: ");
            FullName = Console.ReadLine();
            Console.Write("Tuoi: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Can cuoc so: ");
            PersonID = Console.ReadLine();

        }
        public void Export()
        {
            Console.WriteLine("{0} - {1} Tuoi - ID: {2}", FullName , Age, PersonID);
        }   
        public void Export(string FullName, int Age)
        {
            Console.WriteLine("{0} - {1} Tuoi", FullName , Age);
        }
        public void Export(string FullName, string PersonID)
        {
            Console.WriteLine("{0} - can cuoc so: {1} ", FullName , PersonID);
        }
    }
}
