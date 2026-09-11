// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    /// <summary>
    /// Utilities for managing the MSAL token cache persisted to disk by Azure.Identity.
    /// </summary>
    internal static class TokenCacheUtilities
    {
        // Azure.Identity internal constants for cache storage configuration.
        // See: Azure/azure-sdk-for-net - sdk/core/Azure.Core/src/Identity/Constants.cs
        private const string DefaultCacheKeychainService = "Microsoft.Developer.IdentityService";
        private const string DefaultCacheKeyringSchema = "msal.cache";
        private const string DefaultCacheKeyringCollection = "default";
        private static readonly KeyValuePair<string, string> DefaultCacheKeyringAttribute1 =
            new KeyValuePair<string, string>("MsalClientID", "Microsoft.Developer.IdentityService");
        private static readonly KeyValuePair<string, string> DefaultCacheKeyringAttribute2 =
            new KeyValuePair<string, string>("Microsoft.Developer.IdentityService", "1.0.0.0");

        // Azure.Identity appends CAE suffixes to the cache name internally.
        private const string CaeEnabledSuffix = ".cae";
        private const string CaeDisabledSuffix = ".nocae";

        private static readonly string DefaultCacheDirectory =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                ".IdentityService");

        /// <summary>
        /// Clears the persisted MSAL token cache files created by Azure.Identity
        /// for the given cache name. Clears both CAE-enabled and CAE-disabled variants.
        /// When <paramref name="homeAccountId"/> identifies the current session's account, only that
        /// account is removed from the cache; otherwise the entire cache is cleared as a fallback.
        /// </summary>
        /// <param name="cacheName">The cache name (e.g., "mg.msal.cache").</param>
        /// <param name="clientId">The module's client id, used to enumerate cached accounts.</param>
        /// <param name="authority">The authority URL used to build the public client application.</param>
        /// <param name="homeAccountId">
        /// The HomeAccountId of the current session's account. When <c>null</c> or empty, or when no
        /// matching account is found, the entire cache is cleared.
        /// </param>
        public static async Task ClearPersistedTokenCacheAsync(string cacheName, string clientId = null, string authority = null, string homeAccountId = null)
        {
            // Azure.Identity creates separate caches for CAE-enabled and CAE-disabled tokens.
            await ClearCacheAsync(cacheName + CaeEnabledSuffix, clientId, authority, homeAccountId).ConfigureAwait(false);
            await ClearCacheAsync(cacheName + CaeDisabledSuffix, clientId, authority, homeAccountId).ConfigureAwait(false);
        }

        private static async Task ClearCacheAsync(string cacheFileName, string clientId, string authority, string homeAccountId)
        {
            var storageProperties = new StorageCreationPropertiesBuilder(cacheFileName, DefaultCacheDirectory)
                .WithMacKeyChain(DefaultCacheKeychainService, cacheFileName)
                .WithLinuxKeyring(
                    DefaultCacheKeyringSchema,
                    DefaultCacheKeyringCollection,
                    cacheFileName,
                    DefaultCacheKeyringAttribute1,
                    DefaultCacheKeyringAttribute2)
                .Build();

            var cacheHelper = await MsalCacheHelper.CreateAsync(storageProperties).ConfigureAwait(false);

            // When the current session's account can be identified, remove only that account from the
            // persisted cache so other accounts the user has signed into this module remain intact.
            if (!string.IsNullOrEmpty(homeAccountId) && !string.IsNullOrEmpty(clientId))
            {
                var builder = PublicClientApplicationBuilder.Create(clientId);
                if (!string.IsNullOrEmpty(authority))
                {
                    builder = builder.WithAuthority(authority);
                }
                var pca = builder.Build();
                cacheHelper.RegisterCache(pca.UserTokenCache);

                var accounts = await pca.GetAccountsAsync().ConfigureAwait(false);
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

            // Fallback: no identifiable session account, clear the entire cache.
#pragma warning disable CS0618 // MsalCacheHelper.Clear is obsolete but is the correct approach for full cache wipe on disconnect
            cacheHelper.Clear();
#pragma warning restore CS0618
        }
    }
}
