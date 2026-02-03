// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    /// <summary>
    /// Utility class containing runtime utility methods.
    /// </summary>
    internal static class RuntimeUtils
    {
        /// <summary>
        /// Determines if the PSEdition of the current process is Core.
        /// </summary>
        /// <returns><see cref="true"/> when PSEdition is core, else <see cref="false"/>.</returns>
        internal static bool IsPsCore()
        {
            var psCoreVersion = new Version(5, 0, 0);
            return Environment.Version >= psCoreVersion;
        }
    }
}
