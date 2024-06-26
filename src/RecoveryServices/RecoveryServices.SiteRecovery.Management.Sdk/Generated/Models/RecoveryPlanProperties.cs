// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Recovery plan properties.
    /// </summary>
    public partial class RecoveryPlanProperties
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanProperties class.
        /// </summary>
        public RecoveryPlanProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlanProperties class.
        /// </summary>

        /// <param name="friendlyName">The friendly name.
        /// </param>

        /// <param name="primaryFabricId">The primary fabric Id.
        /// </param>

        /// <param name="primaryFabricFriendlyName">The primary fabric friendly name.
        /// </param>

        /// <param name="recoveryFabricId">The recovery fabric Id.
        /// </param>

        /// <param name="recoveryFabricFriendlyName">The recovery fabric friendly name.
        /// </param>

        /// <param name="failoverDeploymentModel">The failover deployment model.
        /// </param>

        /// <param name="replicationProviders">The list of replication providers.
        /// </param>

        /// <param name="allowedOperations">The list of allowed operations.
        /// </param>

        /// <param name="lastPlannedFailoverTime">The start time of the last planned failover.
        /// </param>

        /// <param name="lastUnplannedFailoverTime">The start time of the last unplanned failover.
        /// </param>

        /// <param name="lastTestFailoverTime">The start time of the last test failover.
        /// </param>

        /// <param name="currentScenario">The current scenario details.
        /// </param>

        /// <param name="currentScenarioStatus">The recovery plan status.
        /// </param>

        /// <param name="currentScenarioStatusDescription">The recovery plan status description.
        /// </param>

        /// <param name="groups">The recovery plan groups.
        /// </param>

        /// <param name="providerSpecificDetails">The provider id and provider specific details.
        /// </param>
        public RecoveryPlanProperties(string friendlyName = default(string), string primaryFabricId = default(string), string primaryFabricFriendlyName = default(string), string recoveryFabricId = default(string), string recoveryFabricFriendlyName = default(string), string failoverDeploymentModel = default(string), System.Collections.Generic.IList<string> replicationProviders = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> allowedOperations = default(System.Collections.Generic.IList<string>), System.DateTime? lastPlannedFailoverTime = default(System.DateTime?), System.DateTime? lastUnplannedFailoverTime = default(System.DateTime?), System.DateTime? lastTestFailoverTime = default(System.DateTime?), CurrentScenarioDetails currentScenario = default(CurrentScenarioDetails), string currentScenarioStatus = default(string), string currentScenarioStatusDescription = default(string), System.Collections.Generic.IList<RecoveryPlanGroup> groups = default(System.Collections.Generic.IList<RecoveryPlanGroup>), System.Collections.Generic.IList<RecoveryPlanProviderSpecificDetails> providerSpecificDetails = default(System.Collections.Generic.IList<RecoveryPlanProviderSpecificDetails>))

        {
            this.FriendlyName = friendlyName;
            this.PrimaryFabricId = primaryFabricId;
            this.PrimaryFabricFriendlyName = primaryFabricFriendlyName;
            this.RecoveryFabricId = recoveryFabricId;
            this.RecoveryFabricFriendlyName = recoveryFabricFriendlyName;
            this.FailoverDeploymentModel = failoverDeploymentModel;
            this.ReplicationProviders = replicationProviders;
            this.AllowedOperations = allowedOperations;
            this.LastPlannedFailoverTime = lastPlannedFailoverTime;
            this.LastUnplannedFailoverTime = lastUnplannedFailoverTime;
            this.LastTestFailoverTime = lastTestFailoverTime;
            this.CurrentScenario = currentScenario;
            this.CurrentScenarioStatus = currentScenarioStatus;
            this.CurrentScenarioStatusDescription = currentScenarioStatusDescription;
            this.Groups = groups;
            this.ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the friendly name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName {get; set; }

        /// <summary>
        /// Gets or sets the primary fabric Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primaryFabricId")]
        public string PrimaryFabricId {get; set; }

        /// <summary>
        /// Gets or sets the primary fabric friendly name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primaryFabricFriendlyName")]
        public string PrimaryFabricFriendlyName {get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryFabricId")]
        public string RecoveryFabricId {get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric friendly name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryFabricFriendlyName")]
        public string RecoveryFabricFriendlyName {get; set; }

        /// <summary>
        /// Gets or sets the failover deployment model.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "failoverDeploymentModel")]
        public string FailoverDeploymentModel {get; set; }

        /// <summary>
        /// Gets or sets the list of replication providers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "replicationProviders")]
        public System.Collections.Generic.IList<string> ReplicationProviders {get; set; }

        /// <summary>
        /// Gets or sets the list of allowed operations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allowedOperations")]
        public System.Collections.Generic.IList<string> AllowedOperations {get; set; }

        /// <summary>
        /// Gets or sets the start time of the last planned failover.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastPlannedFailoverTime")]
        public System.DateTime? LastPlannedFailoverTime {get; set; }

        /// <summary>
        /// Gets or sets the start time of the last unplanned failover.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastUnplannedFailoverTime")]
        public System.DateTime? LastUnplannedFailoverTime {get; set; }

        /// <summary>
        /// Gets or sets the start time of the last test failover.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastTestFailoverTime")]
        public System.DateTime? LastTestFailoverTime {get; set; }

        /// <summary>
        /// Gets or sets the current scenario details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentScenario")]
        public CurrentScenarioDetails CurrentScenario {get; set; }

        /// <summary>
        /// Gets or sets the recovery plan status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentScenarioStatus")]
        public string CurrentScenarioStatus {get; set; }

        /// <summary>
        /// Gets or sets the recovery plan status description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentScenarioStatusDescription")]
        public string CurrentScenarioStatusDescription {get; set; }

        /// <summary>
        /// Gets or sets the recovery plan groups.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "groups")]
        public System.Collections.Generic.IList<RecoveryPlanGroup> Groups {get; set; }

        /// <summary>
        /// Gets or sets the provider id and provider specific details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "providerSpecificDetails")]
        public System.Collections.Generic.IList<RecoveryPlanProviderSpecificDetails> ProviderSpecificDetails {get; set; }
    }
}