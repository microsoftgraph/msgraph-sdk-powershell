// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using System;
using System.Globalization;

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    /// <summary>
    /// Helper class to handle token encryption and decryption.
    /// </summary>
    internal static class TokenCacheStorage
    {
        /// <summary>
        /// Gets a decrypted access token from the host platform OS.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <returns></returns>
        public static byte[] GetToken(string appId)
        {
            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(appId)));
            }

            if (Helpers.OperatingSystem.IsWindows())
            {
                return WindowsTokenCache.GetToken(appId);
            }
            else if (Helpers.OperatingSystem.IsMacOS())
            {
                return MacTokenCache.GetToken(appId);
            }
            else
            {
                return LinuxTokenCache.GetToken(appId);
            }
        }

        /// <summary>
        /// Encrypts and saves an access token buffer to the host platform OS.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <param name="accessToken">An access token.</param>
        public static void SetToken(string appId, byte[] accessToken)
        {
            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(appId)));
            }
            if (accessToken == null || accessToken.Length == 0)
            {
                return ;
            }

            if (Helpers.OperatingSystem.IsWindows())
            {
                WindowsTokenCache.SetToken(appId, accessToken);
            }
            else if (Helpers.OperatingSystem.IsMacOS())
            {
                MacTokenCache.SetToken(appId, accessToken);
            }
            else
            {
                LinuxTokenCache.SetToken(appId, accessToken);
            }
        }

        /// <summary>
        /// Deletes an access token from the host OS.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        public static void DeleteToken(string appId)
        {
            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(appId)));
            }

            if (Helpers.OperatingSystem.IsWindows())
            {
                WindowsTokenCache.DeleteToken(appId);
            }
            else if (Helpers.OperatingSystem.IsMacOS())
            {
                MacTokenCache.DeleteToken(appId);
            }
            else
            {
                LinuxTokenCache.DeleteToken(appId);
            }
        }
    }
}
