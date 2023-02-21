using FuelStation.Blazor.Web.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.Blazor.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get()
        {
            var employee = _employeeRepo.GetAll();
            return employee.Select(employee => new EmployeeListDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SalaryPerMonth = employee.SalaryPerMonth

            });

        }
        [HttpGet("{Id}")]

        public async Task<EmployeeEditDto> GetById(int id)
        {
            var employee=_employeeRepo.GetById(id);
            return new EmployeeEditDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SalaryPerMonth = employee.SalaryPerMonth

            };
        }
        [HttpPost]
        public async Task Post(EmployeeEditDto employee)
        {
            var newEmployee = new Employee(employee.Name, employee.Surname,
                
           employee.HireDateStart,employee.HireDateEnd,employee.SalaryPerMonth, employee.EmployeeType);

            newEmployee.Transactions = new();
            _employeeRepo.Add(newEmployee);

        }
        public async Task Put(EmployeeEditDto employee)
        {
            var itemToUpdate=_employeeRepo.GetById(employee.Id);
            itemToUpdate.Id=employee.Id;
            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            itemToUpdate.HireDateStart = employee.HireDateStart;
            itemToUpdate.HireDateEnd = employee.HireDateEnd;
            itemToUpdate.SalaryPerMonth = employee.SalaryPerMonth;

            _employeeRepo.Update(employee.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                _employeeRepo.Delete(id);
                return Ok();

            }
            catch (DbUpdateException ex)
            {
                return BadRequest("This Employee cannot be deleted");
            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest($"Todo with id {id} not found!");

            }
        }

    }

}
