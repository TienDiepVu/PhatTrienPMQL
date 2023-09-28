namespace NewApp.Models
{
    public class Employee
    {
        public string NameOfEmp{ get; set;}
        public int AgeOfEmp{ get; set;}
        public int EmpID{ get; set;}
        public int Salary{ get; set;}

        public void ImportData()
        {
            Console.WriteLine("Ho va ten: ");
            NameOfEmp = Console.ReadLine();
            Console.WriteLine("Tuoi: ");
            AgeOfEmp = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ma Nhan Vien: ");
            EmpID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Muc luong nhan: ");
            Salary = Convert.ToInt16(Console.ReadLine());            
        }
        public void ExportData()
        {
            Console.WriteLine("Thong tin nhan vien: \n Ong/ba : {0} \n Tuoi : {1} \n Ma Nhan Vien: {2} \n Muc luong hien tai: {3} VND", NameOfEmp , AgeOfEmp , EmpID , Salary);
        }
    }
}