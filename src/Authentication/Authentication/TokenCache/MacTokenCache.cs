// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    using Microsoft.Graph.PowerShell.Authentication.TokenCache.PlatformLibs;
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    internal static class MacTokenCache
    {
        public static byte[] GetToken(string appId)
        {
            IntPtr resultStatus = KeyChains.SecKeychainFindGenericPassword(
                IntPtr.Zero, Constants.TokenCahceServiceName.Length, Constants.TokenCahceServiceName, appId.Length, appId, out int contentPtrLen, out IntPtr contentPtr, IntPtr.Zero);

            byte[] decodedContent = new byte[0];
            // Cache already exists, and content is not empty.
            if (resultStatus.ToInt64() == 0 && contentPtrLen > 0)
            {
                string content = Marshal.PtrToStringAuto(contentPtr);
                Marshal.FreeHGlobal(contentPtr);

                if (!string.IsNullOrEmpty(content))
                {
                    UTF8Encoding utf8Encoding = new UTF8Encoding(true, true);
                    decodedContent = utf8Encoding.GetBytes(content);
                }
            }
            return decodedContent;
        }

        public static void SetToken(string appId, byte[] plainContent)
        {
            IntPtr resultStatus = KeyChains.SecKeychainFindGenericPassword(
                IntPtr.Zero, Constants.TokenCahceServiceName.Length, Constants.TokenCahceServiceName, appId.Length, appId, IntPtr.Zero, IntPtr.Zero, out IntPtr itemRef);
            UTF8Encoding utf8Encoding = new UTF8Encoding(true, true);
            string encodedContent = utf8Encoding.GetString(plainContent);

            // Cache already exists, we will update it instead.
            if (resultStatus.ToInt64() == 0)
            {
                KeyChains.SecKeychainItemModifyAttributesAndData(
                    itemRef, IntPtr.Zero, encodedContent.Length, encodedContent);
                Marshal.FreeHGlobal(itemRef);
            }
            else
            {
                KeyChains.SecKeychainAddGenericPassword(
                    IntPtr.Zero, Constants.TokenCahceServiceName.Length, Constants.TokenCahceServiceName, appId.Length, appId, encodedContent.Length, encodedContent, IntPtr.Zero);
            }
        }

        public static void DeleteToken(string appId)
        {
            IntPtr resultStatus = KeyChains.SecKeychainFindGenericPassword(
                IntPtr.Zero, Constants.TokenCahceServiceName.Length, Constants.TokenCahceServiceName, appId.Length, appId, IntPtr.Zero, IntPtr.Zero, out IntPtr itemRef);

            if (resultStatus.ToInt64() == 0)
            {
                KeyChains.SecKeychainItemDelete(itemRef);
                Marshal.FreeHGlobal(itemRef);
            }
        }
    }
}
