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
    [GraphRoute("POST", "/admin/windows/updates/updatePolicies/{updatePolicy-id}/audience/exclusions/{updatableAsset-id}/microsoft.graph.windowsUpdates.removeMembers")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgWindowsUpdatesPolicyAudienceExclusionRemoveMembers", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgWindowsUpdatesPolicyAudienceExclusionRemoveMembersCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UpdatePolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UpdatableAssetId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.UpdatableAsset[]? Assets { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UpdatableAssetId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.WindowsUpdates.Client.Admin.Windows.Updates.UpdatePolicies.Item.Audience.Exclusions.Item.MicrosoftGraphWindowsUpdatesRemoveMembers.RemoveMembersPostRequestBody();

    if (this.IsParameterBound(nameof(Assets)))
        body.Assets = Assets!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Admin.Windows.Updates.UpdatePolicies[UpdatePolicyId].Audience.Exclusions[UpdatableAssetId].MicrosoftGraphWindowsUpdatesRemoveMembers.PostAsync(body, requestConfiguration =>
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
