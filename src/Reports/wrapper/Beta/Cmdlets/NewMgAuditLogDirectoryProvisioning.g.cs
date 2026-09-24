#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("POST", "/auditLogs/directoryProvisioning")]
    [Cmdlet(VerbsCommon.New, "MgAuditLogDirectoryProvisioning", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningObjectSummary))]
    public class NewMgAuditLogDirectoryProvisioningCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Action { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ChangeId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CycleId { get; set; }

        [Parameter(Mandatory = false)]
        public int? DurationInMilliseconds { get; set; }

        [Parameter(Mandatory = false)]
        public string? JobId { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.Initiator? InitiatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ModifiedProperty[]? ModifiedProperties { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningAction? ProvisioningAction { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningStatusInfo? ProvisioningStatusInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningStep[]? ProvisioningSteps { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningServicePrincipal? ServicePrincipal { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisionedIdentity? SourceIdentity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningSystem? SourceSystem { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.StatusBase? StatusInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisionedIdentity? TargetIdentity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningSystem? TargetSystem { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningObjectSummary();

    if (this.IsParameterBound(nameof(Action)))
        body.Action = Action;

    if (this.IsParameterBound(nameof(ActivityDateTime)))
        body.ActivityDateTime = ActivityDateTime;

    if (this.IsParameterBound(nameof(ChangeId)))
        body.ChangeId = ChangeId;

    if (this.IsParameterBound(nameof(CycleId)))
        body.CycleId = CycleId;

    if (this.IsParameterBound(nameof(DurationInMilliseconds)))
        body.DurationInMilliseconds = DurationInMilliseconds;

    if (this.IsParameterBound(nameof(JobId)))
        body.JobId = JobId;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(InitiatedBy)))
        body.InitiatedBy = InitiatedBy;

    if (this.IsParameterBound(nameof(ModifiedProperties)))
        body.ModifiedProperties = ModifiedProperties!.ToList();

    if (this.IsParameterBound(nameof(ProvisioningAction)))
        body.ProvisioningAction = ProvisioningAction;

    if (this.IsParameterBound(nameof(ProvisioningStatusInfo)))
        body.ProvisioningStatusInfo = ProvisioningStatusInfo;

    if (this.IsParameterBound(nameof(ProvisioningSteps)))
        body.ProvisioningSteps = ProvisioningSteps!.ToList();

    if (this.IsParameterBound(nameof(ServicePrincipal)))
        body.ServicePrincipal = ServicePrincipal;

    if (this.IsParameterBound(nameof(SourceIdentity)))
        body.SourceIdentity = SourceIdentity;

    if (this.IsParameterBound(nameof(SourceSystem)))
        body.SourceSystem = SourceSystem;

    if (this.IsParameterBound(nameof(StatusInfo)))
        body.StatusInfo = StatusInfo;

    if (this.IsParameterBound(nameof(TargetIdentity)))
        body.TargetIdentity = TargetIdentity;

    if (this.IsParameterBound(nameof(TargetSystem)))
        body.TargetSystem = TargetSystem;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.ProvisioningObjectSummary? result;
            try
            {
                result = client.AuditLogs.DirectoryProvisioning.PostAsync(body, requestConfiguration =>
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
