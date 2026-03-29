using Day02.Data.DbContexts;
using Day02.Models;
using Microsoft.EntityFrameworkCore;


namespace Day02.Bussiness_Logic
{
    public class StudentBL : IGetable<Student>
    {
        public CollegeSystemDbContext Context { get; set; } = new CollegeSystemDbContext();

        List<Student> IGetable<Student>.GetAll()
        {
            return Context.Students.Include(s => s.Department).Include(s => s.StuCrsResult).ToList();
        }

        Student IGetable<Student>.GetById(int id)
        {
            return Context.Students.FirstOrDefault(s => s.Id == id);
        }
    }
}
