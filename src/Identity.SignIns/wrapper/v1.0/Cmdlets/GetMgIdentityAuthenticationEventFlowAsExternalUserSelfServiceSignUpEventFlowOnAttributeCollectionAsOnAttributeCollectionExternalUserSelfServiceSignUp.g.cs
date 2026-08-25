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
    [GraphRoute("GET", "/identity/authenticationEventsFlows/{authenticationEventsFlow-id}/graph.externalUsersSelfServiceSignUpEventsFlow/onAttributeCollection/graph.onAttributeCollectionExternalUsersSelfServiceSignUp")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowOnAttributeCollectionAsOnAttributeCollectionExternalUserSelfServiceSignUp")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.OnAttributeCollectionExternalUsersSelfServiceSignUp))]
    public class GetMgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowOnAttributeCollectionAsOnAttributeCollectionExternalUserSelfServiceSignUpCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationEventsFlowId { get; set; } = string.Empty;







        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.OnAttributeCollectionExternalUsersSelfServiceSignUp? result;
            try
            {
                result = client.Identity.AuthenticationEventsFlows[AuthenticationEventsFlowId].GraphExternalUsersSelfServiceSignUpEventsFlow.OnAttributeCollection.GraphOnAttributeCollectionExternalUsersSelfServiceSignUp.GetAsync(requestConfiguration =>
                {




        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AuthenticationEventsFlowId);
                return;
            }

            WriteObject(result);
        }
    }
}
