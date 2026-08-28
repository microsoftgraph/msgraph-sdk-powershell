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
    [GraphRoute("POST", "/identity/riskPrevention/webApplicationFirewallVerifications")]
    [Cmdlet(VerbsCommon.New, "MgIdentityRiskPreventionWebApplicationFirewallVerification", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.WebApplicationFirewallVerificationModel))]
    public class NewMgIdentityRiskPreventionWebApplicationFirewallVerificationCommand : GraphClientCmdlet
    {


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
            if (!ShouldProcess(null, "New"))
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
                result = client.Identity.RiskPrevention.WebApplicationFirewallVerifications.PostAsync(body, requestConfiguration =>
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
