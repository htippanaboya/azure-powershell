// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{

    /// <summary>
    /// Defines values for PermissionProperty.
    /// </summary>


    public static class PermissionProperty
    {
        /// <summary>
        /// This permission provides read only access to AWS Security Hub resources.
        /// </summary>
        public const string AWSAWSSecurityHubReadOnlyAccess = "AWS::AWSSecurityHubReadOnlyAccess";
        /// <summary>
        /// This permission grants access to read security configuration metadata.
        /// </summary>
        public const string AWSSecurityAudit = "AWS::SecurityAudit";
        /// <summary>
        /// The permission provides for EC2 Automation service to execute activities defined within Automation documents.
        /// </summary>
        public const string AWSAmazonSSMAutomationRole = "AWS::AmazonSSMAutomationRole";
        /// <summary>
        /// This permission provides read only access to GCP Security Command Center.
        /// </summary>
        public const string GCPSecurityCenterAdminViewer = "GCP::Security Center Admin Viewer";
    }
}