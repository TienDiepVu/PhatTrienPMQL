// Vũ Tiến Điệp 
// 2021050192
namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PersonID { get; set; }
        public void Import()
        {
            Console.Write("Ho va Ten: ");
            FullName = Console.ReadLine();
            Console.Write("Can cuoc so: ");
            PersonID = Console.ReadLine();
            Console.Write("Tuoi: ");
            try
            {
               Age = Convert.ToInt16(Console.ReadLine()); 
            }
            catch
            {
                Age = 22;
            }
        }
        public void Export()
        {
            Console.WriteLine("{0} - {1} Tuoi - ID: {2}", FullName, Age, PersonID);
        }
        public int GetYearOfBirth(int Age)
        {
            int YearOfBirth = 2023 - Age;
            return YearOfBirth;
        }
    }
}
