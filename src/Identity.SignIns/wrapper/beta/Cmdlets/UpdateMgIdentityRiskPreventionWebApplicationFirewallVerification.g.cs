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
    [GraphRoute("PATCH", "/identity/riskPrevention/webApplicationFirewallVerifications/{webApplicationFirewallVerificationModel-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityRiskPreventionWebApplicationFirewallVerification", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.WebApplicationFirewallVerificationModel))]
    public class UpdateMgIdentityRiskPreventionWebApplicationFirewallVerificationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WebApplicationFirewallVerificationModelId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? VerifiedHost { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.WebApplicationFirewallProviderType? ProviderType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.WebApplicationFirewallVerificationResult? VerificationResult { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.WebApplicationFirewallVerifiedDetails? VerifiedDetails { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WebApplicationFirewallVerificationModelId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.WebApplicationFirewallVerificationModel();

    if (this.IsParameterBound(nameof(VerifiedHost)))
        body.VerifiedHost = VerifiedHost;

    if (this.IsParameterBound(nameof(ProviderType)))
        body.ProviderType = ProviderType;

    if (this.IsParameterBound(nameof(VerificationResult)))
        body.VerificationResult = VerificationResult;

    if (this.IsParameterBound(nameof(VerifiedDetails)))
        body.VerifiedDetails = VerifiedDetails;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.WebApplicationFirewallVerificationModel? result;
            try
            {
                result = client.Identity.RiskPrevention.WebApplicationFirewallVerifications[WebApplicationFirewallVerificationModelId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WebApplicationFirewallVerificationModelId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Identity.RiskPrevention.WebApplicationFirewallVerifications[WebApplicationFirewallVerificationModelId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WebApplicationFirewallVerificationModelId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
