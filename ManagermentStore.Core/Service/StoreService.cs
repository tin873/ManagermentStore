using ManagermentStore.Core.Interface;

namespace ManagermentStore.Core
{
    public class StoreService : BaseService<Store>, IStoreService
    {
        private readonly IBaseRepository<Store> _storeRepository;
        private ServiceResult _serviceResult;
        public StoreService(IBaseRepository<Store> baseRepository) : base(baseRepository)
        {
            _storeRepository = baseRepository;
            _serviceResult = new ServiceResult();
        }

    }
}
