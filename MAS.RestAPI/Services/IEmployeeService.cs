namespace MAS.RestAPI.Services
{
    /// <summary>
    /// Defines the <see cref="IEmployeeService" />.
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// The CalculateAnnualSalary.
        /// </summary>
        /// <returns>The <see cref="double"/>.</returns>
        double CalculateAnnualSalary();
    }
}
