using MediatR_CQRS_Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatR_CQRS_Demo.Data
{
    public interface IDataAccess
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> AddEmployee(string fname, string lname);
    }
}
