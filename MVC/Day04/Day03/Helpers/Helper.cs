using System.Collections.Generic;

namespace Day04.Helpers
{
    public static class Helper
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(predicate);
            foreach (T element in source)
                if (predicate(element))
                    yield return element;
        }

        //public static int Count<T>(DbSet<T> tableExpressions) => return context.tableExpressions.Count();
    }
}
