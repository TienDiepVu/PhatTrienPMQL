// Vũ Tiến Điệp 
// 2021050192
namespace NewApp.Models
{
    public class SinhVien
    {
        public string HoTen { get; set;}
        public string DiaChi { get; set;}
        public int Tuoi { get; set;}
        public string SoDienThoai { get; set;}

        public void NhapThongTinSV()
        {
            Console.Write("Ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Tuoi: ");
            Tuoi = Convert.ToInt16(Console.ReadLine());
            Console.Write("So dien thoai: ");
            SoDienThoai = Console.ReadLine();
            
        }

        public void HienThiThongTinSV() 
        {
            Console.WriteLine("Ho va ten: " + HoTen + "\n Dia chi: " + DiaChi + "\n Tuoi: " + Tuoi + "\n So dien thoai: " + SoDienThoai );
        }
        
    }
}