using System;

namespace MAS.Domain
{
    /// <summary>
    /// Defines the <see cref="Employee" />.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public Int64 Id { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ContractTypeName.
        /// </summary>
        public string ContractTypeName { get; set; }

        /// <summary>
        /// Gets or sets the RoleId.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the RoleName.
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the RoleDescription.
        /// </summary>
        public string RoleDescription { get; set; }

        /// <summary>
        /// Gets or sets the HourlySalary.
        /// </summary>
        public double HourlySalary { get; set; }

        /// <summary>
        /// Gets or sets the MonthlySalary.
        /// </summary>
        public double MonthlySalary { get; set; }
    }
}
