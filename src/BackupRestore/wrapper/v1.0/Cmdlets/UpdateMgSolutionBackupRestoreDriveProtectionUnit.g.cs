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
    [GraphRoute("PATCH", "/solutions/backupRestore/driveProtectionUnits/{driveProtectionUnit-id}")]
    [Cmdlet(VerbsData.Update, "MgSolutionBackupRestoreDriveProtectionUnit", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BackupRestore.Client.Models.DriveProtectionUnit))]
    public class UpdateMgSolutionBackupRestoreDriveProtectionUnitCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveProtectionUnitId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OffboardRequestedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DirectoryObjectId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.PublicError? Error { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ProtectionSource? ProtectionSources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BackupRestore.Client.Models.ProtectionUnitStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveProtectionUnitId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.BackupRestore.Client.Models.DriveProtectionUnit();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(OffboardRequestedDateTime)))
        body.OffboardRequestedDateTime = OffboardRequestedDateTime;

    if (this.IsParameterBound(nameof(PolicyId)))
        body.PolicyId = PolicyId;

    if (this.IsParameterBound(nameof(DirectoryObjectId)))
        body.DirectoryObjectId = DirectoryObjectId;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(ProtectionSources)))
        body.ProtectionSources = ProtectionSources;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BackupRestore.Client.Models.DriveProtectionUnit? result;
            try
            {
                result = client.Solutions.BackupRestore.DriveProtectionUnits[DriveProtectionUnitId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DriveProtectionUnitId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BackupRestore.DriveProtectionUnits[DriveProtectionUnitId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, DriveProtectionUnitId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
