using Backend_WebAPI.DTOs;
using Backend_WebAPI.Repositories.Employee.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _repo;
        public EmployeeController(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("Add")]
        public IActionResult AddEmployee(EmployeeDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            _repo.Create(dto);
            return Ok(dto);
        }

        [HttpGet("GetAll")]
        public List<Models.Employee> GetAll()
        {
            return _repo.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var find = _repo.GetById(id);
            if (find == null)
            {
                return NotFound();
            }
            return Ok(find);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _repo.Delete(id);
            if (!deleted)
                return NotFound();

            return Ok();
        }


        [HttpPut("Update/{id}")]
        public IActionResult Update(int id, EmployeeDTO dto)
        {
            if (dto == null)
                return BadRequest();

            var success = _repo.Update(dto, id);
            if (!success)
                return NotFound();

            return Ok();
        }

    }
}
