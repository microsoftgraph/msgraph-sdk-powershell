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
    [GraphRoute("POST", "/admin/windows/updates/updatableAssets/{updatableAsset-id}/microsoft.graph.windowsUpdates.removeMembersById")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgWindowsUpdatesUpdatableAssetRemoveMembersById", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgWindowsUpdatesUpdatableAssetRemoveMembersByIdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UpdatableAssetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Ids { get; set; }

        [Parameter(Mandatory = false)]
        public string? MemberEntityType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UpdatableAssetId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.WindowsUpdates.Client.Admin.Windows.Updates.UpdatableAssets.Item.MicrosoftGraphWindowsUpdatesRemoveMembersById.RemoveMembersByIdPostRequestBody();

    if (this.IsParameterBound(nameof(Ids)))
        body.Ids = Ids!.ToList();

    if (this.IsParameterBound(nameof(MemberEntityType)))
        body.MemberEntityType = MemberEntityType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Admin.Windows.Updates.UpdatableAssets[UpdatableAssetId].MicrosoftGraphWindowsUpdatesRemoveMembersById.PostAsync(body, requestConfiguration =>
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
