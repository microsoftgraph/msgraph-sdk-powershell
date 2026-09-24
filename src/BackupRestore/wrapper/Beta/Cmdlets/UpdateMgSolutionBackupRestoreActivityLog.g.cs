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
    [GraphRoute("PATCH", "/solutions/backupRestore/activityLogs/{activityLogBase-id}")]
    [Cmdlet(VerbsData.Update, "MgSolutionBackupRestoreActivityLog", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ActivityLogBase))]
    public class UpdateMgSolutionBackupRestoreActivityLogCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ActivityLogBaseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EventDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PerformedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ActivityLogOperationType? ActivityType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.PublicError? Error { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ActivityLogResultStatus? ResultStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ServiceType? ServiceType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ActivityLogSeverity? Severity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ActivityLogBaseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ActivityLogBase();

    if (this.IsParameterBound(nameof(EventDateTime)))
        body.EventDateTime = EventDateTime;

    if (this.IsParameterBound(nameof(PerformedBy)))
        body.PerformedBy = PerformedBy;

    if (this.IsParameterBound(nameof(ActivityType)))
        body.ActivityType = ActivityType;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;

    if (this.IsParameterBound(nameof(ResultStatus)))
        body.ResultStatus = ResultStatus;

    if (this.IsParameterBound(nameof(ServiceType)))
        body.ServiceType = ServiceType;

    if (this.IsParameterBound(nameof(Severity)))
        body.Severity = Severity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ActivityLogBase? result;
            try
            {
                result = client.Solutions.BackupRestore.ActivityLogs[ActivityLogBaseId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ActivityLogBaseId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BackupRestore.ActivityLogs[ActivityLogBaseId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ActivityLogBaseId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
