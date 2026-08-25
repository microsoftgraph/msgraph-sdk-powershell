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
    [GraphRoute("PATCH", "/identityProtection/riskyUsers/{riskyUser-id}")]
    [Cmdlet(VerbsData.Update, "MgRiskyUser", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyUser))]
    public class UpdateMgRiskyUserCommand : GraphClientCmdlet
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
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetail? RiskDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskLevel? RiskLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskState? RiskState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RiskyUserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyUser();

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

    if (this.IsParameterBound(nameof(RiskDetail)))
        body.RiskDetail = RiskDetail;

    if (this.IsParameterBound(nameof(RiskLevel)))
        body.RiskLevel = RiskLevel;

    if (this.IsParameterBound(nameof(RiskState)))
        body.RiskState = RiskState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskyUser? result;
            try
            {
                result = client.IdentityProtection.RiskyUsers[RiskyUserId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, RiskyUserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityProtection.RiskyUsers[RiskyUserId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, RiskyUserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
