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
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/accessPackageSuggestions/{accessPackageSuggestion-id}")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementAccessPackageSuggestion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSuggestion))]
    public class UpdateMgEntitlementManagementAccessPackageSuggestionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageSuggestionId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSuggestionReason[]? Reasons { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageSuggestionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSuggestion();


    if (this.IsParameterBound(nameof(Reasons)))
        body.Reasons = Reasons!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSuggestion? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.AccessPackageSuggestions[AccessPackageSuggestionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageSuggestionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.AccessPackageSuggestions[AccessPackageSuggestionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AccessPackageSuggestionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
