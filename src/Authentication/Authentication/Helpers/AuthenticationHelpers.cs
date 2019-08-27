// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using Microsoft.Graph.Auth;
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using Microsoft.Identity.Client;
    using System;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;

    internal static class AuthenticationHelpers
    {
        private static readonly object FileLock = new object();
        private static readonly string UserCacheFileName = "userTokenCache.bin3";
        private static readonly string AppCacheFileName = "appTokenCache.bin3";

        private static DeviceCodeProvider UserAuthProvider = null;
        private static ClientCredentialProvider AppAuthProvider = null;

        /// <summary>
        /// Path to the token cache.
        /// </summary>
        internal static readonly string CacheFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

        internal static IAuthenticationProvider GetAuthProvider(AuthConfig authConfig)
        {
            if (authConfig.AuthType == AuthenticationType.Delegated)
            {
                if (UserAuthProvider == null)
                { 
                    IPublicClientApplication clientApp = PublicClientApplicationBuilder
                    .Create(authConfig.ClientId)
                    .WithTenantId(authConfig.TenantId)
                    .Build();

                    ConfigureTokenCache(clientApp.UserTokenCache, CacheFilePath + UserCacheFileName);
                    UserAuthProvider = new DeviceCodeProvider(clientApp, authConfig.Scopes);
                }
                return UserAuthProvider;
            }
            else
            {
                if (AppAuthProvider == null ||
                AppAuthProvider.ClientApplication.AppConfig.ClientId != authConfig.ClientId ||
                AppAuthProvider.ClientApplication.AppConfig.TenantId != authConfig.TenantId ||
                AppAuthProvider.ClientApplication.AppConfig.ClientCredentialCertificate?.SubjectName.Name != authConfig.CertificateName)
                {
                    X509Certificate2 certificate = GetCertificate(authConfig.CertificateName);

                    IConfidentialClientApplication clientApp = ConfidentialClientApplicationBuilder
                    .Create(authConfig.ClientId)
                    .WithTenantId(authConfig.TenantId)
                    .WithCertificate(certificate)
                    .Build();

                    ConfigureTokenCache(clientApp.AppTokenCache, CacheFilePath + AppCacheFileName);
                    AppAuthProvider = new ClientCredentialProvider(clientApp);
                }
                return AppAuthProvider;
            }
        }

        internal static void Logout(AuthConfig authConfig)
        {
            lock (FileLock)
            {
                if (authConfig.AuthType == AuthenticationType.Delegated)
                    File.Delete(CacheFilePath + UserCacheFileName);

                File.Delete(CacheFilePath + AppCacheFileName);
            }
        }

        private static void ConfigureTokenCache(ITokenCache tokenCache, string tokenCachePath)
        {
            tokenCache.SetBeforeAccess((TokenCacheNotificationArgs args) => {
                lock (FileLock)
                {
                    args.TokenCache.DeserializeMsalV3(File.Exists(tokenCachePath)
                        ? ProtectedData.Unprotect(File.ReadAllBytes(tokenCachePath), null, DataProtectionScope.CurrentUser)
                        : null);
                }
            });

            tokenCache.SetAfterAccess((TokenCacheNotificationArgs args) => {
                lock (FileLock)
                {
                    if (args.HasStateChanged)
                    {
                        File.WriteAllBytes(tokenCachePath,
                            ProtectedData.Protect(args.TokenCache.SerializeMsalV3(), null, DataProtectionScope.CurrentUser));
                    }
                }
            });
        }

        /// <summary>
        /// Gets unexpired certificate of the specified certificate subject name for the current user in My store..
        /// </summary>
        /// <param name="certificateName">Subjec name of the certificate to get.</param>
        /// <returns></returns>
        private static X509Certificate2 GetCertificate(string certificateName)
        {
            X509Certificate2 xCertificate = null;

            using (X509Store xStore = new X509Store(StoreName.My, StoreLocation.CurrentUser))
            {
                xStore.Open(OpenFlags.ReadOnly);

                // Get unexpired certificates with the specified name.
                X509Certificate2Collection unexpiredCerts = xStore.Certificates
                    .Find(X509FindType.FindByTimeValid, DateTime.Now, false)
                    .Find(X509FindType.FindBySubjectDistinguishedName, certificateName, false);

                if (unexpiredCerts == null)
                    throw new Exception($"{certificateName} certificate was not found or has expired.");

                // Only return current cert.
                xCertificate = unexpiredCerts
                    .OfType<X509Certificate2>()
                    .OrderByDescending(c => c.NotBefore)
                    .FirstOrDefault();
            }
            return xCertificate;
        }
    }
}
