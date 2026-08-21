#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/identityGovernance/accessReviews/historyDefinitions")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceAccessReviewHistoryDefinition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryDefinition))]
    public class NewMgIdentityGovernanceAccessReviewHistoryDefinitionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReviewHistoryPeriodEndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReviewHistoryPeriodStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UserIdentity? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryDecisionFilter?[]? Decisions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryScheduleSettings? ScheduleSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewScope[]? Scopes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryDefinition();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ReviewHistoryPeriodEndDateTime)))
        body.ReviewHistoryPeriodEndDateTime = ReviewHistoryPeriodEndDateTime;

    if (this.IsParameterBound(nameof(ReviewHistoryPeriodStartDateTime)))
        body.ReviewHistoryPeriodStartDateTime = ReviewHistoryPeriodStartDateTime;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Decisions)))
        body.Decisions = Decisions!.ToList();

    if (this.IsParameterBound(nameof(ScheduleSettings)))
        body.ScheduleSettings = ScheduleSettings;

    if (this.IsParameterBound(nameof(Scopes)))
        body.Scopes = Scopes!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessReviewHistoryDefinition? result;
            try
            {
                result = client.IdentityGovernance.AccessReviews.HistoryDefinitions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
