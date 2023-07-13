// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Core.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using System;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets.RequestContext
{
    [Cmdlet(VerbsCommon.Set, "MgRequestContext", SupportsShouldProcess = true)]
    [OutputType(typeof(IRequestContext))]
    public class SetMgRequestContext : PSCmdlet
    {
        [Parameter(ValueFromPipelineByPropertyName = true, HelpMessage = "Sets the waiting time in seconds before retrying a request with a maximum value of 180 seconds. This defaults to 3 seconds.")]
        [ValidateNotNullOrEmpty]
        [ValidateRange(0, Constants.MAX_RETRY_DELAY_IN_SECONDS)]
        public int RetryDelay { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, HelpMessage = "Sets the maximum number of retries for a request with a maximum value of 10. This defaults to 3.")]
        [ValidateNotNullOrEmpty]
        [ValidateRange(0, Constants.MAX_NUMBER_OF_RETRY)]
        public int MaxRetry { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, HelpMessage = "Sets the maximum time in seconds allowed for request retries.")]
        [ValidateNotNullOrEmpty]
        public int RetriesTimeLimit { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, HelpMessage = "Sets the HTTP client timeout in seconds.")]
        [ValidateNotNullOrEmpty]
        public int ClientTimeout { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            var requestContext = GraphSession.Instance.RequestContext;
            if (MyInvocation.BoundParameters.ContainsKey(nameof(RetryDelay))) { requestContext.RetryDelay = RetryDelay; }
            if (MyInvocation.BoundParameters.ContainsKey(nameof(MaxRetry))) { requestContext.MaxRetry = MaxRetry; }
            if (MyInvocation.BoundParameters.ContainsKey(nameof(RetriesTimeLimit))) { requestContext.RetriesTimeLimit = TimeSpan.FromSeconds(RetriesTimeLimit); }
            if (MyInvocation.BoundParameters.ContainsKey(nameof(ClientTimeout))) { requestContext.ClientTimeout = TimeSpan.FromSeconds(ClientTimeout); }
            GraphSession.Instance.RequestContext = requestContext;
            // Reset HTTP client to use new request options.
            GraphSession.Instance.GraphHttpClient = null;
            WriteObject(GraphSession.Instance.RequestContext);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
