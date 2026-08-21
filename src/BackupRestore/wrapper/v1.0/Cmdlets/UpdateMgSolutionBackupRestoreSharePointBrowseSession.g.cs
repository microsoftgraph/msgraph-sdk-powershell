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
    [GraphRoute("PATCH", "/solutions/backupRestore/sharePointBrowseSessions/{sharePointBrowseSession-id}")]
    [Cmdlet(VerbsData.Update, "MgSolutionBackupRestoreSharePointBrowseSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SharePointBrowseSession))]
    public class UpdateMgSolutionBackupRestoreSharePointBrowseSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharePointBrowseSessionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? BackupSizeInBytes { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RestorePointDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RestorePointId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.PublicError? Error { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.BrowseSessionStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SharePointBrowseSessionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SharePointBrowseSession();

    if (this.IsParameterBound(nameof(BackupSizeInBytes)))
        body.BackupSizeInBytes = BackupSizeInBytes;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(RestorePointDateTime)))
        body.RestorePointDateTime = RestorePointDateTime;

    if (this.IsParameterBound(nameof(RestorePointId)))
        body.RestorePointId = RestorePointId;

    if (this.IsParameterBound(nameof(SiteId)))
        body.SiteId = SiteId;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.SharePointBrowseSession? result;
            try
            {
                result = client.Solutions.BackupRestore.SharePointBrowseSessions[SharePointBrowseSessionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, SharePointBrowseSessionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BackupRestore.SharePointBrowseSessions[SharePointBrowseSessionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, SharePointBrowseSessionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
