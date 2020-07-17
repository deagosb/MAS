using MAS.Domain;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace MAS.Data
{
    public class EmployeeAPIRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return GetEmployeeList();
        }

        public Employee GetById(int employeeId)
        {
            IEnumerable<Employee> employees = GetEmployeeList();

            return employees.Where(x => x.Id == employeeId)
                .FirstOrDefault();
        }

        private IEnumerable<Employee> GetEmployeeList()
        {
            // Set Client             
            RestClient client = new RestClient("http://masglobaltestapi.azurewebsites.net/api/Employees");
            RestRequest request = new RestRequest(Method.GET);

            // Execute 
            IRestResponse response = client.Execute(request);

            // Deserialize json
            return JsonConvert.DeserializeObject<List<Employee>>(response.Content);
        }
    }
}
