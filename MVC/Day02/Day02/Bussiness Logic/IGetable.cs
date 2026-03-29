using Day02.Data.DbContexts;

namespace Day02.Bussiness_Logic
{
    public interface IGetable<T>
    {
        CollegeSystemDbContext Context { set; get; }
        public List<T> GetAll();
        public T GetById(int id);
    }
}
