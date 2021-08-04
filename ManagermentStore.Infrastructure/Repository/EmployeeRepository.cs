using ManagermentStore.Core;

namespace ManagermentStore.Infrastructure
{
    public class EmployeeRepository : BaseRepository<EmployeeRepository>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork unitOfWork, ManagermentStoreContext dbContext) : base(dbContext, unitOfWork) { }
    }
}
