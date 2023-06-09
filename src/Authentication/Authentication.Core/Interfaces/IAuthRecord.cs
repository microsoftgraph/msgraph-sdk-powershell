// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Threading;
using Microsoft.Identity.Client;

namespace Microsoft.Graph.PowerShell.Authentication
{
    public interface IAuthRecord
    {
        AccountId AccountId { get; set; }
        string Authority { get; set; }
        string ClientId { get; set; }
        string HomeAccountId { get; set; }
        string TenantId { get; set; }
        string Username { get; set; }
        string Version { get; set; }
        System.Threading.Tasks.Task SerializeAsync(System.IO.Stream stream, CancellationToken cancellationToken = default);
    }
}