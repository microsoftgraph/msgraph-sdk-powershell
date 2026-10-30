#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/partner/securityAlerts")]
    [Cmdlet(VerbsCommon.New, "MgSecurityPartnerSecurityAlert", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.PartnerSecurityAlert))]
    public class NewMgSecurityPartnerSecurityAlertCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AlertType { get; set; }

        [Parameter(Mandatory = false)]
        public string? CatalogOfferId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomerTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DetectedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstObservedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTest { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastObservedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResolvedBy { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ResolvedOnDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubscriptionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ValueAddedResellerTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.ActivityLog[]? ActivityLogs { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.AdditionalDataDictionary? AdditionalDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.AffectedResource[]? AffectedResources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityAlertConfidence? ConfidenceLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityAlertResolvedReason? ResolvedReason { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityAlertSeverity? Severity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityAlertStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.PartnerSecurityAlert();

    if (this.IsParameterBound(nameof(AlertType)))
        body.AlertType = AlertType;

    if (this.IsParameterBound(nameof(CatalogOfferId)))
        body.CatalogOfferId = CatalogOfferId;

    if (this.IsParameterBound(nameof(CustomerTenantId)))
        body.CustomerTenantId = CustomerTenantId;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DetectedDateTime)))
        body.DetectedDateTime = DetectedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FirstObservedDateTime)))
        body.FirstObservedDateTime = FirstObservedDateTime;

    if (this.IsParameterBound(nameof(IsTest)))
        body.IsTest = IsTest;

    if (this.IsParameterBound(nameof(LastObservedDateTime)))
        body.LastObservedDateTime = LastObservedDateTime;

    if (this.IsParameterBound(nameof(ResolvedBy)))
        body.ResolvedBy = ResolvedBy;

    if (this.IsParameterBound(nameof(ResolvedOnDateTime)))
        body.ResolvedOnDateTime = ResolvedOnDateTime;

    if (this.IsParameterBound(nameof(SubscriptionId)))
        body.SubscriptionId = SubscriptionId;

    if (this.IsParameterBound(nameof(ValueAddedResellerTenantId)))
        body.ValueAddedResellerTenantId = ValueAddedResellerTenantId;

    if (this.IsParameterBound(nameof(ActivityLogs)))
        body.ActivityLogs = ActivityLogs!.ToList();

    if (this.IsParameterBound(nameof(AdditionalDetails)))
        body.AdditionalDetails = AdditionalDetails;

    if (this.IsParameterBound(nameof(AffectedResources)))
        body.AffectedResources = AffectedResources!.ToList();

    if (this.IsParameterBound(nameof(ConfidenceLevel)))
        body.ConfidenceLevel = ConfidenceLevel;

    if (this.IsParameterBound(nameof(ResolvedReason)))
        body.ResolvedReason = ResolvedReason;

    if (this.IsParameterBound(nameof(Severity)))
        body.Severity = Severity;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.PartnerSecurityAlert? result;
            try
            {
                result = client.Security.Partner.SecurityAlerts.PostAsync(body, requestConfiguration =>
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
