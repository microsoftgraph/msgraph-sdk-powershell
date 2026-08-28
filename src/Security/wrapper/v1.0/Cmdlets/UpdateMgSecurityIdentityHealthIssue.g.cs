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
    [GraphRoute("PATCH", "/security/identities/healthIssues/{healthIssue-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityIdentityHealthIssue", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.HealthIssue))]
    public class UpdateMgSecurityIdentityHealthIssueCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string HealthIssueId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? AdditionalInformation { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? DomainNames { get; set; }

        [Parameter(Mandatory = false)]
        public string? IssueTypeId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Recommendations { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RecommendedActionCommands { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SensorDNSNames { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.HealthIssueType? HealthIssueType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.HealthIssueSeverity? Severity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.HealthIssueStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(HealthIssueId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.HealthIssue();

    if (this.IsParameterBound(nameof(AdditionalInformation)))
        body.AdditionalInformation = AdditionalInformation!.ToList();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DomainNames)))
        body.DomainNames = DomainNames!.ToList();

    if (this.IsParameterBound(nameof(IssueTypeId)))
        body.IssueTypeId = IssueTypeId;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Recommendations)))
        body.Recommendations = Recommendations!.ToList();

    if (this.IsParameterBound(nameof(RecommendedActionCommands)))
        body.RecommendedActionCommands = RecommendedActionCommands!.ToList();

    if (this.IsParameterBound(nameof(SensorDNSNames)))
        body.SensorDNSNames = SensorDNSNames!.ToList();

    if (this.IsParameterBound(nameof(HealthIssueType)))
        body.HealthIssueType = HealthIssueType;

    if (this.IsParameterBound(nameof(Severity)))
        body.Severity = Severity;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.HealthIssue? result;
            try
            {
                result = client.Security.Identities.HealthIssues[HealthIssueId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, HealthIssueId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Identities.HealthIssues[HealthIssueId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, HealthIssueId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
