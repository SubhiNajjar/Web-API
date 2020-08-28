using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXAPI.Models
{
    /// <summary>
    /// Represents One Specific Perosn
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID from SQL
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// The user's First Name.
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// The user's Last Name
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        /// The user's Age
        /// </summary>
        public int Age { get; set; } = 0;
    }
}