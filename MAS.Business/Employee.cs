using DrPennybags.EasyMapper;
using MAS.Data;
using System.Collections.Generic;

namespace MAS.Business
{
    public class Employee
    {
        private readonly IEmployeeRepository _employeeRepository;

        public Employee()
        {
            _employeeRepository = new EmployeeAPIRepository();
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            IEnumerable<Domain.Employee> employees = _employeeRepository.GetAll();

            // TODO: Implement ITranforms 
            return employees.To<IEnumerable<EmployeeDto>>(); ;
        }

        public EmployeeDto GetById(int employeeId)
        {
            Domain.Employee employee = _employeeRepository.GetById(employeeId);

            // TODO: Implement ITranforms 
            return employee.To<EmployeeDto>();
        }
    }
}
