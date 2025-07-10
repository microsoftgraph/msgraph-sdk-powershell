// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication
{
    public interface IGraphOption
    {
        bool EnableWAMForMSGraph { get; set; }
        bool EnableATPoPForMSGraph { get; set; }
    }
}