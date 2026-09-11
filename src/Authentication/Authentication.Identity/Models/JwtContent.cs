// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Core.Models
{
    internal class JwtContent
    {
        public string Header { get; set; }
        public string Payload { get; set; }
    }
}
