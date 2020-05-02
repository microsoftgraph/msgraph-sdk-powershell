// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    using Microsoft.Graph.PowerShell.Authentication.TokenCache.PlatformLibs;
    using System;
    using System.Runtime.InteropServices;

    public static class LinuxTokenCache
    {
        public static byte[] GetToken(string appId)
        {
            int key = LibKeyUtils.request_key(
                LibKeyUtils.KeyTypes.User, $"{Constants.TokenCahceServiceName}:{appId}", Constants.TokenCahceServiceName, (int)LibKeyUtils.KeyringType.KEY_SPEC_USER_SESSION_KEYRING);
            if (key == -1)
                return new byte[0];

            LibKeyUtils.keyctl_read_alloc(key, out IntPtr contentPtr);
            string content = Marshal.PtrToStringAuto(contentPtr);
            Marshal.FreeHGlobal(contentPtr);

            if (string.IsNullOrEmpty(content))
                return new byte[0];

            return Convert.FromBase64String(content);
        }

        public static void SetToken(string appId, byte[] plainContent)
        {
            if (plainContent != null && plainContent.Length > 0)
            {
                string encodedContent = Convert.ToBase64String(plainContent);
                int key = LibKeyUtils.request_key(
                    LibKeyUtils.KeyTypes.User, $"{Constants.TokenCahceServiceName}:{appId}", Constants.TokenCahceServiceName, (int)LibKeyUtils.KeyringType.KEY_SPEC_USER_SESSION_KEYRING);
                if (key == -1)
                    LibKeyUtils.add_key(
                        LibKeyUtils.KeyTypes.User, $"{Constants.TokenCahceServiceName}:{appId}", encodedContent, encodedContent.Length, (int)LibKeyUtils.KeyringType.KEY_SPEC_USER_SESSION_KEYRING);
                else
                    LibKeyUtils.keyctl_update(key, encodedContent, encodedContent.Length);
            }
        }

        public static void DeleteToken(string appId)
        {
            int key = LibKeyUtils.request_key(LibKeyUtils.KeyTypes.User, $"{Constants.TokenCahceServiceName}:{appId}", Constants.TokenCahceServiceName, (int)LibKeyUtils.KeyringType.KEY_SPEC_USER_SESSION_KEYRING);
            if (key == -1)
                throw new Exception("Access token not found in cache.");

            long removedState = LibKeyUtils.keyctl_revoke(key);
            if (removedState == -1)
                throw new Exception("Failed to remove token from cache.");
        }
    }
}
