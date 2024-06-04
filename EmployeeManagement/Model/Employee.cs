using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EmployeeManagement.Model
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        [JsonIgnore]
        public int EducationId { get; set; }
        public Education Education { get; set; }
        public int Experience { get; set; }
        public long Salary { get; set; }
    }
}