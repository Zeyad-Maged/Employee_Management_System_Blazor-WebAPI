using Backend_WebAPI.DTOs;

namespace Backend_WebAPI.Repositories.Employee.Interface
{
    public interface IEmployeeRepo
    {
        public List<Models.Employee> GetAll();
        public Models.Employee GetById(int id);
        public void Create(EmployeeDTO dto);
        public bool Update(EmployeeDTO dto, int id);
        public bool Delete(int id);
    }
}