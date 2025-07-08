using Backend_WebAPI.Data;
using Backend_WebAPI.DTOs;
using Backend_WebAPI.Repositories.Employee.Interface;

namespace Backend_WebAPI.Repositories.Employee.Concrete_Class
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(EmployeeDTO dto)
        {
            var obj = new Models.Employee
            {
                Address = dto.Address,
                DateOfBirth = dto.DateOfBirth,
                Department = dto.Department,
                Email = dto.Email,
                Gender = dto.Gender,
                JobTitle = dto.JobTitle,
                Name = dto.Name,
                PhoneNumber = dto.PhoneNumber,
                Salary = dto.Salary,
                StartDate = dto.StartDate,
            };
            _context.employees.Add(obj);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var delete = _context.employees.FirstOrDefault(i => i.Id == id);
            if (delete == null)
            {
                return false;
            }

            _context.employees.Remove(delete);
            _context.SaveChanges();
            return true;
        }

        public List<Models.Employee> GetAll()
        {
            return _context.employees.OrderByDescending(i => i.Id).ToList();
        }

        public Models.Employee GetById(int id)
        {
            var get = _context.employees.FirstOrDefault(i => i.Id == id);
            return get;
        }

        public bool Update(EmployeeDTO dto, int id)
        {
            var update = _context.employees.FirstOrDefault(i => i.Id == id);
            if (update == null)
            {
                return false;
            }

            update.StartDate = dto.StartDate;
            update.DateOfBirth = dto.DateOfBirth;
            update.Department = dto.Department;
            update.Email = dto.Email;
            update.Gender = dto.Gender;
            update.JobTitle = dto.JobTitle;
            update.Name = dto.Name;
            update.PhoneNumber = dto.PhoneNumber;
            update.Salary = dto.Salary;
            update.Address = dto.Address;

            _context.employees.Update(update);
            _context.SaveChanges();
            return true;
        }
    }
}
