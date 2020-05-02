// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using System;
    public static class PlatformHelpers
    {
        /// <summary>
        /// Detects if the platform we are running on is Windows or not.
        /// </summary>
        /// <returns>True if we are runnning on Windows or False if we are not.</returns>
        public static bool IsWindows()
        {
            return Environment.OSVersion.Platform == PlatformID.Win32NT;
        }

        public static bool IsMacOS()
        {
            return Environment.OSVersion.Platform == PlatformID.Unix;
        }

        public static bool IsLinux()
        {
            return Environment.OSVersion.Platform == PlatformID.Unix;
        }
    }
}
