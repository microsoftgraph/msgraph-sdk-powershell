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
    [GraphRoute("PATCH", "/auditLogs/customSecurityAttributeAudits/{customSecurityAttributeAudit-id}")]
    [Cmdlet(VerbsData.Update, "MgAuditLogCustomSecurityAttributeAudit", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.CustomSecurityAttributeAudit))]
    public class UpdateMgAuditLogCustomSecurityAttributeAuditCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CustomSecurityAttributeAuditId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ActivityDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Category { get; set; }

        [Parameter(Mandatory = false)]
        public string? CorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? LoggedByService { get; set; }

        [Parameter(Mandatory = false)]
        public string? OperationType { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResultReason { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserAgent { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.KeyValue[]? AdditionalDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.AuditActivityInitiator? InitiatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.OperationResult? Result { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.TargetResource[]? TargetResources { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CustomSecurityAttributeAuditId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.CustomSecurityAttributeAudit();

    if (this.IsParameterBound(nameof(ActivityDateTime)))
        body.ActivityDateTime = ActivityDateTime;

    if (this.IsParameterBound(nameof(ActivityDisplayName)))
        body.ActivityDisplayName = ActivityDisplayName;

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(CorrelationId)))
        body.CorrelationId = CorrelationId;

    if (this.IsParameterBound(nameof(LoggedByService)))
        body.LoggedByService = LoggedByService;

    if (this.IsParameterBound(nameof(OperationType)))
        body.OperationType = OperationType;

    if (this.IsParameterBound(nameof(ResultReason)))
        body.ResultReason = ResultReason;

    if (this.IsParameterBound(nameof(UserAgent)))
        body.UserAgent = UserAgent;

    if (this.IsParameterBound(nameof(AdditionalDetails)))
        body.AdditionalDetails = AdditionalDetails!.ToList();

    if (this.IsParameterBound(nameof(InitiatedBy)))
        body.InitiatedBy = InitiatedBy;

    if (this.IsParameterBound(nameof(Result)))
        body.Result = Result;

    if (this.IsParameterBound(nameof(TargetResources)))
        body.TargetResources = TargetResources!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.CustomSecurityAttributeAudit? result;
            try
            {
                result = client.AuditLogs.CustomSecurityAttributeAudits[CustomSecurityAttributeAuditId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CustomSecurityAttributeAuditId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.AuditLogs.CustomSecurityAttributeAudits[CustomSecurityAttributeAuditId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CustomSecurityAttributeAuditId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
