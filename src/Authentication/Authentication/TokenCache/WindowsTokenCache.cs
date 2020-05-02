// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    using System.IO;
    using System.Security.Cryptography;
    /// <summary>
    /// Contains methods to store, get and encrypt access tokens using Windows DPAPI in token cache file.
    /// </summary>
    internal static class WindowsTokenCache
    {
        /// <summary>
        /// Gets a decrypted token from the token cache.
        /// </summary>
        /// <param name="tokenCacheFilePath">Path to the token cache file to read from.</param>
        /// <returns>A decrypted access token.</returns>
        public static byte[] GetToken(string tokenCacheFilePath)
        {
            if (!Directory.Exists(Constants.TokenCacheDirectory))
                Directory.CreateDirectory(Constants.TokenCacheDirectory);

            return File.Exists(tokenCacheFilePath)
                        ? ProtectedData.Unprotect(File.ReadAllBytes(tokenCacheFilePath), null, DataProtectionScope.CurrentUser)
                        : new byte[0];
        }

        /// <summary>
        /// Sets an encrypted access token to the token cache.
        /// </summary>
        /// <param name="tokenCacheFilePath">Path to the token cache file path to write to.</param>
        /// <param name="plainContent">Plain access token to securely write to the token cache file.</param>
        public static void SetToken(string tokenCacheFilePath, byte[] plainContent)
        {
            if (!Directory.Exists(Constants.TokenCacheDirectory))
                Directory.CreateDirectory(Constants.TokenCacheDirectory);

            File.WriteAllBytes(tokenCacheFilePath, ProtectedData.Protect(plainContent, null, DataProtectionScope.CurrentUser));
        }

        /// <summary>
        /// Deletes an access token cache file/
        /// </summary>
        /// <param name="tokenCacheFilePath">Token cache file path to delete.</param>
        public static void DeleteToken(string tokenCacheFilePath)
        {
            File.Delete(tokenCacheFilePath);
        }
    }
}
