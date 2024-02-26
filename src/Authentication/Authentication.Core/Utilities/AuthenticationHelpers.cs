// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Azure.Core;
using Azure.Core.Diagnostics;
using Azure.Core.Pipeline;
using Azure.Identity;
using Azure.Identity.Broker;
using Microsoft.Graph.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.Extensions;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    /// <summary>
    /// Helper class for authentication.
    /// </summary>
    public static class AuthenticationHelpers
    {
        /// <summary>
        /// Gets a <see cref="TokenCredential"/> using the provide <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to get a token credential for.</param>
        /// <returns>A <see cref="TokenCredential"/> based on provided <see cref="IAuthContext"/>.</returns>
        public static async Task<TokenCredential> GetTokenCredentialAsync(IAuthContext authContext, CancellationToken cancellationToken = default)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            switch (authContext.AuthType)
            {
                case AuthenticationType.Delegated:
                    if (authContext.TokenCredentialType == TokenCredentialType.InteractiveBrowser)
                        return await GetInteractiveBrowserCredentialAsync(authContext, cancellationToken).ConfigureAwait(false);
                    return await GetDeviceCodeCredentialAsync(authContext, cancellationToken).ConfigureAwait(false);
                case AuthenticationType.AppOnly:
                    return authContext.TokenCredentialType == TokenCredentialType.ClientCertificate
                        ? await GetClientCertificateCredentialAsync(authContext).ConfigureAwait(false)
                        : await GetClientSecretCredentialAsync(authContext).ConfigureAwait(false);
                case AuthenticationType.ManagedIdentity:
                    return await GetManagedIdentityCredentialAsync(authContext).ConfigureAwait(false);
                case AuthenticationType.EnvironmentVariable:
                    return await GetEnvironmentCredentialAsync(authContext).ConfigureAwait(false);
                case AuthenticationType.UserProvidedAccessToken:
                    return new UserProvidedTokenCredential();
                default:
                    throw new NotSupportedException($"{authContext.AuthType} is not supported.");
            }
        }

        private static async Task<TokenCredential> GetEnvironmentCredentialAsync(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            var tokenCredentialOptions = new TokenCredentialOptions
            {
                AuthorityHost = new Uri(GetAuthorityUrl(authContext))
            };

            if (IsAuthFlowNotSupported())
            {
                throw new Exception(string.Format(CultureInfo.InvariantCulture, ErrorConstants.Message.AuthNotSupported, "Username and password"));
            }

            var environmentCredential = new EnvironmentCredential(tokenCredentialOptions);
            return await Task.FromResult(environmentCredential).ConfigureAwait(false);
        }

        private static bool IsAuthFlowNotSupported()
        {
            return ((!string.IsNullOrEmpty(EnvironmentVariables.Username) && !string.IsNullOrEmpty(EnvironmentVariables.Password))
                && (string.IsNullOrEmpty(EnvironmentVariables.ClientSecret) && string.IsNullOrEmpty(EnvironmentVariables.ClientCertificatePath)));
        }

        private static bool IsWamSupported()
        {
            return GraphSession.Instance.GraphOption.EnableWAMForMSGraph && SharedUtilities.IsWindowsPlatform();
        }

        //Check to see if ATPoP is Supported
        private static bool IsATPoPSupported()
        {
            return GraphSession.Instance.GraphOption.EnableATPoPForMSGraph;
        }

        private static async Task<TokenCredential> GetClientSecretCredentialAsync(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            var clientSecretCredentialOptions = new ClientSecretCredentialOptions
            {
                AuthorityHost = new Uri(GetAuthorityUrl(authContext)),
                TokenCachePersistenceOptions = GetTokenCachePersistenceOptions(authContext)
            };
            var clientSecretCredential = new ClientSecretCredential(authContext.TenantId, authContext.ClientId, authContext.ClientSecret.ConvertToString(), clientSecretCredentialOptions);
            return await Task.FromResult(clientSecretCredential).ConfigureAwait(false);
        }

        private static async Task<TokenCredential> GetManagedIdentityCredentialAsync(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            var userAccountId = authContext.ManagedIdentityId.StartsWith(Constants.DefaultMsiIdPrefix) ? null : authContext.ManagedIdentityId;
            return await Task.FromResult(new ManagedIdentityCredential(userAccountId)).ConfigureAwait(false);
        }

        private static async Task<InteractiveBrowserCredential> GetInteractiveBrowserCredentialAsync(IAuthContext authContext, CancellationToken cancellationToken = default)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            var interactiveOptions = IsWamSupported() ? new InteractiveBrowserCredentialBrokerOptions(WindowHandleUtlities.GetConsoleOrTerminalWindow()) : new InteractiveBrowserCredentialOptions();
            interactiveOptions.ClientId = authContext.ClientId;
            interactiveOptions.TenantId = authContext.TenantId ?? "common";
            interactiveOptions.AuthorityHost = new Uri(GetAuthorityUrl(authContext));
            interactiveOptions.TokenCachePersistenceOptions = GetTokenCachePersistenceOptions(authContext);

            if (!File.Exists(Constants.AuthRecordPath))
            {
                AuthenticationRecord authRecord;
                var interactiveBrowserCredential = new InteractiveBrowserCredential(interactiveOptions);
                if (IsWamSupported())
                {
                    // Adding a scenario to account for Access Token Proof of Possession
                    if (IsATPoPSupported())
                    {
                        // Logic to implement ATPoP Authentication
                        authRecord = await Task.Run(() =>
                        {
                            var popTokenAuthenticationPolicy = new PopTokenAuthenticationPolicy(interactiveBrowserCredential as ISupportsProofOfPossession, $"https://graph.microsoft.com/.default");

                            var pipelineOptions = new HttpPipelineOptions(new PopClientOptions()
                            {
                                Diagnostics = 
                                {
                                    IsLoggingContentEnabled = true,
                                    LoggedHeaderNames = { "Authorization" }
                                },
                            });
                            pipelineOptions.PerRetryPolicies.Add(popTokenAuthenticationPolicy);

                            var _pipeline = HttpPipelineBuilder.Build(pipelineOptions, new HttpPipelineTransportOptions { ServerCertificateCustomValidationCallback = (_) => true });
                            using var request = _pipeline.CreateRequest();
                            request.Method = RequestMethod.Get;
                            request.Uri.Reset(new Uri("https://20.190.132.47/beta/me"));
                            var response = _pipeline.SendRequest(request, cancellationToken);
                            var message = new HttpMessage(request, new ResponseClassifier());

                            // Manually invoke the authentication policy's process method
                            popTokenAuthenticationPolicy.ProcessAsync(message, ReadOnlyMemory<HttpPipelinePolicy>.Empty);
                            // Run the thread in MTA.
                            return interactiveBrowserCredential.Authenticate(new TokenRequestContext(authContext.Scopes), cancellationToken);
                        });
                    }
                    else
                    {
                        authRecord = await Task.Run(() =>
                        {
                            // Run the thread in MTA.
                            return interactiveBrowserCredential.Authenticate(new TokenRequestContext(authContext.Scopes), cancellationToken);
                        });
                    }
                }
                else
                {
                    authRecord = await Task.Run(() =>
                    {
                        // Run the thread in MTA.
                        return interactiveBrowserCredential.AuthenticateAsync(new TokenRequestContext(authContext.Scopes), cancellationToken);
                    });
                }
                await WriteAuthRecordAsync(authRecord).ConfigureAwait(false);
                return interactiveBrowserCredential;
            }

            interactiveOptions.AuthenticationRecord = await ReadAuthRecordAsync().ConfigureAwait(false);
            return new InteractiveBrowserCredential(interactiveOptions);
        }

        private static async Task<DeviceCodeCredential> GetDeviceCodeCredentialAsync(IAuthContext authContext, CancellationToken cancellationToken = default)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            var deviceCodeOptions = new DeviceCodeCredentialOptions
            {
                ClientId = authContext.ClientId,
                TenantId = authContext.TenantId,
                AuthorityHost = new Uri(GetAuthorityUrl(authContext)),
                TokenCachePersistenceOptions = GetTokenCachePersistenceOptions(authContext),
                DeviceCodeCallback = (code, cancellation) =>
                {
                    GraphSession.Instance.OutputWriter.WriteObject(code.Message);
                    return Task.CompletedTask;
                }
            };
            if (!File.Exists(Constants.AuthRecordPath))
            {
                var deviceCodeCredential = new DeviceCodeCredential(deviceCodeOptions);
                var authRecord = await deviceCodeCredential.AuthenticateAsync(new TokenRequestContext(authContext.Scopes), cancellationToken).ConfigureAwait(false);
                await WriteAuthRecordAsync(authRecord).ConfigureAwait(false);
                return deviceCodeCredential;
            }

            deviceCodeOptions.AuthenticationRecord = await ReadAuthRecordAsync().ConfigureAwait(false);
            return new DeviceCodeCredential(deviceCodeOptions);
        }

        private static async Task<ClientCertificateCredential> GetClientCertificateCredentialAsync(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            var clientCredentialOptions = new ClientCertificateCredentialOptions
            {
                AuthorityHost = new Uri(GetAuthorityUrl(authContext)),
                TokenCachePersistenceOptions = GetTokenCachePersistenceOptions(authContext),
                SendCertificateChain = authContext.SendCertificateChain
            };
            var clientCertificateCredential = new ClientCertificateCredential(authContext.TenantId, authContext.ClientId, GetCertificate(authContext), clientCredentialOptions);
            return await Task.FromResult(clientCertificateCredential).ConfigureAwait(false);
        }

        private static TokenCachePersistenceOptions GetTokenCachePersistenceOptions(IAuthContext authContext)
        {
            return authContext.ContextScope == ContextScope.Process
                ? GraphSession.Instance.InMemoryTokenCache.GetTokenCachePersistenceOptions()
                : new TokenCachePersistenceOptions { Name = Constants.CacheName };
        }

        /// <summary>
        /// Gets a <see cref="AzureIdentityAccessTokenProvider"/> using the provided <see cref="IAuthContext"/>
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to get a token credential for.</param>
        /// <returns>A <see cref="AzureIdentityAccessTokenProvider"/> based on provided <see cref="IAuthContext"/>.</returns>
        public static async Task<AzureIdentityAccessTokenProvider> GetAuthenticationProviderAsync(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            var tokenCrdential = await GetTokenCredentialAsync(authContext, default).ConfigureAwait(false);
            return new AzureIdentityAccessTokenProvider(credential: tokenCrdential, scopes: GetScopes(authContext));
        }

        public static async Task<IAuthContext> AuthenticateAsync(IAuthContext authContext, CancellationToken cancellationToken)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            IAuthContext signInAuthContext = null;
            bool retrySignIn = true;
            int retryCount = 0;
            while (retrySignIn && retryCount <= Constants.MaxAuthRetry)
            {
                try
                {
                    // Write MSAL logs to debug stream.
                    using (AzureEventSourceListener listener = new AzureEventSourceListener(
                        (args, message) => GraphSession.Instance.OutputWriter.WriteDebug($"{message}"),
                        level: EventLevel.Informational))
                    {
                        signInAuthContext = await SignInAsync(authContext, cancellationToken).ConfigureAwait(false);
                        retrySignIn = false;
                    };
                }
                catch (AuthenticationFailedException authEx)
                {
                    if (authEx.InnerException is MsalCachePersistenceException)
                    {
                        // Can't securely persist token on disk. Retry with in-memory cache.
                        authContext.ContextScope = ContextScope.Process;
                        retrySignIn = true;
                        retryCount++;
                    }
                    else if (authEx.InnerException is MsalClientException msalClientEx
                        && string.Equals(msalClientEx?.ErrorCode, MsalError.LinuxXdgOpen, StringComparison.InvariantCultureIgnoreCase) ||
                        (authEx.Message?.ToLower(CultureInfo.InvariantCulture)?.Contains("unable to open a web page") ?? false))
                    {
                        // Can't open browser. Retry with device code authentication.
                        authContext.TokenCredentialType = TokenCredentialType.DeviceCode;
                        retrySignIn = true;
                        retryCount++;
                    }
                    else if (authEx.InnerException is MsalServiceException msalServiceEx
                        && msalServiceEx.StatusCode == 400 && string.Equals(msalServiceEx.ErrorCode, "invalid_scope", StringComparison.InvariantCultureIgnoreCase)
                        && string.IsNullOrWhiteSpace(authContext.TenantId)
                        && authContext.TokenCredentialType == TokenCredentialType.DeviceCode)
                    {
                        // MSAL scope validation error. Ask customer to specify sign-in audience or tenant Id.
                        throw new MsalClientException(msalServiceEx.ErrorCode, $"{msalServiceEx.Message}.\r\n{ErrorConstants.Message.InvalidScope}", msalServiceEx);
                    }
                    else
                        throw;
                }
                catch (TaskCanceledException taskCanceledEx)
                {
                    throw new Exception(string.Format(CultureInfo.CurrentCulture, ErrorConstants.Message.AuthenticationTimeout, Constants.MaxAuthenticationTimeOutInSeconds), taskCanceledEx);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return signInAuthContext;
        }

        private static async Task<IAuthContext> SignInAsync(IAuthContext authContext, CancellationToken cancellationToken = default)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            var tokenCredential = await GetTokenCredentialAsync(authContext, cancellationToken).ConfigureAwait(false);
            var token = await tokenCredential.GetTokenAsync(new TokenRequestContext(GetScopes(authContext)), cancellationToken).ConfigureAwait(false);
            JwtHelpers.DecodeJWT(token.Token, account: null, ref authContext);
            return authContext;
        }

        private static string[] GetScopes(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            switch (authContext.AuthType)
            {
                case AuthenticationType.AppOnly:
                case AuthenticationType.EnvironmentVariable:
                    return new[] { $"{GraphSession.Instance.Environment?.GraphEndpoint ?? Constants.DefaultGraphEndpoint}/.default" };
                case AuthenticationType.ManagedIdentity:
                    return new[] { GraphSession.Instance.Environment.GraphEndpoint };
                default:
                    return authContext.Scopes;
            }
        }

        /// <summary>
        /// Gets an authority URL from the provided <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to get an authority URL for.</param>
        /// <returns></returns>
        private static string GetAuthorityUrl(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            string audience = authContext.TenantId ?? Constants.DefaultTenant;
            return GraphSession.Instance.Environment != null
                ? $"{GraphSession.Instance.Environment.AzureADEndpoint}/{audience}"
                : $"{Constants.DefaultAzureADEndpoint}/{audience}";
        }

        /// <summary>
        /// Gets a certificate based on the current context.
        /// Priority is Name, ThumbPrint, then In-Memory Cert
        /// </summary>
        /// <param name="authContext">Current <see cref="IAuthContext"/> context</param>
        /// <returns>A <see cref="X509Certificate2"/> based on provided <see cref="IAuthContext"/> context</returns>
        /// <returns>A <see cref="X509Certificate2"/> based on provided <see cref="IAuthContext"/> context</returns>
        private static X509Certificate2 GetCertificate(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            if (!string.IsNullOrWhiteSpace(authContext.CertificateSubjectName))
            {
                if (TryFindCertificateBySubjectName(authContext.CertificateSubjectName, StoreLocation.CurrentUser, out X509Certificate2 certificate) ||
                    TryFindCertificateBySubjectName(authContext.CertificateSubjectName, StoreLocation.LocalMachine, out certificate))
                    return certificate;
                else
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, ErrorConstants.Message.CertificateNotFound,
                        "subject name",
                        authContext.CertificateSubjectName));
            }
            else if (!string.IsNullOrWhiteSpace(authContext.CertificateThumbprint))
            {
                if (TryFindCertificateByThumbprint(authContext.CertificateThumbprint, StoreLocation.CurrentUser, out X509Certificate2 certificate) ||
                    TryFindCertificateByThumbprint(authContext.CertificateThumbprint, StoreLocation.LocalMachine, out certificate))
                    return certificate;
                else
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, ErrorConstants.Message.CertificateNotFound,
                        "thumbprint",
                        authContext.CertificateThumbprint));
            }
            else
                return authContext.Certificate;
        }

        /// <summary>
        /// Gets unexpired certificate using the specified certificate store using the provided thumbprint.
        /// </summary>
        /// <param name="thumbprint">Thumbprint of the certificate to fetch.</param>
        /// <param name="location">The certificate store location.</param>
        /// <param name="certificate">Unexpired certificate.</param>
        private static bool TryFindCertificateByThumbprint(string thumbprint, StoreLocation location, out X509Certificate2 certificate)
        {
            using (X509Store xStore = new X509Store(StoreName.My, location))
            {
                xStore.Open(OpenFlags.ReadOnly);

                // Get unexpired certificates with the specified name.
                X509Certificate2Collection unexpiredCerts = xStore.Certificates
                    .Find(X509FindType.FindByTimeValid, DateTime.Now, validOnly: false)
                    .Find(X509FindType.FindByThumbprint, thumbprint, validOnly: false);

                xStore.Close();

                // Only return current cert.
                certificate = unexpiredCerts
                    .OfType<X509Certificate2>()
                    .OrderByDescending(c => c.NotBefore)
                    .FirstOrDefault();

                return certificate != null;
            }
        }

        /// <summary>
        /// Gets unexpired certificate using the specified certificate store using the provided subject distinguished name.
        /// </summary>
        /// <param name="subjectName">Subject distinguished name of the certificate to fetch.</param>
        /// <param name="location">The certificate store location.</param>
        /// <param name="certificate">Unexpired certificate.</param>
        private static bool TryFindCertificateBySubjectName(string subjectName, StoreLocation location, out X509Certificate2 certificate)
        {
            using (X509Store xStore = new X509Store(StoreName.My, location))
            {
                xStore.Open(OpenFlags.ReadOnly);

                // Get unexpired certificates with the specified name.
                X509Certificate2Collection unexpiredCerts = xStore.Certificates
                    .Find(X509FindType.FindByTimeValid, DateTime.Now, validOnly: false)
                    .Find(X509FindType.FindBySubjectDistinguishedName, subjectName, validOnly: false);

                xStore.Close();

                // Only return current cert.
                certificate = unexpiredCerts
                    .OfType<X509Certificate2>()
                    .OrderByDescending(c => c.NotBefore)
                    .FirstOrDefault();

                return certificate != null;
            }
        }

        /// <summary>
        /// Signs out of the current session using the provided <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to sign-out from.</param>
        public static async Task<IAuthContext> LogoutAsync()
        {
            var authContext = GraphSession.Instance.AuthContext;
            GraphSession.Instance.InMemoryTokenCache?.ClearCache();
            GraphSession.Instance.AuthContext = null;
            GraphSession.Instance.GraphHttpClient = null;
            await DeleteAuthRecordAsync().ConfigureAwait(false);
            return authContext;
        }

        private static async Task<AuthenticationRecord> ReadAuthRecordAsync()
        {
            // Try to create directory if it doesn't exist.
            Directory.CreateDirectory(Constants.GraphDirectoryPath);
            if (!File.Exists(Constants.AuthRecordPath))
                return null;
            using (FileStream authRecordStream = new FileStream(Constants.AuthRecordPath, FileMode.Open, FileAccess.Read))
                return await AuthenticationRecord.DeserializeAsync(authRecordStream).ConfigureAwait(false);
        }

        public static async Task WriteAuthRecordAsync(AuthenticationRecord authRecord)
        {
            // Try to create directory if it doesn't exist.
            Directory.CreateDirectory(Constants.GraphDirectoryPath);
            using (FileStream authRecordStream = new FileStream(Constants.AuthRecordPath, FileMode.Create, FileAccess.Write))
                await authRecord.SerializeAsync(authRecordStream).ConfigureAwait(false);
        }

        public static Task DeleteAuthRecordAsync()
        {
            if (File.Exists(Constants.AuthRecordPath))
                File.Delete(Constants.AuthRecordPath);
            return Task.CompletedTask;
        }
    }
    internal class PopClientOptions : ClientOptions
    {
    }
}