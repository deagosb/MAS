using DrPennybags.EasyMapper;
using MAS.Data;
using System.Collections.Generic;

namespace MAS.Business.Services
{
    /// <summary>
    /// Defines the <see cref="EmployeeService" />.
    /// </summary>
    public class EmployeeService
    {
        /// <summary>
        /// Defines the _employeeRepository.
        /// </summary>
        private readonly IEmployeeRepository _employeeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeService"/> class.
        /// </summary>
        public EmployeeService()
        {
            _employeeRepository = new EmployeeAPIRepository();
        }

        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{EmployeeDto}"/>.</returns>
        public IEnumerable<EmployeeDto> GetAll()
        {
            IEnumerable<Domain.Employee> employees = _employeeRepository.GetAll();

            // TODO: Implement ITranforms 
            return employees.To<List<EmployeeDto>>(); ;
        }

        /// <summary>
        /// The GetById.
        /// </summary>
        /// <param name="employeeId">The employeeId<see cref="int"/>.</param>
        /// <returns>The <see cref="EmployeeDto"/>.</returns>
        public EmployeeDto GetById(int employeeId)
        {
            Domain.Employee employee = _employeeRepository.GetById(employeeId);

            // TODO: Implement ITranforms 
            return employee.To<EmployeeDto>();
        }
    }
}
