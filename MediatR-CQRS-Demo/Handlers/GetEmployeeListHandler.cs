using MediatR;
using MediatR_CQRS_Demo.Data;
using MediatR_CQRS_Demo.Models;
using MediatR_CQRS_Demo.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_CQRS_Demo.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private IDataAccess _dataAccess;
        public GetEmployeeListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;

        }
       

        public Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return  _dataAccess.GetEmployees();
        }
    }
}
