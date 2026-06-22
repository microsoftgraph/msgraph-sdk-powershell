// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.IO;
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
        /// </summary>
        /// <param name="cacheName">The cache name (e.g., "mg.msal.cache").</param>
        public static async Task ClearPersistedTokenCacheAsync(string cacheName)
        {
            // Azure.Identity creates separate caches for CAE-enabled and CAE-disabled tokens.
            await ClearCacheAsync(cacheName + CaeEnabledSuffix).ConfigureAwait(false);
            await ClearCacheAsync(cacheName + CaeDisabledSuffix).ConfigureAwait(false);
        }

        private static async Task ClearCacheAsync(string cacheFileName)
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
#pragma warning disable CS0618 // MsalCacheHelper.Clear is obsolete but is the correct approach for full cache wipe on disconnect
            cacheHelper.Clear();
#pragma warning restore CS0618
        }
    }
}
