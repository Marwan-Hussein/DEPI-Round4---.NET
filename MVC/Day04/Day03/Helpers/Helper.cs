using Day04.Data.DbContexts;
using Day04.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
namespace Day04.Helpers
{
    public class Helper
    {
        CollegeSystemDbContext context = new CollegeSystemDbContext();
        public static IEnumerable<Element> Filter<_Container, Element>(_Container container, Func<Element, bool> predicate) where _Container : Container<Element>
        {
            foreach (Element element in container)
                if (predicate(element))
                    yield return element;
        }

        //public static int Count<T>(DbSet<T> tableExpressions) => return context.tableExpressions.Count();
    }
}