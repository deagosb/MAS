namespace MAS.Business.Services
{
    /// <summary>
    /// Defines the <see cref="IEmployeeSalaryService" />.
    /// </summary>
    public interface IEmployeeSalaryService
    {
        /// <summary>
        /// The CalculateAnnualSalary.
        /// </summary>
        /// <param name="hourlySalary">The hourlySalary<see cref="double"/>.</param>
        /// <param name="monthlySalary">The monthlySalary<see cref="double"/>.</param>
        /// <returns>The <see cref="double"/>.</returns>
        double CalculateAnnualSalary(double hourlySalary, double monthlySalary);
    }
}
