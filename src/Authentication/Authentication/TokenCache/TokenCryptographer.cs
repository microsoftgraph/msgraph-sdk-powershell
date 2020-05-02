// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using System;

    /// <summary>
    /// Helper class to handle token encryption and decryption.
    /// </summary>
    internal static class TokenCryptographer
    {
        /// <summary>
        /// Encrypts and saves an access token buffer to the host platform OS.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <param name="tokenCacheFilePath">Path to the token cache file.</param>
        /// <param name="accessToken">An access token.</param>
        public static void EncryptAndSetToken(string appId, string tokenCacheFilePath, byte[] accessToken)
        {
            if (PlatformHelpers.IsWindows())
                WindowsTokenCache.SetToken(tokenCacheFilePath, accessToken);
            else if (PlatformHelpers.IsMacOS())
                MacTokenCache.SetToken(appId, accessToken);
            else
                LinuxTokenCache.SetToken(appId, accessToken);
        }

        /// <summary>
        /// Gets a decrypted access token from the host platform OS.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <param name="tokenCacheFilePath">Path to the token cache file.</param>
        /// <returns></returns>
        public static byte[] DencryptAndGetToken(string appId, string tokenCacheFilePath)
        {
            if (PlatformHelpers.IsWindows())
                return WindowsTokenCache.GetToken(tokenCacheFilePath);
            else if (PlatformHelpers.IsMacOS())
                return MacTokenCache.GetToken(appId);
            else
                return LinuxTokenCache.GetToken(appId);
        }

        /// <summary>
        /// Deletes an access token from the host OS.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <param name="tokenCacheFilePath">Path to the token cache file.</param>
        public static void DeleteTokenFromCache(string appId, string tokenCacheFilePath)
        {
            if (PlatformHelpers.IsWindows())
                WindowsTokenCache.DeleteToken(tokenCacheFilePath);
            else if (PlatformHelpers.IsMacOS())
                MacTokenCache.DeleteToken(appId);
            else
                LinuxTokenCache.DeleteToken(appId);
        }
    }
}
