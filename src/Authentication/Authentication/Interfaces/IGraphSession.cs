// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Interfaces
{
    public interface IGraphSession
    {
        IAuthContext AuthContext { get; set; }
        IDataStore DataStore { get; set; }
    }
}