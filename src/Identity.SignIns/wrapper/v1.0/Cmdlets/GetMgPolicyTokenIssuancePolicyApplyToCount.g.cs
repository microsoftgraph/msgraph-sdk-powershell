#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("GET", "/policies/tokenIssuancePolicies/{tokenIssuancePolicy-id}/appliesTo/$count")]
    [Cmdlet(VerbsCommon.Get, "MgPolicyTokenIssuancePolicyApplyToCount")]
    [OutputType(typeof(int))]
    public class GetMgPolicyTokenIssuancePolicyApplyToCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TokenIssuancePolicyId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Policies.TokenIssuancePolicies[TokenIssuancePolicyId].AppliesTo.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TokenIssuancePolicyId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
