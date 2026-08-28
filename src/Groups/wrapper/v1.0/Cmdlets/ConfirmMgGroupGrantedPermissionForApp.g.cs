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
    [GraphRoute("POST", "/groups/{group-id}/checkGrantedPermissionsForApp")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgGroupGrantedPermissionForApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Groups.Client.Groups.Item.CheckGrantedPermissionsForApp.CheckGrantedPermissionsForAppPostResponse))]
    public class ConfirmMgGroupGrantedPermissionForAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Confirm"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Groups.Client.Groups.Item.CheckGrantedPermissionsForApp.CheckGrantedPermissionsForAppPostResponse? result;
            try
            {
                result = client.Groups[GroupId].CheckGrantedPermissionsForApp.PostAsCheckGrantedPermissionsForAppPostResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }

            WriteObject(result);
        }
    }
}
