#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("POST", "/communications/calls/{call-id}/mute")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgMuteCommunicationCall", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MuteParticipantOperation))]
    public class InvokeMgMuteCommunicationCallCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ClientContext { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Calls.Item.Mute.MutePostRequestBody();

    if (this.IsParameterBound(nameof(ClientContext)))
        body.ClientContext = ClientContext;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MuteParticipantOperation? result;
            try
            {
                result = client.Communications.Calls[CallId].Mute.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CallId);
                return;
            }

            WriteObject(result);
        }
    }
}
