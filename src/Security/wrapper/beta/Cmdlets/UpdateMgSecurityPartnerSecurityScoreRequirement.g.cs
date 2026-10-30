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
    [GraphRoute("PATCH", "/security/partner/securityScore/requirements/{securityRequirement-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityPartnerSecurityScoreRequirement", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityRequirement))]
    public class UpdateMgSecurityPartnerSecurityScoreRequirementCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SecurityRequirementId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ActionUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? HelpUrl { get; set; }

        [Parameter(Mandatory = false)]
        public long? MaxScore { get; set; }

        [Parameter(Mandatory = false)]
        public long? Score { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? UpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.ComplianceStatus? ComplianceStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityRequirementType? RequirementType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityRequirementState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SecurityRequirementId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityRequirement();

    if (this.IsParameterBound(nameof(ActionUrl)))
        body.ActionUrl = ActionUrl;

    if (this.IsParameterBound(nameof(HelpUrl)))
        body.HelpUrl = HelpUrl;

    if (this.IsParameterBound(nameof(MaxScore)))
        body.MaxScore = MaxScore;

    if (this.IsParameterBound(nameof(Score)))
        body.Score = Score;

    if (this.IsParameterBound(nameof(UpdatedDateTime)))
        body.UpdatedDateTime = UpdatedDateTime;

    if (this.IsParameterBound(nameof(ComplianceStatus)))
        body.ComplianceStatus = ComplianceStatus;

    if (this.IsParameterBound(nameof(RequirementType)))
        body.RequirementType = RequirementType;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Partner.Security.SecurityRequirement? result;
            try
            {
                result = client.Security.Partner.SecurityScore.Requirements[SecurityRequirementId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SecurityRequirementId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Partner.SecurityScore.Requirements[SecurityRequirementId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SecurityRequirementId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
