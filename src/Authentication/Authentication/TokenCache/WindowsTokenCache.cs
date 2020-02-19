// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    using System.Security.Cryptography;
    internal static class WindowsTokenCache
    {
        /// <summary>
        /// Encrypts the passed buffer using Windows DPAPI.
        /// </summary>
        /// <param name="buffer">A <see cref="byte[]"/> to encrypt.</param>
        /// <returns>An encrypted <see cref="byte[]"/>.</returns>
        public static byte[] EncryptToken(byte[] buffer)
        {
            return ProtectedData.Protect(buffer, null, DataProtectionScope.CurrentUser);
        }

        /// <summary>
        /// Decrypts the passed buffer Windows DPAPI.
        /// </summary>
        /// <param name="buffer">A <see cref="byte[]"/> to decrypt.</param>
        /// <returns>An decrypted <see cref="byte[]"/>.</returns>
        public static byte[] DecryptToken(byte[] buffer)
        {
            return ProtectedData.Unprotect(buffer, null, DataProtectionScope.CurrentUser);
        }
    }
}
