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
    [GraphRoute("PATCH", "/identityGovernance/appConsent/appConsentRequests/{appConsentRequest-id}/userConsentRequests/{userConsentRequest-id}/approval")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Approval))]
    public class UpdateMgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AppConsentRequestId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserConsentRequestId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserConsentRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Approval();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Approval? result;
            try
            {
                result = client.IdentityGovernance.AppConsent.AppConsentRequests[AppConsentRequestId].UserConsentRequests[UserConsentRequestId].Approval.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UserConsentRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.AppConsent.AppConsentRequests[AppConsentRequestId].UserConsentRequests[UserConsentRequestId].Approval.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
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
