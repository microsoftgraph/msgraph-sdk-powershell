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
    [GraphRoute("POST", "/solutions/backupRestore/sharePointRestoreSessions/{sharePointRestoreSession-id}/siteRestoreArtifactsBulkAdditionRequests")]
    [Cmdlet(VerbsCommon.New, "MgSolutionBackupRestoreSharePointRestoreSessionSiteRestoreArtifactBulkAdditionRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SiteRestoreArtifactsBulkAdditionRequest))]
    public class NewMgSolutionBackupRestoreSharePointRestoreSessionSiteRestoreArtifactBulkAdditionRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharePointRestoreSessionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ProtectionUnitIds { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SiteIds { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SiteWebUrls { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.DestinationType? DestinationType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.PublicError? Error { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.TimePeriod? ProtectionTimePeriod { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.RestorePointPreference? RestorePointPreference { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.RestoreArtifactsBulkRequestStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.RestorePointTags? Tags { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SharePointRestoreSessionId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SiteRestoreArtifactsBulkAdditionRequest();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(ProtectionUnitIds)))
        body.ProtectionUnitIds = ProtectionUnitIds!.ToList();

    if (this.IsParameterBound(nameof(SiteIds)))
        body.SiteIds = SiteIds!.ToList();

    if (this.IsParameterBound(nameof(SiteWebUrls)))
        body.SiteWebUrls = SiteWebUrls!.ToList();

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(DestinationType)))
        body.DestinationType = DestinationType;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(ProtectionTimePeriod)))
        body.ProtectionTimePeriod = ProtectionTimePeriod;

    if (this.IsParameterBound(nameof(RestorePointPreference)))
        body.RestorePointPreference = RestorePointPreference;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Tags)))
        body.Tags = Tags;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SiteRestoreArtifactsBulkAdditionRequest? result;
            try
            {
                result = client.Solutions.BackupRestore.SharePointRestoreSessions[SharePointRestoreSessionId].SiteRestoreArtifactsBulkAdditionRequests.PostAsync(body, requestConfiguration =>
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
