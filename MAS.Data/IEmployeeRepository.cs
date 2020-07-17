using MAS.Domain;
using System.Collections.Generic;

namespace MAS.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int employeeId);
        //void Insert(Employee employee);
        //void Update(Employee employee);
        //void Delete(int employeeId);
        //void Save();
    }
}
