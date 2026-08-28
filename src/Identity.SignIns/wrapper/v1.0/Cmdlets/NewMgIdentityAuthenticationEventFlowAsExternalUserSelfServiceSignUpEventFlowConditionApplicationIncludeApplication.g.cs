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
    [GraphRoute("POST", "/identity/authenticationEventsFlows/{authenticationEventsFlow-id}/graph.externalUsersSelfServiceSignUpEventsFlow/conditions/applications/includeApplications")]
    [Cmdlet(VerbsCommon.New, "MgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowConditionApplicationIncludeApplication", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationConditionApplication))]
    public class NewMgIdentityAuthenticationEventFlowAsExternalUserSelfServiceSignUpEventFlowConditionApplicationIncludeApplicationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationEventsFlowId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthenticationEventsFlowId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationConditionApplication();

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationConditionApplication? result;
            try
            {
                result = client.Identity.AuthenticationEventsFlows[AuthenticationEventsFlowId].GraphExternalUsersSelfServiceSignUpEventsFlow.Conditions.Applications.IncludeApplications.PostAsync(body, requestConfiguration =>
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
