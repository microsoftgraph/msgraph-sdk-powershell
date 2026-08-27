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
    [GraphRoute("POST", "/identity/authenticationEventsFlows/{authenticationEventsFlow-id}/graph.externalUsersSelfServiceSignUpEventsFlow/onAuthenticationMethodLoadStart/graph.onAuthenticationMethodLoadStartExternalUsersSelfServiceSignUp/identityProviders/$ref")]
    [Cmdlet(VerbsCommon.New, "MgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowOnAuthenticationMethodLoadStartAsOnAuthenticationMethodLoadStartExternalUserSelfServiceSignUpIdentityProviderByRef", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class NewMgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowOnAuthenticationMethodLoadStartAsOnAuthenticationMethodLoadStartExternalUserSelfServiceSignUpIdentityProviderByRefCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationEventsFlowId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OdataId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthenticationEventsFlowId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ReferenceCreate();

    if (this.IsParameterBound(nameof(OdataId)))
        body.OdataId = OdataId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Identity.AuthenticationEventsFlows[AuthenticationEventsFlowId].GraphExternalUsersSelfServiceSignUpEventsFlow.OnAuthenticationMethodLoadStart.GraphOnAuthenticationMethodLoadStartExternalUsersSelfServiceSignUp.IdentityProviders.Ref.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AuthenticationEventsFlowId);
                return;
            }

        }
    }
}
