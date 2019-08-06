// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Common.Authentication
{
    using Microsoft.Graph.Auth;
    using Microsoft.Graph.PowerShell.Common.Models;
    using Microsoft.Identity.Client;
    using System.IO;
    using System.Security.Cryptography;

    internal static class Authentication
    {
        private static readonly object FileLock = new object();
        private static readonly string UserCacheFileName = "userTokenCache.bin3";
        private static readonly string AppCacheFileName = "appTokenCache.bin3";

        /// <summary>
        /// Path to the token cache
        /// </summary>
        internal static readonly string CacheFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

        internal static IAuthenticationProvider GetAuthProvider(AuthConfig authConfig)
        {
            if(authConfig.AuthType == AuthenticationType.Delegated)
            {
                IPublicClientApplication clientApp = PublicClientApplicationBuilder
                .Create(authConfig.ClientId)
                .WithTenantId(authConfig.TenantId)
                .Build();

                ConfigureTokenCache(clientApp.UserTokenCache, CacheFilePath + UserCacheFileName);

                return new DeviceCodeProvider(clientApp, authConfig.Scopes.Split(new char[] { ',', ' ' }));
            }
            else
            {
                IConfidentialClientApplication clientApp = ConfidentialClientApplicationBuilder
                .Create(authConfig.ClientId)
                .WithTenantId(authConfig.TenantId)
                .WithClientSecret(authConfig.ClientSecret)
                .Build();

                ConfigureTokenCache(clientApp.AppTokenCache, CacheFilePath + AppCacheFileName);

                return new ClientCredentialProvider(clientApp);
            }
        }

        internal static void Logout(AuthConfig authConfig)
        {
            lock (FileLock)
            {
                if(authConfig.AuthType == AuthenticationType.Delegated)
                    File.Delete(CacheFilePath + UserCacheFileName);

                File.Delete(CacheFilePath + AppCacheFileName);
            }
        }

        private static void ConfigureTokenCache(ITokenCache tokenCache, string tokenCachePath)
        {
            tokenCache.SetBeforeAccess((TokenCacheNotificationArgs args) => {
                args.TokenCache.DeserializeMsalV3(GetTokenCache(tokenCachePath));
            });

            tokenCache.SetAfterAccess((TokenCacheNotificationArgs args) => {
                SetTokenCache(args.TokenCache.SerializeMsalV3(), tokenCachePath);
            });
        }

        private static byte[] GetTokenCache(string tokenCachePath)
        {
            lock (FileLock)
            {
                return File.Exists(tokenCachePath) ? ProtectedData.Unprotect(File.ReadAllBytes(tokenCachePath), null, DataProtectionScope.CurrentUser) : new byte[0];
            }
        }

        private static void SetTokenCache(byte[] tokenCache, string tokenCachePath)
        {
            lock (FileLock)
            {
                File.WriteAllBytes(tokenCachePath,
                    ProtectedData.Protect(tokenCache, null, DataProtectionScope.CurrentUser));
            }
        }
    }   
}
