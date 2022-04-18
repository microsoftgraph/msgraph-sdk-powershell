// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Common;
using Microsoft.Graph.PowerShell.Authentication.Extensions;
using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
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
                    newEnvironment = new GraphEnvironment { Name = Name };
                }

                if (MyInvocation.BoundParameters.ContainsKey(nameof(AzureADEndpoint)))
                {
                    newEnvironment.AzureADEndpoint = AzureADEndpoint.GetBaseUrl();
                }

                if (MyInvocation.BoundParameters.ContainsKey(nameof(GraphEndpoint)))
                {
                    newEnvironment.GraphEndpoint = GraphEndpoint.GetBaseUrl();
                }

                ValidateEnvironment(newEnvironment);
                newEnvironment.Type = GraphEnvironmentConstants.EnvironmentType.UserDefined;
                bool isSuccess = settings.TrySetEnvironment(newEnvironment, out IGraphEnvironment mergedEnvironment);

                // Update environment session object.
                if (isSuccess && GraphSession.Instance.Environment?.Name == mergedEnvironment?.Name)
                {
                    GraphSession.Instance.Environment = mergedEnvironment;
                }

                WriteObject(mergedEnvironment);
            }
        }

        /// <summary>
        /// Ensures all required properties are set to <see cref="IGraphEnvironment"/> object.
        /// </summary>
        /// <param name="newEnvironment">The new <see cref="IGraphEnvironment"/> object.</param>
        private void ValidateEnvironment(IGraphEnvironment newEnvironment)
        {
            if (string.IsNullOrWhiteSpace(newEnvironment.AzureADEndpoint)
                || string.IsNullOrWhiteSpace(newEnvironment.GraphEndpoint))
            {
                this.ThrowParameterError(ErrorConstants.Message.InvalidUrlParameter, $"{nameof(GraphEndpoint)} or {nameof(AzureADEndpoint)}");
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
