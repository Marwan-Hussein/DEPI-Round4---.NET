using Day04.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Day04.Helpers
{
    public static class Helper
    {
        static readonly CollegeSystemDbContext _db = new();
        
        //public static int Count<TEntity>() where TEntity : class
        //    => _db.Set<TEntity>().Count();

    }
}
