using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Backend_WebAPI.Models
{
    [Index("Email", IsUnique = true)]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required, Phone]
        public string PhoneNumber { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public DateOnly StartDate { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set;}
    }
}
