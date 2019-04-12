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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The number of instances that can be used during this profile.
    /// </summary>
    public partial class ScaleCapacity
    {
        /// <summary>
        /// Initializes a new instance of the ScaleCapacity class.
        /// </summary>
        public ScaleCapacity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScaleCapacity class.
        /// </summary>
        /// <param name="minimum">the minimum number of instances for the
        /// resource.</param>
        /// <param name="maximum">the maximum number of instances for the
        /// resource. The actual maximum number of instances is limited by the
        /// cores that are available in the subscription.</param>
        /// <param name="defaultProperty">the number of instances that will be
        /// set if metrics are not available for evaluation. The default is
        /// only used if the current instance count is lower than the
        /// default.</param>
        public ScaleCapacity(string minimum, string maximum, string defaultProperty)
        {
            Minimum = minimum;
            Maximum = maximum;
            DefaultProperty = defaultProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the minimum number of instances for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public string Minimum { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of instances for the resource. The
        /// actual maximum number of instances is limited by the cores that are
        /// available in the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public string Maximum { get; set; }

        /// <summary>
        /// Gets or sets the number of instances that will be set if metrics
        /// are not available for evaluation. The default is only used if the
        /// current instance count is lower than the default.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public string DefaultProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Minimum == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Minimum");
            }
            if (Maximum == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Maximum");
            }
            if (DefaultProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DefaultProperty");
            }
        }
    }
}
