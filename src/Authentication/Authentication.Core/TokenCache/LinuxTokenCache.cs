// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    using Microsoft.Graph.PowerShell.Authentication.Core;
    using Microsoft.Graph.PowerShell.Authentication.TokenCache.NativePlatformLibs;
    using System;
    using System.Globalization;
    using System.Runtime.InteropServices;

    /// <summary>
    /// A set of methods for getting, setting and deleting tokens on Linux via keyutils.
    /// </summary>
    internal static class LinuxTokenCache
    {
        /// <summary>
        /// Gets an app's token from Linux keyrings facility.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <returns>A decrypted token.</returns>
        public static byte[] GetToken(string appId)
        {
            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(appId)));
            }

            int key = LinuxNativeKeyUtils.request_key(
                type: LinuxNativeKeyUtils.KeyTypes.User,
                description: $"{Constants.TokenCacheServiceName}:{appId}",
                callout_info: IntPtr.Zero,
                dest_keyring: (int)LinuxNativeKeyUtils.KeyringType.KEY_SPEC_SESSION_KEYRING);

            if (key == -1)
                return new byte[0];

            LinuxNativeKeyUtils.keyctl_read_alloc(key: key, buffer: out IntPtr contentPtr);
            string content = Marshal.PtrToStringAnsi(contentPtr);
            Marshal.FreeHGlobal(contentPtr);

            if (string.IsNullOrEmpty(content))
            {
                return new byte[0];
            }

            return Convert.FromBase64String(content);
        }

        /// <summary>
        /// Adds or updates an app's token to Linux keyrings facility.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <param name="plainContent">The content to store.</param>
        public static void SetToken(string appId, byte[] plainContent)
        {
            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(appId)));
            }

            if (plainContent == null || plainContent.Length == 0)
            {
                return ;
            }

            string encodedContent = Convert.ToBase64String(plainContent);
            int key = LinuxNativeKeyUtils.request_key(
                type: LinuxNativeKeyUtils.KeyTypes.User,
                description: $"{Constants.TokenCacheServiceName}:{appId}",
                callout_info: IntPtr.Zero,
                dest_keyring: (int)LinuxNativeKeyUtils.KeyringType.KEY_SPEC_SESSION_KEYRING);

            if (key == -1)
            {
                LinuxNativeKeyUtils.add_key(
                    type: LinuxNativeKeyUtils.KeyTypes.User,
                    description: $"{Constants.TokenCacheServiceName}:{appId}",
                    payload: encodedContent,
                    plen: encodedContent.Length,
                    keyring: (int)LinuxNativeKeyUtils.KeyringType.KEY_SPEC_SESSION_KEYRING);
            }
            else
            {
                LinuxNativeKeyUtils.keyctl_update(
                    key: key,
                    payload: encodedContent,
                    plen: encodedContent.Length);
            }
        }

        /// <summary>
        /// Deletes an app's token from Linux keyrings facility.
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

            int key = LinuxNativeKeyUtils.request_key(
                type: LinuxNativeKeyUtils.KeyTypes.User,
                description: $"{Constants.TokenCacheServiceName}:{appId}",
                callout_info: IntPtr.Zero,
                dest_keyring: (int)LinuxNativeKeyUtils.KeyringType.KEY_SPEC_SESSION_KEYRING);
            if (key != -1)
            {
                int removedState = LinuxNativeKeyUtils.keyctl_revoke(key);
                if (removedState == -1)
                {
                    throw new Exception("Failed to revoke token from cache.");
                }
            }
        }
    }
}
