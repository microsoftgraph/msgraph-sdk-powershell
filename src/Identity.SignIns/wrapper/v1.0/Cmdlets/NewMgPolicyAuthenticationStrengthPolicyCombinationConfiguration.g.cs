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
    [GraphRoute("POST", "/policies/authenticationStrengthPolicies/{authenticationStrengthPolicy-id}/combinationConfigurations")]
    [Cmdlet(VerbsCommon.New, "MgPolicyAuthenticationStrengthPolicyCombinationConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationCombinationConfiguration))]
    public class NewMgPolicyAuthenticationStrengthPolicyCombinationConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationStrengthPolicyId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationMethodModes?[]? AppliesToCombinations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthenticationStrengthPolicyId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationCombinationConfiguration();


    if (this.IsParameterBound(nameof(AppliesToCombinations)))
        body.AppliesToCombinations = AppliesToCombinations!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationCombinationConfiguration? result;
            try
            {
                result = client.Policies.AuthenticationStrengthPolicies[AuthenticationStrengthPolicyId].CombinationConfigurations.PostAsync(body, requestConfiguration =>
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
