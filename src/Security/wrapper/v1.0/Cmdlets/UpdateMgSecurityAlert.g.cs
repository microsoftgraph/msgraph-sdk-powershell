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
    [GraphRoute("PATCH", "/security/alerts/{alert-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityAlert", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Alert))]
    public class UpdateMgSecurityAlertCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AlertId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ActivityGroupName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssignedTo { get; set; }

        [Parameter(Mandatory = false)]
        public string? AzureSubscriptionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AzureTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Category { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ClosedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Comments { get; set; }

        [Parameter(Mandatory = false)]
        public int? Confidence { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? DetectionIds { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EventDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? IncidentIds { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastEventDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RecommendedActions { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SourceMaterials { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Tags { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AlertDetection[]? AlertDetections { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.CloudAppSecurityState[]? CloudAppStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AlertFeedback? Feedback { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.FileSecurityState[]? FileStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AlertHistoryState[]? HistoryStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.HostSecurityState[]? HostStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.InvestigationSecurityState[]? InvestigationSecurityStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.MalwareState[]? MalwareStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.MessageSecurityState[]? MessageSecurityStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.NetworkConnection[]? NetworkConnections { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Process[]? Processes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.RegistryKeyState[]? RegistryKeyStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SecurityResource[]? SecurityResources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AlertSeverity? Severity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AlertStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AlertTrigger[]? Triggers { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.UriClickSecurityState[]? UriClickSecurityStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.UserSecurityState[]? UserStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SecurityVendorInformation? VendorInformation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.VulnerabilityState[]? VulnerabilityStates { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AlertId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Alert();

    if (this.IsParameterBound(nameof(ActivityGroupName)))
        body.ActivityGroupName = ActivityGroupName;

    if (this.IsParameterBound(nameof(AssignedTo)))
        body.AssignedTo = AssignedTo;

    if (this.IsParameterBound(nameof(AzureSubscriptionId)))
        body.AzureSubscriptionId = AzureSubscriptionId;

    if (this.IsParameterBound(nameof(AzureTenantId)))
        body.AzureTenantId = AzureTenantId;

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(ClosedDateTime)))
        body.ClosedDateTime = ClosedDateTime;

    if (this.IsParameterBound(nameof(Comments)))
        body.Comments = Comments!.ToList();

    if (this.IsParameterBound(nameof(Confidence)))
        body.Confidence = Confidence;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DetectionIds)))
        body.DetectionIds = DetectionIds!.ToList();

    if (this.IsParameterBound(nameof(EventDateTime)))
        body.EventDateTime = EventDateTime;

    if (this.IsParameterBound(nameof(IncidentIds)))
        body.IncidentIds = IncidentIds!.ToList();

    if (this.IsParameterBound(nameof(LastEventDateTime)))
        body.LastEventDateTime = LastEventDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(RecommendedActions)))
        body.RecommendedActions = RecommendedActions!.ToList();

    if (this.IsParameterBound(nameof(SourceMaterials)))
        body.SourceMaterials = SourceMaterials!.ToList();

    if (this.IsParameterBound(nameof(Tags)))
        body.Tags = Tags!.ToList();

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(AlertDetections)))
        body.AlertDetections = AlertDetections!.ToList();

    if (this.IsParameterBound(nameof(CloudAppStates)))
        body.CloudAppStates = CloudAppStates!.ToList();

    if (this.IsParameterBound(nameof(Feedback)))
        body.Feedback = Feedback;

    if (this.IsParameterBound(nameof(FileStates)))
        body.FileStates = FileStates!.ToList();

    if (this.IsParameterBound(nameof(HistoryStates)))
        body.HistoryStates = HistoryStates!.ToList();

    if (this.IsParameterBound(nameof(HostStates)))
        body.HostStates = HostStates!.ToList();

    if (this.IsParameterBound(nameof(InvestigationSecurityStates)))
        body.InvestigationSecurityStates = InvestigationSecurityStates!.ToList();

    if (this.IsParameterBound(nameof(MalwareStates)))
        body.MalwareStates = MalwareStates!.ToList();

    if (this.IsParameterBound(nameof(MessageSecurityStates)))
        body.MessageSecurityStates = MessageSecurityStates!.ToList();

    if (this.IsParameterBound(nameof(NetworkConnections)))
        body.NetworkConnections = NetworkConnections!.ToList();

    if (this.IsParameterBound(nameof(Processes)))
        body.Processes = Processes!.ToList();

    if (this.IsParameterBound(nameof(RegistryKeyStates)))
        body.RegistryKeyStates = RegistryKeyStates!.ToList();

    if (this.IsParameterBound(nameof(SecurityResources)))
        body.SecurityResources = SecurityResources!.ToList();

    if (this.IsParameterBound(nameof(Severity)))
        body.Severity = Severity;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Triggers)))
        body.Triggers = Triggers!.ToList();

    if (this.IsParameterBound(nameof(UriClickSecurityStates)))
        body.UriClickSecurityStates = UriClickSecurityStates!.ToList();

    if (this.IsParameterBound(nameof(UserStates)))
        body.UserStates = UserStates!.ToList();

    if (this.IsParameterBound(nameof(VendorInformation)))
        body.VendorInformation = VendorInformation;

    if (this.IsParameterBound(nameof(VulnerabilityStates)))
        body.VulnerabilityStates = VulnerabilityStates!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Alert? result;
            try
            {
                result = client.Security.Alerts[AlertId].PatchAsync(body, requestConfiguration =>
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
                    result = client.Security.Alerts[AlertId].GetAsync().GetAwaiter().GetResult();
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
