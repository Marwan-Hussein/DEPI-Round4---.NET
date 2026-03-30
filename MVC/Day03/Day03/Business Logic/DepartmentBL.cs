using Day03.Bussiness_Logic;
using Day03.Data.DbContexts;
using Day03.Models;
using Microsoft.EntityFrameworkCore;


namespace Day03.Business_Logic
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
