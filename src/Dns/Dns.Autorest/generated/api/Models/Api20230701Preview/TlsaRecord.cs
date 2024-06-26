// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Extensions;

    /// <summary>
    /// A TLSA record. For more information about the TLSA record format, see RFC 6698: https://www.rfc-editor.org/rfc/rfc6698
    /// </summary>
    [Microsoft.Azure.PowerShell.Cmdlets.Dns.DoNotFormat]
    public partial class TlsaRecord :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITlsaRecord,
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.ITlsaRecordInternal
    {

        /// <summary>Backing field for <see cref="CertAssociationData" /> property.</summary>
        private string _certAssociationData;

        /// <summary>This specifies the certificate association data to be matched.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public string CertAssociationData { get => this._certAssociationData; set => this._certAssociationData = value; }

        /// <summary>Backing field for <see cref="MatchingType" /> property.</summary>
        private int? _matchingType;

        /// <summary>The matching type specifies how the certificate association is presented.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public int? MatchingType { get => this._matchingType; set => this._matchingType = value; }

        /// <summary>Backing field for <see cref="Selector" /> property.</summary>
        private int? _selector;

        /// <summary>
        /// The selector specifies which part of the TLS certificate presented by the server will be matched against the association
        /// data.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public int? Selector { get => this._selector; set => this._selector = value; }

        /// <summary>Backing field for <see cref="Usage" /> property.</summary>
        private int? _usage;

        /// <summary>
        /// The usage specifies the provided association that will be used to match the certificate presented in the TLS handshake.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public int? Usage { get => this._usage; set => this._usage = value; }

        /// <summary>Creates an new <see cref="TlsaRecord" /> instance.</summary>
        public TlsaRecord()
        {

        }
    }
    /// A TLSA record. For more information about the TLSA record format, see RFC 6698: https://www.rfc-editor.org/rfc/rfc6698
    public partial interface ITlsaRecord :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.IJsonSerializable
    {
        /// <summary>This specifies the certificate association data to be matched.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This specifies the certificate association data to be matched.",
        SerializedName = @"certAssociationData",
        PossibleTypes = new [] { typeof(string) })]
        string CertAssociationData { get; set; }
        /// <summary>The matching type specifies how the certificate association is presented.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The matching type specifies how the certificate association is presented.",
        SerializedName = @"matchingType",
        PossibleTypes = new [] { typeof(int) })]
        int? MatchingType { get; set; }
        /// <summary>
        /// The selector specifies which part of the TLS certificate presented by the server will be matched against the association
        /// data.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The selector specifies which part of the TLS certificate presented by the server will be matched against the association data.",
        SerializedName = @"selector",
        PossibleTypes = new [] { typeof(int) })]
        int? Selector { get; set; }
        /// <summary>
        /// The usage specifies the provided association that will be used to match the certificate presented in the TLS handshake.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The usage specifies the provided association that will be used to match the certificate presented in the TLS handshake.",
        SerializedName = @"usage",
        PossibleTypes = new [] { typeof(int) })]
        int? Usage { get; set; }

    }
    /// A TLSA record. For more information about the TLSA record format, see RFC 6698: https://www.rfc-editor.org/rfc/rfc6698
    internal partial interface ITlsaRecordInternal

    {
        /// <summary>This specifies the certificate association data to be matched.</summary>
        string CertAssociationData { get; set; }
        /// <summary>The matching type specifies how the certificate association is presented.</summary>
        int? MatchingType { get; set; }
        /// <summary>
        /// The selector specifies which part of the TLS certificate presented by the server will be matched against the association
        /// data.
        /// </summary>
        int? Selector { get; set; }
        /// <summary>
        /// The usage specifies the provided association that will be used to match the certificate presented in the TLS handshake.
        /// </summary>
        int? Usage { get; set; }

    }
}