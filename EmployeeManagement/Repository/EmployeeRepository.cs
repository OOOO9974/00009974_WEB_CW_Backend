using EmployeeManagement.DbContexts;
using EmployeeManagement.Enum;
using EmployeeManagement.Model;
using EmployeeManagement.Model.RequestDto;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeManagement.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Employee> _entities;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
            _entities = context.Set<Employee>();
        }

        public void DeleteEmployee(int id)
        {
            _entities.Remove(GetEmployeeById(id));
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployeeList()
        {
            return _entities.Include(e => e.Education).ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateEmployee(Employee request, int id)
        {
            request.Id = id;
            _entities.Update(request);
            _context.SaveChanges();
        }

        public void AddEmployee(EmployeeRequest request)
        {
            Employee employee = new Employee
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                BirthDate = request.BirthDate,
                Gender = request.Gender,
                Company = request.Company,
                Salary = request.Salary,
                Experience = request.Experience,
                EducationId = request.Education.Id
            };

            _entities.Add(employee);
            _context.SaveChanges();
        }
    }
}
