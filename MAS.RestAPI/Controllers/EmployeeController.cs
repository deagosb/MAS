using MAS.Business;
using MAS.RestAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MAS.RestAPI.Controllers
{
    /// <summary>
    /// Defines the <see cref="EmployeeController" />.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Defines the _employeeFactory.
        /// </summary>
        private readonly EmployeeFactory _employeeFactory;

        /// <summary>
        /// Defines the _employee.
        /// </summary>
        private readonly Employee _employee;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="employeeFactory">The employeeFactory<see cref="EmployeeFactory"/>.</param>
        /// <param name="employee">The employee<see cref="Employee"/>.</param>
        public EmployeeController(
            EmployeeFactory employeeFactory,
            Employee employee)
        {
            _employeeFactory = employeeFactory;
            _employee = employee;
        }

        /// <summary>
        /// The GetMovies.
        /// </summary>
        /// <param name="userSelection">The userSelection<see cref="string"/>.</param>
        /// <returns>The <see cref="double"/>.</returns>
        [HttpGet("list/{userSelection}")]
        public double GetMovies(string userSelection)
        {
            return _employeeFactory.GetEmployeeService(userSelection).CalculateAnnualSalary();
        }

        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{EmployeeDto}"/>.</returns>
        [HttpGet]
        public IEnumerable<EmployeeDto> GetAll()
        {
            return _employee.GetAll();
        }

        /// <summary>
        /// The GetById.
        /// </summary>
        /// <param name="employeeId">The employeeId<see cref="int"/>.</param>
        /// <returns>The <see cref="EmployeeDto"/>.</returns>
        [HttpGet("{employeeId}")]
        public EmployeeDto GetById(int employeeId)
        {
            return _employee.GetById(employeeId);
        }
    }
}
