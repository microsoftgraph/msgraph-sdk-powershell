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
    [GraphRoute("POST", "/policies/authenticationStrengthPolicies/{authenticationStrengthPolicy-id}/updateAllowedCombinations")]
    [Cmdlet(VerbsData.Update, "MgPolicyAuthenticationStrengthPolicyAllowedCombination", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UpdateAllowedCombinationsResult))]
    public class UpdateMgPolicyAuthenticationStrengthPolicyAllowedCombinationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationStrengthPolicyId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationMethodModes?[]? AllowedCombinations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthenticationStrengthPolicyId, "Update"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Policies.AuthenticationStrengthPolicies.Item.UpdateAllowedCombinations.UpdateAllowedCombinationsPostRequestBody();

    if (this.IsParameterBound(nameof(AllowedCombinations)))
        body.AllowedCombinations = AllowedCombinations!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UpdateAllowedCombinationsResult? result;
            try
            {
                result = client.Policies.AuthenticationStrengthPolicies[AuthenticationStrengthPolicyId].UpdateAllowedCombinations.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AuthenticationStrengthPolicyId);
                return;
            }

            WriteObject(result);
        }
    }
}
