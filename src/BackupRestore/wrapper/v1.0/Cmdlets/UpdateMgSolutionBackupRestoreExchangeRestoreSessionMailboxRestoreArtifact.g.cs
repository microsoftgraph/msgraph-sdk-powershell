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
    [GraphRoute("PATCH", "/solutions/backupRestore/exchangeRestoreSessions/{exchangeRestoreSession-id}/mailboxRestoreArtifacts/{mailboxRestoreArtifact-id}")]
    [Cmdlet(VerbsData.Update, "MgSolutionBackupRestoreExchangeRestoreSessionMailboxRestoreArtifact", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxRestoreArtifact))]
    public class UpdateMgSolutionBackupRestoreExchangeRestoreSessionMailboxRestoreArtifactCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ExchangeRestoreSessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailboxRestoreArtifactId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RestoredFolderId { get; set; }

        [Parameter(Mandatory = false)]
        public int? RestoredItemCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.DestinationType? DestinationType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.PublicError? Error { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ArtifactRestoreStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MailboxRestoreArtifactId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxRestoreArtifact();

    if (this.IsParameterBound(nameof(CompletionDateTime)))
        body.CompletionDateTime = CompletionDateTime;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(RestoredFolderId)))
        body.RestoredFolderId = RestoredFolderId;

    if (this.IsParameterBound(nameof(RestoredItemCount)))
        body.RestoredItemCount = RestoredItemCount;

    if (this.IsParameterBound(nameof(DestinationType)))
        body.DestinationType = DestinationType;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.MailboxRestoreArtifact? result;
            try
            {
                result = client.Solutions.BackupRestore.ExchangeRestoreSessions[ExchangeRestoreSessionId].MailboxRestoreArtifacts[MailboxRestoreArtifactId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, MailboxRestoreArtifactId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BackupRestore.ExchangeRestoreSessions[ExchangeRestoreSessionId].MailboxRestoreArtifacts[MailboxRestoreArtifactId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, MailboxRestoreArtifactId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
