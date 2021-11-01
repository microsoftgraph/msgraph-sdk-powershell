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
    /// A set of methods for getting, setting and deleting tokens on MacOS via KeyChain.
    /// </summary>
    internal static class MacTokenCache
    {
        /// <summary>
        /// Gets an app's token from MacOS KeyChain.
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

            IntPtr passwordDataPtr = IntPtr.Zero;
            IntPtr itemPtr = IntPtr.Zero;

            try
            {
                int resultStatus = MacNativeKeyChain.SecKeychainFindGenericPassword(
                    keychainOrArray: IntPtr.Zero,
                    serviceNameLength: (uint)Constants.TokenCacheServiceName.Length,
                    serviceName: Constants.TokenCacheServiceName,
                    accountNameLength: (uint)appId.Length,
                    accountName: appId,
                    passwordLength: out uint passwordLength,
                    passwordData: out passwordDataPtr,
                    itemRef: out itemPtr);

                byte[] contentBuffer = new byte[0];
                switch (resultStatus)
                {
                    case MacNativeKeyChain.SecResultCodes.errSecItemNotFound:
                        break;
                    case MacNativeKeyChain.SecResultCodes.errSecSuccess:
                        if (passwordLength > 0)
                        {
                            contentBuffer = new byte[passwordLength];
                            Marshal.Copy(
                                source: passwordDataPtr,
                                destination: contentBuffer, 
                                startIndex: 0, 
                                length: contentBuffer.Length);
                        }
                        break;
                    default:
                        throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.MacKeyChainFailed,
                            "SecKeychainFindGenericPassword",
                            resultStatus));
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
            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(appId)));
            }
            if (plainContent == null || plainContent.Length == 0)
            {
                return;
            }

            IntPtr passwordDataPtr = IntPtr.Zero;
            IntPtr itemPtr = IntPtr.Zero;
            try
            {
                int resultStatus = MacNativeKeyChain.SecKeychainFindGenericPassword(
                    keychainOrArray: IntPtr.Zero,
                    serviceNameLength: (uint)Constants.TokenCacheServiceName.Length,
                    serviceName: Constants.TokenCacheServiceName,
                    accountNameLength: (uint)appId.Length,
                    accountName: appId,
                    passwordLength: out uint passwordLength,
                    passwordData: out passwordDataPtr,
                    itemRef: out itemPtr);

                switch (resultStatus)
                {
                    case MacNativeKeyChain.SecResultCodes.errSecSuccess:
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
                        break;

                    case MacNativeKeyChain.SecResultCodes.errSecItemNotFound:
                        // Key not found, let's create a new one in the default keychain.
                        resultStatus = MacNativeKeyChain.SecKeychainAddGenericPassword(
                            keychain: IntPtr.Zero,
                            serviceNameLength: (uint)Constants.TokenCacheServiceName.Length,
                            serviceName: Constants.TokenCacheServiceName,
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
                        break;
                    default:
                        throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.MacKeyChainFailed,
                            "SecKeychainFindGenericPassword",
                            resultStatus));
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
            if (string.IsNullOrEmpty(appId))
            {
                throw new ArgumentNullException(string.Format(
                    CultureInfo.CurrentCulture,
                    ErrorConstants.Message.NullOrEmptyParameter,
                    nameof(appId)));
            }

            IntPtr passwordDataPtr = IntPtr.Zero;
            IntPtr itemPtr = IntPtr.Zero;

            try
            {
                int resultStatus = MacNativeKeyChain.SecKeychainFindGenericPassword(
                    keychainOrArray: IntPtr.Zero,
                    serviceNameLength: (uint)Constants.TokenCacheServiceName.Length,
                    serviceName: Constants.TokenCacheServiceName,
                    accountNameLength: (uint)appId.Length,
                    accountName: appId,
                    passwordLength: out uint passwordLength,
                    passwordData: out passwordDataPtr,
                    itemRef: out itemPtr);

                if (resultStatus == MacNativeKeyChain.SecResultCodes.errSecItemNotFound ||
                    itemPtr == IntPtr.Zero)
                {
                    return;
                }
                else if (resultStatus != MacNativeKeyChain.SecResultCodes.errSecSuccess)
                {
                    throw new Exception(string.Format(
                        CultureInfo.CurrentCulture,
                        ErrorConstants.Message.MacKeyChainFailed,
                        "SecKeychainFindGenericPassword",
                        resultStatus));
                }

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
