// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using System.Runtime.InteropServices;

    public static class OperatingSystem
    {
        /// <summary>
        /// Detects if the platform we are running on is Windows.
        /// </summary>
        public static bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        /// <summary>
        /// Detects if the platform we are running on is MacOS.
        /// </summary>
        public static bool IsMacOS() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        /// <summary>
        /// Detects if the platform we are running on is Linux.
        /// </summary>
        public static bool IsLinux() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    }
}
