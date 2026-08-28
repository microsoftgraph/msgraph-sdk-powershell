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
    [GraphRoute("POST", "/communications/calls/{call-id}/recordResponse")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgRecordCommunicationCallResponse", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.RecordOperation))]
    public class InvokeMgRecordCommunicationCallResponseCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? BargeInAllowed { get; set; }

        [Parameter(Mandatory = false)]
        public int? InitialSilenceTimeoutInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaxSilenceTimeoutInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaxRecordDurationInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PlayBeep { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? StopTones { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientContext { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Prompt[]? Prompts { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Calls.Item.RecordResponse.RecordResponsePostRequestBody();

    if (this.IsParameterBound(nameof(BargeInAllowed)))
        body.BargeInAllowed = BargeInAllowed;

    if (this.IsParameterBound(nameof(InitialSilenceTimeoutInSeconds)))
        body.InitialSilenceTimeoutInSeconds = InitialSilenceTimeoutInSeconds;

    if (this.IsParameterBound(nameof(MaxSilenceTimeoutInSeconds)))
        body.MaxSilenceTimeoutInSeconds = MaxSilenceTimeoutInSeconds;

    if (this.IsParameterBound(nameof(MaxRecordDurationInSeconds)))
        body.MaxRecordDurationInSeconds = MaxRecordDurationInSeconds;

    if (this.IsParameterBound(nameof(PlayBeep)))
        body.PlayBeep = PlayBeep;

    if (this.IsParameterBound(nameof(StopTones)))
        body.StopTones = StopTones!.ToList();

    if (this.IsParameterBound(nameof(ClientContext)))
        body.ClientContext = ClientContext;
    if (this.IsParameterBound(nameof(Prompts)))
        body.Prompts = Prompts!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.RecordOperation? result;
            try
            {
                result = client.Communications.Calls[CallId].RecordResponse.PostAsync(body, requestConfiguration =>
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
