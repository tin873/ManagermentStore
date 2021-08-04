using System.Threading.Tasks;

namespace ManagermentStore.Infrastructure
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}
