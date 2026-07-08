// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Azure.Core;
using Azure.Core.Diagnostics;
using Azure.Identity;
using Azure.Identity.Broker;
using Microsoft.Graph.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.Extensions;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Broker;
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
            //There is need for explicitly adding TenantId to the TokenCredentialOptions for EnvironmentCredential due to stricter security requirements.
            authContext.TenantId = EnvironmentVariables.TenantId;
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
            return !string.IsNullOrEmpty(EnvironmentVariables.Username) && !string.IsNullOrEmpty(EnvironmentVariables.Password)
                && string.IsNullOrEmpty(EnvironmentVariables.ClientSecret) && string.IsNullOrEmpty(EnvironmentVariables.ClientCertificatePath);
        }

        private static bool ShouldUseWam(IAuthContext authContext)
        {
            return SharedUtilities.IsWindowsPlatform() && authContext.WamEnabled;
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
            var interactiveOptions = ShouldUseWam(authContext) ? new InteractiveBrowserCredentialBrokerOptions(WindowHandleUtlities.GetConsoleOrTerminalWindow()) : new InteractiveBrowserCredentialOptions();
            interactiveOptions.ClientId = authContext.ClientId;
            interactiveOptions.TenantId = authContext.TenantId ?? "common";
            interactiveOptions.AuthorityHost = new Uri(GetAuthorityUrl(authContext));
            interactiveOptions.TokenCachePersistenceOptions = GetTokenCachePersistenceOptions(authContext);

            if (!File.Exists(Constants.AuthRecordPath))
            {
                AuthenticationRecord authRecord;
                var interactiveBrowserCredential = new InteractiveBrowserCredential(interactiveOptions);
                if (ShouldUseWam(authContext))
                {
                    GraphSession.Instance.OutputWriter.WriteWarning("Note: Sign in by Web Account Manager (WAM) is enabled by default on Windows. If using an embedded terminal, the interactive browser window may be hidden behind other windows.");
                    authRecord = await Task.Run(() =>
                    {
                        return interactiveBrowserCredential.Authenticate(new TokenRequestContext(authContext.Scopes), cancellationToken);
                    });
                }
                else
                {
                    authRecord = await Task.Run(() =>
                    {
                        return interactiveBrowserCredential.AuthenticateAsync(new TokenRequestContext(authContext.Scopes), cancellationToken);
                    });
                }
                await WriteAuthRecordAsync(authRecord).ConfigureAwait(false);
                authContext.HomeAccountId = TryGetHomeAccountId(authRecord);
                return interactiveBrowserCredential;
            }

            var interactiveAuthRecord = await ReadAuthRecordAsync().ConfigureAwait(false);
            interactiveOptions.AuthenticationRecord = interactiveAuthRecord;
            authContext.HomeAccountId = TryGetHomeAccountId(interactiveAuthRecord);
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
                    if (GraphSession.Exists)
                    {
                        try
                        {
                            GraphSession.Instance.OutputWriter.WriteObject(code.Message);
                            return Task.CompletedTask;
                        }
                        catch (InvalidOperationException)
                        {
                            // Fall through to console output if OutputWriter is unavailable.
                        }
                    }
                    Console.WriteLine(code.Message);
                    return Task.CompletedTask;
                }
            };
            if (!File.Exists(Constants.AuthRecordPath))
            {
                var deviceCodeCredential = new DeviceCodeCredential(deviceCodeOptions);
                var authRecord = await deviceCodeCredential.AuthenticateAsync(new TokenRequestContext(authContext.Scopes), cancellationToken).ConfigureAwait(false);
                await WriteAuthRecordAsync(authRecord).ConfigureAwait(false);
                authContext.HomeAccountId = TryGetHomeAccountId(authRecord);
                return deviceCodeCredential;
            }

            var deviceCodeAuthRecord = await ReadAuthRecordAsync().ConfigureAwait(false);
            deviceCodeOptions.AuthenticationRecord = deviceCodeAuthRecord;
            authContext.HomeAccountId = TryGetHomeAccountId(deviceCodeAuthRecord);
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
            var tokenCredential = await GetTokenCredentialAsync(authContext, default).ConfigureAwait(false);
            return new AzureIdentityAccessTokenProvider(credential:tokenCredential, observabilityOptions: null,isCaeEnabled: true,scopes: GetScopes(authContext));
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

        internal static async Task<IAuthContext> SignInAsync(IAuthContext authContext, CancellationToken cancellationToken = default, TokenCredential tokenCredential = null)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            tokenCredential ??= await GetTokenCredentialAsync(authContext, cancellationToken).ConfigureAwait(false);
            // Use isCaeEnabled: true to match the TokenRequestContext that AzureIdentityAccessTokenProvider will use
            // during API calls, ensuring MSAL caches a CAE-capable token that can be found silently later.
            var token = await tokenCredential.GetTokenAsync(new TokenRequestContext(GetScopes(authContext), isCaeEnabled: true), cancellationToken).ConfigureAwait(false);
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
        /// <param name="signOutFromBroker">
        /// When <c>true</c> and the Windows broker (WAM) is in use, cached accounts for this module
        /// are also removed from the broker. This affects the shared OS-level broker store and may
        /// sign the user out of other broker-enabled applications using the same Windows account.
        /// </param>
        /// <returns>The <see cref="IAuthContext"/> that was signed out from.</returns>
        public static async Task<IAuthContext> LogoutAsync(bool signOutFromBroker = false)
        {
            var authContext = GraphSession.Instance.AuthContext;
            GraphSession.Instance.InMemoryTokenCache?.ClearCache();

            // Identify the account that signed in for this session so cache clearing can be scoped to
            // it. Prefer the HomeAccountId captured on the session's auth context (set at sign-in) for
            // correct isolation when multiple identities share the per-user persisted store. Fall back
            // to the persisted auth record, then to clearing all accounts when neither is available.
            var homeAccountId = !string.IsNullOrEmpty(authContext?.HomeAccountId)
                ? authContext.HomeAccountId
                : await GetCurrentHomeAccountIdAsync().ConfigureAwait(false);

            if (authContext?.ContextScope == ContextScope.CurrentUser)
            {
                try
                {
                    await TokenCacheUtilities.ClearPersistedTokenCacheAsync(
                        Constants.CacheName,
                        authContext.ClientId,
                        GetAuthorityUrl(authContext),
                        homeAccountId).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Non-fatal: persisted cache clearing may fail on some platforms.
                    // The auth record and in-memory state are still cleared below.
                    LogCacheClearFailure("Failed to clear the persisted MSAL token cache during Disconnect-MgGraph", ex);
                }
            }

            if (signOutFromBroker && authContext != null && ShouldUseWam(authContext))
            {
                try
                {
                    await ClearBrokerTokenCacheAsync(authContext, homeAccountId).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Non-fatal: removing broker accounts may fail. Disconnect still completes.
                    LogCacheClearFailure("Failed to remove cached accounts from the Windows broker (WAM) during Disconnect-MgGraph", ex);
                }
            }

            GraphSession.Instance.AuthContext = null;
            GraphSession.Instance.GraphHttpClient = null;
            await DeleteAuthRecordAsync().ConfigureAwait(false);
            return authContext;
        }

        /// <summary>
        /// Removes cached accounts for the current module from the Windows broker (WAM).
        /// This only has an effect on Windows when the broker is in use. Because the broker store is
        /// shared at the OS level, removing accounts here may also sign the user out of other
        /// broker-enabled applications (for example Visual Studio, Azure CLI, or Azure PowerShell)
        /// that are using the same Windows account.
        /// </summary>
        /// <summary>
        /// Removes cached accounts for the current module from the Windows broker (WAM).
        /// This only has an effect on Windows when the broker is in use. When the current session's
        /// account can be identified (via the persisted <see cref="AuthenticationRecord"/>), only that
        /// account is removed to limit the impact on other broker-enabled applications. When no account
        /// can be identified, all accounts for this module are removed as a fallback.
        /// Because the broker store is shared at the OS level, removing an account here may also sign
        /// the user out of other broker-enabled applications (for example Visual Studio, Azure CLI, or
        /// Azure PowerShell) that are using the same Windows account.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> whose broker accounts should be removed.</param>
        /// <param name="homeAccountId">
        /// The HomeAccountId of the current session's account, used to scope removal to that account.
        /// When <c>null</c> or empty, all accounts for the module are removed as a fallback.
        /// </param>
        private static async Task ClearBrokerTokenCacheAsync(IAuthContext authContext, string homeAccountId)
        {
            if (authContext is null)
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);

            var pca = PublicClientApplicationBuilder
                .Create(authContext.ClientId)
                .WithAuthority(GetAuthorityUrl(authContext))
                .WithBroker(new BrokerOptions(BrokerOptions.OperatingSystems.Windows))
                .WithParentActivityOrWindow(WindowHandleUtlities.GetConsoleOrTerminalWindow)
                .Build();

            var accounts = await pca.GetAccountsAsync().ConfigureAwait(false);

            // Narrow removal to the account that signed in for this session, identified by the
            // HomeAccountId persisted in the AuthenticationRecord. This avoids removing other accounts
            // the user may have signed into via this module from the shared broker store.
            if (!string.IsNullOrEmpty(homeAccountId))
            {
                var matchingAccounts = accounts
                    .Where(a => string.Equals(a.HomeAccountId?.Identifier, homeAccountId, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                if (matchingAccounts.Count > 0)
                {
                    foreach (var account in matchingAccounts)
                    {
                        await pca.RemoveAsync(account).ConfigureAwait(false);
                    }
                    return;
                }
            }

            // Fallback: no identifiable session account, remove all accounts for this module.
            foreach (var account in accounts)
            {
                await pca.RemoveAsync(account).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Reads the HomeAccountId of the account persisted for the current session, if any.
        /// Returns <c>null</c> when no authentication record is available or it cannot be read.
        /// </summary>
        private static async Task<string> GetCurrentHomeAccountIdAsync()
        {
            try
            {
                var authRecord = await ReadAuthRecordAsync().ConfigureAwait(false);
                return TryGetHomeAccountId(authRecord);
            }
            catch
            {
                // A missing or unreadable auth record simply means we cannot narrow the removal.
                return null;
            }
        }

        /// <summary>
        /// Safely reads the HomeAccountId from an <see cref="AuthenticationRecord"/>. Capturing this
        /// diagnostic identifier must never fail sign-in, so any error yields <c>null</c>.
        /// </summary>
        private static string TryGetHomeAccountId(AuthenticationRecord authRecord)
        {
            try
            {
                return authRecord?.HomeAccountId;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Writes a best-effort diagnostic for a non-fatal cache clearing failure. Logging must never
        /// prevent Disconnect-MgGraph from completing, so any failure to log is swallowed.
        /// </summary>
        private static void LogCacheClearFailure(string summary, Exception ex)
        {
            try
            {
                var writer = GraphSession.Instance.OutputWriter;
                writer.WriteWarning?.Invoke($"{summary}: {ex.Message}");
                writer.WriteDebug?.Invoke($"{summary}: {ex}");
            }
            catch
            {
                // Diagnostics are best-effort and must not break sign-out.
            }
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
}