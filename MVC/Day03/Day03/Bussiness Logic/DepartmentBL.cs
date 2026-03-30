using Day02.Data.DbContexts;
using Day02.Models;
using Microsoft.EntityFrameworkCore;


namespace Day02.Bussiness_Logic
{
    public class DepartmentBL : IGetable<Department>
    {
        public CollegeSystemDbContext Context { get; set; } = new CollegeSystemDbContext();

        List<Department> IGetable<Department>.GetAll()
        {
            return Context.Departments
                .ToList();
        }

        Department IGetable<Department>.GetById(int id)
        {
            return Context.Departments
                .FirstOrDefault(s => s.Id == id);
        }
    }
}
