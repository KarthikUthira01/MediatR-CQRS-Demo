using MediatR;
using MediatR_CQRS_Demo.Models;
using System.Collections.Generic;

namespace MediatR_CQRS_Demo.Queries
{
    public record GetEmployeeListQuery:IRequest<List<Employee>>;
    
}
