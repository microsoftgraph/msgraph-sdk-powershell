// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Collections;

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    /// <summary>
    /// Session-scoped cache of the command metadata used by Find-MgGraphCommand. Lives in the cmdlet assembly (default
    /// AssemblyLoadContext) so that it stays visible to the module's script-based cmdlets; GraphSession itself lives in the
    /// isolated load context and cannot be referenced from PowerShell type literals.
    /// </summary>
    public static class GraphCommandCache
    {
        public static Hashtable[] MgCommandMetadata { get; set; }

        public static Hashtable[] MgLegacyCommandMapping { get; set; }
    }
}
