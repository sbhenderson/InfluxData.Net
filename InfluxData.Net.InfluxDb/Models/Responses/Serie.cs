using System.Collections.Generic;

namespace InfluxData.Net.InfluxDb.Models.Responses
{
    /// <summary>
    /// Represents a time series point for db reads (fetch queries).
    /// InfluxDb by convention returns all data represented as Serie objects.
    /// </summary>
    public class Serie
    {
        public Serie()
        {
            Tags = new Dictionary<string, string>();
        }

        /// <summary>
        /// Serie name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Serie tags.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// List of serie fields.
        /// </summary>
        public string[] Columns { get; set; }

        /// <summary>
        /// Serie values.
        /// </summary>
        public object[][] Values { get; set; }
    }
}