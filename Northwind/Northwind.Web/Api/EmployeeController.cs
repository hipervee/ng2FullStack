using System.Web.Http;
using Northwind.Service;
using Repository.Pattern.UnitOfWork;
using Northwind.Entities.Models;
using System.Linq;

namespace Northwind.Web.Api
{
    public class EmployeeController : ApiController
    {
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        private readonly ICustomerService _customerService;

        public EmployeeController(
           IUnitOfWorkAsync unitOfWorkAsync,
           ICustomerService customerService)
        {
            _unitOfWorkAsync = unitOfWorkAsync;
            _customerService = customerService;
        }

        [HttpGet]
        [Queryable]
        public IQueryable<Customer> GetCustomer()
        {
            return _customerService.Queryable();
        }
    }
}
