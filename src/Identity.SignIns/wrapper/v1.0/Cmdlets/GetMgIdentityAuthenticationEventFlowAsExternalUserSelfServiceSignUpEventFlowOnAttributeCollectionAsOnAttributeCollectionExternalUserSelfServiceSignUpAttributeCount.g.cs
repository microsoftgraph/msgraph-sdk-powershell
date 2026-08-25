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
    [GraphRoute("GET", "/identity/authenticationEventsFlows/{authenticationEventsFlow-id}/graph.externalUsersSelfServiceSignUpEventsFlow/onAttributeCollection/graph.onAttributeCollectionExternalUsersSelfServiceSignUp/attributes/$count")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowOnAttributeCollectionAsOnAttributeCollectionExternalUserSelfServiceSignUpAttributeCount")]
    [OutputType(typeof(int))]
    public class GetMgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowOnAttributeCollectionAsOnAttributeCollectionExternalUserSelfServiceSignUpAttributeCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationEventsFlowId { get; set; } = string.Empty;



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
                result = client.Identity.AuthenticationEventsFlows[AuthenticationEventsFlowId].GraphExternalUsersSelfServiceSignUpEventsFlow.OnAttributeCollection.GraphOnAttributeCollectionExternalUsersSelfServiceSignUp.Attributes.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AuthenticationEventsFlowId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
