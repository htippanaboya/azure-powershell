// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>MSDeployLog resource specific properties</summary>
    public partial class MSDeployLogProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Entry" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogEntry[] _entry;

        /// <summary>List of log entry messages</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogEntry[] Entry { get => this._entry; }

        /// <summary>Internal Acessors for Entry</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogEntry[] Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogPropertiesInternal.Entry { get => this._entry; set { {_entry = value;} } }

        /// <summary>Creates an new <see cref="MSDeployLogProperties" /> instance.</summary>
        public MSDeployLogProperties()
        {

        }
    }
    /// MSDeployLog resource specific properties
    public partial interface IMSDeployLogProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
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
    /// MSDeployLog resource specific properties
    internal partial interface IMSDeployLogPropertiesInternal

    {
        /// <summary>List of log entry messages</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IMSDeployLogEntry[] Entry { get; set; }

    }
}