// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Interfaces
{
    public interface IRequestContext
    {
        RetryHandlerOption RetryOptions { get; set; }
        TimeSpan ClientTimeout { get; set; }
    }
}
