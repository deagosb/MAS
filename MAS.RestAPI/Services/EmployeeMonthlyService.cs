namespace MAS.RestAPI.Services
{
    /// <summary>
    /// Defines the <see cref="EmployeeMonthlyService" />.
    /// </summary>
    public class EmployeeMonthlyService : IEmployeeService
    {
        /// <summary>
        /// The ShowMovies.
        /// </summary>
        /// <returns>The <see cref="string[]"/>.</returns>
        public string[] ShowList()
        {
            return new string[]
            {
            "Value A",
            "Value B",
            "Value C"
            };
        }
    }
}
