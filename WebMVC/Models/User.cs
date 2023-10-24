namespace WebMVC.Models
{
    public class User
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Factor { get; set; }
        public double Allowance { get; set; }

        public double CalculateSalary()
        {
            return Salary * Factor + Allowance;
        }
    }
}