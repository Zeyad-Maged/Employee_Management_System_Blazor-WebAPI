using System.ComponentModel.DataAnnotations;

namespace Backend_WebAPI.DTOs
{
    public class EmployeeDTO
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

//      ------------------------------------------------------------
        [Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }

//      ------------------------------------------------------------
        [Required(ErrorMessage = "Phone Number is Required"), Phone]
        public string PhoneNumber { get; set; }

//      ------------------------------------------------------------
        [Required(ErrorMessage = "Email is Required"), EmailAddress]
        public string Email { get; set; }

//      ------------------------------------------------------------
        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

//      ------------------------------------------------------------
        [Required(ErrorMessage = "Department is Required")]
        public string Department { get; set; }

//      ------------------------------------------------------------
        [Required(ErrorMessage = "Job Title is Required")]
        public string JobTitle { get; set; }

//      ------------------------------------------------------------
        [Required(ErrorMessage = "Salary is Required")]
        public decimal Salary { get; set; }

//      ------------------------------------------------------------
        [Required(ErrorMessage = "Start Date is Required")]
        public DateOnly StartDate { get; set; }

//      ------------------------------------------------------------
        [Required(ErrorMessage = "Date of Birth is Required")]
        public DateOnly DateOfBirth { get; set; }
    }
}
