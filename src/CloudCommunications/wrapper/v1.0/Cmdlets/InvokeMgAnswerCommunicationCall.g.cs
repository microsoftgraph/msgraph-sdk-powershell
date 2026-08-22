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
    [GraphRoute("POST", "/communications/calls/{call-id}/answer")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgAnswerCommunicationCall", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgAnswerCommunicationCallCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CallbackUri { get; set; }

        [Parameter(Mandatory = false)]
        public int? ParticipantCapacity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.MediaConfig? MediaConfig { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Modality?[]? AcceptedModalities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.IncomingCallOptions? CallOptions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Calls.Item.Answer.AnswerPostRequestBody();

    if (this.IsParameterBound(nameof(CallbackUri)))
        body.CallbackUri = CallbackUri;

    if (this.IsParameterBound(nameof(ParticipantCapacity)))
        body.ParticipantCapacity = ParticipantCapacity;
    if (this.IsParameterBound(nameof(MediaConfig)))
        body.MediaConfig = MediaConfig;

    if (this.IsParameterBound(nameof(AcceptedModalities)))
        body.AcceptedModalities = AcceptedModalities!.ToList();

    if (this.IsParameterBound(nameof(CallOptions)))
        body.CallOptions = CallOptions;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Communications.Calls[CallId].Answer.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, CallId);
                return;
            }

        }
    }
}
