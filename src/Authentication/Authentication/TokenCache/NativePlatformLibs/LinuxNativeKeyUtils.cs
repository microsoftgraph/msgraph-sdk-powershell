// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.TokenCache.NativePlatformLibs
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// A set of methods to call native Linux keyutils in-kernel key management API - http://man7.org/linux/man-pages/man7/keyutils.7.html.
    /// </summary>
    internal class LinuxNativeKeyUtils
    {
        /// <summary>
        /// Keyring type serial numbers.
        /// </summary>
        internal enum KeyringType
        {
            /// <summary>
            /// Each thread may have its own keyring.
            /// It specifies the caller's thread-specific keyring
            /// This is searched first, before all others.
            /// </summary>
            KEY_SPEC_THREAD_KEYRING = -1,

            /// <summary>
            /// Each process (thread group) may have its own keyring.
            /// It specifies the caller's process-specific keyring.
            /// This is shared between all members of a group and will be searched after the thread keyring.
            /// </summary>
            KEY_SPEC_PROCESS_KEYRING = -2,

            /// <summary>
            /// Each process subscribes to a session keyring that is inherited across (v)fork, exec and clone.
            /// It specifies the caller's session-specific keyring.
            /// This is searched after the process keyring.
            /// </summary>
            KEY_SPEC_SESSION_KEYRING = -3,

            /// <summary>
            /// This keyring is shared between all the processes owned by a particular user.
            /// It specifies the caller's UID-specific keyring.
            /// It isn't searched directly, but is normally linked to from the session keyring.
            /// </summary>
            KEY_SPEC_USER_KEYRING = -4,

            /// <summary>
            /// This is the default session keyring for a particular user.
            /// It specifies the caller's UID-session keyring.
            /// </summary>
            KEY_SPEC_USER_SESSION_KEYRING = -5
        }

        /// <summary>
        /// Keyutils key types.
        /// </summary>
        internal static class KeyTypes
        {
            /// <summary>
            /// This is a general purpose key type whose payload may be read and updated by user-space applications.
            /// </summary>
            public const string User = "user";
        }

#pragma warning disable SA1300 // disable lowercase function name warning.
        /// <summary>
        /// Creates or updates a key to the Kernel's key management facility.
        /// </summary>
        /// <param name="type">A key type.</param>
        /// <param name="description">A description of the key to lookup.</param>
        /// <param name="payload">The payload to instantiate the key with.</param>
        /// <param name="plen">The length of the payload.</param>
        /// <param name="keyring">The keyring to attach the key to.</param>
        /// <returns>On success, it returns the serial number of the key. On error, it returns -1.</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("libkeyutils.so.1", CallingConvention = CallingConvention.StdCall)]
        public static extern int add_key(string type, string description, string payload, int plen, int keyring);

        /// <summary>
        /// Requests a key from the kernel's key management facility.
        /// </summary>
        /// <param name="type">A key type.</param>
        /// <param name="description">A description of the key to lookup.</param>
        /// <param name="callout_info">The payload of the key.</param>
        /// <param name="dest_keyring">A serial number of the keyring type to request the key from.</param>
        /// <returns>On success, it returns the serial number of the key. On error, it returns -1.</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("libkeyutils.so.1", CallingConvention = CallingConvention.StdCall)]
        public static extern int request_key(string type, string description, IntPtr callout_info, int dest_keyring);

        /// <summary>
        /// Updates a key's data payload.
        /// </summary>
        /// <param name="key">The id of the key to update.</param>
        /// <param name="payload">New payload data.></param>
        /// <param name="plen">Length of the new payload data.</param>
        /// <returns>On success, it returns the serial number of the key. On error, it returns -1.</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("libkeyutils.so.1", CallingConvention = CallingConvention.StdCall)]
        public static extern int keyctl_update(int key, string payload, int plen);

        /// <summary>
        /// Revokes a key. The key is the scheduled for garbage collection.
        /// it will no longer be findable, and will be unavailable for further operations.
        /// </summary>
        /// <param name="key">The id of the key to revoke.</param>
        /// <returns>On success, it returns the serial number of the key. On error, it returns -1.</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("libkeyutils.so.1", CallingConvention = CallingConvention.StdCall)]
        public static extern int keyctl_revoke(int key);

        /// <summary>
        /// Reads the payload of a key if the key type supports it.
        /// </summary>
        /// <param name="key">The id of the key to read.</param>
        /// <param name="buffer">A buffer to hold the payload data.</param>
        /// <returns>On success, it returns the serial number of the key. On error, it returns -1.</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("libkeyutils.so.1", CallingConvention = CallingConvention.StdCall)]
        public static extern int keyctl_read_alloc(int key, out IntPtr buffer);
#pragma warning restore SA1300 // restore lowercase function name warning.
    }
}
