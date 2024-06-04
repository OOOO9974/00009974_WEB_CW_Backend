using EmployeeManagement.Model;
using EmployeeManagement.Model.RequestDto;

namespace EmployeeManagement.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployeeList();
        Employee GetEmployeeById(int id);
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee employee, int id);
        void AddEmployee(EmployeeRequest request);
    }
}
