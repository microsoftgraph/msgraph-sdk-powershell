// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Core.Interfaces;
using System;

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    internal class RequestContext : IRequestContext
    {
        public RetryHandlerOption RetryOptions { get; set; } = new RetryHandlerOption();
        public TimeSpan ClientTimeout { get; set; } = TimeSpan.FromSeconds(Constants.ClientTimeout);
    }
}
