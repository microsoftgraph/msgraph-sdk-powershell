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
    [GraphRoute("PATCH", "/identityGovernance/appConsent/appConsentRequests/{appConsentRequest-id}/userConsentRequests/{userConsentRequest-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceAppConsentRequestUserConsentRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UserConsentRequest))]
    public class UpdateMgIdentityGovernanceAppConsentRequestUserConsentRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AppConsentRequestId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserConsentRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ApprovalId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomData { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public string? Reason { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentitySet? CreatedBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserConsentRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UserConsentRequest();

    if (this.IsParameterBound(nameof(ApprovalId)))
        body.ApprovalId = ApprovalId;

    if (this.IsParameterBound(nameof(CompletedDateTime)))
        body.CompletedDateTime = CompletedDateTime;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CustomData)))
        body.CustomData = CustomData;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Reason)))
        body.Reason = Reason;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UserConsentRequest? result;
            try
            {
                result = client.IdentityGovernance.AppConsent.AppConsentRequests[AppConsentRequestId].UserConsentRequests[UserConsentRequestId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, UserConsentRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.AppConsent.AppConsentRequests[AppConsentRequestId].UserConsentRequests[UserConsentRequestId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, UserConsentRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
