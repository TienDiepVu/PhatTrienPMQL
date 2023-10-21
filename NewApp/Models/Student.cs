// Vũ Tiến Điệp 
// 2021050192
namespace NewApp.Models
{
    public class Student:Person
    {
        public string StudentID {get; set;}
        public void Import()
        {
            base.Import();
            Console.Write("Ma SV : ");
            StudentID = Console.ReadLine();
            
        }

        public void Export()
        {
            base.Export();
            Console.WriteLine(" - Ma sinh vien: {0}", StudentID);
        }
    }
}