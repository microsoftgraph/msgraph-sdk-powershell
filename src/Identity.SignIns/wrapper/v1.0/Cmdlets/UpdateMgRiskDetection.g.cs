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
    [GraphRoute("PATCH", "/identityProtection/riskDetections/{riskDetection-id}")]
    [Cmdlet(VerbsData.Update, "MgRiskDetection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetection))]
    public class UpdateMgRiskDetectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RiskDetectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? AdditionalInfo { get; set; }

        [Parameter(Mandatory = false)]
        public string? CorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DetectedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? IpAddress { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RiskEventType { get; set; }

        [Parameter(Mandatory = false)]
        public string? Source { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ActivityType? Activity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetectionTimingType? DetectionTimingType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.SignInLocation? Location { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetail? RiskDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskLevel? RiskLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskState? RiskState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TokenIssuerType? TokenIssuerType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RiskDetectionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetection();

    if (this.IsParameterBound(nameof(ActivityDateTime)))
        body.ActivityDateTime = ActivityDateTime;

    if (this.IsParameterBound(nameof(AdditionalInfo)))
        body.AdditionalInfo = AdditionalInfo;

    if (this.IsParameterBound(nameof(CorrelationId)))
        body.CorrelationId = CorrelationId;

    if (this.IsParameterBound(nameof(DetectedDateTime)))
        body.DetectedDateTime = DetectedDateTime;

    if (this.IsParameterBound(nameof(IpAddress)))
        body.IpAddress = IpAddress;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(RequestId)))
        body.RequestId = RequestId;

    if (this.IsParameterBound(nameof(RiskEventType)))
        body.RiskEventType = RiskEventType;

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(UserDisplayName)))
        body.UserDisplayName = UserDisplayName;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;

    if (this.IsParameterBound(nameof(DetectionTimingType)))
        body.DetectionTimingType = DetectionTimingType;

    if (this.IsParameterBound(nameof(Location)))
        body.Location = Location;

    if (this.IsParameterBound(nameof(RiskDetail)))
        body.RiskDetail = RiskDetail;

    if (this.IsParameterBound(nameof(RiskLevel)))
        body.RiskLevel = RiskLevel;

    if (this.IsParameterBound(nameof(RiskState)))
        body.RiskState = RiskState;

    if (this.IsParameterBound(nameof(TokenIssuerType)))
        body.TokenIssuerType = TokenIssuerType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetection? result;
            try
            {
                result = client.IdentityProtection.RiskDetections[RiskDetectionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, RiskDetectionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityProtection.RiskDetections[RiskDetectionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, RiskDetectionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
