// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>The configuration settings of the Facebook provider.</summary>
    public partial class Facebook :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IFacebook,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IFacebookInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>
        /// <code>false</code> if the Facebook provider should not be enabled despite the set registration; otherwise, <code>true</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="GraphApiVersion" /> property.</summary>
        private string _graphApiVersion;

        /// <summary>The version of the Facebook api to be used while logging in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string GraphApiVersion { get => this._graphApiVersion; set => this._graphApiVersion = value; }

        /// <summary>Backing field for <see cref="Login" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginScopes _login;

        /// <summary>The configuration settings of the login flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginScopes Login { get => (this._login = this._login ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.LoginScopes()); set => this._login = value; }

        /// <summary>A list of the scopes that should be requested while authenticating.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] LoginScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginScopesInternal)Login).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginScopesInternal)Login).Scope = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Login</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginScopes Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IFacebookInternal.Login { get => (this._login = this._login ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.LoginScopes()); set { {_login = value;} } }

        /// <summary>Internal Acessors for Registration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppRegistration Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IFacebookInternal.Registration { get => (this._registration = this._registration ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AppRegistration()); set { {_registration = value;} } }

        /// <summary>Backing field for <see cref="Registration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppRegistration _registration;

        /// <summary>The configuration settings of the app registration for the Facebook provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppRegistration Registration { get => (this._registration = this._registration ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AppRegistration()); set => this._registration = value; }

        /// <summary>The App ID of the app used for login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string RegistrationAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppRegistrationInternal)Registration).AppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppRegistrationInternal)Registration).AppId = value ?? null; }

        /// <summary>The app setting name that contains the app secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string RegistrationAppSecretSettingName { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppRegistrationInternal)Registration).AppSecretSettingName; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppRegistrationInternal)Registration).AppSecretSettingName = value ?? null; }

        /// <summary>Creates an new <see cref="Facebook" /> instance.</summary>
        public Facebook()
        {

        }
    }
    /// The configuration settings of the Facebook provider.
    public partial interface IFacebook :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>
        /// <code>false</code> if the Facebook provider should not be enabled despite the set registration; otherwise, <code>true</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"<code>false</code> if the Facebook provider should not be enabled despite the set registration; otherwise, <code>true</code>.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>The version of the Facebook api to be used while logging in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the Facebook api to be used while logging in.",
        SerializedName = @"graphApiVersion",
        PossibleTypes = new [] { typeof(string) })]
        string GraphApiVersion { get; set; }
        /// <summary>A list of the scopes that should be requested while authenticating.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of the scopes that should be requested while authenticating.",
        SerializedName = @"scopes",
        PossibleTypes = new [] { typeof(string) })]
        string[] LoginScope { get; set; }
        /// <summary>The App ID of the app used for login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The App ID of the app used for login.",
        SerializedName = @"appId",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationAppId { get; set; }
        /// <summary>The app setting name that contains the app secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The app setting name that contains the app secret.",
        SerializedName = @"appSecretSettingName",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationAppSecretSettingName { get; set; }

    }
    /// The configuration settings of the Facebook provider.
    internal partial interface IFacebookInternal

    {
        /// <summary>
        /// <code>false</code> if the Facebook provider should not be enabled despite the set registration; otherwise, <code>true</code>.
        /// </summary>
        bool? Enabled { get; set; }
        /// <summary>The version of the Facebook api to be used while logging in.</summary>
        string GraphApiVersion { get; set; }
        /// <summary>The configuration settings of the login flow.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginScopes Login { get; set; }
        /// <summary>A list of the scopes that should be requested while authenticating.</summary>
        string[] LoginScope { get; set; }
        /// <summary>The configuration settings of the app registration for the Facebook provider.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppRegistration Registration { get; set; }
        /// <summary>The App ID of the app used for login.</summary>
        string RegistrationAppId { get; set; }
        /// <summary>The app setting name that contains the app secret.</summary>
        string RegistrationAppSecretSettingName { get; set; }

    }
}