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
    [GraphRoute("POST", "/admin/windows/updates/deployments/{deployment-id}/audience/members/microsoft.graph.windowsUpdates.enrollAssetsById")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgWindowsUpdatesDeploymentAudienceMemberEnrollAssetsById", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgWindowsUpdatesDeploymentAudienceMemberEnrollAssetsByIdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeploymentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? MemberEntityType { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Ids { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.UpdateCategory? UpdateCategory { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeploymentId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.WindowsUpdates.Client.Admin.Windows.Updates.Deployments.Item.Audience.Members.MicrosoftGraphWindowsUpdatesEnrollAssetsById.EnrollAssetsByIdPostRequestBody();

    if (this.IsParameterBound(nameof(MemberEntityType)))
        body.MemberEntityType = MemberEntityType;

    if (this.IsParameterBound(nameof(Ids)))
        body.Ids = Ids!.ToList();
    if (this.IsParameterBound(nameof(UpdateCategory)))
        body.UpdateCategory = UpdateCategory;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Admin.Windows.Updates.Deployments[DeploymentId].Audience.Members.MicrosoftGraphWindowsUpdatesEnrollAssetsById.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeploymentId);
                return;
            }

        }
    }
}
