// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Extensions;

    public partial class SynapseIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.ISynapseIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.ISynapseIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.ISynapseIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject json ? new SynapseIdentity(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject into a new instance of <see cref="SynapseIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SynapseIdentity(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)Location;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_workspaceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("workspaceName"), out var __jsonWorkspaceName) ? (string)__jsonWorkspaceName : (string)WorkspaceName;}
            {_kustoPoolName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("kustoPoolName"), out var __jsonKustoPoolName) ? (string)__jsonKustoPoolName : (string)KustoPoolName;}
            {_attachedDatabaseConfigurationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("attachedDatabaseConfigurationName"), out var __jsonAttachedDatabaseConfigurationName) ? (string)__jsonAttachedDatabaseConfigurationName : (string)AttachedDatabaseConfigurationName;}
            {_databaseName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("databaseName"), out var __jsonDatabaseName) ? (string)__jsonDatabaseName : (string)DatabaseName;}
            {_dataConnectionName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("dataConnectionName"), out var __jsonDataConnectionName) ? (string)__jsonDataConnectionName : (string)DataConnectionName;}
            {_principalAssignmentName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("principalAssignmentName"), out var __jsonPrincipalAssignmentName) ? (string)__jsonPrincipalAssignmentName : (string)PrincipalAssignmentName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SynapseIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SynapseIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._location)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._location.ToString()) : null, "location" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._workspaceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._workspaceName.ToString()) : null, "workspaceName" ,container.Add );
            AddIf( null != (((object)this._kustoPoolName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._kustoPoolName.ToString()) : null, "kustoPoolName" ,container.Add );
            AddIf( null != (((object)this._attachedDatabaseConfigurationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._attachedDatabaseConfigurationName.ToString()) : null, "attachedDatabaseConfigurationName" ,container.Add );
            AddIf( null != (((object)this._databaseName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._databaseName.ToString()) : null, "databaseName" ,container.Add );
            AddIf( null != (((object)this._dataConnectionName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._dataConnectionName.ToString()) : null, "dataConnectionName" ,container.Add );
            AddIf( null != (((object)this._principalAssignmentName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._principalAssignmentName.ToString()) : null, "principalAssignmentName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}