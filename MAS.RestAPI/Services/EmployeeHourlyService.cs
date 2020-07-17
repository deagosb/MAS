namespace MAS.RestAPI.Services
{
    /// <summary>
    /// Defines the <see cref="EmployeeHourlyService" />.
    /// </summary>
    public class EmployeeHourlyService : IEmployeeService
    {
        /// <summary>
        /// The ShowList.
        /// </summary>
        /// <returns>The <see cref="string[]"/>.</returns>
        public string[] ShowList()
        {
            return new string[]
            {
            "Value 1",
            "Value 2",
            "Value 3"
            };
        }
    }
}
