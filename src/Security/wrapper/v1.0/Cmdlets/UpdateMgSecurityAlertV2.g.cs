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
    [GraphRoute("PATCH", "/security/alerts_v2/{alert-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityAlertV2", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.Alert))]
    public class UpdateMgSecurityAlertV2Command : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AlertId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ActorDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AlertPolicyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AlertWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssignedTo { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Categories { get; set; }

        [Parameter(Mandatory = false)]
        public string? Category { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DetectorId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? IncidentId { get; set; }

        [Parameter(Mandatory = false)]
        public string? IncidentWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? MitreTechniques { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProductName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProviderAlertId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecommendedActions { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ResolvedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SystemTags { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ThreatDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ThreatFamilyName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AlertClassification? Classification { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AlertComment[]? Comments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.Dictionary? CustomDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.DetectionSource? DetectionSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AlertDetermination? Determination { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AlertEvidence[]? Evidence { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.InvestigationState? InvestigationState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ServiceSource? ServiceSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AlertSeverity? Severity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AlertStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AlertId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.Alert();

    if (this.IsParameterBound(nameof(ActorDisplayName)))
        body.ActorDisplayName = ActorDisplayName;

    if (this.IsParameterBound(nameof(AlertPolicyId)))
        body.AlertPolicyId = AlertPolicyId;

    if (this.IsParameterBound(nameof(AlertWebUrl)))
        body.AlertWebUrl = AlertWebUrl;

    if (this.IsParameterBound(nameof(AssignedTo)))
        body.AssignedTo = AssignedTo;

    if (this.IsParameterBound(nameof(Categories)))
        body.Categories = Categories!.ToList();

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DetectorId)))
        body.DetectorId = DetectorId;

    if (this.IsParameterBound(nameof(FirstActivityDateTime)))
        body.FirstActivityDateTime = FirstActivityDateTime;

    if (this.IsParameterBound(nameof(IncidentId)))
        body.IncidentId = IncidentId;

    if (this.IsParameterBound(nameof(IncidentWebUrl)))
        body.IncidentWebUrl = IncidentWebUrl;

    if (this.IsParameterBound(nameof(LastActivityDateTime)))
        body.LastActivityDateTime = LastActivityDateTime;

    if (this.IsParameterBound(nameof(LastUpdateDateTime)))
        body.LastUpdateDateTime = LastUpdateDateTime;

    if (this.IsParameterBound(nameof(MitreTechniques)))
        body.MitreTechniques = MitreTechniques!.ToList();

    if (this.IsParameterBound(nameof(ProductName)))
        body.ProductName = ProductName;

    if (this.IsParameterBound(nameof(ProviderAlertId)))
        body.ProviderAlertId = ProviderAlertId;

    if (this.IsParameterBound(nameof(RecommendedActions)))
        body.RecommendedActions = RecommendedActions;

    if (this.IsParameterBound(nameof(ResolvedDateTime)))
        body.ResolvedDateTime = ResolvedDateTime;

    if (this.IsParameterBound(nameof(SystemTags)))
        body.SystemTags = SystemTags!.ToList();

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(ThreatDisplayName)))
        body.ThreatDisplayName = ThreatDisplayName;

    if (this.IsParameterBound(nameof(ThreatFamilyName)))
        body.ThreatFamilyName = ThreatFamilyName;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(Classification)))
        body.Classification = Classification;

    if (this.IsParameterBound(nameof(Comments)))
        body.Comments = Comments!.ToList();

    if (this.IsParameterBound(nameof(CustomDetails)))
        body.CustomDetails = CustomDetails;

    if (this.IsParameterBound(nameof(DetectionSource)))
        body.DetectionSource = DetectionSource;

    if (this.IsParameterBound(nameof(Determination)))
        body.Determination = Determination;

    if (this.IsParameterBound(nameof(Evidence)))
        body.Evidence = Evidence!.ToList();

    if (this.IsParameterBound(nameof(InvestigationState)))
        body.InvestigationState = InvestigationState;

    if (this.IsParameterBound(nameof(ServiceSource)))
        body.ServiceSource = ServiceSource;

    if (this.IsParameterBound(nameof(Severity)))
        body.Severity = Severity;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.Alert? result;
            try
            {
                result = client.Security.Alerts_v2[AlertId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AlertId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Alerts_v2[AlertId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, AlertId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
