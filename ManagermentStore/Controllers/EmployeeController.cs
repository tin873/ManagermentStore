using ManagermentStore.Core;
using Microsoft.AspNetCore.Mvc;

namespace ManagermentStore.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class EmployeeController : ManagermentStoreBaseController<Employee>
    {
        IEmployeeService _employeeService;
        public EmployeeController(IBaseService<Employee> baseService, IEmployeeService employeeService) : base(baseService)
        {
            _employeeService = employeeService;
        }


    }
}
