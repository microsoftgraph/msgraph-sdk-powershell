// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Common;
using Microsoft.Graph.PowerShell.Authentication.Core.Extensions;
using Microsoft.Graph.PowerShell.Authentication.Core.TokenCache;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Graph.PowerShell.Authentication.Extensions;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using Microsoft.Graph.PowerShell.Authentication.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.Graph.PowerShell.Authentication.Constants;
using static Microsoft.Graph.PowerShell.Authentication.Helpers.AsyncHelpers;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsCommunications.Connect, "MgGraph", DefaultParameterSetName = Constants.UserParameterSet, HelpUri = "https://learn.microsoft.com/powershell/microsoftgraph/authentication-commands#using-connect-mggraph")]
    [Alias("Connect-Graph")]
    public class ConnectMgGraph : PSCmdlet, IModuleAssemblyInitializer, IModuleAssemblyCleanup
    {
        [Parameter(ParameterSetName = Constants.UserParameterSet, Position = 1, HelpMessage = HelpMessages.Scopes)]
        public string[] Scopes { get; set; }

        [Parameter(ParameterSetName = Constants.AppCertificateParameterSet, Position = 1, Mandatory = true, HelpMessage = HelpMessages.ClientId)]
        [Parameter(ParameterSetName = Constants.UserParameterSet, Mandatory = false, HelpMessage = HelpMessages.ClientId)]
        [Parameter(ParameterSetName = Constants.IdentityParameterSet, Mandatory = false, HelpMessage = HelpMessages.ManagedIdentityClientId)]
        [Alias("AppId", "ApplicationId")]
        public string ClientId { get; set; }

        [Parameter(ParameterSetName = Constants.AppCertificateParameterSet, Position = 2, HelpMessage = HelpMessages.CertificateSubjectName)]
        [Alias("CertificateSubject", "CertificateName")]
        public string CertificateSubjectName { get; set; }

        [Parameter(ParameterSetName = Constants.AppCertificateParameterSet, Position = 3, HelpMessage = HelpMessages.CertificateThumbprint)]
        public string CertificateThumbprint { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = Constants.AppCertificateParameterSet, HelpMessage = HelpMessages.Certificate)]
        public X509Certificate2 Certificate { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = Constants.AppSecretCredentialParameterSet, HelpMessage = HelpMessages.ClientSecretCredential)]
        [Alias("SecretCredential", "Credential")]
        public PSCredential ClientSecretCredential { get; set; }

        [Parameter(ParameterSetName = Constants.AccessTokenParameterSet, Position = 1, Mandatory = true, HelpMessage = HelpMessages.AccessToken)]
        public SecureString AccessToken { get; set; }

        [Parameter(ParameterSetName = Constants.AppCertificateParameterSet, HelpMessage = HelpMessages.TenantId)]
        [Parameter(ParameterSetName = Constants.AppSecretCredentialParameterSet, HelpMessage = HelpMessages.TenantId)]
        [Parameter(ParameterSetName = Constants.UserParameterSet, Position = 4, HelpMessage = HelpMessages.TenantId)]
        [Alias("Audience", "Tenant")]
        public string TenantId { get; set; }

        [Parameter(ParameterSetName = Constants.AppCertificateParameterSet, HelpMessage = HelpMessages.ContextScope)]
        [Parameter(ParameterSetName = Constants.AppSecretCredentialParameterSet, HelpMessage = HelpMessages.ContextScope)]
        [Parameter(ParameterSetName = Constants.UserParameterSet, Mandatory = false, HelpMessage = HelpMessages.ContextScope)]
        [Parameter(ParameterSetName = Constants.IdentityParameterSet, Mandatory = false, HelpMessage = HelpMessages.ContextScope)]
        [Parameter(ParameterSetName = Constants.EnvironmentVariableParameterSet, Mandatory = false, HelpMessage = HelpMessages.ContextScope)]
        public ContextScope ContextScope { get; set; }

        [Parameter(ParameterSetName = Constants.AppCertificateParameterSet, HelpMessage = HelpMessages.Environment)]
        [Parameter(ParameterSetName = Constants.AppSecretCredentialParameterSet, HelpMessage = HelpMessages.Environment)]
        [Parameter(ParameterSetName = Constants.AccessTokenParameterSet, HelpMessage = HelpMessages.Environment)]
        [Parameter(ParameterSetName = Constants.UserParameterSet, Mandatory = false, HelpMessage = HelpMessages.Environment)]
        [Parameter(ParameterSetName = Constants.IdentityParameterSet, Mandatory = false, HelpMessage = HelpMessages.Environment)]
        [Parameter(ParameterSetName = Constants.EnvironmentVariableParameterSet, Mandatory = false, HelpMessage = HelpMessages.Environment)]
        [ValidateNotNullOrEmpty]
        [Alias("EnvironmentName", "NationalCloud")]
        public string Environment { get; set; }

        [Parameter(ParameterSetName = Constants.UserParameterSet, Mandatory = false, HelpMessage = HelpMessages.UseDeviceCode)]
        [Alias("UseDeviceAuthentication", "DeviceCode", "DeviceAuth", "Device")]
        public SwitchParameter UseDeviceCode { get; set; }

        [Parameter(ParameterSetName = Constants.AppCertificateParameterSet, HelpMessage = HelpMessages.ClientTimeout)]
        [Parameter(ParameterSetName = Constants.AppSecretCredentialParameterSet, HelpMessage = HelpMessages.ClientTimeout)]
        [Parameter(ParameterSetName = Constants.AccessTokenParameterSet, HelpMessage = HelpMessages.ClientTimeout)]
        [Parameter(ParameterSetName = Constants.UserParameterSet, Mandatory = false, HelpMessage = HelpMessages.ClientTimeout)]
        [Parameter(ParameterSetName = Constants.IdentityParameterSet, Mandatory = false, HelpMessage = HelpMessages.ClientTimeout)]
        [Parameter(ParameterSetName = Constants.EnvironmentVariableParameterSet, Mandatory = false, HelpMessage = HelpMessages.ClientTimeout)]
        [ValidateNotNullOrEmpty]
        public double ClientTimeout { get; set; }

        [Parameter(ParameterSetName = Constants.IdentityParameterSet, Position = 1, Mandatory = false, HelpMessage = HelpMessages.Identity)]
        [Alias("ManagedIdentity", "ManagedServiceIdentity", "MSI")]
        public SwitchParameter Identity { get; set; }

        [Parameter(ParameterSetName = Constants.EnvironmentVariableParameterSet, Mandatory = false, HelpMessage = HelpMessages.EnvironmentVariable)]
        public SwitchParameter EnvironmentVariable { get; set; }

        [Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        public SwitchParameter Break { get; set; }

        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private IGraphEnvironment environment;

        protected override void BeginProcessing()
        {
            if (Break)
                this.Break();
            base.BeginProcessing();
            ValidateParameters();

            if (MyInvocation.BoundParameters.ContainsKey(nameof(Environment)))
            {
                if (!this.GetContextSettings().TryGetEnvironment(Environment, out environment))
                    throw new PSInvalidOperationException(string.Format(ErrorConstants.Message.InvalidEnvironment, Environment));
            }
            else
            {
                environment = GraphEnvironment.BuiltInEnvironments[GraphEnvironmentConstants.EnvironmentName.Global];
            }
        }
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                using (var asyncCommandRuntime = new CustomAsyncCommandRuntime(this, _cancellationTokenSource.Token))
                {
                    GraphSessionInitializer.InitializeOutput(asyncCommandRuntime);
                    asyncCommandRuntime.Wait(ProcessRecordAsync());
                }
            }
            catch (AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach (var innerException in aggregateException.Flatten().InnerExceptions)
                {
                    var errorRecords = innerException.Data;
                    if (errorRecords.Count > 1)
                        foreach (DictionaryEntry dictionaryEntry in errorRecords)
                            WriteError((ErrorRecord)dictionaryEntry.Value);
                    else
                        WriteError(new ErrorRecord(innerException, string.Empty, ErrorCategory.NotSpecified, null));
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
                IAuthContext authContext = new AuthContext { TenantId = TenantId, PSHostVersion = this.Host.Version };
                if (MyInvocation.BoundParameters.ContainsKey(nameof(ClientTimeout)))
                    GraphSession.Instance.RequestContext.ClientTimeout = TimeSpan.FromSeconds(ClientTimeout);

                GraphSession.Instance.Environment = environment;
                GraphSession.Instance.GraphHttpClient = null;
                if (GraphSession.Instance.InMemoryTokenCache is null)
                    GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache();

                switch (ParameterSetName)
                {
                    case Constants.UserParameterSet:
                        {
                            TimeSpan authTimeout = new TimeSpan(0, 0, Core.Constants.MaxAuthenticationTimeOutInSeconds);
                            _cancellationTokenSource.CancelAfter(authTimeout);
                            if (MyInvocation.BoundParameters.ContainsKey(nameof(ClientId)))
                                authContext.ClientId = ClientId;
                            authContext.AuthType = AuthenticationType.Delegated;
                            string[] processedScopes = ProcessScopes(Scopes);
                            authContext.Scopes = !processedScopes.Any() ? new[] { "User.Read" } : processedScopes;
                            if (RuntimeInformation.OSDescription.ContainsValue("WSL", StringComparison.InvariantCulture))
                            {
                                // Use process scope when on WSL. WSL does not have secret service that's used to cache tokens on Linux, see https://github.com/microsoft/WSL/issues/4254.
                                authContext.ContextScope = ContextScope.Process;
                            }
                            else
                            {
                                // Default to CurrentUser but allow the customer to change this via `-ContextScope`.
                                authContext.ContextScope = this.IsParameterBound(nameof(ContextScope)) ? ContextScope : ContextScope.CurrentUser;
                            }
                            authContext.TokenCredentialType = UseDeviceCode ? TokenCredentialType.DeviceCode : TokenCredentialType.InteractiveBrowser;
                        }
                        break;
                    case Constants.AppCertificateParameterSet:
                        {
                            authContext.AuthType = AuthenticationType.AppOnly;
                            authContext.ClientId = ClientId;
                            authContext.CertificateThumbprint = CertificateThumbprint;
                            authContext.CertificateSubjectName = CertificateSubjectName;
                            authContext.Certificate = Certificate;
                            // Default to Process but allow the customer to change this via `-ContextScope`.
                            authContext.ContextScope = this.IsParameterBound(nameof(ContextScope)) ? ContextScope : ContextScope.Process;
                            authContext.TokenCredentialType = TokenCredentialType.ClientCertificate;
                        }
                        break;
                    case Constants.AppSecretCredentialParameterSet:
                        {
                            authContext.AuthType = AuthenticationType.AppOnly;
                            authContext.ClientId = ClientSecretCredential.UserName;
                            authContext.ClientSecret = ClientSecretCredential.Password;
                            authContext.ClientSecret.MakeReadOnly();
                            authContext.ContextScope = this.IsParameterBound(nameof(ContextScope)) ? ContextScope : ContextScope.Process;
                            authContext.TokenCredentialType = TokenCredentialType.ClientSecret;
                        }
                        break;
                    case Constants.IdentityParameterSet:
                        {
                            authContext.ManagedIdentityId = this.IsParameterBound(nameof(ClientId)) ? ClientId : $"{Core.Constants.DefaultMsiIdPrefix}{Core.Constants.DefaultMsiPort}";
                            authContext.AuthType = AuthenticationType.ManagedIdentity;
                            authContext.ContextScope = this.IsParameterBound(nameof(ContextScope)) ? ContextScope : ContextScope.Process;
                            authContext.TokenCredentialType = TokenCredentialType.ManagedIdentity;
                        }
                        break;
                    case Constants.EnvironmentVariableParameterSet:
                        {
                            authContext.AuthType = AuthenticationType.EnvironmentVariable;
                            authContext.ContextScope = this.IsParameterBound(nameof(ContextScope)) ? ContextScope : ContextScope.Process;
                            authContext.TokenCredentialType = TokenCredentialType.EnvironmentVariable;
                        }
                        break;
                    case Constants.AccessTokenParameterSet:
                        {
                            authContext.AuthType = AuthenticationType.UserProvidedAccessToken;
                            authContext.TokenCredentialType = TokenCredentialType.UserProvidedAccessToken;
                            authContext.ContextScope = ContextScope.Process;
                            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache(Encoding.UTF8.GetBytes(AccessToken.ConvertToString()));
                        }
                        break;
                }

                try
                {
                    GraphSession.Instance.AuthContext = await AuthenticationHelpers.AuthenticateAsync(authContext, _cancellationTokenSource.Token).ConfigureAwait(false);
                }
                catch (Exception)
                {
                    // Reset session instance on error. This will allow the user to re-authenticate without holding on to the previous auth context.
                    await AuthenticationHelpers.LogoutAsync();
                    throw;
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
        private static string[] ProcessScopes(string[] scopes)
        {
            if (scopes is null)
                return Array.Empty<string>();

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
                case Constants.AppCertificateParameterSet:
                    {
                        // Client Id
                        if (string.IsNullOrEmpty(ClientId))
                            this.ThrowParameterError(nameof(ClientId));

                        // Certificate thumbprint, subject name or actual Certificate
                        if (string.IsNullOrEmpty(CertificateThumbprint) && string.IsNullOrEmpty(CertificateSubjectName) && Certificate == null)
                            this.ThrowParameterError($"{nameof(CertificateThumbprint)} or {nameof(CertificateSubjectName)} or {nameof(Certificate)}");

                        // A thumbprint will always have 40 characters since thumbprints are dynamically calculated as a SHA-1 hash of a certificate's binary data. A SHA-1 hash has a length of 40 hexadecimal numbers (160-bit = 20-byte).
                        // See https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509certificate2.thumbprint?view=net-5.0#remarks.
                        if (!string.IsNullOrEmpty(CertificateThumbprint) && CertificateThumbprint.Length != 40)
                            this.ThrowError(string.Format(ErrorConstants.Message.InvalidCertificateThumbprint, nameof(CertificateThumbprint)), ErrorCategory.InvalidArgument);

                        // Tenant Id
                        if (string.IsNullOrEmpty(TenantId))
                            this.ThrowParameterError(nameof(TenantId));
                    }
                    break;
                case Constants.AccessTokenParameterSet:
                    {
                        // AccessToken
                        if (AccessToken.Length < 1)
                            this.ThrowParameterError(nameof(AccessToken));
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