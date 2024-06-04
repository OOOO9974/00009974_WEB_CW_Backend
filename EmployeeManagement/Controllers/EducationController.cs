using EmployeeManagement.Model;
using EmployeeManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EducationController : Controller
    {

        private readonly IEducationRepository educationRepository;

        public EducationController(IEducationRepository educationRepository)
        {
            this.educationRepository = educationRepository;
        }

        [HttpGet("education", Name = "GetEducationList")]
        public IEnumerable<Education> GetString()
        {
            return educationRepository.GetEducationList();
        }
    }
}
