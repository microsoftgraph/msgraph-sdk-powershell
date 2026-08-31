#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition-id}/instances/{accessReviewInstance-id}/acceptRecommendations")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessReviewScheduleDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessReviewInstanceId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessReviewInstanceId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.AccessReviews.Definitions[AccessReviewScheduleDefinitionId].Instances[AccessReviewInstanceId].AcceptRecommendations.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessReviewInstanceId);
                return;
            }

        }
    }
}
