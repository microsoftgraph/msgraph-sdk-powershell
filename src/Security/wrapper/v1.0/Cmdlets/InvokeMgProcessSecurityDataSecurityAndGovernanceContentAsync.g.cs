#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/dataSecurityAndGovernance/processContentAsync")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgProcessSecurityDataSecurityAndGovernanceContentAsync", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.ProcessContentAsync.ProcessContentAsyncPostResponse))]
    public class InvokeMgProcessSecurityDataSecurityAndGovernanceContentAsyncCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.ProcessContentBatchRequest[]? ProcessContentRequests { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.ProcessContentAsync.ProcessContentAsyncPostRequestBody();

    if (this.IsParameterBound(nameof(ProcessContentRequests)))
        body.ProcessContentRequests = ProcessContentRequests!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.ProcessContentAsync.ProcessContentAsyncPostResponse? result;
            try
            {
                result = client.Security.DataSecurityAndGovernance.ProcessContentAsync.PostAsProcessContentAsyncPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
