namespace WebMVC.Models
{
    public class Person 
    {
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public dynamic str { get; internal set; }
    }
}