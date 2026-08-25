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
    [GraphRoute("POST", "/communications/calls/{call-id}/transfer")]
    [Cmdlet(VerbsCommon.Move, "MgCommunicationCall", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class MoveMgCommunicationCallCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.InvitationParticipantInfo? TransferTarget { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ParticipantInfo? Transferee { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallId, "Move"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Calls.Item.Transfer.TransferPostRequestBody();

    if (this.IsParameterBound(nameof(TransferTarget)))
        body.TransferTarget = TransferTarget;

    if (this.IsParameterBound(nameof(Transferee)))
        body.Transferee = Transferee;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Communications.Calls[CallId].Transfer.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CallId);
                return;
            }

        }
    }
}
