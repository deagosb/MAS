using MAS.Business;
using MAS.Business.Services;
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
        /// Defines the _employeeService.
        /// </summary>
        private readonly EmployeeService _employeeService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="employeeService">The employeeService<see cref="EmployeeService"/>.</param>
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{EmployeeDto}"/>.</returns>
        [HttpGet]
        public IEnumerable<EmployeeDto> GetAll()
        {
            return _employeeService.GetAll();
        }

        /// <summary>
        /// The GetById.
        /// </summary>
        /// <param name="employeeId">The employeeId<see cref="int"/>.</param>
        /// <returns>The <see cref="EmployeeDto"/>.</returns>
        [HttpGet("{employeeId}")]
        public EmployeeDto GetById(int employeeId)
        {
            return _employeeService.GetById(employeeId);
        }
    }
}
