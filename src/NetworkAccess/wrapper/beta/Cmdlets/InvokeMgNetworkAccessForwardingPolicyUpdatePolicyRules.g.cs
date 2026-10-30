#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("POST", "/networkAccess/forwardingPolicies/{forwardingPolicy-id}/microsoft.graph.networkaccess.updatePolicyRules")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgNetworkAccessForwardingPolicyUpdatePolicyRules", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgNetworkAccessForwardingPolicyUpdatePolicyRulesCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ForwardingPolicyId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.PolicyRuleDelta[]? Rules { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ForwardingPolicyId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.NetworkAccess.Client.NetworkAccess.ForwardingPolicies.Item.MicrosoftGraphNetworkaccessUpdatePolicyRules.UpdatePolicyRulesPostRequestBody();

    if (this.IsParameterBound(nameof(Rules)))
        body.Rules = Rules!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.NetworkAccess.ForwardingPolicies[ForwardingPolicyId].MicrosoftGraphNetworkaccessUpdatePolicyRules.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ForwardingPolicyId);
                return;
            }

        }
    }
}
