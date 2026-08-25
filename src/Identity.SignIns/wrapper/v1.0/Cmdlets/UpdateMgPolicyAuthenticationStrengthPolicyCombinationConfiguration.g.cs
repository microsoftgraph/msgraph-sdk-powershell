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
    [GraphRoute("PATCH", "/policies/authenticationStrengthPolicies/{authenticationStrengthPolicy-id}/combinationConfigurations/{authenticationCombinationConfiguration-id}")]
    [Cmdlet(VerbsData.Update, "MgPolicyAuthenticationStrengthPolicyCombinationConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationCombinationConfiguration))]
    public class UpdateMgPolicyAuthenticationStrengthPolicyCombinationConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationStrengthPolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AuthenticationCombinationConfigurationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationMethodModes?[]? AppliesToCombinations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthenticationCombinationConfigurationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationCombinationConfiguration();


    if (this.IsParameterBound(nameof(AppliesToCombinations)))
        body.AppliesToCombinations = AppliesToCombinations!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationCombinationConfiguration? result;
            try
            {
                result = client.Policies.AuthenticationStrengthPolicies[AuthenticationStrengthPolicyId].CombinationConfigurations[AuthenticationCombinationConfigurationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AuthenticationCombinationConfigurationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.AuthenticationStrengthPolicies[AuthenticationStrengthPolicyId].CombinationConfigurations[AuthenticationCombinationConfigurationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AuthenticationCombinationConfigurationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
