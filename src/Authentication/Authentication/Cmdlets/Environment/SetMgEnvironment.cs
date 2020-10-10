// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using Microsoft.Graph.PowerShell.Authentication.Extensions;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Management.Automation;

    /// <summary>
    /// Sets a Microsoft Graph environment to the settings file..
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "MgEnvironment", SupportsShouldProcess = true)]
    [OutputType(typeof(GraphEnvironment))]
    public class SetMgEnvironment : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The environment name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 1, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The base URL for Azure AD endpoint to get access tokens for Microsoft Graph endpoint.")]
        [ValidateNotNullOrEmpty]
        [Alias("AzureADUrl")]
        public string AzureADEndpoint { get; set; }

        [Parameter(Position = 2, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The service root endpoint for Microsoft Graph.")]
        [ValidateNotNullOrEmpty]
        [Alias("GraphUrl")]
        public string GraphEndpoint { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            ValidateParameters();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            if (ShouldProcess("updating environment", Name))
            {
                if (GraphEnvironment.BuiltInEnvironments.Keys.Any((k) => string.Equals(k, Name, StringComparison.CurrentCultureIgnoreCase)))
                {
                    throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture,
                            "Cannot change built-in environment {0}.", Name));
                }

                GraphSettings settings = this.GetContextSettings();
                if (!settings.TryGetEnvironment(Name, out IGraphEnvironment newEnvironment))
                {
                    // Create default environment if it doesn't exist.
                    newEnvironment = new GraphEnvironment {
                        Name = Name,
                        AzureADEndpoint = settings.EnvironmentTable[GraphEnvironmentConstants.EnvironmentName.Global].AzureADEndpoint,
                        GraphEndpoint = settings.EnvironmentTable[GraphEnvironmentConstants.EnvironmentName.Global].GraphEndpoint
                    };
                }

                if (MyInvocation.BoundParameters.ContainsKey(nameof(AzureADEndpoint)))
                {
                    newEnvironment.AzureADEndpoint = AzureADEndpoint.GetBaseUrl();
                }

                if (MyInvocation.BoundParameters.ContainsKey(nameof(GraphEndpoint)))
                {
                    newEnvironment.GraphEndpoint = GraphEndpoint.GetBaseUrl();
                }

                newEnvironment.Type = GraphEnvironmentConstants.EnvironmentType.UserDefined;
                settings.TrySetEnvironment(newEnvironment, out IGraphEnvironment mergedEnvironment);

                WriteObject(mergedEnvironment);
            }
        }

        private void ValidateParameters()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                this.ThrowParameterError(nameof(Name));
            }

            if (MyInvocation.BoundParameters.ContainsKey(nameof(AzureADEndpoint))
                && (string.IsNullOrWhiteSpace(AzureADEndpoint) || !Uri.IsWellFormedUriString(AzureADEndpoint, UriKind.Absolute)))
            {
                this.ThrowParameterError(ErrorConstants.Message.InvalidUrlParameter, nameof(AzureADEndpoint));
            }

            if (MyInvocation.BoundParameters.ContainsKey(nameof(GraphEndpoint))
                && (string.IsNullOrWhiteSpace(GraphEndpoint) || !Uri.IsWellFormedUriString(GraphEndpoint, UriKind.Absolute)))
            {
                this.ThrowParameterError(ErrorConstants.Message.InvalidUrlParameter, nameof(GraphEndpoint));
            }
        }
    }
}
