using System.Threading.Tasks;

namespace ManagermentStore.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private ManagermentStoreContext _dbContext;

        public UnitOfWork(ManagermentStoreContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

    }
}
