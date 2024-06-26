// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Support
{

    /// <summary>Information about the connected appliance.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Support.ProviderTypeConverter))]
    public partial struct Provider :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "VMWare".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'VMWare'", "VMWare", global::System.Management.Automation.CompletionResultType.ParameterValue, "VMWare");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "HCI".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'HCI'", "HCI", global::System.Management.Automation.CompletionResultType.ParameterValue, "HCI");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SCVMM".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'SCVMM'", "SCVMM", global::System.Management.Automation.CompletionResultType.ParameterValue, "SCVMM");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "KubeVirt".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'KubeVirt'", "KubeVirt", global::System.Management.Automation.CompletionResultType.ParameterValue, "KubeVirt");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "OpenStack".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'OpenStack'", "OpenStack", global::System.Management.Automation.CompletionResultType.ParameterValue, "OpenStack");
            }
        }
    }
}