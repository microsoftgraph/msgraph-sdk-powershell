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
    [GraphRoute("POST", "/groupLifecyclePolicies/{groupLifecyclePolicy-id}/removeGroup")]
    [Cmdlet(VerbsCommon.Remove, "MgGroupFromLifecyclePolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Groups.Client.GroupLifecyclePolicies.Item.RemoveGroup.RemoveGroupPostResponse))]
    public class RemoveMgGroupFromLifecyclePolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupLifecyclePolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? GroupId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupLifecyclePolicyId, "Remove"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Groups.Client.GroupLifecyclePolicies.Item.RemoveGroup.RemoveGroupPostRequestBody();

    if (this.IsParameterBound(nameof(GroupId)))
        body.GroupId = GroupId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Groups.Client.GroupLifecyclePolicies.Item.RemoveGroup.RemoveGroupPostResponse? result;
            try
            {
                result = client.GroupLifecyclePolicies[GroupLifecyclePolicyId].RemoveGroup.PostAsRemoveGroupPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GroupLifecyclePolicyId);
                return;
            }

            WriteObject(result);
        }
    }
}
