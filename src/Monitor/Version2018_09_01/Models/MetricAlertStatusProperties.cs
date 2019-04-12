// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An alert status properties.
    /// </summary>
    public partial class MetricAlertStatusProperties
    {
        /// <summary>
        /// Initializes a new instance of the MetricAlertStatusProperties
        /// class.
        /// </summary>
        public MetricAlertStatusProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricAlertStatusProperties
        /// class.
        /// </summary>
        /// <param name="dimensions">An object describing the type of the
        /// dimensions.</param>
        /// <param name="status">status value</param>
        /// <param name="timestamp">UTC time when the status was
        /// checked.</param>
        public MetricAlertStatusProperties(IDictionary<string, string> dimensions = default(IDictionary<string, string>), string status = default(string), System.DateTime? timestamp = default(System.DateTime?))
        {
            Dimensions = dimensions;
            Status = status;
            Timestamp = timestamp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an object describing the type of the dimensions.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IDictionary<string, string> Dimensions { get; set; }

        /// <summary>
        /// Gets or sets status value
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets UTC time when the status was checked.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

    }
}
