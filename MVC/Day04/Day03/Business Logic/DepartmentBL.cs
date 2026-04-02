using Day04.Business_Logic;
using Day04.Data.DbContexts;
using Day04.Models;
using Microsoft.EntityFrameworkCore;


namespace Day04.Business_Logic
{
    public class DepartmentBL : IGetable<Department>
    {
        public CollegeSystemDbContext Context { get; set; } = new CollegeSystemDbContext();

        List<Department> IGetable<Department>.GetAll()
        {
            return Context.Departments
                .Include(D => D.Teachers)
                .Include(D => D.Courses)
                .Include(D => D.Students)
                .ToList();
        }

        Department IGetable<Department>.GetById(int id)
        {
            return Context.Departments
                .Include(D => D.Teachers)
                .Include(D => D.Courses)
                .Include(D => D.Students)
                .FirstOrDefault(s => s.Id == id);
        }

        public bool Contains(string name)
            => Context.Departments
                .Any(d => d.Name == name);

        public KeyValuePair<int, List<string>> Filter(Department dept, Func<Student, bool> predicate)
        {
            List<string> studentsNames= new List<string>();
            foreach (Student student in dept.Students)
                if (predicate(student))
                    studentsNames.Add(student.Name);
            return KeyValuePair.Create(dept.Students.Count(), studentsNames);
        }

        public void Add(Department department)
        {
            Context.Departments.Add(department);
            Context.SaveChanges();
        }

        //public void Delete(int id) 
        //{
        //    var dept = Context.Departments.Select(d => d.Id).FirstOrDefault();
        //    Context.Departments.Remove(dept);
        //}
        
    }
}
