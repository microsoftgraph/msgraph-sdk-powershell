#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("POST", "/groupLifecyclePolicies/renewGroup")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgRenewGroupLifecyclePolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Groups.Client.GroupLifecyclePolicies.RenewGroup.RenewGroupPostResponse))]
    public class InvokeMgRenewGroupLifecyclePolicyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? GroupId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Groups.Client.GroupLifecyclePolicies.RenewGroup.RenewGroupPostRequestBody();

    if (this.IsParameterBound(nameof(GroupId)))
        body.GroupId = GroupId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Groups.Client.GroupLifecyclePolicies.RenewGroup.RenewGroupPostResponse? result;
            try
            {
                result = client.GroupLifecyclePolicies.RenewGroup.PostAsRenewGroupPostResponseAsync(body, requestConfiguration =>
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
