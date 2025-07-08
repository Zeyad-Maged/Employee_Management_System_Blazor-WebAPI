using System.ComponentModel.DataAnnotations;

namespace Company_Employees.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        [Range(5000, double.MaxValue, ErrorMessage = "Salary must be at least 5000.")]
        public decimal Salary { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
