using System;

namespace MAS.Business.Services
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
        /// <param name="contractTypeName">The contractTypeName<see cref="string"/>.</param>
        /// <returns>The <see cref="IEmployeeSalaryService"/>.</returns>
        public IEmployeeSalaryService GetEmployeeService(string contractTypeName)
        {

            if (contractTypeName == "HourlySalaryEmployee")
            {
                return (IEmployeeSalaryService)_serviceProvider.GetService(typeof(EmployeeSalaryHourlyService));
            }

            return (IEmployeeSalaryService)_serviceProvider.GetService(typeof(EmployeeSalaryMonthlyService));
        }
    }
}
