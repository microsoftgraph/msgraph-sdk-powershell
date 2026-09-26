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
    [GraphRoute("POST", "/identityGovernance/accessReviews/unified/instances/{accessReviewInstance-id}/batchApplyCustomDataProvidedResourceDecisions")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityGovernanceAccessReviewUnifiedInstanceBatchApplyCustomDataProvidedResourceDecisions", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgIdentityGovernanceAccessReviewUnifiedInstanceBatchApplyCustomDataProvidedResourceDecisionsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessReviewInstanceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ApplyDescription { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomDataProvidedResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewInstanceDecisionItemApplyResult? ApplyResult { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessReviewInstanceId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.AccessReviews.Unified.Instances.Item.BatchApplyCustomDataProvidedResourceDecisions.BatchApplyCustomDataProvidedResourceDecisionsPostRequestBody();

    if (this.IsParameterBound(nameof(ApplyDescription)))
        body.ApplyDescription = ApplyDescription;

    if (this.IsParameterBound(nameof(CustomDataProvidedResourceId)))
        body.CustomDataProvidedResourceId = CustomDataProvidedResourceId;
    if (this.IsParameterBound(nameof(ApplyResult)))
        body.ApplyResult = ApplyResult;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.AccessReviews.Unified.Instances[AccessReviewInstanceId].BatchApplyCustomDataProvidedResourceDecisions.PostAsync(body, requestConfiguration =>
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
