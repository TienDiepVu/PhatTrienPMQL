namespace WebMVC.Models
{
    public class ExcuteSalary
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public double Factor { get; set; }
        public double Allowance { get; set; }

        public double totalSalary()
        {
            return Salary * Factor + Allowance;
        }
    }
}