// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Common Data Service for Apps entity dataset properties.
    /// </summary>
    public partial class CommonDataServiceForAppsEntityDatasetTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the CommonDataServiceForAppsEntityDatasetTypeProperties class.
        /// </summary>
        public CommonDataServiceForAppsEntityDatasetTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CommonDataServiceForAppsEntityDatasetTypeProperties class.
        /// </summary>

        /// <param name="entityName">The logical name of the entity. Type: string (or Expression with resultType
        /// string).
        /// </param>
        public CommonDataServiceForAppsEntityDatasetTypeProperties(object entityName = default(object))

        {
            this.EntityName = entityName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the logical name of the entity. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "entityName")]
        public object EntityName {get; set; }
    }
}