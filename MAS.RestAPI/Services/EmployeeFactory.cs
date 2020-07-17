using System;

namespace MAS.RestAPI.Services
{
    /// <summary>
    /// Defines the <see cref="EmployeeFactory" />.
    /// </summary>
    public class EmployeeFactory
    {
        /// <summary>
        /// Defines the _serviceProvider.
        /// </summary>
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeFactory"/> class.
        /// </summary>
        /// <param name="serviceProvider">The serviceProvider<see cref="IServiceProvider"/>.</param>
        public EmployeeFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// The GetEmployeeService.
        /// </summary>
        /// <param name="userSelection">The userSelection<see cref="string"/>.</param>
        /// <returns>The <see cref="IEmployeeService"/>.</returns>
        public IEmployeeService GetEmployeeService(string userSelection)
        {

            if (userSelection == "hourly")
                return (IEmployeeService)_serviceProvider.GetService(typeof(EmployeeHourlyService));

            return (IEmployeeService)_serviceProvider.GetService(typeof(EmployeeMonthlyService));
        }
    }
}
