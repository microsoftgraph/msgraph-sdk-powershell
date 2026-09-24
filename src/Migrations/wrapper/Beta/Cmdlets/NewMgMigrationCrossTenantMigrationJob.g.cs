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
    [GraphRoute("POST", "/solutions/migrations/crossTenantMigrationJobs")]
    [Cmdlet(VerbsCommon.New, "MgMigrationCrossTenantMigrationJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationJob))]
    public class NewMgMigrationCrossTenantMigrationJobCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompleteAfterDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Message { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Resources { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceType { get; set; }

        [Parameter(Mandatory = false)]
        public string? SourceTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? TargetTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Workloads { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Migrations.Client.Models.ExchangeOnlineCrossTenantMigrationSettings? ExchangeSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationJobType? JobType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationJobStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationJob();

    if (this.IsParameterBound(nameof(CompleteAfterDateTime)))
        body.CompleteAfterDateTime = CompleteAfterDateTime;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(Message)))
        body.Message = Message;

    if (this.IsParameterBound(nameof(Resources)))
        body.Resources = Resources!.ToList();

    if (this.IsParameterBound(nameof(ResourceType)))
        body.ResourceType = ResourceType;

    if (this.IsParameterBound(nameof(SourceTenantId)))
        body.SourceTenantId = SourceTenantId;

    if (this.IsParameterBound(nameof(TargetTenantId)))
        body.TargetTenantId = TargetTenantId;

    if (this.IsParameterBound(nameof(Workloads)))
        body.Workloads = Workloads!.ToList();

    if (this.IsParameterBound(nameof(ExchangeSettings)))
        body.ExchangeSettings = ExchangeSettings;

    if (this.IsParameterBound(nameof(JobType)))
        body.JobType = JobType;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Migrations.Client.Models.CrossTenantMigrationJob? result;
            try
            {
                result = client.Solutions.Migrations.CrossTenantMigrationJobs.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
