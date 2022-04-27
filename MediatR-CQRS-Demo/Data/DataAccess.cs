using MediatR_CQRS_Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatR_CQRS_Demo.Data
{
    public class DataAccess : IDataAccess
    {
        private List<Employee> employees = new List<Employee>();
        public DataAccess()
        {
            employees.Add(new Employee() { FirstName="karthik",LastName="uthira"});
            employees.Add(new Employee() { FirstName = "uthira", LastName = "kumaran" });

        }
        public async Task<Employee> AddEmployee(string fname,string lname)
        {
            Employee employee = new()
            {
                FirstName = fname,
                LastName = lname
            };
            employees.Add(employee);
            return employee;
        }

      

        public async Task<List<Employee>> GetEmployees()
        {
            return employees;
        }
    }
}
