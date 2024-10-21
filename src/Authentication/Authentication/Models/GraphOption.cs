// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.IO;

namespace Microsoft.Graph.PowerShell.Authentication
{
    internal class GraphOption : IGraphOption
    {
        public bool EnableWAMForMSGraph { get; set; }
        public bool EnableATPoPForMSGraph { get; set; }
    }

}