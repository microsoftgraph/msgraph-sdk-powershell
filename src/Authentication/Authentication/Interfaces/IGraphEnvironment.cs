// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Interfaces
{
    public interface IGraphEnvironment
    {
        string Name { get; set; }
        string Type { get; set; }
        string AzureADEndpoint { get; set; }
        string GraphEndpoint { get; set; }
    }
}
