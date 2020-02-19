// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    using System;

    /// <summary>
    /// Helper class to handle token encryption and decryption.
    /// </summary>
    internal static class TokenCryptographer
    {
        /// <summary>
        /// Encrypts the passed buffer based on the host platform.
        /// </summary>
        /// <param name="buffer">A <see cref="byte[]"/> to encrypt.</param>
        /// <returns>An encrypted <see cref="byte[]"/>.</returns>
        public static byte[] EncryptToken(byte[] buffer)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                return WindowsTokenCache.EncryptToken(buffer);
            return buffer;
        }

        /// <summary>
        /// Decrypts the passed buffer based on the host platform.
        /// </summary>
        /// <param name="buffer">A <see cref="byte[]"/> to decrypt.</param>
        /// <returns>An decrypted <see cref="byte[]"/>.</returns>
        public static byte[] DecryptToken(byte[] buffer)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                return WindowsTokenCache.DecryptToken(buffer);
            return buffer;
        }
    }
}
