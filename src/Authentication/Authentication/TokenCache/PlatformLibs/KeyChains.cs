// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache.PlatformLibs
{
    using System;
    using System.Runtime.InteropServices;
    /// <summary>
    /// An implementation of MacOS KeyChains API https://developer.apple.com/documentation/security/keychain_services/keychains.
    /// </summary>
    internal class KeyChains
    {
        private const string SecurityFramework = "/System/Library/Frameworks/Security.framework/Security";

        [DllImport(SecurityFramework)]
        public static extern IntPtr SecKeychainFindGenericPassword(IntPtr keychainOrArray, int serviceNameLength, string serviceName, int accountNameLength, string accountName, IntPtr passwordLength, IntPtr passwordData, out IntPtr itemRef);

        [DllImport(SecurityFramework)]
        public static extern IntPtr SecKeychainFindGenericPassword(IntPtr keychainOrArray, int serviceNameLength, string serviceName, int accountNameLength, string accountName, out int passwordLength, out IntPtr passwordData, IntPtr itemRef);

        [DllImport(SecurityFramework)]
        public static extern IntPtr SecKeychainAddGenericPassword(IntPtr keychain, int serviceNameLength, string serviceName, int accountNameLength, string accountName, int passwordLength, string passwordData, IntPtr itemRef);

        [DllImport(SecurityFramework)]
        public static extern IntPtr SecKeychainItemModifyAttributesAndData(IntPtr itemRef, IntPtr attrList, int passwordLength, string passwordData);

        [DllImport(SecurityFramework)]
        public static extern IntPtr SecKeychainItemDelete(IntPtr itemRef);
    }
}
