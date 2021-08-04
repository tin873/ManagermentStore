using ManagermentStore.Core;
using ManagermentStore.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ManagermentStore.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class StoreController : ManagermentStoreBaseController<Store>
    {
        IStoreService _storeService;
        public StoreController(IBaseService<Store> baseService, IStoreService storeService) : base(baseService)
        {
            _storeService = storeService;
        }
    }
}
