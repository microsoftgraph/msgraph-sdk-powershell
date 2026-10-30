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
    [GraphRoute("POST", "/admin/windows/updates/updatableAssets/microsoft.graph.windowsUpdates.enrollAssets")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgWindowsUpdatesUpdatableAssetEnrollAssets", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgWindowsUpdatesUpdatableAssetEnrollAssetsCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.UpdateCategory? UpdateCategory { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.UpdatableAsset[]? Assets { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.WindowsUpdates.Client.Admin.Windows.Updates.UpdatableAssets.MicrosoftGraphWindowsUpdatesEnrollAssets.EnrollAssetsPostRequestBody();

    if (this.IsParameterBound(nameof(UpdateCategory)))
        body.UpdateCategory = UpdateCategory;

    if (this.IsParameterBound(nameof(Assets)))
        body.Assets = Assets!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Admin.Windows.Updates.UpdatableAssets.MicrosoftGraphWindowsUpdatesEnrollAssets.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

        }
    }
}
