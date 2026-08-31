#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("DELETE", "/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition-id}/instances/{accessReviewInstance-id}/decisions/{accessReviewInstanceDecisionItem-id}/insights/{governanceInsight-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsightCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessReviewScheduleDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessReviewInstanceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AccessReviewInstanceDecisionItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string GovernanceInsightId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GovernanceInsightId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.IdentityGovernance.AccessReviews.Definitions[AccessReviewScheduleDefinitionId].Instances[AccessReviewInstanceId].Decisions[AccessReviewInstanceDecisionItemId].Insights[GovernanceInsightId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GovernanceInsightId);
                return;
            }
        }
    }
}
