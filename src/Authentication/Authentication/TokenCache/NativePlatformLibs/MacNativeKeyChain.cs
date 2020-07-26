// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache.NativePlatformLibs
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// A set of methods to call native MacOS KeyChains Items API - https://developer.apple.com/documentation/security/keychain_services/keychain_items.
    /// </summary>
    internal class MacNativeKeyChain
    {
        /// <summary>
        /// Keychain Result Codes.
        /// https://developer.apple.com/documentation/security/1542001-security_framework_result_codes
        /// https://github.com/xamarin/xamarin-macios/blob/master/src/Security/Enums.cs#L11
        /// </summary>
        public static class SecResultCodes
        {
            /// <summary>
            /// No error.
            /// </summary>
            public const int errSecSuccess = 0;
            /// <summary>
            /// Authorization and/or authentication failed.
            /// </summary>
            public const int errSecAuthFailed = -25293;
            /// <summary>
            /// The keychain does not exist.
            /// </summary>
            public const int errSecNoSuchKeychain = -25294;
            /// <summary>
            /// A keychain with the same name already exists.
            /// </summary>
            public const int errSecDuplicateKeychain = -25296;
            /// <summary>
            /// The item already exists.
            /// </summary>
            public const int errSecDuplicateItem = -25299;
            /// <summary>
            /// The item cannot be found.
            /// </summary>
            public const int errSecItemNotFound = -25300;
            /// <summary>
            /// A default keychain does not exist.
            /// </summary>
            public const int errSecNoDefaultKeychain = -25307;
            /// <summary>
            /// Unable to decode the provided data.
            /// </summary>
            public const int errSecDecode = -26275;
        }

        private const string FoundationFramework = "/System/Library/Frameworks/Foundation.framework/Foundation";
        private const string SecurityFramework = "/System/Library/Frameworks/Security.framework/Security";

        /// <summary>
        /// Releases memory a Foundation object.
        /// </summary>
        /// <param name="handle">An object to release.</param>
        [DllImport(FoundationFramework)]
        public static extern void CFRelease(IntPtr handle);

        /// <summary>
        /// Releases the memory used by the keychain attribute list and the keychain data retrieved in a call.
        /// </summary>
        /// <param name="attrList">A pointer to the attribute list to release.</param>
        /// <param name="data">A pointer to the data buffer to release.</param>
        /// <returns>A <see cref="SecResultCodes"/></returns>
        [DllImport(SecurityFramework)]
        public static extern int SecKeychainItemFreeContent(IntPtr attrList, IntPtr data);

        /// <summary>
        /// Finds a generic password bassed on the parameters passed.
        /// </summary>
        /// <param name="keychainOrArray">A reference to the keychains to search.</param>
        /// <param name="serviceNameLength">The length of a service name.</param>
        /// <param name="serviceName">The service name.</param>
        /// <param name="accountNameLength">The length of an account name.</param>
        /// <param name="accountName">The account name.</param>
        /// <param name="passwordLength">On return, the length of the buffer pointed by passwordData..</param>
        /// <param name="passwordData">On return, a pointer to a buffer that holds the password data.</param>
        /// <param name="itemRef">On return, a pointer to the item object of the generic password. This MUST be released after use.</param>
        /// <returns>A <see cref="SecResultCodes"/></returns>
        [DllImport(SecurityFramework)]
        public static extern int SecKeychainFindGenericPassword(IntPtr keychainOrArray, uint serviceNameLength, string serviceName, uint accountNameLength, string accountName, out uint passwordLength, out IntPtr passwordData, out IntPtr itemRef);

        /// <summary>
        /// Adds a new generic password to keychain.
        /// </summary>
        /// <param name="keychain">A reference to the keychains to add the password.</param>
        /// <param name="serviceNameLength">The length of a service name.</param>
        /// <param name="serviceName">The service name.</param>
        /// <param name="accountNameLength">The length of an account name.</param>
        /// <param name="accountName">The account name.</param>
        /// <param name="passwordLength">The length of the passwordData buffer.</param>
        /// <param name="passwordData">A buffer containing the password data.</param>
        /// <param name="itemRef">On return, a pointer to the item object of the generic password. This MUST be released after use.</param>
        /// <returns>A <see cref="SecResultCodes"/></returns>
        [DllImport(SecurityFramework)]
        public static extern int SecKeychainAddGenericPassword(IntPtr keychain, uint serviceNameLength, string serviceName, uint accountNameLength, string accountName, uint passwordLength, byte[] passwordData, out IntPtr itemRef);

        /// <summary>
        /// Updates an existing keychain item.
        /// </summary>
        /// <param name="itemRef">A reference to the keychain item to modify.</param>
        /// <param name="attrList">A pointer to the list of attributes to modify and their new values.</param>
        /// <param name="passwordLength">The length of the passwordData buffer.</param
        /// <param name="passwordData">A buffer containing the password data.</param>
        /// <returns>A <see cref="SecResultCodes"/></returns>
        [DllImport(SecurityFramework)]
        public static extern int SecKeychainItemModifyAttributesAndData(IntPtr itemRef, IntPtr attrList, uint passwordLength, byte[] passwordData);

        /// <summary>
        /// Permanently deletes a keychain item from the default keychain.
        /// </summary>
        /// <param name="itemRef">A reference to the keychain item to delete.</param>
        /// <returns>A <see cref="SecResultCodes"/></returns>
        [DllImport(SecurityFramework)]
        public static extern int SecKeychainItemDelete(IntPtr itemRef);
    }
}
