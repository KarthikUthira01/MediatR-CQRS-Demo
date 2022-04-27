using MediatR;
using MediatR_CQRS_Demo.Commands;
using MediatR_CQRS_Demo.Data;
using MediatR_CQRS_Demo.Models;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_CQRS_Demo.Handlers
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, Employee>
    {
        public AddEmployeeCommandHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        private IDataAccess dataAccess;

        public Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return dataAccess.AddEmployee(request.fname,request.lname);
        }
    }
}
