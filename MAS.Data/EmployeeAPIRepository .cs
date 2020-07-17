using MAS.Domain;
using RestClient.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAS.Data
{
    public class EmployeeAPIRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return GetEmployeeList();
        }

        public Employee GetById(int EmployeeID)
        {
            IEnumerable<Employee> employees = GetEmployeeList();

            return employees.Where(x => x.Id == EmployeeID)
                .FirstOrDefault();
        }

        private IEnumerable<Employee> GetEmployeeList()
        {
            Client client = new Client(new Uri("http://masglobaltestapi.azurewebsites.net/api/Employees"));
            Task<RestClient.Net.Abstractions.Response<List<Employee>>> response = client.GetAsync<List<Employee>>();
            return response.Result.Body;
        }
    }
}
