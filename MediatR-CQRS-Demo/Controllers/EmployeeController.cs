using MediatR;
using MediatR_CQRS_Demo.Commands;
using MediatR_CQRS_Demo.Models;
using MediatR_CQRS_Demo.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatR_CQRS_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;
        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;   
        }

        [HttpGet]
        public async Task<List<Employee>> GetEmployees()
        {
            return await mediator.Send(new GetEmployeeListQuery());

        }
       [HttpPost]
       public async Task<Employee> AddEmployee(Employee employee)
        {
            return await mediator.Send(new AddEmployeeCommand(employee.FirstName,employee.LastName));   

        }
    }
}
