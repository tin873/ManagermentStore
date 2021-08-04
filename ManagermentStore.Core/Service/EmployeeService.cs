namespace ManagermentStore.Core
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        private readonly IBaseRepository<Employee> _employeeRepository;
        private ServiceResult _serviceResult;
        public EmployeeService(IBaseRepository<Employee> baseRepository) : base(baseRepository) 
        {
            _employeeRepository = baseRepository;
            _serviceResult = new ServiceResult();
        }


    }
}
