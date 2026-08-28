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
    [GraphRoute("POST", "/identityProtection/riskyUsers/{riskyUser-id}/history")]
    [Cmdlet(VerbsCommon.New, "MgRiskyUserHistory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyUserHistoryItem))]
    public class NewMgRiskyUserHistoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RiskyUserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsDeleted { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsProcessing { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RiskLastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? InitiatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetail? RiskDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskLevel? RiskLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskState? RiskState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskUserActivity? Activity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RiskyUserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyUserHistoryItem();

    if (this.IsParameterBound(nameof(IsDeleted)))
        body.IsDeleted = IsDeleted;

    if (this.IsParameterBound(nameof(IsProcessing)))
        body.IsProcessing = IsProcessing;

    if (this.IsParameterBound(nameof(RiskLastUpdatedDateTime)))
        body.RiskLastUpdatedDateTime = RiskLastUpdatedDateTime;

    if (this.IsParameterBound(nameof(UserDisplayName)))
        body.UserDisplayName = UserDisplayName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(InitiatedBy)))
        body.InitiatedBy = InitiatedBy;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(RiskDetail)))
        body.RiskDetail = RiskDetail;

    if (this.IsParameterBound(nameof(RiskLevel)))
        body.RiskLevel = RiskLevel;

    if (this.IsParameterBound(nameof(RiskState)))
        body.RiskState = RiskState;

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyUserHistoryItem? result;
            try
            {
                result = client.IdentityProtection.RiskyUsers[RiskyUserId].History.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
