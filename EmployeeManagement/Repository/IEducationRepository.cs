using EmployeeManagement.Model;

namespace EmployeeManagement.Repository
{
    public interface IEducationRepository
    {
        public IEnumerable<Education> GetEducationList();

        public Education GetEducation(int id);
    }
}
