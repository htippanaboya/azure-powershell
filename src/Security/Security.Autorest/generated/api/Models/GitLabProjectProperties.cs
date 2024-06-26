// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Security.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Extensions;

    /// <summary>GitLab Project properties.</summary>
    public partial class GitLabProjectProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitLabProjectProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitLabProjectPropertiesInternal
    {

        /// <summary>Backing field for <see cref="FullyQualifiedFriendlyName" /> property.</summary>
        private string _fullyQualifiedFriendlyName;

        /// <summary>
        /// Gets or sets the human readable fully-qualified name of the Project object.
        ///
        /// This contains the entire namespace hierarchy as seen on GitLab UI where entities are separated by the '/' character.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string FullyQualifiedFriendlyName { get => this._fullyQualifiedFriendlyName; }

        /// <summary>Backing field for <see cref="FullyQualifiedName" /> property.</summary>
        private string _fullyQualifiedName;

        /// <summary>
        /// Gets or sets the fully-qualified name of the project object.
        ///
        /// This contains the entire hierarchy where entities are separated by the '$' character.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string FullyQualifiedName { get => this._fullyQualifiedName; }

        /// <summary>Backing field for <see cref="FullyQualifiedParentGroupName" /> property.</summary>
        private string _fullyQualifiedParentGroupName;

        /// <summary>
        /// Gets or sets the fully-qualified name of the project's parent group object.
        ///
        /// This contains the entire hierarchy where namespaces are separated by the '$' character.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string FullyQualifiedParentGroupName { get => this._fullyQualifiedParentGroupName; }

        /// <summary>Internal Acessors for FullyQualifiedFriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitLabProjectPropertiesInternal.FullyQualifiedFriendlyName { get => this._fullyQualifiedFriendlyName; set { {_fullyQualifiedFriendlyName = value;} } }

        /// <summary>Internal Acessors for FullyQualifiedName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitLabProjectPropertiesInternal.FullyQualifiedName { get => this._fullyQualifiedName; set { {_fullyQualifiedName = value;} } }

        /// <summary>Internal Acessors for FullyQualifiedParentGroupName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitLabProjectPropertiesInternal.FullyQualifiedParentGroupName { get => this._fullyQualifiedParentGroupName; set { {_fullyQualifiedParentGroupName = value;} } }

        /// <summary>Internal Acessors for ProvisioningStatusMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitLabProjectPropertiesInternal.ProvisioningStatusMessage { get => this._provisioningStatusMessage; set { {_provisioningStatusMessage = value;} } }

        /// <summary>Internal Acessors for ProvisioningStatusUpdateTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitLabProjectPropertiesInternal.ProvisioningStatusUpdateTimeUtc { get => this._provisioningStatusUpdateTimeUtc; set { {_provisioningStatusUpdateTimeUtc = value;} } }

        /// <summary>Internal Acessors for Url</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitLabProjectPropertiesInternal.Url { get => this._url; set { {_url = value;} } }

        /// <summary>Backing field for <see cref="OnboardingState" /> property.</summary>
        private string _onboardingState;

        /// <summary>
        /// Details about resource onboarding status across all connectors.
        ///
        /// OnboardedByOtherConnector - this resource has already been onboarded to another connector. This is only applicable to
        /// top-level resources.
        /// Onboarded - this resource has already been onboarded by the specified connector.
        /// NotOnboarded - this resource has not been onboarded to any connector.
        /// NotApplicable - the onboarding state is not applicable to the current endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string OnboardingState { get => this._onboardingState; set => this._onboardingState = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// The provisioning state of the resource.
        ///
        /// Pending - Provisioning pending.
        /// Failed - Provisioning failed.
        /// Succeeded - Successful provisioning.
        /// Canceled - Provisioning canceled.
        /// PendingDeletion - Deletion pending.
        /// DeletionSuccess - Deletion successful.
        /// DeletionFailure - Deletion failure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="ProvisioningStatusMessage" /> property.</summary>
        private string _provisioningStatusMessage;

        /// <summary>Gets or sets resource status message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string ProvisioningStatusMessage { get => this._provisioningStatusMessage; }

        /// <summary>Backing field for <see cref="ProvisioningStatusUpdateTimeUtc" /> property.</summary>
        private global::System.DateTime? _provisioningStatusUpdateTimeUtc;

        /// <summary>Gets or sets time when resource was last checked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public global::System.DateTime? ProvisioningStatusUpdateTimeUtc { get => this._provisioningStatusUpdateTimeUtc; }

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        /// <summary>Gets or sets the url of the GitLab Project.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string Url { get => this._url; }

        /// <summary>Creates an new <see cref="GitLabProjectProperties" /> instance.</summary>
        public GitLabProjectProperties()
        {

        }
    }
    /// GitLab Project properties.
    public partial interface IGitLabProjectProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Gets or sets the human readable fully-qualified name of the Project object.
        ///
        /// This contains the entire namespace hierarchy as seen on GitLab UI where entities are separated by the '/' character.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the human readable fully-qualified name of the Project object.

        This contains the entire namespace hierarchy as seen on GitLab UI where entities are separated by the '/' character.",
        SerializedName = @"fullyQualifiedFriendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FullyQualifiedFriendlyName { get;  }
        /// <summary>
        /// Gets or sets the fully-qualified name of the project object.
        ///
        /// This contains the entire hierarchy where entities are separated by the '$' character.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fully-qualified name of the project object.

        This contains the entire hierarchy where entities are separated by the '$' character.",
        SerializedName = @"fullyQualifiedName",
        PossibleTypes = new [] { typeof(string) })]
        string FullyQualifiedName { get;  }
        /// <summary>
        /// Gets or sets the fully-qualified name of the project's parent group object.
        ///
        /// This contains the entire hierarchy where namespaces are separated by the '$' character.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fully-qualified name of the project's parent group object.

        This contains the entire hierarchy where namespaces are separated by the '$' character.",
        SerializedName = @"fullyQualifiedParentGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string FullyQualifiedParentGroupName { get;  }
        /// <summary>
        /// Details about resource onboarding status across all connectors.
        ///
        /// OnboardedByOtherConnector - this resource has already been onboarded to another connector. This is only applicable to
        /// top-level resources.
        /// Onboarded - this resource has already been onboarded by the specified connector.
        /// NotOnboarded - this resource has not been onboarded to any connector.
        /// NotApplicable - the onboarding state is not applicable to the current endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details about resource onboarding status across all connectors.

        OnboardedByOtherConnector - this resource has already been onboarded to another connector. This is only applicable to top-level resources.
        Onboarded - this resource has already been onboarded by the specified connector.
        NotOnboarded - this resource has not been onboarded to any connector.
        NotApplicable - the onboarding state is not applicable to the current endpoint.",
        SerializedName = @"onboardingState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("NotApplicable", "OnboardedByOtherConnector", "Onboarded", "NotOnboarded")]
        string OnboardingState { get; set; }
        /// <summary>
        /// The provisioning state of the resource.
        ///
        /// Pending - Provisioning pending.
        /// Failed - Provisioning failed.
        /// Succeeded - Successful provisioning.
        /// Canceled - Provisioning canceled.
        /// PendingDeletion - Deletion pending.
        /// DeletionSuccess - Deletion successful.
        /// DeletionFailure - Deletion failure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The provisioning state of the resource.

        Pending - Provisioning pending.
        Failed - Provisioning failed.
        Succeeded - Successful provisioning.
        Canceled - Provisioning canceled.
        PendingDeletion - Deletion pending.
        DeletionSuccess - Deletion successful.
        DeletionFailure - Deletion failure.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Pending", "PendingDeletion", "DeletionSuccess", "DeletionFailure")]
        string ProvisioningState { get; set; }
        /// <summary>Gets or sets resource status message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets resource status message.",
        SerializedName = @"provisioningStatusMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningStatusMessage { get;  }
        /// <summary>Gets or sets time when resource was last checked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets time when resource was last checked.",
        SerializedName = @"provisioningStatusUpdateTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ProvisioningStatusUpdateTimeUtc { get;  }
        /// <summary>Gets or sets the url of the GitLab Project.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the url of the GitLab Project.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get;  }

    }
    /// GitLab Project properties.
    internal partial interface IGitLabProjectPropertiesInternal

    {
        /// <summary>
        /// Gets or sets the human readable fully-qualified name of the Project object.
        ///
        /// This contains the entire namespace hierarchy as seen on GitLab UI where entities are separated by the '/' character.
        /// </summary>
        string FullyQualifiedFriendlyName { get; set; }
        /// <summary>
        /// Gets or sets the fully-qualified name of the project object.
        ///
        /// This contains the entire hierarchy where entities are separated by the '$' character.
        /// </summary>
        string FullyQualifiedName { get; set; }
        /// <summary>
        /// Gets or sets the fully-qualified name of the project's parent group object.
        ///
        /// This contains the entire hierarchy where namespaces are separated by the '$' character.
        /// </summary>
        string FullyQualifiedParentGroupName { get; set; }
        /// <summary>
        /// Details about resource onboarding status across all connectors.
        ///
        /// OnboardedByOtherConnector - this resource has already been onboarded to another connector. This is only applicable to
        /// top-level resources.
        /// Onboarded - this resource has already been onboarded by the specified connector.
        /// NotOnboarded - this resource has not been onboarded to any connector.
        /// NotApplicable - the onboarding state is not applicable to the current endpoint.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("NotApplicable", "OnboardedByOtherConnector", "Onboarded", "NotOnboarded")]
        string OnboardingState { get; set; }
        /// <summary>
        /// The provisioning state of the resource.
        ///
        /// Pending - Provisioning pending.
        /// Failed - Provisioning failed.
        /// Succeeded - Successful provisioning.
        /// Canceled - Provisioning canceled.
        /// PendingDeletion - Deletion pending.
        /// DeletionSuccess - Deletion successful.
        /// DeletionFailure - Deletion failure.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Pending", "PendingDeletion", "DeletionSuccess", "DeletionFailure")]
        string ProvisioningState { get; set; }
        /// <summary>Gets or sets resource status message.</summary>
        string ProvisioningStatusMessage { get; set; }
        /// <summary>Gets or sets time when resource was last checked.</summary>
        global::System.DateTime? ProvisioningStatusUpdateTimeUtc { get; set; }
        /// <summary>Gets or sets the url of the GitLab Project.</summary>
        string Url { get; set; }

    }
}