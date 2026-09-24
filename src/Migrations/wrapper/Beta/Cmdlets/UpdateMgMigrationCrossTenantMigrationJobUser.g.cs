#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Migrations.Client;
using Microsoft.Graph.PowerShell.Migrations.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Migrations
{
    [GraphRoute("PATCH", "/solutions/migrations/crossTenantMigrationJobs/{crossTenantMigrationJob-id}/users/{crossTenantMigrationTask-id}")]
    [Cmdlet(VerbsData.Update, "MgMigrationCrossTenantMigrationJobUser", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationTask))]
    public class UpdateMgMigrationCrossTenantMigrationJobUserCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CrossTenantMigrationJobId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CrossTenantMigrationTaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaskType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationServiceStatusDetails[]? CurrentStatus { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CrossTenantMigrationTaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationTask();

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(TaskType)))
        body.TaskType = TaskType;

    if (this.IsParameterBound(nameof(CurrentStatus)))
        body.CurrentStatus = CurrentStatus!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationTask? result;
            try
            {
                result = client.Solutions.Migrations.CrossTenantMigrationJobs[CrossTenantMigrationJobId].Users[CrossTenantMigrationTaskId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CrossTenantMigrationTaskId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.Migrations.CrossTenantMigrationJobs[CrossTenantMigrationJobId].Users[CrossTenantMigrationTaskId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CrossTenantMigrationTaskId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
