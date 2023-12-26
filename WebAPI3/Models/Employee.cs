namespace WebAPI3.Models
{
    public class Employee
    {   
        //create a employee class with properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? City { get; set; }
        public string? AddDate { get; set; }

    }
}
