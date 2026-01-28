// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.IO;

namespace Microsoft.Graph.PowerShell.Authentication
{
    internal class GraphOption : IGraphOption
    {
        public bool? DisableWAMForMSGraph { get; set; }

        // Display property that returns false when null for Get-MgGraphOption output
        public bool DisableLoginByWAM => DisableWAMForMSGraph ?? false;
    }

}