// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>A list of shared private link resources</summary>
    public partial class SharedPrivateLinkResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResourceList,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResourceListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested
        /// private endpoint connections exceed maximum page size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResource[] _value;

        /// <summary>The list of the shared private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SharedPrivateLinkResourceList" /> instance.</summary>
        public SharedPrivateLinkResourceList()
        {

        }
    }
    /// A list of shared private link resources
    public partial interface ISharedPrivateLinkResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested
        /// private endpoint connections exceed maximum page size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested private endpoint connections exceed maximum page size.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of the shared private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the shared private link resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResource[] Value { get; set; }

    }
    /// A list of shared private link resources
    internal partial interface ISharedPrivateLinkResourceListInternal

    {
        /// <summary>
        /// Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested
        /// private endpoint connections exceed maximum page size.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>The list of the shared private link resources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISharedPrivateLinkResource[] Value { get; set; }

    }
}