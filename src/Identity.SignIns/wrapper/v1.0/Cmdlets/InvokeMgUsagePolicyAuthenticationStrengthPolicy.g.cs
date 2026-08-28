#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/policies/authenticationStrengthPolicies/{authenticationStrengthPolicy-id}/usage()")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUsagePolicyAuthenticationStrengthPolicy")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationStrengthUsage))]
    public class InvokeMgUsagePolicyAuthenticationStrengthPolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationStrengthPolicyId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationStrengthUsage? result;
            try
            {
                result = client.Policies.AuthenticationStrengthPolicies[AuthenticationStrengthPolicyId].Usage.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AuthenticationStrengthPolicyId);
                return;
            }

            WriteObject(result);
        }
    }
}
