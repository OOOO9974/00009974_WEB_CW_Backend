namespace EmployeeManagement.Model.RequestDto
{
    public class EmployeeRequest
    {
        public long Id { get; set; } = getSize();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public Education Education { get; set; }
        public int Experience { get; set; }
        public long Salary { get; set; }

        private static long count = 0;

        private static long getSize()
        {
            return ++count;
        }
    }
}
