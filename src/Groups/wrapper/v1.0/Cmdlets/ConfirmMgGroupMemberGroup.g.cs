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
    [GraphRoute("POST", "/groups/{group-id}/checkMemberGroups")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgGroupMemberGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Groups.Client.Groups.Item.CheckMemberGroups.CheckMemberGroupsPostResponse))]
    public class ConfirmMgGroupMemberGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? GroupIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Confirm"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Groups.Client.Groups.Item.CheckMemberGroups.CheckMemberGroupsPostRequestBody();

    if (this.IsParameterBound(nameof(GroupIds)))
        body.GroupIds = GroupIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Groups.Client.Groups.Item.CheckMemberGroups.CheckMemberGroupsPostResponse? result;
            try
            {
                result = client.Groups[GroupId].CheckMemberGroups.PostAsCheckMemberGroupsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }

            WriteObject(result);
        }
    }
}
