﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Common;
using Microsoft.Graph.PowerShell.Authentication.Extensions;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using System;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    /// <summary>
    /// Adds Microsoft Graph environment to the settings file.
    /// </summary>
    [Cmdlet(VerbsCommon.Add, "MgEnvironment", SupportsShouldProcess = true, HelpUri = "https://learn.microsoft.com/powershell/microsoftgraph/authentication-commands#using-get-mgenvironment")]
    [OutputType(typeof(GraphEnvironment))]
    public class AddMgEnvironment : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The environment name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The base URL for Azure AD endpoint to get access tokens for Microsoft Graph endpoint.")]
        [ValidateNotNullOrEmpty]
        [Alias("AzureADUrl")]
        public string AzureADEndpoint { get; set; }

        [Parameter(Position = 2, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The service root endpoint for Microsoft Graph.")]
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
            if (ShouldProcess("adding environment", Name))
            {
                if (GraphEnvironment.BuiltInEnvironments.Keys.Any((k) => string.Equals(k, Name, StringComparison.CurrentCultureIgnoreCase)))
                {
                    throw new InvalidOperationException(
                        ErrorConstants.Message.CannotModifyBuiltInEnvironment.FormatCurrentCulture("add", Name));
                }

                GraphSettings settings = this.GetContextSettings();
                if (!settings.TryGetEnvironment(Name, out IGraphEnvironment newEnvironment))
                {
                    newEnvironment = new GraphEnvironment { Name = Name };
                }

                newEnvironment.AzureADEndpoint = AzureADEndpoint.GetBaseUrl();
                newEnvironment.GraphEndpoint = GraphEndpoint.GetBaseUrl();
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

        private void ValidateParameters()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                this.ThrowParameterError(nameof(Name));
            }

            if (string.IsNullOrWhiteSpace(AzureADEndpoint) || !Uri.IsWellFormedUriString(AzureADEndpoint, UriKind.Absolute))
            {
                this.ThrowParameterError(ErrorConstants.Message.InvalidUrlParameter, nameof(AzureADEndpoint));
            }

            if (string.IsNullOrWhiteSpace(GraphEndpoint) || !Uri.IsWellFormedUriString(GraphEndpoint, UriKind.Absolute))
            {
                this.ThrowParameterError(ErrorConstants.Message.InvalidUrlParameter, nameof(GraphEndpoint));
            }
        }
    }
}
