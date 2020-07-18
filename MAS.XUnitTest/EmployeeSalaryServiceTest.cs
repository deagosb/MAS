using MAS.Business.Services;
using Xunit;

namespace MAS.XUnitTest
{
    /// <summary>
    /// Defines the <see cref="UnitTest1" />.
    /// </summary>
    public class EmployeeSalaryServiceTest
    {
        /// <summary>
        /// Defines the _employeeSalaryHourlyService.
        /// </summary>
        private readonly EmployeeSalaryHourlyService _employeeSalaryHourlyService;

        /// <summary>
        /// Defines the _employeeSalaryMonthlyService.
        /// </summary>
        private readonly EmployeeSalaryMonthlyService _employeeSalaryMonthlyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeSalaryServiceTest"/> class.
        /// </summary>
        public EmployeeSalaryServiceTest()
        {
            _employeeSalaryHourlyService = new EmployeeSalaryHourlyService();
            _employeeSalaryMonthlyService = new EmployeeSalaryMonthlyService();
        }

        /// <summary>
        /// The Calculate_Hourly_Annual_Salary_Not_Equal.
        /// </summary>
        [Fact]
        public void Calculate_Hourly_Annual_Salary_Not_Equal()
        {
            Assert.NotEqual(0, _employeeSalaryHourlyService.CalculateAnnualSalary(60000, 80000));
        }

        /// <summary>
        /// The Calculate_Hourly_Annual_Salary_Equal.
        /// </summary>
        [Fact]
        public void Calculate_Hourly_Annual_Salary_Equal()
        {
            Assert.Equal(86400000.0, _employeeSalaryHourlyService.CalculateAnnualSalary(60000, 80000));
        }

        /// <summary>
        /// The Calculate_Monthly_Annual_Salary_Not_Equal.
        /// </summary>
        [Fact]
        public void Calculate_Monthly_Annual_Salary_Not_Equal()
        {
            Assert.NotEqual(0, _employeeSalaryMonthlyService.CalculateAnnualSalary(60000, 80000));
        }

        /// <summary>
        /// The Calculate_Monthly_Annual_Salary_Equal.
        /// </summary>
        [Fact]
        public void Calculate_Monthly_Annual_Salary_Equal()
        {
            Assert.Equal(960000.0, _employeeSalaryMonthlyService.CalculateAnnualSalary(60000, 80000));
        }
    }
}
