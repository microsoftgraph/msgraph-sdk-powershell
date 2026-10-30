#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/identityProtection/agentRiskDetections/{agentRiskDetection-id}")]
    [Cmdlet(VerbsData.Update, "MgAgentRiskDetection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AgentRiskDetection))]
    public class UpdateMgAgentRiskDetectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AgentRiskDetectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? AdditionalInfo { get; set; }

        [Parameter(Mandatory = false)]
        public string? AgentDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AgentId { get; set; }

        [Parameter(Mandatory = false)]
        public string? BlueprintId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientSessionId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DetectedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? IdentityId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RiskEventType { get; set; }

        [Parameter(Mandatory = false)]
        public string? RiskEvidence { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignInClientDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignInCorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignInRequestId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Source { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetectionTimingType? DetectionTimingType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AgentIdentityType? IdentityType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetail? RiskDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskLevel? RiskLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskState? RiskState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AgentRiskDetectionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AgentRiskDetection();

    if (this.IsParameterBound(nameof(ActivityDateTime)))
        body.ActivityDateTime = ActivityDateTime;

    if (this.IsParameterBound(nameof(AdditionalInfo)))
        body.AdditionalInfo = AdditionalInfo;

    if (this.IsParameterBound(nameof(AgentDisplayName)))
        body.AgentDisplayName = AgentDisplayName;

    if (this.IsParameterBound(nameof(AgentId)))
        body.AgentId = AgentId;

    if (this.IsParameterBound(nameof(BlueprintId)))
        body.BlueprintId = BlueprintId;

    if (this.IsParameterBound(nameof(ClientSessionId)))
        body.ClientSessionId = ClientSessionId;

    if (this.IsParameterBound(nameof(DetectedDateTime)))
        body.DetectedDateTime = DetectedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IdentityId)))
        body.IdentityId = IdentityId;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(RiskEventType)))
        body.RiskEventType = RiskEventType;

    if (this.IsParameterBound(nameof(RiskEvidence)))
        body.RiskEvidence = RiskEvidence;

    if (this.IsParameterBound(nameof(SignInClientDisplayName)))
        body.SignInClientDisplayName = SignInClientDisplayName;

    if (this.IsParameterBound(nameof(SignInCorrelationId)))
        body.SignInCorrelationId = SignInCorrelationId;

    if (this.IsParameterBound(nameof(SignInRequestId)))
        body.SignInRequestId = SignInRequestId;

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(DetectionTimingType)))
        body.DetectionTimingType = DetectionTimingType;

    if (this.IsParameterBound(nameof(IdentityType)))
        body.IdentityType = IdentityType;

    if (this.IsParameterBound(nameof(RiskDetail)))
        body.RiskDetail = RiskDetail;

    if (this.IsParameterBound(nameof(RiskLevel)))
        body.RiskLevel = RiskLevel;

    if (this.IsParameterBound(nameof(RiskState)))
        body.RiskState = RiskState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AgentRiskDetection? result;
            try
            {
                result = client.IdentityProtection.AgentRiskDetections[AgentRiskDetectionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AgentRiskDetectionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityProtection.AgentRiskDetections[AgentRiskDetectionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AgentRiskDetectionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
