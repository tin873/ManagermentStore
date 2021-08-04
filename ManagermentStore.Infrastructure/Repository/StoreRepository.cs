using ManagermentStore.Core;

namespace ManagermentStore.Infrastructure
{
    public class StoreRepository : BaseRepository<Store>, IStoreRepository
    {
        public StoreRepository(IUnitOfWork unitOfWork, ManagermentStoreContext dbContext) : base(dbContext, unitOfWork) { }
    }
}
