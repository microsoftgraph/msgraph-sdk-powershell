// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Core.Interfaces;
using System;

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    internal class RequestContext : IRequestContext
    {
        /// <summary>
        /// HTTP Client timeout in seconds.
        /// </summary>
        public TimeSpan ClientTimeout { get; set; } = TimeSpan.FromSeconds(Constants.ClientTimeout);
        /// <summary>
        /// The waiting time in seconds before retrying a request with a maximum value of 180 seconds. This defaults to 3 seconds.
        /// </summary>
        public int RetryDelay { get; set; } = Constants.DEFAULT_RETRY_DELAY;
        /// <summary>
        /// The maximum number of retries for a request with a maximum value of 10. This defaults to 3.
        /// </summary>
        public int MaxRetry { get; set; } = Constants.DEFAULT_MAX_RETRY;
        /// <summary>
        /// The maximum time allowed for request retries.
        /// </summary>
        public TimeSpan RetriesTimeLimit { get; set; } = TimeSpan.Zero;
    }
}
