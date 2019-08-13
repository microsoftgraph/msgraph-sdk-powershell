// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using System;
    using System.Management.Automation;
    using System.Net.Http;
    
    [Cmdlet(VerbsCommunications.Connect, "Graph", DefaultParameterSetName = UserParameterSet)]
    public class ConnectGraph : PSCmdlet
    {
        public const string UserParameterSet = "UserParameterSet";
        public const string AppParameterSet = "AppParameterSet";

        [Parameter(ParameterSetName = UserParameterSet, Position = 1, Mandatory = true)]
        [Parameter(ParameterSetName = AppParameterSet, Position = 1, Mandatory = true)]
        public string ClientId { get; set; }

        [Parameter(ParameterSetName = UserParameterSet, Position = 2, Mandatory = true)]
        [Parameter(ParameterSetName = AppParameterSet, Position = 2)]
        public string Scopes { get; set; }

        [Parameter(ParameterSetName = AppParameterSet, Position = 3)]
        public string ClientSecret { get; set; }

        [Parameter(ParameterSetName = UserParameterSet, Position = 3)]
        [Parameter(ParameterSetName = AppParameterSet, Position = 4)]
        public string TenantId { get; set; }

        protected override void BeginProcessing()
        {
            validateParameters();
            base.BeginProcessing();
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            AuthConfig authConfig = new AuthConfig { ClientId = ClientId, ClientSecret = ClientSecret, Scopes = Scopes, TenantId = TenantId };

            if (ParameterSetName == UserParameterSet)
                authConfig.AuthType = AuthenticationType.Delegated;
            else
                authConfig.AuthType = AuthenticationType.AppOnly;

            // Save auth config to session state.
            SessionState.PSVariable.Set(Constants.GraphAuthConfigId, authConfig);

            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(authConfig);

            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://graph.microsoft.com/v1.0/me");
            authProvider.AuthenticateRequestAsync(requestMessage).GetAwaiter().GetResult();

            WriteObject("Welcome To Microsoft Graph!");
            // WriteObject(File.ReadAllText(".\\Art\\WelcomeText.txt"));
            // WriteObject(File.ReadAllText(".\\Art\\GRaphText.txt"));
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }

        private void validateParameters()
        {
            if (ParameterSetName == UserParameterSet || ParameterSetName == AppParameterSet)
            {
                // Client Id
                if (string.IsNullOrEmpty(ClientId))
                    ThrowParameterError("ClientId");

                // Scopes
                if (string.IsNullOrEmpty(Scopes))
                    ThrowParameterError("Scopes");
            }

            if (ParameterSetName == AppParameterSet)
            {
                // Client Secret
                if (string.IsNullOrEmpty(ClientSecret))
                    ThrowParameterError("ClientSecret");

                // Tenant Id
                if (string.IsNullOrEmpty(TenantId))
                    ThrowParameterError("TenantId");
            }
        }

        private void ThrowParameterError(string parameterName)
        {
            ThrowTerminatingError(
                new ErrorRecord(
                    new ArgumentException($"Must specify {parameterName}"), Guid.NewGuid().ToString(), ErrorCategory.InvalidArgument, null)
                );
        }
    }
}
