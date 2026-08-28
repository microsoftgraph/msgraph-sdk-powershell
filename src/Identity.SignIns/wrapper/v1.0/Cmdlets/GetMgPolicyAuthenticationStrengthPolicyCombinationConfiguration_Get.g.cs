#nullable enable

using System;
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
    [GraphRoute("GET", "/policies/authenticationStrengthPolicies/{authenticationStrengthPolicy-id}/combinationConfigurations/{authenticationCombinationConfiguration-id}")]
    [Cmdlet(VerbsCommon.Get, "MgPolicyAuthenticationStrengthPolicyCombinationConfiguration_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationCombinationConfiguration))]
    public class GetMgPolicyAuthenticationStrengthPolicyCombinationConfiguration_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationStrengthPolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AuthenticationCombinationConfigurationId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationCombinationConfiguration? result;
            try
            {
                result = client.Policies.AuthenticationStrengthPolicies[AuthenticationStrengthPolicyId].CombinationConfigurations[AuthenticationCombinationConfigurationId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AuthenticationCombinationConfigurationId);
                return;
            }

            WriteObject(result);
        }
    }
}
