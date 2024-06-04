using EmployeeManagement.Enum;
using EmployeeManagement.Model;
using EmployeeManagement.Model.RequestDto;
using EmployeeManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet("employees", Name = "GetEmployeeList")]
        public IEnumerable<Employee> GetEmployeeList()
        {
            return employeeRepository.GetAllEmployeeList();
        }

        [HttpPost("employees", Name = "AddEmployee")]
        public void AddEmployee(EmployeeRequest request)
        {
            employeeRepository.AddEmployee(request);
        }

        [HttpPut("employees/{id}", Name = "UpdateEmployee")]
        public void UpdateEmployee(Employee employee, int id)
        {
            employeeRepository.UpdateEmployee(employee, id);
        }

        [HttpDelete("employees/{id}", Name = "DeleteEmployee")]
        public void DeleteEmployee(int id)
        {
            employeeRepository.DeleteEmployee(id);
        }
    }
}
