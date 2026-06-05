using Day05.Models;
using System.ComponentModel.DataAnnotations;

namespace Day05.ViewModels
{
    public class StudentDepVM
    {
        // Student
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(80, ErrorMessage = "Name must be at most 80 characters")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Age is required")]
        [Range(16, 60, ErrorMessage = "Age must be between 16 and 60")]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        
        public Department? Department { get; set; }

        // Department
        public List<Department>? Departments { get; set; }
    }
}
