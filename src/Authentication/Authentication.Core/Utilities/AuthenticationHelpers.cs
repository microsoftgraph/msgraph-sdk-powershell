// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    using Azure.Core;
    using Azure.Identity;
    using Microsoft.Graph.PowerShell.Authentication.Core;
    using Microsoft.Identity.Client;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Threading.Tasks;

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
                    else
                        return await GetDeviceCodeCredentialAsync(authContext, cancellationToken).ConfigureAwait(false);
                case AuthenticationType.AppOnly:
                    return await GetClientCertificateCredentialAsync(authContext).ConfigureAwait(false);
                case AuthenticationType.UserProvidedAccessToken:
                    return new UserProvidedTokenCredential(new NetworkCredential(string.Empty, GraphSession.Instance.UserProvidedToken));
                default:
                    throw new NotSupportedException($"{authContext.AuthType} is not supported.");
            }
        }

        private static async Task<InteractiveBrowserCredential> GetInteractiveBrowserCredentialAsync(IAuthContext authContext, CancellationToken cancellationToken = default)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            var interactiveOptions = new InteractiveBrowserCredentialOptions
            {
                ClientId = authContext.ClientId,
                TenantId = authContext.TenantId,
                AuthorityHost = new Uri(GetAuthorityUrl(authContext)),
                TokenCachePersistenceOptions = GetTokenCachePersistenceOptions(authContext)
            };

            if (!File.Exists(Constants.AuthRecordPath))
            {
                var interactiveBrowserCredential = new InteractiveBrowserCredential(interactiveOptions);
                var authRecord = await interactiveBrowserCredential.AuthenticateAsync(new TokenRequestContext(authContext.Scopes), cancellationToken).ConfigureAwait(false);
                await WriteAuthRecordAsync(authRecord).ConfigureAwait(false);
                return interactiveBrowserCredential;
            }
            else
            {
                interactiveOptions.AuthenticationRecord = await ReadAuthRecordAsync().ConfigureAwait(false);
                return new InteractiveBrowserCredential(interactiveOptions);
            }
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
                var authRecord = await deviceCodeCredential.AuthenticateAsync(new TokenRequestContext(authContext.Scopes), cancellationToken);
                await WriteAuthRecordAsync(authRecord).ConfigureAwait(false);
                return deviceCodeCredential;
            }
            else
            {
                deviceCodeOptions.AuthenticationRecord = await ReadAuthRecordAsync().ConfigureAwait(false);
                return new DeviceCodeCredential(deviceCodeOptions);
            }
        }

        private static async Task<ClientCertificateCredential> GetClientCertificateCredentialAsync(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            var clientCredentialOptions = new ClientCertificateCredentialOptions
            {
                AuthorityHost = new Uri(GetAuthorityUrl(authContext)),
                TokenCachePersistenceOptions = GetTokenCachePersistenceOptions(authContext)
            };
            var clientCertificateCredential = new ClientCertificateCredential(authContext.TenantId, authContext.ClientId, GetCertificate(authContext), clientCredentialOptions);
            return await Task.FromResult(clientCertificateCredential);
        }

        private static TokenCachePersistenceOptions GetTokenCachePersistenceOptions(IAuthContext authContext)
        {
            if (authContext.ContextScope == ContextScope.Process)
                return GraphSession.Instance.InMemoryTokenCache.GetTokenCachePersistenceOptions();
            else
                return new TokenCachePersistenceOptions { Name = Constants.CacheName };
        }

        /// <summary>
        /// Gets a <see cref="IAuthenticationProvider"/> using the provided <see cref="IAuthContext"/>
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to get a token credential for.</param>
        /// <returns>A <see cref="IAuthenticationProvider"/> based on provided <see cref="IAuthContext"/>.</returns>
        public static IAuthenticationProvider GetAuthenticationProvider(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            return new TokenCredentialAuthProvider(GetTokenCredentialAsync(authContext, default).GetAwaiter().GetResult(), GetScopes(authContext));
        }

        public static async Task<IAuthContext> AuthenticateAsync(IAuthContext authContext, CancellationToken cancellationToken = default)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            try
            {
                var tokenCredential = await GetTokenCredentialAsync(authContext, cancellationToken);
                var token = await tokenCredential.GetTokenAsync(new TokenRequestContext(GetScopes(authContext)), cancellationToken).ConfigureAwait(false);
                JwtHelpers.DecodeJWT(token.Token, null, ref authContext);
                return authContext;
            }
            catch (AuthenticationFailedException authEx)
            {
                switch (authEx.InnerException)
                {
                    case MsalClientException msalClientEx:
                        if (msalClientEx.ErrorCode == MsalError.LinuxXdgOpen)
                        {
                            // Retry with device code authentication.
                            authContext.TokenCredentialType = TokenCredentialType.DeviceCode;
                            return await AuthenticateAsync(authContext, cancellationToken);
                        }
                        break;
                    case MsalServiceException msalServiceEx:
                        if (msalServiceEx.StatusCode == 400 && msalServiceEx.ErrorCode == "invalid_scope"
                            && string.IsNullOrWhiteSpace(authContext.TenantId)
                            && authContext.TokenCredentialType == TokenCredentialType.DeviceCode)
                        {
                            // MSAL scope validation error. Ask customer to specify sign-in audience or tenant Id.
                            throw new MsalClientException(msalServiceEx.ErrorCode, $"{msalServiceEx.Message}.\r\n{ErrorConstants.Message.InvalidScope}", msalServiceEx);
                        }
                        break;
                    case TaskCanceledException taskCanceledEx:
                        throw new Exception(string.Format(CultureInfo.CurrentCulture, ErrorConstants.Message.AuthenticationTimeout, Constants.MaxAuthenticationTimeOut), taskCanceledEx);
                }
                throw authEx;
            }
            catch (Exception ex)
            {
                throw ex.InnerException ?? ex;
            }
        }

        private static string[] GetScopes(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            if (authContext.AuthType == AuthenticationType.AppOnly)
                return new[] { $"{GraphSession.Instance.Environment?.GraphEndpoint ?? Constants.DefaultGraphEndpoint}/.default" };
            else
                return authContext.Scopes;
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
            string audience = authContext.TenantId ?? Constants.DefaulAdTenant;
            if (GraphSession.Instance.Environment != null)
                return $"{GraphSession.Instance.Environment.AzureADEndpoint}/{audience}";
            else
                return $"{Constants.DefaultAzureADEndpoint}/{audience}";
        }

        /// <summary>
        /// Gets a certificate based on the current context.
        /// Priority is Name, ThumbPrint, then In-Memory Cert
        /// </summary>
        /// <param name="authContext">Current <see cref="IAuthContext"/> context</param>
        /// <returns>A <see cref="X509Certificate2"/> based on provided <see cref="IAuthContext"/> context</returns>
        private static X509Certificate2 GetCertificate(IAuthContext authContext)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            X509Certificate2 certificate;
            if (!string.IsNullOrWhiteSpace(authContext.CertificateSubjectName))
                certificate = GetCertificateByName(authContext.CertificateSubjectName);
            else if (!string.IsNullOrWhiteSpace(authContext.CertificateThumbprint))
                certificate = GetCertificateByThumbprint(authContext.CertificateThumbprint);
            else
                certificate = authContext.Certificate;

            if (certificate is null)
                throw new ArgumentNullException(nameof(certificate), $"Certificate with the Specified ThumbPrint {authContext.CertificateThumbprint}, Name {authContext.CertificateSubjectName} or In-Memory could not be found");

            return certificate;
        }

        /// <summary>
        /// Gets unexpired certificate of the specified certificate thumbprint for the current user in My store.
        /// </summary>
        /// <param name="certificateThumbprint">Subject name of the certificate to get.</param>
        /// <returns></returns>
        private static X509Certificate2 GetCertificateByThumbprint(string certificateThumbprint)
        {
            // TODO: Perform certificate lookup in both CurrentUser and LocalMachine. LocalMachine takes precedence.
            X509Certificate2 xCertificate = null;
            using (X509Store xStore = new X509Store(StoreName.My, StoreLocation.CurrentUser))
            {
                xStore.Open(OpenFlags.ReadOnly);

                // Get unexpired certificates with the specified name.
                X509Certificate2Collection unexpiredCerts = xStore.Certificates
                    .Find(X509FindType.FindByTimeValid, DateTime.Now, false)
                    .Find(X509FindType.FindByThumbprint, certificateThumbprint, false);

                if (unexpiredCerts.Count < 1)
                    throw new Exception($"{certificateThumbprint} certificate was not found or has expired.");

                // Only return current cert.
                xCertificate = unexpiredCerts
                    .OfType<X509Certificate2>()
                    .OrderByDescending(c => c.NotBefore)
                    .FirstOrDefault();
            }
            return xCertificate;
        }

        /// <summary>
        /// Gets unexpired certificate of the specified certificate subject name for the current user in My store.
        /// </summary>
        /// <param name="certificateName">Subject name of the certificate to get.</param>
        /// <returns></returns>
        private static X509Certificate2 GetCertificateByName(string certificateName)
        {
            // TODO: Perform certificate lookup in both CurrentUser and LocalMachine. LocalMachine takes precedence.
            X509Certificate2 xCertificate = null;
            using (X509Store xStore = new X509Store(StoreName.My, StoreLocation.CurrentUser))
            {
                xStore.Open(OpenFlags.ReadOnly);

                // Get unexpired certificates with the specified name.
                X509Certificate2Collection unexpiredCerts = xStore.Certificates
                    .Find(X509FindType.FindByTimeValid, DateTime.Now, false)
                    .Find(X509FindType.FindBySubjectDistinguishedName, certificateName, false);

                if (unexpiredCerts.Count < 1)
                    throw new Exception($"{certificateName} certificate was not found or has expired.");

                // Only return current cert.
                xCertificate = unexpiredCerts
                    .OfType<X509Certificate2>()
                    .OrderByDescending(c => c.NotBefore)
                    .FirstOrDefault();
            }
            return xCertificate;
        }

        /// <summary>
        /// Signs out of the current session using the provided <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to sign-out from.</param>
        public static async Task LogoutAsync(IAuthContext authContext)
        {
            if (authContext.AuthType == AuthenticationType.UserProvidedAccessToken)
                GraphSession.Instance.UserProvidedToken = null;
            else
            {
                GraphSession.Instance.InMemoryTokenCache.ClearCache();
                await DeleteAuthRecordAsync().ConfigureAwait(false);
            }
        }

        private static async Task<AuthenticationRecord> ReadAuthRecordAsync()
        {
            // Try to create directory if it doesn't exist.
            Directory.CreateDirectory(Constants.GraphDirectoryPath);
            if (!File.Exists(Constants.AuthRecordPath))
                return null;
            using (FileStream authRecordStream = new FileStream(Constants.AuthRecordPath, FileMode.Open, FileAccess.Read))
            {
                return await AuthenticationRecord.DeserializeAsync(authRecordStream);
            }
        }

        public static async Task WriteAuthRecordAsync(AuthenticationRecord authRecord)
        {
            // Try to create directory if it doesn't exist.
            Directory.CreateDirectory(Constants.GraphDirectoryPath);
            using (FileStream authRecordStream = new FileStream(Constants.AuthRecordPath, FileMode.Create, FileAccess.Write))
            {
                await authRecord.SerializeAsync(authRecordStream);
            }
        }

        public static Task DeleteAuthRecordAsync()
        {
            if (File.Exists(Constants.AuthRecordPath))
                File.Delete(Constants.AuthRecordPath);
            return Task.CompletedTask;
        }
    }
}