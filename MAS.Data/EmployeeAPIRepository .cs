using MAS.Domain;
using System.Collections.Generic;

namespace MAS.Data
{
    public class EmployeeAPIRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee>();
        }

        public Employee GetById(int EmployeeID)
        {
            return new Employee();
        }
    }
}
