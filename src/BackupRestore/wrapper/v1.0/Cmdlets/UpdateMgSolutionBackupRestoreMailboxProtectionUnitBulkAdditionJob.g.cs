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
    [GraphRoute("PATCH", "/solutions/backupRestore/mailboxProtectionUnitsBulkAdditionJobs/{mailboxProtectionUnitsBulkAdditionJob-id}")]
    [Cmdlet(VerbsData.Update, "MgSolutionBackupRestoreMailboxProtectionUnitBulkAdditionJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxProtectionUnitsBulkAdditionJob))]
    public class UpdateMgSolutionBackupRestoreMailboxProtectionUnitBulkAdditionJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MailboxProtectionUnitsBulkAdditionJobId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? DirectoryObjectIds { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Mailboxes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.PublicError? Error { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ProtectionUnitsBulkJobStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MailboxProtectionUnitsBulkAdditionJobId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxProtectionUnitsBulkAdditionJob();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(DirectoryObjectIds)))
        body.DirectoryObjectIds = DirectoryObjectIds!.ToList();

    if (this.IsParameterBound(nameof(Mailboxes)))
        body.Mailboxes = Mailboxes!.ToList();

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxProtectionUnitsBulkAdditionJob? result;
            try
            {
                result = client.Solutions.BackupRestore.MailboxProtectionUnitsBulkAdditionJobs[MailboxProtectionUnitsBulkAdditionJobId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, MailboxProtectionUnitsBulkAdditionJobId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BackupRestore.MailboxProtectionUnitsBulkAdditionJobs[MailboxProtectionUnitsBulkAdditionJobId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, MailboxProtectionUnitsBulkAdditionJobId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
