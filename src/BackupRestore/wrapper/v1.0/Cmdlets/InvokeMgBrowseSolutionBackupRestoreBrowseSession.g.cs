#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BackupRestore.Client;
using Microsoft.Graph.PowerShell.BackupRestore.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BackupRestore
{
    [GraphRoute("POST", "/solutions/backupRestore/browseSessions/{browseSessionBase-id}/browse")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgBrowseSolutionBackupRestoreBrowseSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.BackupRestore.Client.Solutions.BackupRestore.BrowseSessions.Item.Browse.BrowsePostResponse))]
    public class InvokeMgBrowseSolutionBackupRestoreBrowseSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BrowseSessionBaseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? BrowseLocationItemKey { get; set; }

        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.BrowsableResourceType? BrowseResourceType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.BrowseQueryOrder? OrderBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BrowseSessionBaseId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.BackupRestore.Client.Solutions.BackupRestore.BrowseSessions.Item.Browse.BrowsePostRequestBody();

    if (this.IsParameterBound(nameof(BrowseLocationItemKey)))
        body.BrowseLocationItemKey = BrowseLocationItemKey;

    if (this.IsParameterBound(nameof(Filter)))
        body.Filter = Filter;
    if (this.IsParameterBound(nameof(BrowseResourceType)))
        body.BrowseResourceType = BrowseResourceType;

    if (this.IsParameterBound(nameof(OrderBy)))
        body.OrderBy = OrderBy;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.BackupRestore.Client.Solutions.BackupRestore.BrowseSessions.Item.Browse.BrowsePostResponse? result;
            try
            {
                result = client.Solutions.BackupRestore.BrowseSessions[BrowseSessionBaseId].Browse.PostAsBrowsePostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, BrowseSessionBaseId);
                return;
            }

            WriteObject(result);
        }
    }
}
