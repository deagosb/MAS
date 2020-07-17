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
        public string[] ShowMovies()
        {
            return new string[]
            {
            "Movie A",
            "Movie B",
            "Movie C"
            };
        }
    }
}
