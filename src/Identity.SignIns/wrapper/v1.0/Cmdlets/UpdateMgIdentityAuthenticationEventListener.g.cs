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
    [GraphRoute("PATCH", "/identity/authenticationEventListeners/{authenticationEventListener-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityAuthenticationEventListener", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationEventListener))]
    public class UpdateMgIdentityAuthenticationEventListenerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthenticationEventListenerId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AuthenticationEventsFlowId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationConditions? Conditions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthenticationEventListenerId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationEventListener();

    if (this.IsParameterBound(nameof(AuthenticationEventsFlowId)))
        body.AuthenticationEventsFlowId = AuthenticationEventsFlowId;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Conditions)))
        body.Conditions = Conditions;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationEventListener? result;
            try
            {
                result = client.Identity.AuthenticationEventListeners[AuthenticationEventListenerId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AuthenticationEventListenerId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Identity.AuthenticationEventListeners[AuthenticationEventListenerId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AuthenticationEventListenerId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
