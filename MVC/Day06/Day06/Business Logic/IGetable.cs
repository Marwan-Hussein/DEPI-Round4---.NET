using Day06.Data.DbContexts;

namespace Day06.Business_Logic
{
    public interface IGetable<T>
    {
        CollegeSystemDbContext Context { set; get; }
        public List<T> GetAll();
        public T GetById(int id);
    }
}
