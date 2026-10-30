#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("POST", "/admin/windows/updates/deployments/{deployment-id}/audience/members/{updatableAsset-id}/microsoft.graph.windowsUpdates.removeMembers")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgWindowsUpdatesDeploymentAudienceMemberRemoveMembers", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgWindowsUpdatesDeploymentAudienceMemberRemoveMembersCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeploymentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UpdatableAssetId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.UpdatableAsset[]? Assets { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UpdatableAssetId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.WindowsUpdates.Client.Admin.Windows.Updates.Deployments.Item.Audience.Members.Item.MicrosoftGraphWindowsUpdatesRemoveMembers.RemoveMembersPostRequestBody();

    if (this.IsParameterBound(nameof(Assets)))
        body.Assets = Assets!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Admin.Windows.Updates.Deployments[DeploymentId].Audience.Members[UpdatableAssetId].MicrosoftGraphWindowsUpdatesRemoveMembers.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UpdatableAssetId);
                return;
            }

        }
    }
}
