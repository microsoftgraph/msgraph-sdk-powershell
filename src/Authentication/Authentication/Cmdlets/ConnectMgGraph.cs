// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Net;
    using System.Collections;
    using System.Security.Cryptography.X509Certificates;

    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using Microsoft.Graph.PowerShell.Authentication.Models;

    using Interfaces;
    using Common;

    using static Helpers.AsyncHelpers;
    using Microsoft.Graph.Authentication.Core;
    using Microsoft.Graph.PowerShell.Authentication.Utilities;

    [Cmdlet(VerbsCommunications.Connect, "MgGraph", DefaultParameterSetName = Constants.UserParameterSet)]
    [Alias("Connect-Graph")]
    public class ConnectMgGraph : PSCmdlet, IModuleAssemblyInitializer, IModuleAssemblyCleanup
    {
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 1,
            HelpMessage = "An array of delegated permissions to consent to.")]
        public string[] Scopes { get; set; }

        [Parameter(ParameterSetName = Constants.AppParameterSet,
            Position = 1,
            Mandatory = true,
            HelpMessage = "The client id of your application.")]
        [Alias("AppId")]
        public string ClientId { get; set; }

        [Parameter(ParameterSetName = Constants.AppParameterSet,
            Position = 2,
            HelpMessage = "The name of your certificate. The Certificate will be retrieved from the current user's certificate store.")]
        [Alias("CertificateSubject")]
        public string CertificateName { get; set; }

        [Parameter(ParameterSetName = Constants.AppParameterSet,
            Position = 3,
            HelpMessage = "The thumbprint of your certificate. The Certificate will be retrieved from the current user's certificate store.")]
        public string CertificateThumbprint { get; set; }

        [Parameter(Mandatory = false,
            ParameterSetName = Constants.AppParameterSet,
            HelpMessage = "An X.509 certificate supplied during invocation.")]
        public X509Certificate2 Certificate { get; set; }

        [Parameter(ParameterSetName = Constants.AccessTokenParameterSet,
            Position = 1,
            HelpMessage = "Specifies a bearer token for Microsoft Graph service. Access tokens do timeout and you'll have to handle their refresh.")]
        public string AccessToken { get; set; }

        [Parameter(ParameterSetName = Constants.AppParameterSet)]
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 4,
            HelpMessage = "The id of the tenant to connect to.")]
        public string TenantId { get; set; }

        [Parameter(ParameterSetName = Constants.AppParameterSet)]
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Position = 5,
            HelpMessage = "Forces the command to get a new access token silently.")]
        public SwitchParameter ForceRefresh { get; set; }

        [Parameter(ParameterSetName = Constants.AppParameterSet)]
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Mandatory = false,
            HelpMessage = "Determines the scope of authentication context. This accepts `Process` for the current process, or `CurrentUser` for all sessions started by user.")]
        public ContextScope ContextScope { get; set; }

        [Parameter(ParameterSetName = Constants.AppParameterSet)]
        [Parameter(ParameterSetName = Constants.AccessTokenParameterSet)]
        [Parameter(ParameterSetName = Constants.UserParameterSet,
            Mandatory = false,
            HelpMessage = "The name of the national cloud environment to connect to. By default global cloud is used.")]
        [ValidateNotNullOrEmpty]
        [Alias("EnvironmentName", "NationalCloud")]
        public string Environment { get; set; }

        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        private IGraphEnvironment environment;

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
            ValidateParameters();

            if (MyInvocation.BoundParameters.ContainsKey(nameof(Environment)))
            {
                GraphSettings settings = this.GetContextSettings();
                if (!settings.TryGetEnvironment(Environment, out environment))
                {
                    throw new PSInvalidOperationException(string.Format(ErrorConstants.Message.InvalidEnvironment, Environment));
                }
            }
            else
            {
                environment = GraphEnvironment.BuiltInEnvironments[GraphEnvironmentConstants.EnvironmentName.Global];
            }
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                using (var asyncCommandRuntime = new CustomAsyncCommandRuntime(this, _cancellationTokenSource.Token))
                {
                    asyncCommandRuntime.Wait(ProcessRecordAsync(), _cancellationTokenSource.Token);
                }
            }
            catch (AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach (var innerException in aggregateException.Flatten().InnerExceptions)
                {
                    var errorRecords = innerException.Data;
                    if (errorRecords.Count > 1)
                    {
                        foreach (DictionaryEntry dictionaryEntry in errorRecords)
                        {
                            WriteError((ErrorRecord)dictionaryEntry.Value);
                        }
                    }
                    else
                    {
                        WriteError(new ErrorRecord(innerException, string.Empty, ErrorCategory.NotSpecified, null));
                    }
                }
            }
            catch (Exception exception) when (exception as PipelineStoppedException == null ||
                                              (exception as PipelineStoppedException).InnerException != null)
            {
                // Write exception out to error channel.
                WriteError(new ErrorRecord(exception, string.Empty, ErrorCategory.NotSpecified, null));
            }
        }

        private async Task ProcessRecordAsync()
        {
            using (NoSynchronizationContext)
            {
                IAuthContext authContext = new AuthContext { TenantId = TenantId };
                // Set selected environment to the session object.
                GraphSession.Instance.Environment = environment;

                switch (ParameterSetName)
                {
                    case Constants.UserParameterSet:
                        {
                            // 2 mins timeout. 1 min < HTTP timeout.
                            TimeSpan authTimeout = new TimeSpan(0, 0, Core.Constants.MaxDeviceCodeTimeOut);
                            // To avoid re-initializing the tokenSource, use CancelAfter
                            _cancellationTokenSource.CancelAfter(authTimeout);
                            authContext.AuthType = AuthenticationType.Delegated;
                            string[] processedScopes = ProcessScopes(Scopes);
                            authContext.Scopes = processedScopes.Length == 0 ? new string[] { "User.Read" } : processedScopes;
                            // Default to CurrentUser but allow the customer to change this via `ContextScope` param.
                            authContext.ContextScope = this.IsParameterBound(nameof(ContextScope)) ? ContextScope : ContextScope.CurrentUser;
                        }
                        break;
                    case Constants.AppParameterSet:
                        {
                            authContext.AuthType = AuthenticationType.AppOnly;
                            authContext.ClientId = ClientId;
                            authContext.CertificateThumbprint = CertificateThumbprint;
                            authContext.CertificateName = CertificateName;
                            authContext.Certificate = Certificate;
                            // Default to Process but allow the customer to change this via `ContextScope` param.
                            authContext.ContextScope = this.IsParameterBound(nameof(ContextScope)) ? ContextScope : ContextScope.Process;
                        }
                        break;
                    case Constants.AccessTokenParameterSet:
                        {
                            authContext.AuthType = AuthenticationType.UserProvidedAccessToken;
                            authContext.ContextScope = ContextScope.Process;
                            // Store user provided access token to a session object.
                            GraphSession.Instance.UserProvidedToken = new NetworkCredential(string.Empty, AccessToken).SecurePassword;
                        }
                        break;
                }

                try
                {
                    // Save auth context to session state.
                    GraphSession.Instance.AuthContext = await Authenticator.AuthenticateAsync(authContext, ForceRefresh, _cancellationTokenSource.Token);
                }
                catch(Exception ex)
                {
                    throw ex;
                }

                WriteObject("Welcome To Microsoft Graph!");
            }
        }

        protected override void StopProcessing()
        {
            _cancellationTokenSource.Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Processes user provided scopes by removing whitespace and splitting comma separated scopes.
        /// </summary>
        /// <param name="scopes">An array of scopes.</param>
        /// <returns>A formated array of scopes.</returns>
        private string[] ProcessScopes(string[] scopes)
        {
            if (scopes == null)
            {
                return new string[0];
            }

            List<string> formatedScopes = new List<string>();
            foreach (string scope in scopes)
            {
                string[] cleanScopes = scope.Split(',')
                    .Select(s => s.Trim())
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .ToArray();

                formatedScopes.AddRange(cleanScopes);
            }
            return formatedScopes.ToArray();
        }

        private void ValidateParameters()
        {
            switch (ParameterSetName)
            {
                case Constants.AppParameterSet:
                    {
                        // Client Id
                        if (string.IsNullOrEmpty(ClientId))
                        {
                            this.ThrowParameterError(nameof(ClientId));
                        }

                        // Certificate Thumbprint, Name or Actual Certificate
                        if (string.IsNullOrEmpty(CertificateThumbprint) && string.IsNullOrEmpty(CertificateName) && this.Certificate == null)
                        {
                            this.ThrowParameterError($"{nameof(CertificateThumbprint)} or {nameof(CertificateName)} or {nameof(Certificate)}");
                        }

                        // A thumbprint will always have 40 characters since thumbprints are dynamically calculated as a SHA-1 hash of a certificate's binary data. A SHA-1 hash has a length of 40 hexadecimal numbers (160-bit = 20-byte).
                        // See https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509certificate2.thumbprint?view=net-5.0#remarks.
                        if (!string.IsNullOrEmpty(CertificateThumbprint) && CertificateThumbprint.Length != 40)
                        {
                            this.ThrowError(string.Format(ErrorConstants.Message.InvalidCertificateThumbprint, nameof(CertificateThumbprint)), ErrorCategory.InvalidArgument);
                        }

                        // Tenant Id
                        if (string.IsNullOrEmpty(TenantId))
                        {
                            this.ThrowParameterError(nameof(TenantId));
                        }

                    }
                    break;
                case Constants.AccessTokenParameterSet:
                    {
                        // AccessToken
                        if (string.IsNullOrEmpty(AccessToken))
                        {
                            this.ThrowParameterError(nameof(AccessToken));
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Globally initializes GraphSession.
        /// </summary>
        public void OnImport()
        {
            GraphSessionInitializer.InitializeSession();
            GraphSession.Instance.DataStore = new DiskDataStore();
        }

        /// <summary>
        /// Resets <see cref="GraphSession"/> instance when a user removes the module from the session via Remove-Module.
        /// </summary>
        /// <param name="psModuleInfo">A <see cref="PSModuleInfo"/> object.</param>
        public void OnRemove(PSModuleInfo psModuleInfo)
        {
            GraphSession.Reset();
            DependencyAssemblyResolver.Reset();
        }
    }
}
