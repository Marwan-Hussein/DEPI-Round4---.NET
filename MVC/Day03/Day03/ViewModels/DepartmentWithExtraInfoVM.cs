using Day03.Models;

namespace Day03.ViewModels
{
    public class DepartmentWithExtraInfoVM
    {
        public string DepName { get; set; }
        public int TotStudents { get; set; }

        public string State { get; set; }
        public List<Student> StudentsEx25{ get; set; }
    }
}
