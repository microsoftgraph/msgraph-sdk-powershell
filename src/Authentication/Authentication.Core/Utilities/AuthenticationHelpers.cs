// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    using Azure.Core;
    using Azure.Identity;
    using Microsoft.Graph.PowerShell.Authentication.Core;
    using Microsoft.Graph.PowerShell.Authentication.TokenCache;
    using Microsoft.Identity.Client;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Threading.Tasks;

    using AuthenticationException = System.Security.Authentication.AuthenticationException;

    /// <summary>
    /// Helper class for authentication.
    /// </summary>
    public static class AuthenticationHelpers
    {
        static ReaderWriterLockSlim _cacheLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);

        /// <summary>
        /// Signs out of the current session using the provided <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to sign-out from.</param>
        public static void Logout(IAuthContext authContext)
        {
            try
            {
                _cacheLock.EnterWriteLock();
                if (authContext.AuthType == AuthenticationType.UserProvidedAccessToken)
                {
                    GraphSession.Instance.UserProvidedToken = null;
                }
                else
                {
                    TokenCacheStorage.DeleteToken(authContext);
                }
            }
            finally
            {
                _cacheLock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Gets a <see cref="TokenCredential"/> using the provide <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to get a token credential for.</param>
        /// <returns>A <see cref="TokenCredential"/> based on provided <see cref="IAuthContext"/>.</returns>
        public static async Task<TokenCredential> GetTokenCredentialAsync(IAuthContext authContext)
        {
            if (authContext is null)
            {
                throw new AuthenticationException(ErrorConstants.Message.MissingAuthContext);
            }

            Uri authorityUri = new Uri(GetAuthorityUrl(authContext));
            switch (authContext.AuthType)
            {
                case AuthenticationType.Delegated:
                    var authRecord = await GetAuthenticationRecordAsync(authContext).ConfigureAwait(false);
                    if (authContext.AuthProviderType == AuthProviderType.InteractiveAuthenticationProvider)
                    {
                        var interactiveOptions = new InteractiveBrowserCredentialOptions
                        {
                            AuthorityHost = authorityUri,
                            TokenCachePersistenceOptions = new TokenCachePersistenceOptions { Name = authContext.ClientId },
                            AuthenticationRecord = authRecord
                        };
                        var interactiveBrowserCredential = new InteractiveBrowserCredential(authContext.TenantId, authContext.ClientId, interactiveOptions);
                        return interactiveBrowserCredential;
                    }
                    else
                    {
                        Func<DeviceCodeInfo, CancellationToken, Task> callback = (code, cancellation) =>
                        {
                            GraphSession.Instance.OutputWriter.WriteObject(code.Message);
                            return Task.CompletedTask;
                        };
                        var deviceCodeOptions = new DeviceCodeCredentialOptions
                        {
                            AuthorityHost = authorityUri,
                            TokenCachePersistenceOptions = new TokenCachePersistenceOptions { Name = authContext.ClientId },
                            AuthenticationRecord = authRecord
                        };
                        var deviceCodeCredential = new DeviceCodeCredential(callback, authContext.TenantId, authContext.ClientId, deviceCodeOptions);
                        return deviceCodeCredential;
                    }
                case AuthenticationType.AppOnly:
                    var clientCredentialOptions = new ClientCertificateCredentialOptions
                    {
                        AuthorityHost = authorityUri,
                        TokenCachePersistenceOptions = new TokenCachePersistenceOptions { Name = authContext.ClientId }
                    };
                    var clientCertificateCredential = new ClientCertificateCredential(authContext.TenantId, authContext.ClientId, GetCertificate(authContext), clientCredentialOptions);
                    return clientCertificateCredential;
                case AuthenticationType.UserProvidedAccessToken:
                    var userProvidedTokenCredential = new UserProvidedTokenCredential(new NetworkCredential(string.Empty, GraphSession.Instance.UserProvidedToken));
                    return userProvidedTokenCredential;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Gets a <see cref="IAuthenticationProvider"/> using the provided <see cref="IAuthContext"/>
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to get a token credential for.</param>
        /// <returns>A <see cref="IAuthenticationProvider"/> based on provided <see cref="IAuthContext"/>.</returns>
        public static IAuthenticationProvider GetAuthenticationProvider(IAuthContext authContext)
        {
            return new TokenCredentialAuthProvider(GetTokenCredentialAsync(authContext).GetAwaiter().GetResult(), authContext.Scopes);
        }

        private static async Task<AuthenticationRecord> GetAuthenticationRecordAsync(IAuthContext authContext)
        {
            string tokenCacheFilePath = Path.Combine(Constants.GraphDirectoryPath, authContext.ClientId);
            if (File.Exists(tokenCacheFilePath))
            {
                using (var authRecordStream = new FileStream(tokenCacheFilePath, FileMode.Open, FileAccess.Read))
                {
                    return await AuthenticationRecord.DeserializeAsync(authRecordStream).ConfigureAwait(false);
                }
            }
            return null;
        }
        /// <summary>
        /// Configures a token cache using the provide <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="tokenCache">MSAL's token cache to configure.</param>
        /// <param name="authContext">The <see cref="IAuthContext"/> to get configure an token cache for.</param>
        private static void ConfigureTokenCache(AuthenticationRecord authRecord, IAuthContext authContext)
        {
            string tokenCacheFilePath = Path.Combine(Constants.GraphDirectoryPath, authContext.ClientId);
            string AUTH_RECORD_PATH = tokenCacheFilePath;
            if (!File.Exists(AUTH_RECORD_PATH))
            {
                using(var authRecordStream = new FileStream(AUTH_RECORD_PATH, FileMode.Create, FileAccess.Write))
                {
                    authRecord.Serialize(authRecordStream);
                }
            }
            else
            {
                // Load the previously serialized AuthenticationRecord from disk and deserialize it.
                using (var authRecordStream = new FileStream(AUTH_RECORD_PATH, FileMode.Open, FileAccess.Read))
                {
                    authRecord = AuthenticationRecord.Deserialize(authRecordStream);
                }

                // Construct a new client with our TokenCachePersistenceOptions with the addition of the AuthenticationRecord property.
                // This tells the credential to use the same token cache in addition to which account to try and fetch from cache when GetToken is called.
                //credential = new InteractiveBrowserCredential(
                //    new InteractiveBrowserCredentialOptions
                //    {
                //        TokenCachePersistenceOptions = new TokenCachePersistenceOptions { Name = TOKEN_CACHE_NAME },
                //        AuthenticationRecord = authRecord
                //    });
            }

            //tokenCache.SetBeforeAccess((TokenCacheNotificationArgs args) =>
            //{
            //    try
            //    {
            //        _cacheLock.EnterReadLock();
            //        args.TokenCache.DeserializeMsalV3(TokenCacheStorage.GetToken(authContext), shouldClearExistingCache: true);
            //    }
            //    finally
            //    {
            //        _cacheLock.ExitReadLock();
            //    }
            //});

            //tokenCache.SetAfterAccess((TokenCacheNotificationArgs args) =>
            //{
            //    if (args.HasStateChanged)
            //    {
            //        try
            //        {
            //            _cacheLock.EnterWriteLock();
            //            TokenCacheStorage.SetToken(authContext, args.TokenCache.SerializeMsalV3());
            //        }
            //        finally
            //        {
            //            _cacheLock.ExitWriteLock();
            //        }
            //    }
            //});
        }

        public static async Task<IAuthContext> AuthenticateAsync(IAuthContext authContext, bool forceRefresh, CancellationToken cancellationToken, Action fallBackWarning = null)
        {
            try
            {
                string tokenCacheFilePath = Path.Combine(Constants.GraphDirectoryPath, authContext.ClientId);
                var requestContext = new TokenRequestContext(authContext.Scopes);
                var tokenCredential = await GetTokenCredentialAsync(authContext).ConfigureAwait(false);
                if (!File.Exists(tokenCacheFilePath) && authContext.AuthType == AuthenticationType.Delegated)
                {
                    AuthenticationRecord authRecord = null;
                    switch (tokenCredential)
                    {
                        case InteractiveBrowserCredential interactiveBrowserCredential:
                            authRecord = await interactiveBrowserCredential.AuthenticateAsync(requestContext, cancellationToken).ConfigureAwait(false);
                            break;
                        case DeviceCodeCredential deviceCodeCredential:
                            authRecord = await deviceCodeCredential.AuthenticateAsync(requestContext, cancellationToken).ConfigureAwait(false);
                            break;
                        default:
                            authRecord = null;
                            break;
                    }
                    if (authRecord != null)
                    {
                        using (var authRecordStream = new FileStream(tokenCacheFilePath, FileMode.Create, FileAccess.Write))
                        {
                            await authRecord.SerializeAsync(authRecordStream).ConfigureAwait(false);
                        }
                    }
                }
                else
                {
                    var token = await tokenCredential.GetTokenAsync(requestContext, cancellationToken).ConfigureAwait(false);
                    IAccount account = null;
                    JwtHelpers.DecodeJWT(token.Token, account, ref authContext);
                }

                // TODO: Update fallback logic. This won't work with Azure Identity.
                //if (authContext.AuthProviderType == AuthProviderType.InteractiveAuthenticationProvider)
                //{
                //    var interactiveProvider = (authProvider as InteractiveAuthenticationProvider).ClientApplication;
                //    //When User is not Interactive, Pre-Emptively Fallback and warn, to DeviceCode
                //    if (!interactiveProvider.IsUserInteractive())
                //    {
                //        authContext.AuthProviderType = AuthProviderType.DeviceCodeProviderFallBack;
                //        fallBackWarning?.Invoke();
                //        var fallBackAuthContext = await AuthenticateAsync(authContext, forceRefresh, cancellationToken, fallBackWarning);
                //        return fallBackAuthContext;
                //    }
                //}

                // Triggers authentication.
                //var requestContext = new TokenRequestContext(authContext.Scopes);
                //var token = await tokenCredential.GetTokenAsync(requestContext, cancellationToken);

                //IAccount account = null;
                // TODO: Figure out how to get IAccount from Azure.Identity.
                //if (tokenCredential != null)
                //{
                //    // Only get accounts when we are using MSAL to get an access token.
                //    IEnumerable<IAccount> accounts = clientApplication.GetAccountsAsync().GetAwaiter().GetResult();
                //    account = accounts.FirstOrDefault();
                //}

                //JwtHelpers.DecodeJWT(token.Token, account, ref authContext);
                return authContext;
            }
            catch (AuthenticationException authEx)
            {
                //Interactive Authentication Failure: Could Not Open Browser, fallback to DeviceAuth
                if (IsUnableToOpenWebPageError(authEx))
                {
                    authContext.AuthProviderType = AuthProviderType.DeviceCodeProviderFallBack;
                    //ReAuthenticate using DeviceCode as fallback.
                    var fallBackAuthContext = await AuthenticateAsync(authContext, forceRefresh, cancellationToken);
                    //Indicate that this was a Fallback
                    if (fallBackWarning != null && fallBackAuthContext.AuthProviderType == AuthProviderType.DeviceCodeProviderFallBack)
                    {
                        fallBackWarning();
                    }
                    return fallBackAuthContext;
                }

                if (authEx.InnerException is TaskCanceledException && cancellationToken.IsCancellationRequested)
                {
                    // Authentication requets timeout.
                    throw new Exception(string.Format(CultureInfo.CurrentCulture, ErrorConstants.Message.DeviceCodeTimeout, Constants.MaxDeviceCodeTimeOut));
                }
                else if (authEx.InnerException is MsalServiceException msalServiceEx
                      && msalServiceEx.StatusCode == 400
                      && msalServiceEx.ErrorCode == "invalid_scope"
                      && string.IsNullOrWhiteSpace(authContext.TenantId)
                      && (authContext.AuthProviderType == AuthProviderType.DeviceCodeProvider
                      || authContext.AuthProviderType == AuthProviderType.DeviceCodeProviderFallBack))
                {
                    // MSAL scope validation error. Ask customer to specify sign-in audience or tenant Id.
                    throw new MsalClientException(msalServiceEx.ErrorCode, $"{msalServiceEx.Message}.\r\n{ErrorConstants.Message.InvalidScope}", msalServiceEx);
                }

                //Something Unknown Went Wrong
                throw authEx.InnerException ?? authEx;
            }
            catch (Exception ex)
            {
                throw ex.InnerException ?? ex;
            }
        }
        /// <summary>
        /// Gets an authority URL from the provided <see cref="IAuthContext"/>.
        /// </summary>
        /// <param name="authContext">The <see cref="IAuthContext"/> to get an authority URL for.</param>
        /// <returns></returns>
        private static string GetAuthorityUrl(IAuthContext authContext)
        {
            string audience = authContext.TenantId ?? Constants.DefaulAdTenant;
            string defaultInstance = Constants.DefaultAzureADEndpoint;
            string authorityUrl = $"{defaultInstance}/{audience}";

            if (GraphSession.Instance.Environment != null)
            {
                authorityUrl = $"{GraphSession.Instance.Environment.AzureADEndpoint}/{audience}";
            }

            return authorityUrl;
        }

        /// <summary>
        /// Gets a certificate based on the current context.
        /// Priority is Name, ThumbPrint, then In-Memory Cert
        /// </summary>
        /// <param name="context">Current <see cref="IAuthContext"/> context</param>
        /// <returns>A <see cref="X509Certificate2"/> based on provided <see cref="IAuthContext"/> context</returns>
        private static X509Certificate2 GetCertificate(IAuthContext context)
        {
            X509Certificate2 certificate;
            if (!string.IsNullOrWhiteSpace(context.CertificateName))
            {
                certificate = GetCertificateByName(context.CertificateName);
            }
            else if (!string.IsNullOrWhiteSpace(context.CertificateThumbprint))
            {
                certificate = GetCertificateByThumbprint(context.CertificateThumbprint);
            }
            else
            {
                certificate = context.Certificate;
            }

            if (certificate == null)
            {
                throw new ArgumentNullException(nameof(certificate), $"Certificate with the Specified ThumbPrint {context.CertificateThumbprint}, Name {context.CertificateName} or In-Memory could not be found");
            }

            return certificate;
        }

        /// <summary>
        /// Gets unexpired certificate of the specified certificate thumbprint for the current user in My store.
        /// </summary>
        /// <param name="certificateThumbprint">Subject name of the certificate to get.</param>
        /// <returns></returns>
        private static X509Certificate2 GetCertificateByThumbprint(string certificateThumbprint)
        {
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

        private static bool IsUnableToOpenWebPageError(Exception exception)
        {
            return exception.InnerException is MsalClientException clientException &&
                   clientException?.ErrorCode == MsalError.LinuxXdgOpen ||
                   (exception.Message?.ToLower()?.Contains("unable to open a web page") ?? false);
        }
    }
}