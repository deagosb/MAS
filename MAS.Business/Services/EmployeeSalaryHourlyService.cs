namespace MAS.Business.Services
{
    /// <summary>
    /// Defines the <see cref="EmployeeSalaryHourlyService" />.
    /// </summary>
    public class EmployeeSalaryHourlyService : IEmployeeSalaryService
    {
        /// <summary>
        /// The CalculateAnnualSalary.
        /// </summary>
        /// <param name="hourlySalary">The hourlySalary<see cref="double"/>.</param>
        /// <param name="monthlySalary">The monthlySalary<see cref="double"/>.</param>
        /// <returns>The <see cref="double"/>.</returns>
        public double CalculateAnnualSalary(double hourlySalary, double monthlySalary)
        {
            return 120 * hourlySalary * 12;
        }
    }
}
