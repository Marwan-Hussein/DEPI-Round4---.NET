using Day05.Data.DbContexts;
using Day05.Models;
using Microsoft.EntityFrameworkCore;


namespace Day05.Business_Logic
{
    public class StudentBL : IGetable<Student>
    {
        public CollegeSystemDbContext Context { get; set; } = new CollegeSystemDbContext();

        List<Student> IGetable<Student>.GetAll()
        {
            return Context.Students
                .Include(s => s.Department)
                .Include(s => s.StuCrsResult)
                .ToList();
        }

        Student IGetable<Student>.GetById(int id)
        {
            return Context.Students
                .Include(s => s.Department)
                .Include(s => s.StuCrsResult)
                .FirstOrDefault(s => s.Id == id);
        }

        public void Add(Student student)
        {
            Context.Students.Add(student);
            Context.SaveChanges();
        }

        public void Edit(Student student)
        {
            Context.Students.Update(student);
            Context.SaveChanges();
        }

        public void Delete(Student student)
        {
            Context.Students.Remove(student);
            Context.SaveChanges();  
        }
    }
}
