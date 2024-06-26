// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>MSDeploy log</summary>
    public partial class MSDeployLog :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLog,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResource __proxyOnlyResource = new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ProxyOnlyResource();

        /// <summary>List of log entry messages</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogEntry[] Entry { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogPropertiesInternal)Property).Entry; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; }

        /// <summary>Kind of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind = value ?? null; }

        /// <summary>Internal Acessors for Entry</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogEntry[] Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogInternal.Entry { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogPropertiesInternal)Property).Entry; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogPropertiesInternal)Property).Entry = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogProperties Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.MSDeployLogProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type = value; }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogProperties _property;

        /// <summary>MSDeployLog resource specific properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.MSDeployLogProperties()); set => this._property = value; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; }

        /// <summary>Creates an new <see cref="MSDeployLog" /> instance.</summary>
        public MSDeployLog()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyOnlyResource), __proxyOnlyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyOnlyResource), __proxyOnlyResource);
        }
    }
    /// MSDeploy log
    public partial interface IMSDeployLog :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResource
    {
        /// <summary>List of log entry messages</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of log entry messages",
        SerializedName = @"entries",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogEntry) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogEntry[] Entry { get;  }

    }
    /// MSDeploy log
    internal partial interface IMSDeployLogInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal
    {
        /// <summary>List of log entry messages</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogEntry[] Entry { get; set; }
        /// <summary>MSDeployLog resource specific properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogProperties Property { get; set; }

    }
}