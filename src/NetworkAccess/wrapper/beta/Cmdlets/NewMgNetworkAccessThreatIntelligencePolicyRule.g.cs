#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("POST", "/networkAccess/threatIntelligencePolicies/{threatIntelligencePolicy-id}/policyRules")]
    [Cmdlet(VerbsCommon.New, "MgNetworkAccessThreatIntelligencePolicyRule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.PolicyRule))]
    public class NewMgNetworkAccessThreatIntelligencePolicyRuleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ThreatIntelligencePolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ThreatIntelligencePolicyId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.PolicyRule();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.PolicyRule? result;
            try
            {
                result = client.NetworkAccess.ThreatIntelligencePolicies[ThreatIntelligencePolicyId].PolicyRules.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
