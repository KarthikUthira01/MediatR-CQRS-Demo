using MediatR;
using MediatR_CQRS_Demo.Models;

namespace MediatR_CQRS_Demo.Commands
{
    public record AddEmployeeCommand(string fname,string lname):IRequest<Employee>;
   
}
