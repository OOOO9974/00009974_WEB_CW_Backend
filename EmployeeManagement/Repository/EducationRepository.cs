using EmployeeManagement.DbContexts;
using EmployeeManagement.Enum;
using EmployeeManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repository
{
    public class EducationRepository : IEducationRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Education> _entities;

        public EducationRepository(AppDbContext context)
        {
            _context = context;
            _entities = context.Set<Education>();
        }

        public Education GetEducation(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Education> GetEducationList()
        {
            return _entities.ToArray();
        }
    }
}
