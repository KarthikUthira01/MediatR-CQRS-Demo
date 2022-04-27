using MediatR;
using MediatR_CQRS_Demo.Models;

namespace MediatR_CQRS_Demo.Queries
{
    public record GetEmployeeByIdQuery(int id):IRequest<Employee>;
    
}
