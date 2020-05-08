// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache
{
    using Microsoft.Graph.PowerShell.Authentication.TokenCache.NativePlatformLibs;
    using System;
    using System.Globalization;
    using System.Runtime.InteropServices;

    /// <summary>
    /// A set of methods for getting, setting and deleting tokens on MacOS via KeyChain.
    /// </summary>
    internal static class MacTokenCache
    {
        /// <summary>
        /// Gets an app's token from MacOS KeyChain.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <returns>A decypted token.</returns>
        public static byte[] GetToken(string appId)
        {
            IntPtr passwordDataPtr = IntPtr.Zero;
            IntPtr itemPtr = IntPtr.Zero;

            try
            {
                byte[] contentBuffer = new byte[0];
                int resultStatus = MacNativeKeyChain.SecKeychainFindGenericPassword(
                    keychainOrArray: IntPtr.Zero,
                    serviceNameLength: (uint)Constants.TokenCahceServiceName.Length,
                    serviceName: Constants.TokenCahceServiceName,
                    accountNameLength: (uint)appId.Length,
                    accountName: appId,
                    passwordLength: out uint passwordLength,
                    passwordData: out passwordDataPtr,
                    itemRef: out itemPtr);

                if (resultStatus == MacNativeKeyChain.SecResultCodes.errSecItemNotFound)
                    return contentBuffer;

                else if (resultStatus != MacNativeKeyChain.SecResultCodes.errSecSuccess)
                {
                    throw new Exception(string.Format(
                        CultureInfo.CurrentCulture,
                        ErrorConstants.Message.MacKeyChainFailed,
                        "SecKeychainFindGenericPassword",
                        resultStatus));
                }

                if (itemPtr != IntPtr.Zero && passwordLength > 0)
                {
                    contentBuffer = new byte[passwordLength];
                    Marshal.Copy(passwordDataPtr, contentBuffer, 0, contentBuffer.Length);
                }
                return contentBuffer;
            }
            finally
            {
                FreePointers(ref itemPtr, ref passwordDataPtr);
            }
        }

        /// <summary>
        /// Adds or updates an app's token to MacOS KeyChain.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        /// <param name="plainContent">The content to store.</param>
        public static void SetToken(string appId, byte[] plainContent)
        {
            IntPtr passwordDataPtr = IntPtr.Zero;
            IntPtr itemPtr = IntPtr.Zero;
            try
            {
                int resultStatus = MacNativeKeyChain.SecKeychainFindGenericPassword(
                    keychainOrArray: IntPtr.Zero,
                    serviceNameLength: (uint)Constants.TokenCahceServiceName.Length,
                    serviceName: Constants.TokenCahceServiceName,
                    accountNameLength: (uint)appId.Length,
                    accountName: appId,
                    passwordLength: out uint passwordLength,
                    passwordData: out passwordDataPtr,
                    itemRef: out itemPtr);

                if (resultStatus != MacNativeKeyChain.SecResultCodes.errSecSuccess &&
                    resultStatus != MacNativeKeyChain.SecResultCodes.errSecItemNotFound)
                {
                    throw new Exception(string.Format(
                        CultureInfo.CurrentCulture,
                        ErrorConstants.Message.MacKeyChainFailed,
                        "SecKeychainFindGenericPassword",
                        resultStatus));
                }

                if (itemPtr != IntPtr.Zero)
                {
                    // Key exists, let's update it.
                    resultStatus = MacNativeKeyChain.SecKeychainItemModifyAttributesAndData(
                        itemRef: itemPtr,
                        attrList: IntPtr.Zero,
                        passwordLength: (uint)plainContent.Length,
                        passwordData: plainContent);

                    if (resultStatus != MacNativeKeyChain.SecResultCodes.errSecSuccess)
                    {
                        throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.MacKeyChainFailed,
                            "SecKeychainItemModifyAttributesAndData",
                            resultStatus));
                    }
                }
                else
                {
                    // Key not found, let's create a new one in the default keychain.
                    resultStatus = MacNativeKeyChain.SecKeychainAddGenericPassword(
                        keychain: IntPtr.Zero,
                        serviceNameLength: (uint)Constants.TokenCahceServiceName.Length,
                        serviceName: Constants.TokenCahceServiceName,
                        accountNameLength: (uint)appId.Length,
                        accountName: appId,
                        passwordLength: (uint)plainContent.Length,
                        passwordData: plainContent,
                        itemRef: out itemPtr);

                    if (resultStatus != MacNativeKeyChain.SecResultCodes.errSecSuccess)
                    {
                        throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.MacKeyChainFailed,
                            "SecKeychainAddGenericPassword",
                            resultStatus));
                    }
                }
            }
            finally
            {
                FreePointers(ref itemPtr, ref passwordDataPtr);
            }
        }

        /// <summary>
        /// Deletes an app's token from MacOS KeyChain.
        /// </summary>
        /// <param name="appId">An app/client id.</param>
        public static void DeleteToken(string appId)
        {
            IntPtr passwordDataPtr = IntPtr.Zero;
            IntPtr itemPtr = IntPtr.Zero;

            try
            {
                int resultStatus = MacNativeKeyChain.SecKeychainFindGenericPassword(
                    keychainOrArray: IntPtr.Zero,
                    serviceNameLength: (uint)Constants.TokenCahceServiceName.Length,
                    serviceName: Constants.TokenCahceServiceName,
                    accountNameLength: (uint)appId.Length,
                    accountName: appId,
                    passwordLength: out uint passwordLength,
                    passwordData: out passwordDataPtr,
                    itemRef: out itemPtr);

                if (resultStatus == MacNativeKeyChain.SecResultCodes.errSecItemNotFound)
                    return;
                else if (resultStatus != MacNativeKeyChain.SecResultCodes.errSecSuccess)
                {
                    throw new Exception(string.Format(
                        CultureInfo.CurrentCulture,
                        ErrorConstants.Message.MacKeyChainFailed,
                        "SecKeychainFindGenericPassword",
                        resultStatus));
                }

                if (itemPtr == IntPtr.Zero)
                    return;

                resultStatus = MacNativeKeyChain.SecKeychainItemDelete(itemPtr);
                if (resultStatus != MacNativeKeyChain.SecResultCodes.errSecSuccess)
                {
                    throw new Exception(string.Format(
                        CultureInfo.CurrentCulture,
                        ErrorConstants.Message.MacKeyChainFailed,
                        "SecKeychainItemDelete",
                        resultStatus));
                }
            }
            finally
            {
                FreePointers(ref itemPtr, ref passwordDataPtr);
            }
        }

        /// <summary>
        /// Frees up memory referenced by a keychain data and/or a CFType object after use.
        /// </summary>
        /// <param name="itemPtr">A pointer to a generic password item.</param>
        /// <param name="passwordDataPtr">A pointer to the data buffer to release.</param>
        private static void FreePointers(ref IntPtr itemPtr, ref IntPtr passwordDataPtr)
        {
            if (itemPtr != IntPtr.Zero)
            {
                MacNativeKeyChain.CFRelease(itemPtr);
                itemPtr = IntPtr.Zero;
            }

            if (passwordDataPtr != IntPtr.Zero)
            {
                MacNativeKeyChain.SecKeychainItemFreeContent(attrList: IntPtr.Zero, data: passwordDataPtr);
                passwordDataPtr = IntPtr.Zero;
            }
        }
    }
}
