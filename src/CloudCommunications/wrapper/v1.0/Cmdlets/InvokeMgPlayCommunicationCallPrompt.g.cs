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
    [GraphRoute("POST", "/communications/calls/{call-id}/playPrompt")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPlayCommunicationCallPrompt", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.PlayPromptOperation))]
    public class InvokeMgPlayCommunicationCallPromptCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ClientContext { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Prompt[]? Prompts { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Calls.Item.PlayPrompt.PlayPromptPostRequestBody();

    if (this.IsParameterBound(nameof(ClientContext)))
        body.ClientContext = ClientContext;
    if (this.IsParameterBound(nameof(Prompts)))
        body.Prompts = Prompts!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.PlayPromptOperation? result;
            try
            {
                result = client.Communications.Calls[CallId].PlayPrompt.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CallId);
                return;
            }

            WriteObject(result);
        }
    }
}
