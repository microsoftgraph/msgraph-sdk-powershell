// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    internal static class WindowHandleUtlities
    {
        enum GetAncestorFlags
        {
            GetParent = 1,
            GetRoot = 2,
            /// <summary>
            /// Retrieves the owned root window by walking the chain of parent and owner windows returned by GetParent.
            /// </summary>
            GetRootOwner = 3
        }

        /// <summary>
        /// Retrieves the handle to the ancestor of the specified window.
        /// See https://learn.microsoft.com/en-us/azure/active-directory/develop/scenario-desktop-acquire-token-wam#console-applications.
        /// </summary>
        /// <param name="hwnd">A handle to the window whose ancestor is to be retrieved.
        /// If this parameter is the desktop window, the function returns NULL. </param>
        /// <param name="flags">The ancestor to be retrieved.</param>
        /// <returns>The return value is the handle to the ancestor window.</returns>
        [DllImport("user32.dll", ExactSpelling = true)]
        static extern IntPtr GetAncestor(IntPtr hwnd, GetAncestorFlags flags);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        public static IntPtr GetConsoleOrTerminalWindow()
        {
            if (SharedUtilities.IsWindowsPlatform())
            {
                IntPtr consoleHandle = GetConsoleWindow();
                IntPtr handle = GetAncestor(consoleHandle, GetAncestorFlags.GetRootOwner);
                return handle;
            }
            else
            {
                // can't call Windows native APIs
                return (IntPtr)0;
            }
        }
    }
}
