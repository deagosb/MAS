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
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="employeeFactory">The employeeFactory<see cref="EmployeeFactory"/>.</param>
        public EmployeeController(EmployeeFactory employeeFactory)
        {
            _employeeFactory = employeeFactory;
        }

        /// <summary>
        /// The GetMovies.
        /// </summary>
        /// <param name="userSelection">The userSelection<see cref="string"/>.</param>
        /// <returns>The <see cref="IEnumerable{string}"/>.</returns>
        [HttpGet("list/{userSelection}")]
        public IEnumerable<string> GetMovies(string userSelection)
        {
            return _employeeFactory.GetEmployeeService(userSelection).ShowList();
        }
    }
}
