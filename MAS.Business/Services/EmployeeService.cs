using DrPennybags.EasyMapper;
using MAS.Data;
using MAS.Domain;
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
        /// Defines the _employeeFactory.
        /// </summary>
        private readonly EmployeeFactory _employeeFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeService"/> class.
        /// </summary>
        /// <param name="employeeFactory">The employeeFactory<see cref="EmployeeFactory"/>.</param>
        public EmployeeService(EmployeeFactory employeeFactory)
        {
            _employeeRepository = new EmployeeAPIRepository();
            _employeeFactory = employeeFactory;
        }

        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{EmployeeDto}"/>.</returns>
        public IEnumerable<EmployeeDto> GetAll()
        {
            IEnumerable<Employee> employees = _employeeRepository.GetAll();

            List<EmployeeDto> employeeDtos = employees.To<List<EmployeeDto>>();

            foreach (EmployeeDto employeeDto in employeeDtos)
            {
                // Calculate Annual Salary
                employeeDto.AnnualSalary =
                    _employeeFactory.GetEmployeeService(employeeDto.ContractTypeName).CalculateAnnualSalary(employeeDto.HourlySalary, employeeDto.MonthlySalary);
            }

            return employeeDtos;
        }

        /// <summary>
        /// The GetById.
        /// </summary>
        /// <param name="employeeId">The employeeId<see cref="int"/>.</param>
        /// <returns>The <see cref="EmployeeDto"/>.</returns>
        public EmployeeDto GetById(int employeeId)
        {
            Employee employee = _employeeRepository.GetById(employeeId);

            EmployeeDto employeeDto = employee.To<EmployeeDto>();

            // Calculate Annual Salary
            employeeDto.AnnualSalary =
                _employeeFactory.GetEmployeeService(employeeDto.ContractTypeName).CalculateAnnualSalary(employeeDto.HourlySalary, employeeDto.MonthlySalary);

            return employeeDto;
        }
    }
}
