// Vũ Tiến Điệp 
// 2021050192
namespace NewApp.Models
{
    public class Fruit
    {
        public string TypeFruit { get; set; }
        public double Weight { get; set; }
        public void ImportFruit()
        {
            Console.WriteLine("Loai trai cay: ");
            TypeFruit = Console.ReadLine();
            Console.WriteLine("Trong luong: ");
            Weight = Convert.ToInt16(Console.ReadLine());
        }
        public void ExportFruit()
        {
            Console.WriteLine("Trai {0} nang {}kg", TypeFruit , Weight);
        }
    }
}