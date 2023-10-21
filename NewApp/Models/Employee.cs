// Vũ Tiến Điệp 
// 2021050192
namespace NewApp.Models
{
    public class Employee:Person
    {
        public int Salary{ get; set; }
        public void Import()
        {
            base.Import();
            Console.Write("Muc luong: ");
            Salary = Convert.ToInt16(Console.ReadLine());
        }
        public void Export()
        {
            base.Export();
            Console.Write(" - Luong duoc nhan: {0} USD", Salary);
        }
    }
}