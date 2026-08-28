#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BackupRestore.Client;
using Microsoft.Graph.PowerShell.BackupRestore.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BackupRestore
{
    [GraphRoute("POST", "/solutions/backupRestore/sharePointRestoreSessions/{sharePointRestoreSession-id}/granularSiteRestoreArtifacts")]
    [Cmdlet(VerbsCommon.New, "MgSolutionBackupRestoreSharePointRestoreSessionGranularSiteRestoreArtifact", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.GranularSiteRestoreArtifact))]
    public class NewMgSolutionBackupRestoreSharePointRestoreSessionGranularSiteRestoreArtifactCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharePointRestoreSessionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? BrowseSessionId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RestoredItemKey { get; set; }

        [Parameter(Mandatory = false)]
        public string? RestoredItemPath { get; set; }

        [Parameter(Mandatory = false)]
        public string? RestoredItemWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RestorePointDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ArtifactRestoreStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SharePointRestoreSessionId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.BackupRestore.Client.Models.GranularSiteRestoreArtifact();

    if (this.IsParameterBound(nameof(BrowseSessionId)))
        body.BrowseSessionId = BrowseSessionId;

    if (this.IsParameterBound(nameof(CompletionDateTime)))
        body.CompletionDateTime = CompletionDateTime;

    if (this.IsParameterBound(nameof(RestoredItemKey)))
        body.RestoredItemKey = RestoredItemKey;

    if (this.IsParameterBound(nameof(RestoredItemPath)))
        body.RestoredItemPath = RestoredItemPath;

    if (this.IsParameterBound(nameof(RestoredItemWebUrl)))
        body.RestoredItemWebUrl = RestoredItemWebUrl;

    if (this.IsParameterBound(nameof(RestorePointDateTime)))
        body.RestorePointDateTime = RestorePointDateTime;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

    if (this.IsParameterBound(nameof(SiteId)))
        body.SiteId = SiteId;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.GranularSiteRestoreArtifact? result;
            try
            {
                result = client.Solutions.BackupRestore.SharePointRestoreSessions[SharePointRestoreSessionId].GranularSiteRestoreArtifacts.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
