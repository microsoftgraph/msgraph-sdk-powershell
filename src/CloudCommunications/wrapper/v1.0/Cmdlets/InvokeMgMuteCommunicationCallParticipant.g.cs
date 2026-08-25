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
    [GraphRoute("POST", "/communications/calls/{call-id}/participants/{participant-id}/mute")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgMuteCommunicationCallParticipant", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MuteParticipantOperation))]
    public class InvokeMgMuteCommunicationCallParticipantCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ParticipantId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ClientContext { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ParticipantId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Calls.Item.Participants.Item.Mute.MutePostRequestBody();

    if (this.IsParameterBound(nameof(ClientContext)))
        body.ClientContext = ClientContext;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MuteParticipantOperation? result;
            try
            {
                result = client.Communications.Calls[CallId].Participants[ParticipantId].Mute.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ParticipantId);
                return;
            }

            WriteObject(result);
        }
    }
}
