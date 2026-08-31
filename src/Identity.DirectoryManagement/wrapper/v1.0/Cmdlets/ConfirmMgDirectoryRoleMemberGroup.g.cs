#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/directoryRoles/{directoryRole-id}/checkMemberGroups")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgDirectoryRoleMemberGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryRoles.Item.CheckMemberGroups.CheckMemberGroupsPostResponse))]
    public class ConfirmMgDirectoryRoleMemberGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DirectoryRoleId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? GroupIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DirectoryRoleId, "Confirm"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryRoles.Item.CheckMemberGroups.CheckMemberGroupsPostRequestBody();

    if (this.IsParameterBound(nameof(GroupIds)))
        body.GroupIds = GroupIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryRoles.Item.CheckMemberGroups.CheckMemberGroupsPostResponse? result;
            try
            {
                result = client.DirectoryRoles[DirectoryRoleId].CheckMemberGroups.PostAsCheckMemberGroupsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DirectoryRoleId);
                return;
            }

            WriteObject(result);
        }
    }
}
