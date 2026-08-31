#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/identity/riskPrevention/webApplicationFirewallProviders/{webApplicationFirewallProvider-id}/verify")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgIdentityRiskPreventionWebApplicationFirewallProvider", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.WebApplicationFirewallVerificationModel))]
    public class ConfirmMgIdentityRiskPreventionWebApplicationFirewallProviderCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WebApplicationFirewallProviderId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? HostName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WebApplicationFirewallProviderId, "Confirm"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Identity.RiskPrevention.WebApplicationFirewallProviders.Item.Verify.VerifyPostRequestBody();

    if (this.IsParameterBound(nameof(HostName)))
        body.HostName = HostName;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.WebApplicationFirewallVerificationModel? result;
            try
            {
                result = client.Identity.RiskPrevention.WebApplicationFirewallProviders[WebApplicationFirewallProviderId].Verify.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WebApplicationFirewallProviderId);
                return;
            }

            WriteObject(result);
        }
    }
}
